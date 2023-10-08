using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_smells.OO_abuser.temporary_field
{
    internal class Student
    {
        public string first_name {  get; set; }
        public string last_name { get; set;}
        public string full_name {  get; set; }

        public Student(string first_name, string last_name)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.full_name = first_name + " " +  last_name;
        }
    }
}
