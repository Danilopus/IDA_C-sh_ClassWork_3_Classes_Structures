// ClassWork template 1.0 // date: 22.09.2023

using Service;
using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;

// ClassWork 03 : [C sharp Classes] --------------------------------

/// Модификаторы доступа [полей классов] / [классов]:
/*
    1) private (только этот же класс)
    2) private protected (+ только наследники этой же сборки) 
    3) protected (+ только наследники в других сборках)
    4) internal (доступны только классам текущей сборки)
    5) protected internal ()
    6) public (доступно всем во всех сборках
*/

/// Родственность/отношение классов классов
/*


 */

/// Модификаторы static / const / readonly
/*  
 static - статическое поле/метод

 const - только для полей. Просто CONST

 readonly - только для полей (изменение таких полей только изнутри класса)  
 */

/// C-tor
/*
static C-tor:
   1. без параметров
   2. без модификаторов
   3. вызывается один раз и в самом начале, до любого 1-го обращения к классу
   4. имеет доступ, только к классичеким членам класса
*/

/// Arguments
/* 
1) Передача аргумента по ссылке - ref
    int Summ(ref int a, ref int b) {return int};

2) ключевое слово - out *замена привычного return
определение:    void Summ(ref int a, ref int b, out int ans){ans=...};
использование:  Summ(a, b, out local_variable);
 */

 /// Partial
 /*
  partial class ClassName -  класс определен в нескольких местах  
  */

 /// Fields accessosrs/mutators
 /* int _sum;
  * public int sum
  *     {
  *         get {return _sum;)
  *         set {_sum = value;}
  *     }
  * object.sum = 10;
  *
  */

 /// namespace
 /* 
  
  */



namespace IDA_C_sh_ClassWork_3_Classes_Structures
{
    struct Student
    {
        public const int sum = 0;
        public string name;
        public int age;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task_1();
            
            // Setters & Getters
            //Task_2(); 

           // Task_3();   

//            Task_4();

            Task_5();


            Console.ReadKey();
        }

        public static void Task_1()
        /*  Задание ... */
        {
            int a = 5;
            int b = 15;

            RandomName obj = new RandomName();

            obj.summ_1(ref a, ref b);
            obj.summ_2(a, b);
        }

        public static void Task_2()
        /*  Задание ... */
        {
            DateTime date = new DateTime(1821, 6,15);
            Employee empl_obj_1 = new("Fedor Dostoevskyi",
                date,
                "+7-912-777-5533",
                "sample@gmail.com",
                "content-writer",
                "write content");

            Employee empl_obj_2 = new();

            empl_obj_2._name_= "Fedor Dostoevskyi";
            empl_obj_2._birthday_date_ = date;
            empl_obj_2._phone_ = "+7-912-777-5533";
            empl_obj_2._position_ = "content-writer";
            empl_obj_2._position_instruction_ = "write content";


            Console.WriteLine("\n\nC-tor creation");
            Console.WriteLine("\nname = " + empl_obj_1._name_ +
                "\nbirthday_date = " + empl_obj_1._birthday_date_ +
                "\nphone = "  + empl_obj_1._phone_ +
                "\nposition = " + empl_obj_1._position_ +
                "\nposition_instruction = " + empl_obj_1._position_instruction_);

            Console.WriteLine("\n\nMutator creation");
            Console.WriteLine("\nname = " + empl_obj_2._name_ +
                "\nbirthday_date = " + empl_obj_2._birthday_date_ +
                "\nphone = " + empl_obj_2._phone_ +
                "\nposition = " + empl_obj_2._position_ +
                "\nposition_instruction = " + empl_obj_2._position_instruction_);

            Console.ReadKey();
        }

        public static void Task_3()
        /*  Задание ... */
        {

            //Console.WriteLine("");
            try
            {
                Divide(ServiceFunction.Get_Double(), ServiceFunction.Get_Double());
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("DivideByZeroException");
            }
        }
        static double Divide(double num, double denum)
        {
            return num / denum;
        }

        public static void Task_4()
        {
            double cube_edge = 5;
            double parallelepiped_edge_1 = 5;
            double parallelepiped_edge_2 = 3;
            double parallelepiped_edge_3 = 7;

            Figure new_figur = new();

            Console.WriteLine("What to calculate:\n1)Cube area\n2)Parallelepiped area\n");
            switch (ServiceFunction.Get_Int(1, 2))
            {
                case 1:
                    {
                        Console.WriteLine("\nEnter cube edge -> ");
                        cube_edge = ServiceFunction.Get_Double(0, Double.MaxValue);
                        Console.WriteLine("Square of cube with [edge = " + cube_edge + "] -> " + new_figur.Area(cube_edge));
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("\nEnter parallelepiped edge_1 -> ");
                        parallelepiped_edge_1 = ServiceFunction.Get_Double(0, Double.MaxValue);
                        Console.WriteLine("\nEnter parallelepiped edge_2 -> ");
                        parallelepiped_edge_2 = ServiceFunction.Get_Double(0, Double.MaxValue);
                        Console.WriteLine("\nEnter parallelepiped edge_3 -> ");
                        parallelepiped_edge_3 = ServiceFunction.Get_Double(0, Double.MaxValue);

                        Console.WriteLine("Square of parallelepiped with [dimensions " + parallelepiped_edge_1 + "," + parallelepiped_edge_2 + "," + parallelepiped_edge_3 + "] -> "
                            + new_figur.Area(parallelepiped_edge_1, parallelepiped_edge_2, parallelepiped_edge_3));

                        break;
                    }

            }
                     
        }

        public static void Task_5()
        {

            Class_Task_5 obj = new();
            obj.change_num_1(5);
            obj.change_num_2(15);

            Console.WriteLine("obj.max() " + obj.max());
            Console.WriteLine("obj.sum() " + obj.sum());



        }


    }// class Programm

    class Class_Task_5
    {
        int num_1;
        int num_2;
        public void ShowData()
        {
            Console.WriteLine("num_1 = " + num_1);
            Console.WriteLine("num_2 = " + num_2);
        }

        public void change_num_1(int num_1)
        {
            this.num_1 = num_1;
        }

        public void change_num_2(int num_2)
        {
            this.num_2 = num_2;
        }
        public int sum()
        {
            return num_1 + num_2;   
        }

        public int max()
        {
            return num_1 > num_2 ? num_1 : num_2;
        }

    }

    class RandomName
    {
        public int summ_1(ref int num_1, ref int num_2)
        {
            num_1 = 50;
            num_2 = 150;
            return num_1+num_2;
        }
        public int summ_2(int num_1, int num_2)
        {
            num_1 = 500;
            num_2 = 1500;
            return num_1 + num_2;
        }
    }

    class Employee
    {
        string _name;
        DateTime _birthday_date;
        string _phone;
        string _email;
        string _position;
        string _position_instruction;

        public Employee() { }

        public Employee(string name,
        DateTime birthday_date,
        string phone,
        string email,
        string position,
        string position_instruction) 
            {
            _name = name;
            _birthday_date = birthday_date;
            _phone = phone;
            _email = email;
            _position = position;
            _position_instruction = position_instruction;
        }

        public string _name_
        {
            get { return _name; }
            set { _name = value; }
        }
        public DateTime _birthday_date_
        {
            get { return _birthday_date; }
            set { _birthday_date = value; }
        }
        public string _phone_
        {
            get { return _phone; }
            set { _phone = value; }
        }
        public string _email_
        {
                get { return _email; }
                set { _email = value; }
        }
        public string _position_
        {
            get { return _position; }
            set { _position = value; }
        }
        public string _position_instruction_
        {
            get { return _position_instruction; }
            set { _position_instruction = value; }
        }

    }

    class Figure
    {
        public double Area(double cube_edge)     { return cube_edge * cube_edge*6;}
        public double Area(double parallelepiped_edge_1, double parallelepiped_edge_2, double parallelepiped_edge_3) 
        { return 2*(parallelepiped_edge_1 * parallelepiped_edge_2 
                + parallelepiped_edge_1* parallelepiped_edge_3 
                + parallelepiped_edge_2* parallelepiped_edge_3); }
    }


}//namespace
