using Microsoft.Data.Sqlite;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
using System.Reflection;

namespace FedotovAnton_Linq_DataBase
{
    class Program
    {
        static void Main(string[] args)
        {
            // first part
            List<SecretInfo> secretInfo = File.ReadAllLines($"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\Маркеры доступа - Levels.csv")
                .Skip(1)
                .Select(v => SecretInfo.FromCsv(v))
                .ToList();
            List<Person> persons;
            List<Person> newPersons;

            string tableName = "PeopleLevels";
            string connectionString = $"Data Source=TopSecret.db";
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                persons = DownloadInfo(tableName, connection);
            }

            // second part
            Task1(persons);
            Task2(persons);
            Task3(persons, secretInfo);
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                CreateTable("NewTable", connection, persons);
                AddRandomPerson(tableName, connection, persons, "John");
                DeletePerson(tableName, connection, "Name='John'");
                newPersons = ShowInfoFromNewTable("NewTable", connection);
            }
            Task8(persons, newPersons);
        }

        private static List<Person> DownloadInfo(string tableName, SqliteConnection connection)
        {
            string getElementsCommand = $"select * from {tableName}";
            SqliteCommand command = new SqliteCommand(getElementsCommand, connection);
            List<Person> persons = new List<Person>();
            using (SqliteDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                        persons.Add(new Person(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
                }
            }
            return persons;
        }
        private static void Task1(List<Person> persons)
        {
            // don't understand the task and make it in my way
            for (int i = 0; i < persons.Count; i++)
            {
                switch (persons[i].Level)
                {
                    case "Green":
                        persons[i].Color = Color.Green;
                        break;
                    case "White":
                        persons[i].Color = Color.White;
                        break;
                    case "Blue":
                        persons[i].Color = Color.Blue;
                        break;
                    case "Yellow":
                        persons[i].Color = Color.Yellow;
                        break;
                    case "Red":
                        persons[i].Color = Color.Red;
                        break;
                    case "Orange":
                        persons[i].Color = Color.Orange;
                        break;
                }
            }
            
        }
        private static void Task2(List<Person> persons)
        {
            var request = (from person in persons
                           group person by person.Level into newGRoup
                           select newGRoup).ToList();

            foreach (IGrouping<string, Person> group in request)
            {
                switch (group.Key)
                {
                    case "Green":
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case "White":
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case "Blue":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case "Yellow":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case "Red":
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;
                    case "Orange":
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                }
                Console.WriteLine(group.Key);
                Console.WriteLine("-----------------------");
                foreach (Person item in group)
                    Console.WriteLine(item.Name);
                Console.WriteLine();
                Console.ResetColor();
            }
        }
        private static void Task3(List<Person> persons, List<SecretInfo> secretInfo)
        {
            string input = Console.ReadLine();
            bool isFound = false;
            for (int i = 0; i < persons.Count; i++)
            {
                if (input == persons[i].Name)
                {
                    isFound = true;
                    Console.WriteLine($"{Convert.ToInt32(persons[i].Color)} {persons[i].Level}");
                    Console.WriteLine("Информацию какого уровня вы хотите получить?");
                    input = Console.ReadLine();
                    if (Convert.ToInt32(input) <= Convert.ToInt32(persons[i].Color))
                        Console.WriteLine(secretInfo[Convert.ToInt32(input)].Info);
                    else
                        Console.WriteLine("Ошибка");
                    break;
                }
            }
            if (!isFound)
                Console.WriteLine("Нет такого пользователя");
        }
        private static void CreateTable(string tableName, SqliteConnection connection, List<Person> persons)
        {
            SqliteCommand command = new SqliteCommand();
            command.Connection = connection;

            string checkTableCommand = $"select name from sqlite_master where type='table' and name='{tableName}'";
            command.CommandText = checkTableCommand;

            if (command.ExecuteScalar() == null)
            {
                string createTableCommand = $"create table {tableName}(Id INTEGER PRIMARY KEY AUTOINCREMENT UNIQUE NOT NULL, SecretLevel TEXT NOT NULL, Name TEXT NOT NULL)";
                command.CommandText = createTableCommand;
                command.ExecuteNonQuery();
                for (int i = 0; i < persons.Count; i++)
                {
                    AddPerson(tableName, connection, persons[i]);
                }
            }

        }
        private static void AddPerson(string tableName, SqliteConnection connection, Person person)
        {
            SqliteCommand command = new SqliteCommand();
            command.Connection = connection;
            string addCommand = $"insert into {tableName}(SecretLevel, Name) values('{person.Level}','{person.Name}');";
            command.CommandText = addCommand;
            command.ExecuteNonQuery();
        }
        private static void AddRandomPerson(string tableName, SqliteConnection connection, List<Person> persons, string name)
        {
            SqliteCommand command = new SqliteCommand();
            command.Connection = connection;

            Person person = new Person(persons.Count, Color.White.ToString(), name);
            persons.Add(person);

            Random rnd = new Random();
            switch (rnd.Next(0, 6))
            {
                case 0:
                    person.Level = Color.White.ToString();
                    break;
                case 1:
                    person.Level = Color.Green.ToString();
                    break;
                case 2:
                    person.Level = Color.Blue.ToString();
                    break;
                case 3:
                    person.Level = Color.Orange.ToString();
                    break;
                case 4:
                    person.Level = Color.Yellow.ToString();
                    break;
                case 5:
                    person.Level = Color.Red.ToString();
                    break;
            }

            string addCommand = $"insert into {tableName}(SecretLevel, Name) values('{person.Level}','{person.Name}');";
            command.CommandText = addCommand;
            command.ExecuteNonQuery();
        }
        private static void DeletePerson(string tableName, SqliteConnection connection, string condition)
        {
            SqliteCommand command = new SqliteCommand();
            command.Connection = connection;
            string addCommand = $"delete from {tableName} where {condition};";
            command.CommandText = addCommand;
            command.ExecuteNonQuery();
        }
        private static List<Person> ShowInfoFromNewTable(string tableName, SqliteConnection connection)
        {
            string getElementsCommand = $"select * from {tableName}";
            SqliteCommand command = new SqliteCommand(getElementsCommand, connection);
            List<Person> persons = DownloadInfo(tableName, connection);
            var request = from person in persons
                          orderby person.Name
                          select person;
            foreach (var person in request)
            {
                switch (person.Level)
                {
                    case "Green":
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case "White":
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case "Blue":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case "Yellow":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case "Red":
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;
                    case "Orange":
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                }
                Console.WriteLine($"{person.Name} {person.Level}");
                Console.ResetColor();
            }
            return persons;
        }
        private static void Task8(List<Person> persons, List<Person> newPersons)
        {
            var request = persons.Union(newPersons);
            foreach (var person in request)
            {
                Console.WriteLine($"{person.Name}");
            }
        }
    }
}
