using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TodoList
{
    internal class MenuUI
    {
        public static void PrintMenu()
        {
            PrintHeader();

            WriteLine();
            PrintTasks();
            WriteLine();

            PrintDivider();
            PrintOptions();
            PrintDivider();
        }
        public static void PrintHeader()
        {
            WriteLine("====================TODO APP==============================");
        }

        public static void PrintTasks()
        {
            WriteLine("task example");
        }

        public static void PrintDivider()
        {
            WriteLine("----------------------------------------------------------");
        }

        public static void PrintOptions()
        {
            WriteLine("1. Add task");
            WriteLine("2. Delete task");
            WriteLine("3. Exit");
        }
    }
}
