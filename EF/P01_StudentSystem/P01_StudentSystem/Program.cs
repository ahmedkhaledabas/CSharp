using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using P01_StudentSystem.Data;
using P01_StudentSystem.Models;

namespace P01_StudentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SeedData();
            //ReadDataStudent();
            //ReadDataCourse();

            //ApplicationDbContext context = new ApplicationDbContext();
            //var students = context.Students.ToList();
            //foreach(var student in students)
            //{
            //    Console.WriteLine(student);
            //}
        }

        public static void ReadDataStudent()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            Console.WriteLine("Enter Your Name");
            var name = Console.ReadLine();
            Console.WriteLine("Enter Your Phone");
            var phone = Console.ReadLine();
            Console.WriteLine("Enter Your BirthDay Like{2/29/2024 7:19:28 AM}");
            var birtDay = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter Register On Like{2/29/2024 7:19:28 AM}");
            var registerOn = Convert.ToDateTime(Console.ReadLine());

            context.Students.Add(new() { PhoneNumber = phone, BirthDay = birtDay, Name = name, RegisteredOn = registerOn });
            context.SaveChanges();
        }

        public static void ReadDataCourse()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            Console.WriteLine("Enter Name Of Course");
            var name = Console.ReadLine();
            Console.WriteLine("Enter Description");
            var desc = Console.ReadLine();
            Console.WriteLine("Enter Start Date Like{2/29/2024 7:19:28 AM}");
            var startDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter End Date Like{2/29/2024 7:19:28 AM}");
            var endDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter SPrice");
            var price = Convert.ToDouble(Console.ReadLine());
            context.Courses.Add(new() { Desc = desc, EndDate = endDate, Name = name, Price = price, StartDate = startDate });
            context.SaveChanges();
        }

        public static void SeedData()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            List<Course> courses = new List<Course>
            {
                new Course() {EndDate = DateTime.Now , StartDate = DateTime.Now , Desc = "anydesc" , Name = "BackEnd" , Price = 1d  },
                new Course() {EndDate = DateTime.Now , StartDate = DateTime.Now , Name = "FrontEnd" , Price = 2d},
                new Course() {EndDate = DateTime.Now , StartDate = DateTime.Now , Desc = "anydesc2" , Name = "CCNA" , Price = 3d },

            };
            context.Courses.AddRange(courses);

            List<Resource> resources = new List<Resource>
            {
                new Resource(){ Name = "ROne" , CourseId = 13, ResourceType = ResourceType.Document , Url ="https/-----1" },
                new Resource(){ Name = "RTow" , CourseId = 14, ResourceType = ResourceType.Presentation , Url ="https/-----2"},
                new Resource(){ Name = "RThree" , CourseId = 15, ResourceType = ResourceType.Video , Url ="https/-----3"},
            };
            context.Resources.AddRange(resources);


            List<Student> students = new List<Student>
            {
                new Student() {BirthDay =  DateTime.Now , Name ="Ahmed" , PhoneNumber = "0123" , RegisteredOn = DateTime.Now  },
                new Student() {BirthDay =  DateTime.Now , Name ="Khaled" , PhoneNumber = "01234" , RegisteredOn = DateTime.Now },
                new Student() {BirthDay =  DateTime.Now , Name ="Abas" , PhoneNumber = "012345" , RegisteredOn = DateTime.Now },

            };
            context.Students.AddRange(students);

            List<Homework> homeworks = new List<Homework>
            {
                new Homework() {Content = "homework 1" , ContentType = ContentType.Application, CourseId = 13, StudentId = 13 , SubmissionTime = DateTime.Now},
                new Homework() {ContentType = ContentType.Zip, CourseId = 14, StudentId = 14 , SubmissionTime = DateTime.Now},
                new Homework() {Content = "homework 3" , ContentType = ContentType.Pdf, CourseId = 15, StudentId = 15 , SubmissionTime = DateTime.Now }

            };
            context.Homework.AddRange(homeworks);
            context.SaveChanges();

        }
    }
}
