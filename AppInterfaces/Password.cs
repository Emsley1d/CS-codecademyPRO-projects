using System;

namespace SavingInterface
{
    class PasswordManager : IDisplayable, IResetable
    {
        private string Password { get; set; }
        private bool Hidden { get; set; }

        public string HeaderSymbol => "-----------";

        public PasswordManager(string password, bool hidden)
        {
            Password = password;
            Hidden = hidden;
        }

        public void Display()
        {
            if (Hidden)
            {
                Console.WriteLine(new string('*', Password.Length));
            }
            else
            {
                Console.WriteLine(Password);
            }
        }
        
        public void Reset() => Password = "";
    }
}