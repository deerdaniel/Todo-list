using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    internal class Todo
    {
        public string? Name { get; set; }
        //public bool IsDone { get; set; }

        public Todo(string name) 
        {
            Name = name;
        }
    }
}
