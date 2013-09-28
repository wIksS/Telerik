using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class GSMTest
    {
        private GSM[] phones = new GSM[3] { new GSM(), new GSM(), new GSM() };
        // making an array with empty GSM classes in it

        public void DisplayGSMs()
        {
            foreach (var phone in phones)
            {
                Console.WriteLine(phone.ToString());
            }
            // I m using my overriden ToString() method
            // so i can display all of the information
            //(which is null) on the console
        }

        public void IPhone4SInfo()
        {
            GSM IPhoneInfo = new GSM();
            Console.WriteLine(IPhoneInfo.IPhone4s.ToString());
            // im making a new instance of the GSM class
            // and I display the IPhone4S field
            // using my ToString() method
        }
    }
}
