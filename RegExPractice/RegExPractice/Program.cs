using System;
using System.Text.RegularExpressions;

namespace RegExPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task: Write a   program that   will recognize   invalid inputs   using regular expressions.    
            //What will the application   do?  ● The program   will validate   diﬀerent kinds   of input.     

            //Build Speciﬁcations  
            //1. Write a method that will validate names. Names can only have alphabets, they should start with a capital letter, and they have a maximum length of 30.  
            //2. Write a method that will validate emails. An email should be in the following format:{combination of alphanumeric characters, with a length between 5 and 30, and there   are no special characters}@{ combination of alphanumeric characters, with a length between 5 and 10, and there is no special characters}.{domain can be combination of alphanumeric characters with a length of two  or three}
            //3. Write a method that will validate phone numbers.A phone number should be in the following format: {area code of 3 digits} – {3 digits} – {4 digits}
            //4. Write a method that will validate date based on the following format: (dd/mm/yyyy).

            //Extended Challenges: 
            //● Write a method that validates HTML elements(Example: <p> </p> is a valid html element, and <h1<h1> is not valid. Don’t worry about special cases where you have self-contained HTML elements).

            Console.WriteLine("Please enter a valid name (First and Last)");
            string name = Name(Console.ReadLine());
            Console.WriteLine("You have entered a valid name!");

            Console.WriteLine("Please enter a valid email");
            string email = Email(Console.ReadLine());
            Console.WriteLine("You have entered a valid email!");

            Console.WriteLine("Please enter a valid phone number");
            string phone = Phone(Console.ReadLine());
            Console.WriteLine("You have entered a valid phone number!");

            Console.WriteLine("Please enter a valid date (dd/mm/yyyy)");
            string date = Date(Console.ReadLine());
            Console.WriteLine("You have entered a valid date!");

            Console.WriteLine("Please enter a valid html element (<p></p> or <div></div>)");
            string html = Html(Console.ReadLine());
            Console.WriteLine("You have entered a valid Html Element!");

            Console.WriteLine("Goodbye");

        }

        static string Name(string name)
        {
            Regex rg = new Regex(@"^[A-Z][a-z]+\s[A-Z][a-z]+$");
            string cont = "y";
            do
            {
                bool result = rg.IsMatch(name);
                if (result == true)
                {
                    cont = "n";
                }
                else
                {
                    Console.WriteLine("invalid name, please enter a valid name. Ex: Randy Zilinski");
                    name = Console.ReadLine();
                }
            } while (cont == "y");

            return name;
        }
        static string Email(string email)
        {
            Regex rg = new Regex(@"^[A-Za-z1-9_]+\@[a-z]{3,10}.[a-z]{2,3}$");
            string cont = "y";
            do
            {
                bool result = rg.IsMatch(email);
                if (result == true)
                {
                    cont = "n";
                }
                else
                {
                    Console.WriteLine("invalid email, please enter a valid email. Ex: rzilinski77@gmail.com");
                    email = Console.ReadLine();
                }
            } while (cont == "y");

            return email;
        }
        static string Phone(string phone)
        {
            Regex rg = new Regex(@"^[1-9]{3}-[1-9]{3}-[1-9]{4}$");
            string cont = "y";
            do
            {
                bool result = rg.IsMatch(phone);
                if (result == true)
                {
                    cont = "n";
                }
                else
                {
                    Console.WriteLine("invalid name, please enter a valid phone number. Ex: 555-555-5555");
                    phone = Console.ReadLine();
                }
            } while (cont == "y");

            return phone;
        }
        static string Date(string date)
        {
            Regex rg = new Regex(@"^[0-9]{2}/[0-9]{2}/[0-9]{4}$");
            string cont = "y";
            do
            {
                bool result = rg.IsMatch(date);
                if (result == true)
                {
                    cont = "n";
                }
                else
                {
                    Console.WriteLine("invalid name, please enter a valid date. Ex: 05/16/1990");
                    date = Console.ReadLine();
                }
            } while (cont == "y");

            return date;
        }

        static string Html(string html)
        {
            Regex rg = new Regex(@"^<[A-Za-z]+>\s*</[A-Za-z]+>$");
            string cont = "y";
            do
            {
                bool result = rg.IsMatch(html);
                if (result == true)
                {
                    cont = "n";
                }
                else
                {
                    Console.WriteLine("invalid html element, please enter a valid html element. Ex: <table></table>");
                    html = Console.ReadLine();
                }
            } while (cont == "y");

            return html;
        }


    }
}
