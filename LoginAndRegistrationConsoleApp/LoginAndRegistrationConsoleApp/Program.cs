using System;
using LoginAndRegistrationBL;

namespace LoginAndRegistrationConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string count;
            do
            {
                Console.WriteLine("enter any of the below options");
                Console.WriteLine("register");
                Console.WriteLine("login");
                Console.WriteLine("forgot password");
                string option = Console.ReadLine();                                 // reads the input from the user.
                TypeFactory typeFactoryObj = new TypeFactory();
                IFormType formType = typeFactoryObj.getType(option);               // gets the type as per user request.
                Console.WriteLine(formType.GetDetails());                         // gets the details of user.
                Console.WriteLine("Do you want to continue?(y/n)");
                count = Console.ReadLine();
            }
            while (count == "y");

        }
    }
}
