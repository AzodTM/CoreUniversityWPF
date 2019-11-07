using System;
using System.Collections.Generic;
using System.Text;

namespace CoreUniversityWPF.Model.Tables
{
    class Faculty
    {
        public int Id { set; get; }
        public string Title { set; get; }
        public string Dean { set; get; }

        public List<Student> Students { set; get; }

        public int UniversityID { set; get; }
        public University University { set; get; }

        public override string ToString()
        {
            return Title;
        }

    }
}
