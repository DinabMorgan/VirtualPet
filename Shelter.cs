using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_virtual_pet
{
    internal class Shelter
    {
        public List<Pet> Pets;
        public List<Robot> Robots;

        public Shelter()
        {
            Pets = new List<Pet>();
           
        }
    }
}
