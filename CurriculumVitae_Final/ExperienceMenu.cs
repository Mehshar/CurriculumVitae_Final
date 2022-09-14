using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculumVitae_Final
{
    public class ExperienceMenu : MainMenu
    {
        private string[] expOptions = {"Ceridian Mauritius (2022)", "Company Two", "Company Three"};

        public override string header { get; set; } = "\t\t\t\t\t\t--------- EXPERIENCE MENU ---------";

        public ExperienceMenu() : base()
        {
        }

        public override void DisplayMenu()
        {
            Console.WriteLine(header);

            for (int i = 0; i < expOptions.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + expOptions[i]);
            }

            Console.WriteLine((expOptions.Length + 1) + ". Go Back");
        }

        public override void MakeChoice()
        {
            while (true)
            {
                Console.WriteLine("\nEnter a choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                int goBack = expOptions.Length + 1;
                if (choice == goBack)
                {
                    header = base.header;
                    base.DisplayMenu();
                    base.MakeChoice();
                }

                else
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("                                           -------- CERIDIAN MAURITIUS (2022) --------\n");
                            Console.WriteLine("Technology Training: Ramp up on the following technology stack training\n[C#, Front end, SQL, Automation]\n\nDomain Knowledge: Ramp up on Dayforce Product\n\nProcess Immersion:\n(i) Assigned to teams and contributing on internal projects and tasks on internal projects or client projects\n(ii) Successfully complete assigned tasks within agreed timeline and with required level of quality\n(iii) Get acquainted with scrum practices and participate in scrum events\n");
                            DisplayMenu();
                            break;

                        case 2:
                            Console.WriteLine("                                           -------- COMPANY TWO --------\n");
                            Console.WriteLine("Details about the job description at Company Two...\n");
                            DisplayMenu();
                            break;

                        case 3:
                            Console.WriteLine("                                           -------- COMPANY THREE --------\n");
                            Console.WriteLine("Details about the job description at Company Three...\n");
                            DisplayMenu();
                            break;

                        default:
                            DisplayMenu();
                            break;
                    }
                }
            }
        }
    }
}
