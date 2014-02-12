
namespace ExerciseOne
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Test
    {
        public static void Main()
        {
            Student student = new Student("Ivo");

            Discipline discipline = new Discipline("Mathematics");

            string disciplineComments = discipline.Comments();

            string studentComment = student.Comments();
        }
    }
}
