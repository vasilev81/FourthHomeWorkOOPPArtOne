
namespace ExerciseOne
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class SchoolClass : Comment
    {
        private string name;
        private List<Discipline> disciplines;

        public SchoolClass(string name)
        {
            this.Name = name;
            this.Disciplines = new List<Discipline>();

        }

        public string Name { get; set; }
        public List<Discipline> Disciplines { get; set; }

        public override string Comments()
        {
            string comment = string.Empty;

            Console.WriteLine("Input comment for your school class:");

            comment = Console.ReadLine();

            return comment;
        }
    }
}
