using System;
using LoginAndRegistrationBL;

namespace LoginAndRegistrationExcel
{
    class LoginForm
    {
        public void FormType()
        {
            int input;
            do
            {
                // displaying the menu.
                Console.WriteLine("login :           Press 1");
                Console.WriteLine("Forgot password?: Press 2");
                Console.WriteLine("Register:         Press 3");
                input = Convert.ToInt32(Console.ReadLine());
                string username = string.Empty;
                string password = string.Empty;
                TypeFactory typeFactoryObj = new TypeFactory();
                IFormType authObj = typeFactoryObj.getType();

                switch (input)
                {
                    // case for login.
                    case 1:
                        Console.WriteLine("Username:");
                        username = Console.ReadLine();
                        Console.WriteLine("Password:");
                        password = Console.ReadLine();
                        bool flag = authObj.Login(username, password);
                        if (flag)
                        {
                            Console.WriteLine("Login successful");
                        }
                        else
                        {
                            Console.WriteLine("Login Unsuccessful");
                        }
                        break;
                    case 2:
                        // case for Forgot Password.
                        Console.WriteLine("Username:");
                        username = Console.ReadLine();
                        Console.WriteLine("enter a new password");
                        password = Console.ReadLine();
                        authObj.ResetPassword(username, password);
                        Console.WriteLine("Password updated successfully!");
                        break;
                    case 3:
                        // case for Registration.
                        Console.WriteLine("Username:");
                        username = Console.ReadLine();
                        Console.WriteLine("Password");
                        password = Console.ReadLine();
                        authObj.Registration(username, password);
                        Console.WriteLine("registration sucessful");
                        break;
                    default:
                        break;
                }
            } while (input <= 3);

            // Input invalid.
            if (input > 3)
            {
                Console.WriteLine("invalid option entry.");
                Console.ReadLine();
            }
        }
    }
}

