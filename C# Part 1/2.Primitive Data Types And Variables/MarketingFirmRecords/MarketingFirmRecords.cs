using System;

class MarketingFirmRecords
{
    static void Main(string[] args)
    {
        Console.WriteLine("Fist name :");
        string firstName = Console.ReadLine();
        Console.WriteLine("Family name :");
        string familyName = Console.ReadLine();
        byte age;
        string gender;
        string male = "male";
        string female = "female";
        long idNumber;
        long employeeNumber;
        Console.WriteLine("Age:");
        do
        {
            age = byte.Parse(Console.ReadLine());
            if ((age < 18) || (age > 65))
            {
                Console.WriteLine("The age you have entered is incorrect.");
                Console.WriteLine("Age:");
            }
        } while ((age < 18) || (age > 65));
        Console.WriteLine("Gender : (male or female)");
        do
        {
            gender = Console.ReadLine();
            if ((gender!=male)&&(gender!=female))
            {
                Console.WriteLine("The information you have entered is incorrect.");
                Console.WriteLine("Gender:");
            }

        } while ((gender != male) && (gender != female));
        Console.WriteLine("ID number:");
        do
        {
            idNumber=long.Parse(Console.ReadLine());
            if ((idNumber < 101) || (idNumber > 1000000001)) 
	        {
		        Console.WriteLine("The ID number you have entered is incorrect.");
                Console.WriteLine("ID number:");

	        }
        } while ((idNumber < 101) || (idNumber > 1000000001));
        Console.WriteLine("Employee number:");
        do
        {
            employeeNumber=long.Parse(Console.ReadLine());
            if ((employeeNumber < 27560000) || (employeeNumber > 27570000))
	        {
		        Console.WriteLine("The employee number you have entered is incorrect");
                Console.WriteLine("Employee number:");
	        }

        } while ((employeeNumber < 27560000) || (employeeNumber > 27570000));

        //string firstName = "Svetlin";
        //string familyName = "Nakov";
        //byte age = 37;
        //string gender = "Male";
        //int idNumber = 40096605;
        //int employeeNumber = 275625873;
        //Console.WriteLine("First name : {0}\nFamily name : {1}\nAge : {2}\nGender : {3}\nID Number : {4}\nUnique employee number : {5}", firstName, familyName, age, gender, idNumber, employeeNumber);
    }
}

