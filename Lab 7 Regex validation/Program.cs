using System;
using System.Text.RegularExpressions;


namespace Lab_7_Regex_validation
{
    class Program
    {
        public static bool Name_Checker(string name)
        {
            string strRegex = @"[^0-9]?[A-Z][a-z]+[^0-9]+?$";
            //I thought that excluding a [0 - 9] would be enough to exclude all numbers, but it isn't!                                                        
            Regex re = new Regex(strRegex);
            if (re.IsMatch(name))
                return (true);
            else
                return (false);
        }
        //"[^0-9]?[A-Z][a-z]+[^0-9]+?$";


        public static bool isValidEmail(string inputEmail)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }

        public static bool Ph_Num_Chckr(string phone_num)
        {
            string strRegex = @"^\(?([0-9]{3})\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(phone_num))
                return (true);
            else
                return (false);

        }

        public static bool Date_Checker(string date)
        {
            string strRegex = "^(1[0-2]|0[1-9])/(3[01]|[12][0-9]|0[1-9])/[0-9]{4}$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(date))
                return (true);
            else
                return (false);
        }


        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please Enter a valid name: ");
                string user_name = Console.ReadLine();

                bool checkerN = Name_Checker(user_name);

                if (checkerN != true)
                {
                    Console.WriteLine("Sorry, name is not valid!");
                    continue;
                }
                else
                {
                    Console.WriteLine($"Name = {user_name}");
                    break;
                }
            }

            while (true)
            {
                Console.WriteLine("Please Enter a valid email: ");
                string user_email = Console.ReadLine();

                bool checkerE = isValidEmail(user_email);

                if (checkerE != true)
                {
                    Console.WriteLine("Sorry, email is not valid");
                    continue;
                }
                else
                {
                    Console.WriteLine($"Email = {user_email}");
                    break;
                }
            }

            while (true)
            {
                Console.WriteLine("Please enter a valid phone number: ");
                string user_Phone = Console.ReadLine();

                bool checkerP = Ph_Num_Chckr(user_Phone);

                if (checkerP != true)
                {
                    Console.WriteLine("Sorry, phone number is not valid ");
                    continue;
                }
                else
                {
                    Console.WriteLine($"Phone number ={user_Phone}");
                    break;
                }
            }

            while (true)
            {
                Console.WriteLine("Please enter a valid date: ");
                string user_date = Console.ReadLine();
                bool checkerD = Date_Checker(user_date);

                if (checkerD != true)
                {
                    Console.WriteLine("Sorry, date is not valid");
                }
                else
                {
                    Console.WriteLine($"Date ={user_date}");
                }
            }
        } 
    }
}
