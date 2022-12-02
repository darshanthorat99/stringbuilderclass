using System;
using System.Collections.Generic;

namespace stringbuilderclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string str = "hello";
            //double per = 86.23;
            //StringBuilder sb = new StringBuilder("hello abs ");
            //sb.Append("Good Morning");
            //sb.AppendFormat("   percentage  {0:P}", per);
            //Console.WriteLine(sb);
            //sb.Remove(6, 3);
            //Console.WriteLine(sb);

            //sb.Insert(6, "darshan ");
            //Console.WriteLine(sb);


            //sb.Replace("Good Morning", "Good Day");
            //Console.WriteLine(sb);


            //Book[] booklist = new Book[2]
            //{
            //    new Book { Id = 1, Name = "rich dad poor dad", Publisher = "Warner Books", Price = 899, },
            //    new Book { Id = 2, Name = "mind game", Publisher = "Warner Books", Price = 599 }
            //};
            //foreach (Book b in booklist)
            //{
            //    Console.WriteLine($"id {b.Id}  name {b.Name} publisher {b.Publisher} price {b.Price}");
            //}

            //Course[] courselist = new Course[]
            //{
            //    new Course { Id = 1, Name = "c++", Duration = 2, Fee = 2000 },
            //     new Course { Id = 1, Name = "c++", Duration = 2, Fee = 2000 },

            //};
            //foreach(Course c in courselist)
            //{
            //    Console.WriteLine($"id  {c.Id}  name  {c.Name} duration  {c.Duration} fee {c.Fee}");
            //}

            //Course[] courselists = new Course[1];
            //for (int i = 0; i < 1; i++)
            //{
            //    Console.WriteLine("enter id");
            //    int Id = Convert.ToInt32(Console.ReadLine());
            //    string Name = Console.ReadLine();
            //    string Publisher = Console.ReadLine();
            //    double Price = Convert.ToDouble(Console.ReadLine());

            //}
            //foreach (Course H in courselists) 
            //{
            //    Console.WriteLine($"id  {H.Id}  name  {H.Name} duration  {H.Duration} fee {H.Fee}");
            //}

            // int[] arr = new int[] { 1, 2, 3 };
            // ArrayList list = new ArrayList();
            // list.Add(33);  
            // list.Add(34);
            // list.Add(334);
            // list.Add(838);
            // list.Insert(1, 2000);

            // list.Remove(33);
            //// list.RemoveAt(5);

            // list.Sort();
            // list.Reverse();
            // list.AddRange(arr);

            // list.RemoveRange(1, 2);




            //Hashtable ht = new Hashtable();
            //ht.Add(1, "india");
            //ht.Add(2, "usa");
            //ht.Add(63, "nepal");
            //ht.Add(91, "pakista");

            //ht.Remove(4);

            //foreach (DictionaryEntry item in ht)
            //{
            //    Console.WriteLine($"{item.Key}   {item.Value}";

            //}
            //List<int> ilist = new List<int>();
            //ilist.Add(90);
            //ilist.Add(70);
            //ilist.Add(95);
            //ilist.Add(50);

            //ilist.Remove(95);
            //ilist.Insert(0, 100);
            //ilist.Sort();
            //ilist.Reverse();

            //foreach(int i in ilist)
            //{
            //    Console.WriteLine(i);
            //}
            //List<Book> books = new List<Book>()
            //{
            //    new Book { Id=1,Name="mahabharat",Publisher="krishna",Price=1000},
            //     new Book { Id=2,Name="ramayan",Publisher="ram",Price=2000},
            //      new Book { Id=3,Name="ncrt",Publisher="cbse",Price=100},
            //};
            //foreach (Book b in books)
            //{
            //    Console.WriteLine($"id {b.Id} {b.Name} {b.Publisher} {b.Price}");
            //}

            //List<Course> courseslist = new List<Course>()
            //{
            //    new Course(1,"c++", 20000f),
            //    new Course(2,"python", 20000f),
            //    new Course(2,"java",30000)

            //};
            //foreach(Course c in courseslist)
            //{
            //    Console.WriteLine(c);
            //}


            //Stack<int> s = new Stack<int>();
            //s.Push(10);
            //s.Push(20);
            //s.Push(30);
            //s.Push(40);
            //s.Push(50);

            //s.Pop();
            //foreach(var item in s)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("last element " + s.Peek());



            //Queue<int> q = new Queue<int>();
            //q.Enqueue(10);

            //q.Enqueue(20);
            //q.Enqueue(30);
            //q.Dequeue();
            //foreach(int item in q)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("first element " + q.Peek());

            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "darshan");
            d.Add(2, "vishal");
            d.Add(3, "rahul");
            foreach (KeyValuePair<int, string> item in d)
            {
                Console.WriteLine(item.Value);
            }
            Dictionary<int, Course>  da = new Dictionary<int,Course>();
            da.Add(1, new Course(1, "c++", 20000f));
            da.Add(2, new Course(2, "java", 20000f));
            da.Add(3, new Course(3, "python", 20000f));
            foreach(KeyValuePair<int, Course> c in da)
            {
                Console.WriteLine(c);
            }


















        }
    }
}

