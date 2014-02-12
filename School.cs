
namespace ExerciseOne
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class School
    {
        private string name;
        private List<SchoolClass> classes;
        public School(string name)
        {
            this.Name = name;
            this.Classes = new List<SchoolClass>();
        }

        public string Name { get; set; }
        public List<SchoolClass> Classes { get; set; }
  
    }
}
