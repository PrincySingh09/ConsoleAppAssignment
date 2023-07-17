using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                User user = new User();
                Console.WriteLine("Enter your name:");
                user.Name = Console.ReadLine();
                if (user.Name.Length < 6)
                {
                    throw new ValidationException("Name should be atleast 6 characters long.");
                }
                Console.WriteLine("Enter your email:");
                user.Email = Console.ReadLine();
                if (!user.Email.Contains('@') || !user.Email.Contains('.'))
                {
                    throw new ValidationException("Email is not valid. It must contain an '@' and a '.' character.");
                }
                Console.WriteLine("Enter your password:");
                user.Password = Console.ReadLine();
                if (user.Password.Length < 6)
                {
                    throw new ValidationException("Password should be atleast 6 characters long.");
                }
                Console.WriteLine("Registration successful!!");
            } catch (ValidationException ex)
            {
                Console.WriteLine("Error: "+ ex.Message);
            }
              
            }
        }
    }

