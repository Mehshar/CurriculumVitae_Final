using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculumVitae_Final
{
    public class PersonalSkills : IDetails
    {
        public void PrintDetails()
        {
            Console.WriteLine("\t\t\t\t\t\t-------- PERSONAL SKILLS --------\n");
            Console.WriteLine("- Fluent and articulate communication\n- Teamworking Skills\n- Creative Problem Solving\n- Efficient Time Management\n- Strategic thought and planning aptitude\n- Leadership skills\n- Ability to work under pressure and with conflicting deadlines\n- Mathematical Aptitude\n");
        }
    }
}
