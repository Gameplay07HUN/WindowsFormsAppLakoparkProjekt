using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppLakoparkProjekt
{
    internal class HappyLiving
    {
        public List<Lakopark> lakoparkok;

        public HappyLiving(string fileName)
        {
            lakoparkok = new List<Lakopark>();
        }
    }
}
