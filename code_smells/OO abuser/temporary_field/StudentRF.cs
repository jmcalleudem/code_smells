using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_smells.OO_abuser.temporary_field
{
    internal class StudentRF
    {
        public string first_name { get; set; }
        public string last_name { get; set; }

        public StudentRF(string first_name, string last_name)
        {
            this.first_name = first_name;
            this.last_name = last_name;
        }

        public string get_full_name()
        {
            return first_name + " " + last_name;
        }
    }
}
