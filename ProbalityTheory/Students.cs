using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbalityTheory
{
    internal class Students
    {
        List<string> namesStudent;

        Students() { 
            namesStudent = new List<string>();
        }

        void get(string name) { 
            namesStudent.Add(name);
        }

    }
}
