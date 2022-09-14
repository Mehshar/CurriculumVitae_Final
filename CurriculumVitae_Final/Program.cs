using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculumVitae_Final
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\t\t-------- INTRODUCTION --------");
            Console.WriteLine("\nHaving achieved good grades at GCE 'A' Level, I am keen to pursue a career in the IT industry. I believe I bring forth a positive attitude and the willingness and motivation to learn new programs. I am eager to utilize my skills and passion to further the mission of the company.");

            Console.WriteLine("\n");

            MainMenu mainMenu = new MainMenu();
            mainMenu.DisplayMenu();
            mainMenu.MakeChoice();
        }
    }
}
