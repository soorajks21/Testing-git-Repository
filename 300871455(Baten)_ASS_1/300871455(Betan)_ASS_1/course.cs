using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _300871455_Betan__ASS_1
{
  public  class course
    {
        private int sem;
        private string course1;
        private string course2;
        private string course3;
        private string course4;
        private string course5;

        public List<course> courses;

        public int Sem { get => sem; set => sem = value; }
        public string Course1 { get => course1; set => course1 = value; }
        public string Course2 { get => course2; set => course2 = value; }
        public string Course3 { get => course3; set => course3 = value; }
        public string Course4 { get => course4; set => course4 = value; }
        public string Course5 { get => course5; set => course5 = value; }
    }
}
