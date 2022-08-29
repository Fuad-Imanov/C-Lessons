using System;

namespace lesson1
{
    class Student
    {
        public Student(string lastname, string firstname)
        {
            _lastName = lastname;
            _firstName = firstname;
        }
        public Student(string lastname, string firstname, string fathername, DateTime birthday)
        {
            _lastName = lastname;
            _firstName = firstname;
            _fatherName = fathername;
            _birthDay = birthday;
        }

        public Student(Student student)
        {
            _lastName = student._lastName;
            _firstName = student._firstName;
        }


        private string _lastName;
        private string _firstName;
        private string _fatherName;
        private DateTime _birthDay;



        public void PrintStudentInfo()
        {
            Console.WriteLine($"lastName = {_lastName}: \n firstName = {_firstName}: \n fatherName = {_fatherName}: \n birthday = {_birthDay}:");
        }
        public void LastNameChanged(string lastnamechanged)
        {
            _lastName = lastnamechanged;
        }

    }

    class Point
    {

        static Point()
        {
            Console.WriteLine("Saymaga bashlayiram");
        }

        public Point()
        {
            count++;
        }

        private static int count;

        public int Count
        {
            get { return count; }
            private set { count = value; }

        }

        private int x;

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        private int y;

        public int Y
        {
            get { return y; }
            set { y = value; }
        }


        public void SetX(int x)
        {
            this.x = x;
        }
        public int GetX()
        {
            return x;
        }

    }

    class Point2D
    {
        public Point2D()
        {
            Console.WriteLine("Point2D konstruktor cagirilmishdi");
        }

        public int x { get; set; }
        public int y { get; set; }
    }

    class Point3D :Point2D
    {

        public Point3D()
        {
            Console.WriteLine("Point3D konstruktor cagirilmishdi");
        }
        public int z { get; set; }
    }

    class Program
    {
       
        static void Main(string[] args)
        {

            Point3D point3d = new Point3D();
            



            
           /* string line = Console.ReadLine(); // ввод числа в десятеричной системе 

            int x = int.Parse(line);
            int[] myArray = new int[10] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] arr = new string[6] { "a", "b", "c", "d", "e", "f" };
            string answer;
            string res = "";
            if (x<16)
            {
                if (x<10)
                {
                    Console.WriteLine(myArray[x]);
                }
                else
                {
                    Console.WriteLine(arr[x-10]);
                }
            }
            else
            {
                while (x >= 16)
                {
                    int result = x % 16;
                    x = x / 16;
                    if (result < 16)
                    {
                        if (result < 10)
                        {
                            res+=myArray[result ];
                        }
                        else
                        {
                            res+=arr[result - 10];
                        }
                    }


                }

                if (x < 10)
                {
                    res += myArray[x];
                }
                else
                {
                    res += arr[x - 10];
                }
                string res1 = "";
                for (int i = res.Length-1; i >= 0; i--)
                {
                    res1 += res[i];
                }
                Console.WriteLine(res1);
            }*/
            

           
        }
       
    }
}

