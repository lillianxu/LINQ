using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //#Display students first name begin with S
            //--Lamda Expression 
            //var studentWithSCharacters = students.FindAll(s => s.First[0].ToString() == "S");
            //--LINQ Lambda way
            //var studentWithSCharacters = students.Where(s => s.First[0].ToString() == "S");        
            //--LINQ Query way
            //var studentWithSCharacters = from s in students
            //                                where s.First[0].ToString() == "S"
            //                                select s;

            //foreach (var student in studentWithSCharacters)
            //{
            //    Console.WriteLine("Student name is {0} {1}", student.First, student.Last);
            //}



            //4.Use FindAll and Lambda Expressions to display all students with their first name starting with the character "T"
            //--Lamda Expression 
            // var studentWithTCharacter = students.FindAll(s => s.First[0].ToString() == "T");
            //--LINQ Lambda way
            //var studentWithTCharacter = students.Where(s => s.First[0].ToString() == "T");
            //--LINQ Query way
            //var studentWithTCharacter = from s in students
            //                            where s.First[0].ToString() == "s"
            //                            select s;
            //foreach (var student in studentWithTCharacter)
            //{
            //    Console.WriteLine("Student name is {0}{1}", student.First, student.Last);
            //}


            //5.Use FindAll and Lambda Expressions to display students with the highest individual score.
            //--LINQ Lambda way
            //var maxScore = students.Max(s => s.Scores.Max());
            //var studentWithhigestScore = students.Where(s => s.Scores.Max() == maxScore);

            //--Lamda Expression 
            //var maxScore = students.Max(s => s.Scores.Max());
            //var studentWithhigestScore = students.FindAll(s => s.Scores.Max() == maxScore);

            //foreach (var student in studentWithhigestScore)
            //{
            //    Console.WriteLine("student with the highest individual score is {0}{1}", student.First, student.Last);
            //}


            /* 
             int[] Scores = { 1, 5, 2, 7 };
             // var max = Scores.Max();
             int temp1 = 0;
             int temp2 = 100;
             for (int i = 0; i < Scores.Length; i++)
             {
                 if (temp1 < Scores[i])
                     temp1 = Scores[i];
                 if (temp2 > Scores[i])
                     temp2 = Scores[i];
             }
             Console.WriteLine(max);
             Console.WriteLine("{0}", temp1);
             Console.WriteLine("{0}", temp2);
             */

            //6.Use FindAll and Lambda Expressions to display students with the highest total score.
            //--LINQ Lambda way
            //var Total = students.Max(s => s.Scores.Sum());
            //var MaxTotal = students.Where(t => t.Scores.Sum() == Total);
            //--Lamda Expression 
            //var Total = students.Max(s => s.Scores.Sum());
            //var MaxTotal = students.FindAll(t => t.Scores.Sum() == Total);
            //foreach (var student in MaxTotal)
            //{
            //    Console.WriteLine("student with thehighest total score is :{0}{1}", student.First, student.Last);
            //}


            //7.Display students with first name length greater than 7
            //--Lamda Expression
            //var studentWithFirstNameLengthGreater = students.FindAll(s => s.First.Length >7);
            //--LINQ Lambda way
            //var studentWithFirstNameLengthGreater = students.Where(s=>s.First.Length>7);
            //--LINQ Query way
            //var studentWithFirstNameLengthGreater = from s in students
            //                                         where s.First.Length <>7
            //                                         select s;
            //foreach (var student in studentWithFirstNameLengthGreater)
            //{
            //    Console.WriteLine("student with first name length greater than 7 is {0} {1}", student.First, student.Last);
            //}


            //8.Display student with total score greater than 270
            // --Lamda Expression
            //var StudentScoreG = students.FindAll(s => s.Scores.Sum() > 270);

            //--LINQ Lambda way
            //var StudentScoreG = students.Where(s => s.Scores.Sum() > 270);
            //foreach (var student in StudentScoreG)
            //{
            //    Console.WriteLine("student with total score greater than 270 is {0} {1}", student.First, student.Last);
            //}


            //9.Print students with reversed name
            /*
                        List<Student> RName = new List<Student>();

                        foreach (var SName in students)
                        {
                            var fName = SName.First;
                            var lName = SName.Last;
                            RName.Add(new Student { First = lName, Last = fName});
                        }

                        foreach (var rName in RName)
                        {
                            Console.WriteLine("{0} {1}",rName.First,rName.Last);
                        }

            */



            //10.Generate student to a new List object and the object have FirstName and LastName property

            //List<onlyName> OnlyNames = new List<onlyName>();
            //foreach (Student temp in students)
            //{
            //    OnlyNames.Add(new onlyName { First = temp.First, Last = temp.Last });
            //}
            //foreach (var student in OnlyNames)
            //{
            //    Console.WriteLine("Student name is {0} {1}", student.First, student.Last);
            //}
            //Console.WriteLine("--------------");


            //11.Print students with First name Descending order
            //var DescendingOrder = students.OrderByDescending(s => s.First);
            //foreach (var student in DescendingOrder)
            //{
            //    Console.WriteLine("students with First name Descending order : {0} {1}", student.First, student.Last);

            //}
            //Console.WriteLine("--------------");

            //12.Print students with Last name Ascending order
            //var AscendOrder = students.OrderBy(s => s.Last);
            //foreach (var student in DescendingOrder)
            //{
            //    Console.WriteLine("students with Last name Ascending order: {0} {1}", student.First, student.Last);
            //}




            //SS
            /*var tempx =students.Where(s=>s.Scores.Sum()== students.Max(x => x.Scores.Sum()));
              Student te=tempx.First();
              Console.WriteLine("studentqqq with the highest total score is" + te.First + "\t" + te.Last + "\tsore" + te.Scores.Sum());
              */
            //var ie = students.OrderBy(x => x.Scores.Sum());
            //  Student temp1 = ie.Last<Student>();
            //  Console.WriteLine("good student name" + temp1.First + "\t" + temp1.Last + "\tsore" + temp1.Scores.Sum());


            //Console.WriteLine("--------------------------");
            //var it=ie.Select(x => x.Scores.Sum() > 270);//>270
            //show(it);
            //Console.WriteLine("--------------------------");


            /*      List<onlyName> justnames = new List<onlyName>();//
                      foreach (Student temp in students) {
                          justnames.Add(new studentname {First=temp.First, Last=temp.Last });
                      }
              */


            /*

            //    private static void showname(IEnumerable<studentname> ie,bool flag)
            //    {
            //        foreach (studentname temp in ie)
            //        {

            //            Console.WriteLine("{0,-20:X} {1,-20:X}", flag?temp.First:getrev(temp.First), temp.Last);



            //        }
            //    }
            //    private static string getrev(IEnumerable<char> revstr)
            //    {
            //        string str = "";
            //        foreach (char temp in revstr.Reverse())

            //            str += temp;


            // return str;
            */

            Console.ReadKey();
        }


        //private static void show(IEnumerable<Student> ie)
        //{
        //    foreach (Student temp in ie)
        //    {

        //        Console.Write("{0,-20:X} {1,-20:X} {2,-5:D} \t", temp.First, temp.Last, temp.Scores.Sum());
        //        Console.Write("{");
        //        foreach (int x in temp.Scores)
        //            Console.Write(x + "\t");
        //        Console.WriteLine("}");

        //    }
        //}

        class onlyName
        {
            public string First { get; set; }
            public string Last { get; set; }
        }
        static List<Student> students = new List<Student>
        {
           new Student {First="Svetlana", Last="Omelchenko", ID=111, Scores= new List<int> {97, 92, 81, 60}},
           new Student {First="Claire", Last="O'Donnell", ID=112, Scores= new List<int> {75, 84, 91, 39}},
           new Student {First="Sven", Last="Mortensen", ID=113, Scores= new List<int> {88, 94, 65, 91}},
           new Student {First="Cesar", Last="Garcia", ID=114, Scores= new List<int> {97, 89, 85, 82}},
           new Student {First="Debra", Last="Garcia", ID=115, Scores= new List<int> {35, 72, 91, 70}},
           new Student {First="Fadi", Last="Fakhouri", ID=116, Scores= new List<int> {99, 86, 90, 94}},
           new Student {First="Hanying", Last="Feng", ID=117, Scores= new List<int> {93, 92, 80, 87}},
           new Student {First="Hugo", Last="Garcia", ID=118, Scores= new List<int> {92, 90, 83, 78}},
           new Student {First="Lance", Last="Tucker", ID=119, Scores= new List<int> {68, 79, 88, 92}},
           new Student {First="Terry", Last="Adams", ID=120, Scores= new List<int> {99, 82, 81, 79}},
           new Student {First="Eugene", Last="Zabokritski", ID=121, Scores= new List<int> {96, 85, 91, 60}},
           new Student {First="Michael", Last="Tucker", ID=122, Scores= new List<int> {94, 92, 91, 91} }
        };
    }

    
    public class Student
    {
        public string First { get; set; }
        public string Last { get; set; }
        public int ID { get; set; }
        public List<int> Scores;
    }

    // Create a data source by using a collection initializer.

}
