using System;

namespace SavingInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            TodoList tdl = new TodoList();
            PasswordManager pm = new PasswordManager("coding", false);

            tdl.Add("Test");
            tdl.Display();
            pm.Display();
            tdl.Reset();
            pm.Reset();
        }
    }
}