using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentinfo
{
    public class student
    {
        public string reg;
        public string firstname;
        public string lastname;

        public string getfullname()
        { 
          return (firstname + " " + lastname);
        }
    }
}
