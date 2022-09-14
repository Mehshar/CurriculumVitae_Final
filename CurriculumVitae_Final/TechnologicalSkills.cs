using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculumVitae_Final
{
    public class TechnologicalSkills : IDetails
    {
        public void PrintDetails()
        {
            Console.WriteLine("\t\t\t\t\t\t-------- TECHNOLOGICAL SKILLS --------\n");
            Console.WriteLine("- C++ and C#\n- Java\n- HTML5\n- CSS3\n- PHP\n- JavaScript\n- AJAX\n- XML, XSD & XSLT\n- SQL\n- Web Services\n");
        }
    }
}
