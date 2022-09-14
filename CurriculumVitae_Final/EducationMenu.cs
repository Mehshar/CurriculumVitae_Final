using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculumVitae_Final
{
    public class EducationMenu : MainMenu
    {
        private string[] eduOptions = {"Software Engineering (Year 1)", "Software Engineering (Year 2)", "Training"};

        public override string header { get; set; } = "\t\t\t\t\t\t--------- EDUCATION MENU ---------";

        public EducationMenu() : base()
        {
        }

        public override void DisplayMenu()
        {
            Console.WriteLine(header);

            for (int i = 0; i < eduOptions.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + eduOptions[i]);
            }

            Console.WriteLine((eduOptions.Length + 1) + ". Go Back");
        }

        public override void MakeChoice()
        {
            while (true)
            {
                Console.WriteLine("\nEnter a choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                int goBack = eduOptions.Length + 1;
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
                            Console.WriteLine("                                           -------- Software Engineering (Year 1) --------\n");
                            Console.WriteLine("Modules Covered:\n- Database Systems\n- Discrete Structures\n- Software Design Fundamentals & Programming\n- Communication & Business Skills for IT\n- Software Engineering Principles\n- Software Analysis & Modelling\n\nProjects Done:\n- TypeRacing Quest");
                            DisplayMenu();
                            break;

                        case 2:
                            Console.WriteLine("                                           -------- Software Engineering (Year 2) --------\n");
                            Console.WriteLine("Modules Covered:\n- Web Application Development\n- Software Project Management\n- Data Structures & Algorithms\n- Object Oriented Software Development\n- Software Verification & Validation\n- Interactive System Design\n\nProjects Done:\n- Style Hive E-Commerce Website\n- Fitness Tracker\n- YouDrive Mobile Application");
                            DisplayMenu();
                            break;

                        case 3:
                            Console.WriteLine("                                           -------- Training --------\n");
                            Console.WriteLine("Trainings Attended:\n- Time Management\n- Design Thinking\n- IoT Training ...");
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
