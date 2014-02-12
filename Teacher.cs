
namespace ExerciseOne
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Teacher : Person
    {
        private Discipline discipline;

        public Teacher (string name, Discipline discipline) : base(name)
        {           
            this.Discipline = discipline;
        }
       
        public Discipline Discipline { get; set; }

        public override string Comments()
        {
            string comment = string.Empty;

            Console.WriteLine("Input comment for your teacher:");

            comment = Console.ReadLine();

            return comment;
        }
    }
}
