using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCSharp
{
    class HelloCSharp
    {
        static void Main(string[] args)
        {
            // Chapter 1
            //Console.WriteLine("HOLA C#!");
            //Console.WriteLine("Hello C#!");

            //string firstName = "Leia";
            //string lastName = "Chu";

            //Console.WriteLine("Hello " + firstName + " " + lastName);

            //Console.WriteLine("Print current date and time: ");
            //DateTime now = DateTime.Now;
            //Console.WriteLine("Date: " + now);

            //Console.WriteLine("Write a program that prints the square root of 12345");
            //int number = 12345;
            //double sqroot = Math.Sqrt(number);
            //Console.WriteLine("Square root of " + number + " is " + sqroot);

            //Console.WriteLine("Write a program that reads your age from the console and prints your age after 10 years.");
            //string age = Console.ReadLine();
            //int ageInt = Int32.Parse(age);
            //ageInt = ageInt + 10;
            //Console.WriteLine("Your age after 10 years: " + ageInt);

            //Console.WriteLine("Make a list of the most popular programming languages.");
            //List<string> programmingLangList = new List<string>();
            //programmingLangList.Add("Javascript");
            //programmingLangList.Add("Java");
            //programmingLangList.Add("PHP");
            //programmingLangList.Add("Ruby");

            //Console.WriteLine("List of Programming languages: " + programmingLangList);
            //programmingLangList.ForEach(Console.WriteLine);

            //// Chapter 2
            //Console.WriteLine("Declare a variable isMale of type bool and assign a value to it depending on your gender.");
            //bool isMale;
            //Console.WriteLine("Is your gender Male? ");
            //isMale = bool.Parse(Console.ReadLine());
            //if (isMale == true)
            //{
            //    Console.WriteLine("You are male");
            //}
            //else
            //{
            //    Console.WriteLine("You are not male");
            //}

            //Console.WriteLine("Declare two variables of type string with values Hello and World.Declare a variable of type object.Assign the value obtained of concatenation of the two string variables(add space if necessary) to this variable.Print the variable of type object.");
            //string a = "Hello";
            //string b = " World";
            //object text;

            //Chapter 3
            //Console.WriteLine("Write an expression that checks whether an integer is odd or even.");
            //Console.WriteLine("Enter number: ");
            //string num = Console.ReadLine();
            //int numAsInt = Int32.Parse(num);

            //if (numAsInt % 2 == 0)
            //{
            //    Console.WriteLine("Number is even");
            //}
            //else
            //{
            //    Console.WriteLine("Number is odd");
            //}

            //Console.WriteLine("Write a Boolean expression that checks whether a given integer is divisible by both 5 and 7, without a remainder.");
            //Console.WriteLine("Enter number: ");
            //string num1 = Console.ReadLine();
            //int numAsInt1 = Int32.Parse(num1);

            //if ((numAsInt1 % 5 == 0) && (numAsInt1 % 7 == 0))
            //{
            //    Console.WriteLine("Number is divisible by 7 and 5");
            //}
            //else if (numAsInt1 % 5 == 0)
            //{
            //    Console.WriteLine("Number is divisible by 5");
            //}
            //else if (numAsInt1 % 7 == 0)
            //{
            //    Console.WriteLine("Number is divisible by 7");
            //}
            //else
            //{
            //    Console.WriteLine("It is not divisible by 7 or 5");
            //}

            //Console.WriteLine("The gravitational field of the Moon is approximately 17% of that on the Earth.Write a program that calculates the weight of a man on the moon by a given weight on the Earth.");
            //Console.Write("Enter weight of man on Earth: ");
            //double weightEarth = Convert.ToInt32(Console.ReadLine());
            //double weightPercentMoon = 0.17;

            //double calculatedWeightMoon = (weightEarth * weightPercentMoon);

            //Console.WriteLine("Weight on the moon " + calculatedWeightMoon);


            //Console.WriteLine("Write a program that takes as input a four-digit number in format abcd");
            //Console.WriteLine("(e.g. 2011) and performs the following actions:");
            //Console.WriteLine("-Calculates the sum of the digits(in our example 2 + 0 + 1 + 1 = 4).");
            //Console.WriteLine("- Prints on the console the number in reversed order: dcba(in our example 1102). ");
            //Console.WriteLine("- Puts the last digit in the first position: dabc(in our example 1201).");
            //Console.WriteLine("- Exchanges the second and the third digits: acbd(in our example 2101).");


            //Console.Write("Enter 4-digit number: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //int currentDigit = 0;
            //int sum = 0;

            //while (number > 0)
            //{
            //    currentDigit = number % 10;
            //    Console.WriteLine("currentDigit = " + currentDigit);
            //    number = number / 10;
            //    sum += currentDigit;
            //}
            //Console.WriteLine("Sum = " + sum);

            //Console.WriteLine("reverse order of number");
            //int r; 
            //int suma = 0;
            //Console.WriteLine("Enter number to reverse order: ");
            //int numberEntered = Convert.ToInt32(Console.ReadLine());
            //for (int t = numberEntered; t != 0; t = t / 10)
            //{
            //    r = t % 10;
            //    suma = suma * 10 + r;
            //}
            //Console.Write("The number in reverse order is : {0} \n", suma);

            //Console.WriteLine("Puts the last digit in the first position: dabc(in our example 1201).");
            //int[] outarry = Array.ConvertAll(numberEntered.ToString().ToArray(), x => (int)x);

            //foreach (int e in outarry)
            //{
            //    Console.WriteLine("e = " + outarry[e]);
            //}

            // Chapter 4

            //Console.WriteLine("{0,6}", 123);

            //Console.Write("Enter a floating-point number: ");
            //string line = Console.ReadLine();
            //double number = double.Parse(line);
            //Console.WriteLine("You entered: {0}", number);


            //Console.WriteLine("Write a program that reads from the console three numbers of type int and prints their sum.");
            //Console.WriteLine("Enter number 1: ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter number 2: ");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter number 3: ");
            //int num3 = int.Parse(Console.ReadLine());

            //int sum = num1 + num2 + num3;
            //Console.WriteLine("Sum:  {0}", sum);


            //Console.WriteLine("Write a program that reads from the console the radius \"r\" of a circle and prints its perimeter and area.");
            //Console.WriteLine("Enter radius: ");
            //double radius = double.Parse(Console.ReadLine());

            //double perimeter = 2 * Math.PI * radius;
            //double area = Math.PI * (radius * radius);

            //Console.WriteLine("The perimeter is {0:F2} and the area is {1:F2}", perimeter, area);


            //Console.WriteLine("A given company has name, address, phone number, fax number, web");
            //Console.WriteLine("site and manager.The manager has name, surname and phone number.");
            //Console.WriteLine("Write a program that reads information about the company and its manager and then prints it on the console.");

            //Console.WriteLine("Company Name: ");
            //string companyName = Console.ReadLine();
            //Console.WriteLine("Address: ");
            //string address = Console.ReadLine();
            //Console.WriteLine("Phone number (do not enter spaces or -): ");
            ////string phoneString = Console.ReadLine();
            //string phoneNumber = Console.ReadLine();

            //int phoneNumber;
            //Int32.TryParse(phoneString, out phoneNumber);


            //Console.WriteLine("Manager's first name: ");
            //string manFirstName = Console.ReadLine();
            //Console.WriteLine("Manager's last name: ");
            //string manLastName = Console.ReadLine();

            //Console.WriteLine("Company Name: " + companyName);
            //Console.WriteLine("Address: " + address);
            //Console.WriteLine("Phone number: {0:(###) ### ####}", phoneNumber);   // NEED help with this
            //Console.WriteLine("Manager's name: {0} {1}", manFirstName, manLastName);

            // Chapter 5

            //Console.WriteLine("Write an if-statement that takes two integer variables and exchanges their values if the first one is greater than the second one.");
            //Console.WriteLine("Enter value for var1: ");
            //int var1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter value for var2: ");
            //int var2 = int.Parse(Console.ReadLine());


            //if (var1 > var2)
            //{
            //    var1 = var2;
            //    Console.WriteLine("Value of var1: {0} value of var2: {1}", var1, var2);
            //}
            //else
            //{
            //    Console.WriteLine("var1 is smaller than var2");
            //}


            //Console.WriteLine("Write a program that finds the biggest of three integers, using nested if statements.");
            //Console.WriteLine("Enter value for v1: ");
            //int v1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter value for v2: ");
            //int v2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter value for v3: ");
            //int v3 = int.Parse(Console.ReadLine());


            //if (v1 > v2 && v1 > v3)
            //{
            //    Console.WriteLine("v1 is the biggest");
            //}
            //else if (v2 > v1 && v2 > v3)
            //{
            //    Console.WriteLine("V2 is the biggest");
            //}
            //else
            //{
            //    Console.WriteLine("v3 is the biggest");
            //}


            //Console.WriteLine("Write a program that applies bonus points to given scores in the range [1…9] by the following rules:");
            //Console.WriteLine("- If the score is between 1 and 3, the program multiplies it by 10.");
            //Console.WriteLine("- If the score is between 4 and 6, the program multiplies it by 100.");
            //Console.WriteLine("- If the score is between 7 and 9, the program multiplies it by 1000.");
            //Console.WriteLine("- If the score is 0 or more than 9, the program prints an error message.");

            //Console.WriteLine("Enter grade: ");
            //int grade = int.Parse(Console.ReadLine());

            //if (grade >= 1 && grade <= 3)
            //{
            //    grade = grade * 10;
            //    Console.WriteLine("new value: {0}", grade);
            //}else if (grade >= 4 && grade <= 6)
            //{
            //    grade = grade * 100;
            //    Console.WriteLine("new value: {0}", grade);
            //}
            //else if (grade >= 7 && grade <= 9)
            //{
            //    grade = grade* 1000;
            //    Console.WriteLine("new value: {0}", grade);
            //}
            //else
            //{
            //    Console.WriteLine("error");
            //}

            // Chapter 6

            Console.WriteLine("Write a program that prints on the console the numbers from 1 to N. The number N should be read from the standard input.");

            Console.WriteLine("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            int counter = 1;

            while (counter <= number)
            {
                Console.WriteLine(counter);
                counter++;
            }


            //Chapter 7

        }
    }
}
