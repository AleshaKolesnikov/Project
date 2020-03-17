using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public static class Choise
    {
        public delegate void Pointer(int command);
        public static event Pointer choseCommand;
        public static int command { get; set; }
        public static void InputAndCheck()
        {
            command = Convert.ToInt32(Console.ReadLine());
            choseCommand(command);
        }
    }
}
