using System;
using System.Collections.Generic;
using System.Text;

namespace CoreUniversityWPF.Model.Tables
{
    class Student
    {
        public int Id { get; set; }
        public string Name { set; get; }
        public string SecondName { get; set; }
        public int Age  { get; set; }
        public double AvgScore { get; set; }
        public int YearOfReceipt{ get; set; }


        public int FacultyID { set; get; }
        public Faculty Faculty { set; get; }


}
}
