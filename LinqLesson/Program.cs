using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>()
            {
                new Student() { Id = 1, Name ="Bruno",Age = 40},
                new Student() { Id = 2, Name ="Alice",Age = 20},
                new Student() { Id = 3, Name ="Mario",Age = 25},
                new Student() { Id = 4, Name ="Aila",Age = 20},
                new Student() { Id = 5, Name ="Dario",Age = 40}
            };

            var query = (from student in studentList group student by student.Age)
                .OrderBy(x => x.Key);

            foreach (var students in query)
            {
                Console.WriteLine(students.Key); // gruppo

                var ordered = students.OrderByDescending(i => i.Name);
                foreach (var s in ordered)
                {
                    Console.WriteLine("      {0}", s.Name); //Elementi del gruppo
                }

            }

        }
    }
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
