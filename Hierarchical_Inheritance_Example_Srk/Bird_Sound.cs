using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchical_Inheritance_Example_Srk
{
    public class Bird_Sound: Animal_Sound
    {
        public void ParrotSound()
        {
            Console.WriteLine("Parrot sounds be like : chripp....");
        }
    }
}
