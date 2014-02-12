
namespace ExerciseOne
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Person
    {
        private string name;

        public Person (string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }

        public virtual string Comments()
        {
            string comment = string.Empty;
            return comment;
        }
    }
}
