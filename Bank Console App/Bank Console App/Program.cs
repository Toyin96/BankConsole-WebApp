using System;

namespace Bank_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Transaction toyinTransction = new Transaction("WEM120A", "Payment of school fees", 
                "cash transafer", 23,233.72, 794,203,22.02)

            string status = toyinTransction.PerformTransaction();
            Console.WriteLine(status);
            Console.WriteLine(toyinTransction.GetTransactionBalance);
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
            string transactionType, decimal amount, decimal balance){
            this.transactionId = transactionId;
            this.date = new DateTime(transactionDate);
            this.description = description;
            this.type = transactionType;
            this.amount = amount;
            this.balance = balance;
        }

        public Transaction(string transactionId, string description, string transactionType, 
            decimal amount, decimal balance){
            this.transactionId = transactionId;
            this.description = description;
            this.type = transactionType;
            this.amount = amount;
            this.balance = balance;
        }

        public Transaction(){
        
        }

        public string PerformTransaction(){
            if (this.amount < this.balance){
                this.balance -= amount;
                return "success";
            }else{
                return "invalid transaction";
            }
        }

        public string GetTransactionID(){
            return this.transactionId;
        }

        public DateTime GetTransactionDate(){
            return this.date;
        }

        public void SetTransactionType(string typeName){
            this.type = typeName;
        }

        public DateTime GetTransactionBalance(){
            return this.balance;
        }

        ~Transaction(){
        
        }
    }
}
