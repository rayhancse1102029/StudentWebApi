using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebApi.Models
{
    public class StudentModel
    {

        public string Name { get; set; }
        public string Dept { get; set; }
        public double Cgpa { get; set; }
        public int Year { get; set; }

    }
}
