using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1_net_framework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "My Rocking App pepito";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("***********************************************");
            Console.WriteLine("********** Welcome to My Rocking App **********");
            Console.WriteLine("***********************************************");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Beep();
            
            // Espera a que s'hagi premut la tecla Enter
            Console.ReadLine();
            MessageBox.Show("All done!");
        }
    }
}
