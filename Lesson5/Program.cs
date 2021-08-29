using System;
using System.Collections.Generic;

namespace CourseCoordinator
{
	public class Program
	{
		public static void Main()
		{
			Console.WriteLine("Welcome to My University");
			var students = new List<string>{"Diana", "Jacob", "Jason", "Ric"};
			
			var courses = new List<string>{"Shopping", "Software Engineering", "English", "Jewellery Making"};
			while (true)
			{
				Console.WriteLine("What would you like to see or do?");
			
				Console.WriteLine("Students = See a list of students at the university");
				Console.WriteLine("Courses = See a list of courses at the university");
				Console.WriteLine("Enrol = Enrol a new student at the university");
				Console.WriteLine("Unenrol = Unenrol a student");
				Console.WriteLine("AddCourse = Add a new course to the university catalogue");
				Console.WriteLine("RemoveCourse = Remove a course from the university catalogue");
				Console.WriteLine("X = Exit");
				var userInput = Console.ReadLine();
				
				if (userInput == "x" || userInput == "X")
				{
					break;
				}

				// respond to the user command
				switch (userInput)
				{
					case "Students":
						Console.WriteLine("Here is a list of students:");
                        foreach (string student in students)
                        {
                            Console.WriteLine(student);
                        }
						
						break;
					case "Courses":
						Console.WriteLine("Here is a list of courses offered:");
                        foreach (string courseList in courses)
                        {
                            Console.WriteLine(courses);
                        }

						break;
					
					default:
						Console.WriteLine("I didn't recognise that command");
						break;
				}
			}
		}
	}
}