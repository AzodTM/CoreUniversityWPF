using System;
using System.Collections.Generic;
using System.Text;

namespace CoreUniversityWPF.Model.Tables
{
    class University
    {
        public int Id { set; get; }
        public string Title { set; get; }
        public string City { set; get; }
        public string YearOfFoundation { set; get; }

        public List<Faculty> Faculties { set; get; }

        public override string ToString()
        {
            return Title;
        }
    }
}
