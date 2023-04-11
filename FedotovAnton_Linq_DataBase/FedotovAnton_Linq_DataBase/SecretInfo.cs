using System;

namespace FedotovAnton_Linq_DataBase
{
    class SecretInfo
    {
        public int Level { get; set; }
        public Color Color { get; set; }
        public string Info { get; set; }

        public static SecretInfo FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            SecretInfo secretInfo = new SecretInfo();
            secretInfo.Level = Convert.ToInt32(values[0]);
            secretInfo.Color = Enum.Parse<Color>(values[1]);
            secretInfo.Info = Convert.ToString(values[2]);
            return secretInfo;
        }
    }
}