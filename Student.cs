
namespace ExerciseOne
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Student : Person
    {       
        private int numberInClass;
        private SchoolClass schoolClass;

        public Student(string name) : base(name)
        {
            this.NumberInClass = default(int);
            this.SchoolClass = default(SchoolClass);
        }

        public int NumberInClass { get; set; }
        public SchoolClass SchoolClass { get; set; }

        public override string Comments()
        {
            string comment = string.Empty;

            Console.WriteLine("Input comment for your student:");

            comment = Console.ReadLine();

            return comment;
        }
        
    }
}
