using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class GSM
    {
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        // defining the mobile phone information (fields)
        static GSM IPhone4S;
        // defining the IPhone4S field
        private List<Call> callHistory = new List<Call>();

        public GSM(string model = null, string manufacturer = null, decimal price  = 0, string owner = null)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
        }
        // making the constructor taking parameters or making them null

        public List<Call> CallHistory
        {
            get { return this.callHistory; }
            // I return the private callHistroy
            set { this.callHistory = value; }
            // I make a new callHistory
        }

        public void AddCall(string dialedNumber = "09999999", int duration = 60)
        {
            DateTime now = DateTime.Now;
            callHistory.Add(new Call(now, dialedNumber, duration));
            // making a method to add a Call in my List<Calls>
        }

        public void DeleteCall(int index)
        {
            this.callHistory.RemoveAt(index);
            // this method deletes the element by the given index
        }

        public void ClearCallHistory()
        {
            this.callHistory.Clear();
            // removing all elements in the List<Calls>
        }

        public decimal CalculateTotalCallPrice(decimal price)
        {
            decimal totalPrice = 0;
            foreach (var call in callHistory)
            {
                double minutes = TimeSpan.FromSeconds(call.Duration).TotalMinutes;
                // converting seconds to minutes
                totalPrice += (decimal)minutes * price;
                // multiplying minutes by price so i can get
                // the total price for the current call
            }
            return totalPrice;
        }
    
        public GSM IPhone4s
        {
            get { return IPhone4S; }
            set { IPhone4S = value; }
            // Making a property for the IPhone4S
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Incorrect model !");
                }
                // checking if the model is null or empty
                this.model = value;
            }
        }
        // making it public so it can be adjusted by the outside

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set 
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Incorrect manufacturer !");
                }
                // checking if the manufacturer is null or empty
                this.manufacturer = value; 
            }
        }
        // making it public so it can be adjusted by the outside

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Incorrect price !");
                }
                // checking if the manufacturer is null or empty
                this.price = value;
            }
        }
        // making it public so it can be adjusted by the outside

        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Incorrect owner !");
                }
                // checking if the owner is null or empty
                this.owner = value;
            }
        }
        // making it public so it can be adjusted by the outside

        public override string ToString()
        {
            StringBuilder information = new StringBuilder();
            information.AppendLine("Model -- > " + model);
            information.AppendLine("Manufacturer -- > " + manufacturer);
            information.AppendLine("Price -- > " + Price);
            information.Append("Owner -- > " + Owner);            
            return information.ToString();
            // I m putting all of the info in a string with new lines and everything,
            //so it can look good on the console
        }
        //overriding ToString() method
    }
}
