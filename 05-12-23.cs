using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		StudentProgram();
	}

	//////////////////////////////////////////////////////
	//////////////////////////////////////////////////////
	//////////////////////////////////////////////////////
	public static void StudentProgram()
	{
		Student s1 = new Student();
		s1.FirstName = "Nikola";
		s1.LastName = "Nikolic";
		s1.IndexNumber = 300;
		s1.DateOfBirth = new DateTime(2001, 4, 12);
		///
		s1.CurrentYear = 1;
		s1.AddPassedExam(6);
		s1.AddPassedExam(10);
		s1.AddPassedExam(7);
		s1.AddPassedExam(6);
		s1.AddPassedExam(8);
		s1.AddPassedExam(6);
		s1.AddPassedExam(6);
		s1.AddPassedExam(9);
		s1.AddPassedExam(10);
		///
		Student s2 = new Student("Marija", "Markovic", 11112, 3, new DateTime(1998, 6, 18));
		///
		s2.AddPassedExam(6);
		s2.AddPassedExam(10);
		s2.AddPassedExam(8);
		s2.AddPassedExam(10);
		s2.AddPassedExam(9);
		s2.AddPassedExam(10);
		List<Student> listOfStudents = new List<Student>();
		listOfStudents.Add(s1);
		listOfStudents.Add(s2);
		foreach (Student s in listOfStudents)
		{
			s.DisplayStudentInfo();
			s.CountMedianGrade();
			Console.WriteLine("\nThis student is{0} freshman", s.StudentFreshman() ? "" : " not");
			Console.WriteLine("\n----------------------------------\n");
		}
	}

	public class Student
	{
		private string firstName, lastName;
		private int indexNumber, currentYear;
		private DateTime dateOfBirth;
		private List<int> grades = new List<int>();
		//private int[] grades = new int[32];
		public Student()
		{
		}

		public Student(string name, string last, int index, int currentYear, DateTime dateOfBirth)
		{
			this.firstName = name;
			this.lastName = last;
			this.indexNumber = index;
			this.currentYear = currentYear;
			this.dateOfBirth = dateOfBirth;
		}

		public string FirstName
		{
			get
			{
				return firstName;
			}

			set
			{
				firstName = value;
			}
		}

		public string LastName
		{
			get
			{
				return lastName;
			}

			set
			{
				lastName = value;
			}
		}

		public int IndexNumber
		{
			get
			{
				return indexNumber;
			}

			set
			{
				indexNumber = value;
			}
		}

		public int CurrentYear
		{
			get
			{
				return currentYear;
			}

			set
			{
				currentYear = value;
			}
		}

		public List<int> Grades
		{
			get
			{
				return grades;
			}

			set
			{
				grades = value;
			}
		}

		public DateTime DateOfBirth
		{
			get
			{
				return dateOfBirth;
			}

			set
			{
				dateOfBirth = value;
			}
		}

		public bool StudentFreshman()
		{
			return currentYear == 1;
		}

		public void AddPassedExam(int grade)
		{
			if (this.grades.Count < 32 && grade > 5 && grade <= 10)
			{
				this.grades.Add(grade);
			}
		}

		/*
		public void AddPassedExamToInt(int grade)
		{
			if(this.grades.Length < 32 && grade>5 && grade <=10)
			{
					//Add later
			}
		}
		*/
		public void CountMedianGrade()
		{
			int sum = 0;
			foreach (int grade in grades)
			{
				sum += grade;
			}

			double median = (double)sum / grades.Count;
			Console.WriteLine("Median grade for student is: {0:N}", median);
		}

		public void DisplayStudentInfo()
		{
			Console.WriteLine("Name: {0}\n\nLast Name: {1}\n\nIndex Number: {2}\n\nCurrent Year: {3}\n", firstName, lastName, indexNumber, currentYear);
		}
	}
}