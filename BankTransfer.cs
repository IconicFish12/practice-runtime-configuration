using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul8_103022300110
{
    internal class BankTransfer
    {

        public BankTransferConfig config;
        public const string filepath = @"D:\modul8_103022300110\bank_transfer_config.json";

        private BankTransferConfig ReadConfigFile()
        {
            if (File.Exists(filepath))
            {
                string json = File.ReadAllText(filepath);
                this.config = JsonSerializer.Deserialize<BankTransferConfig>(filepath);
            }

            return this.config;
        }

        private void WriteNewConfigFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            String jsonString = JsonSerializer.Serialize(config, options);
            File.WriteAllText(filepath, jsonString);
        }

        private void SetDefault()
        {
            config = new BankTransferConfig("en", new Transfer(), new Confirmation());
        }

        public BankTransfer()
        {
            try
            {
                this.config = ReadConfigFile();
            }
            catch (Exception)
            {
                SetDefault();
                WriteNewConfigFile();
            }
        }
    }
}
