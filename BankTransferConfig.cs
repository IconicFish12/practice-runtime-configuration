using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul8_103022300110
{
    class Confirmation
    {
        public string en { get; set; }
        public string id { get; set; }

        public Confirmation()
        {
            this.en = "yes";
            this.id = "ya";
        }
    }
    class Transfer
    {
        public int threshold { get; set; }
        public int low_fee { get; set; }
        public int high_fee { get; set; }

        public Transfer()
        {
            this.threshold = 25000000;
            this.low_fee = 6500;
            this.high_fee = 15000;
        }
    }
    internal class BankTransferConfig
    {
        public string lang { get; set; }
        public Transfer transfer { get; set; }
        public List<string> methods { get; set; }
        public Confirmation confirmation { get; set; }

        public BankTransferConfig() { }

        public BankTransferConfig(string lang, Transfer transfer, Confirmation confirmation)
        {
            this.lang = lang;
            this.transfer = transfer;
            this.methods = new List<string>();
            this.confirmation = confirmation;
        }
    }
}
