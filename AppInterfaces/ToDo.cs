using System;
using System.Collections.Generic;

namespace SavingInterface
{
    class TodoList : IDisplayable, IResetable
    {
        public string HeaderSymbol => "-----------";
        private List<string> ToDo;

        public TodoList() => this.ToDo = new List<string>();

        public void Add(string todo) => ToDo.Add(todo);

        public void Display()
        {
            Console.WriteLine("Todos");
            Console.WriteLine(HeaderSymbol);

            foreach (String s in ToDo)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine(HeaderSymbol);
        }

        public void Reset() => ToDo.Clear();
    }
}