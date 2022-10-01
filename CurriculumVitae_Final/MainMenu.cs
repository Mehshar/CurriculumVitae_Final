using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculumVitae_Final
{
    public class MainMenu
    {
        private string[] options = {"Experience / Job History", "Education / Training", "Personal Skills", "Technological Skills", "Contact Details"};

        // public virtual string header { get; set; } = "\t\t\t\t\t\t--------- MAIN MENU ---------";
        public virtual string header { get; set; } = "\t\t\t\t\t\t--------- MAIN MENU ---------";

        // Default Constructor  
        public MainMenu() { }

        public virtual void DisplayMenu()
        {
            Console.WriteLine(header);

            for(int i = 0; i < options.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + options[i]);
            }
        }

        public virtual void MakeChoice()
        {
            MainMenu menu;
            MainMenu mainMenu = new MainMenu();

            while(true)
            {
                Console.WriteLine("\nEnter a choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                int goBack = options.Length + 1;

                if(choice == goBack)
                {
                    DisplayMenu();
                }

                else
                {
                    switch(choice)
                    {
                        case 1: menu = new ExperienceMenu();
                            menu.DisplayMenu();
                            menu.MakeChoice();
                            break;

                        case 2: menu = new EducationMenu();
                            menu.DisplayMenu();
                            menu.MakeChoice();
                            break;

                        case 3: PersonalSkills pSkills = new PersonalSkills();
                            pSkills.PrintDetails();
                            mainMenu.DisplayMenu();
                            mainMenu.MakeChoice();
                            break;

                        case 4: TechnologicalSkills tSkills = new TechnologicalSkills();
                            tSkills.PrintDetails();                          
                            mainMenu.DisplayMenu();
                            mainMenu.MakeChoice();
                            break;

                        case 5: ContactDetails cDetails = new ContactDetails();
                            cDetails.PrintDetails();
                            mainMenu.DisplayMenu();
                            mainMenu.MakeChoice();
                            break;

                        default: DisplayMenu();
                            break;
                    }
                }
            }
        }
    }
}
