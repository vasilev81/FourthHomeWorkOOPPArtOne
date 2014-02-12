
namespace ExerciseOne
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Discipline : Comment
    {
        private string name;
        private int numberofLectures;
        private int numberofExercises;

        public Discipline(string name)
        {
            this.Name = name;
            this.NumberofExercises = default(int);
            this.NumberofLectures = default(int);
        }

        public string Name { get; set; }
        public int NumberofLectures { get; set; }

        public int NumberofExercises { get; set; }

        public override string Comments()
        {
            string comment = string.Empty;

            Console.WriteLine("Input comment for your discipline:");

            comment = Console.ReadLine();

            return comment;
        }
    }
}
