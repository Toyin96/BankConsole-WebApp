using System;

namespace Bank_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Transaction
    {
        public string transactionId { get; set; }
        public DateTime date { get; }
        public string description { get; set; }
        public string type { get; set; }
        public decimal amount { get; set; }
        public decimal balance { get; set; }

        public Transaction(string transactionId, DateTime transactionDate, string description,
            string transactionType, string amount, string balance){
            this.transactionId = transactionId;
            this.date = transactionDate;
            this.description = description;
            this.type = transactionType;
            this.amount = amount;
            this.balance = balance;
        }

        string PerformTransaction(decimal amount){
            if (amount < this.balance){
                this.balance -= amount;
                return "success";
            }else{
                return "invalid transaction";
            }
        }

        string GetTransactionID(){
            return this.transactionId;
        }

        DateTime GetTransactionDate(){
            return this.date;
        }

        void SetTransactionType(string typeName){
            this.type = typeName;
        }

        DateTime GetTransactionBalance(){
            return this.balance;
        }

        ~Transaction(){
        
        }
    }
}
