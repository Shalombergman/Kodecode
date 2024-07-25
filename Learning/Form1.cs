using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learning
{
    public partial class Form1 : Form
    {
        private string[] names = new string[10];
        //private Dog[] dogseArr = new Dog[2];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 2 options to initialize an arr 
            // 1. Define the length of the arrray
            int[] ages = new int[10];

            ages[0] = 23; // 1st element
            ages[1] = 45; // 2st element
            Console.WriteLine(ages[0]);

            // 2. defin an arr with values
            int[] grades = { 100, 100, 99 };

            //Loops
            // 1. 'For'
            // - (1) Initialization 
            // - (2) Condition
            // - (3) Change values
            for (int i = 0; i < grades.Length; i++)
            {
                //Console.WriteLine("Grade " + i + ": " + grades[i]);
                Console.WriteLine($"Grade {i}: {grades[i]}");
            }
            //2. foreche
            Console.WriteLine("-- foreach");
            foreach (int oneAge in ages)
            {
                Console.WriteLine(oneAge);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] names = { "shalom", "jakove", "ouhnh" };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            int studentNumber = 3;
            Student[] studentArr = new Student[studentNumber];

            studentArr[0] = new Student();
            studentArr[0].Id = 212025324;
            studentArr[0].FirstName = "Shalom";
            studentArr[0].LastName = "Bergman";

            Student student = new Student("Yossi", "Cohen");
            studentArr[1] = student;

            Student[] tmp = new Student[studentArr.Length + 1];
            for (int i = 0; i < studentArr.Length; i++)
            {
                tmp[i] = studentArr[i];
            }
            studentArr = tmp;


            foreach (var item in studentArr)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}");
            }

            //studentArr[1] = new Student();
            //studentArr[1].Id = 770;
            //studentArr[1].FirstName = "shalom2";

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ButOperatorAritmeti_Click(object sender, EventArgs e)
        {
            //תרגיל להגדיר 3 משתנים int flat string 
            int x = 3;
            double y = 2.5;
            string str = "shalom";
            Console.WriteLine(x + y);
            Console.WriteLine((x + y).GetType());
            Console.WriteLine(x * y);
            Console.WriteLine((x * y).GetType());
            Console.WriteLine(x + str);
            Console.WriteLine((x + str).GetType());
            Console.WriteLine(x + y + str);
            Console.WriteLine((x + y + str).GetType());
            Console.WriteLine(y + str);
            Console.WriteLine((y + str).GetType());
            Console.WriteLine(x + x);
            Console.WriteLine((x + x).GetType());

            char d = 'a';
            int h = d;
            Console.WriteLine(h + "hik");

        }

       /* private void ButDog_Click(object sender, EventArgs e)
        {
            Dog dog1 = new Dog(5.5f, 4, "milk", "Bob");
            Dog dog2 = new Dog();
            dog2.Name = "dog";
            Console.WriteLine(dog1.Height);
            Console.WriteLine(dog1.Weight);
            Console.WriteLine(dog1.Name);
            Console.WriteLine(dog1.Food);
            Console.WriteLine(dog1);

            Console.WriteLine(dog2.Name);
            dog1.Size();
            dog2.Size();
            dog1.Run();
            dog2.Run();
            dog1.Play(); dog2.Play();
            dog1.Eat(); dog2.Eat();
            dog1.ChanchName("shalom");
            dog1.ChanchFood("salat");
            dog2.ChanchName("guyjh");
            dog2.ChanchFood("8ity");
            Console.WriteLine(dog1.Name);
            for (int i = 0; i < dogseArr.Length; i++)
            {

                if (dogseArr[i] == null)
                {
                    dogseArr[i] = dog1;
                    dogseArr[i + 1] = dog2;
                    break;
                }
                Console.WriteLine(dogseArr[i]);

               
            }

        }*/

        /*private void ButDo_Click(object sender, EventArgs e)
        {
            Dog dog1 = new Dog(5.5f, 4, "milk", "Bob");
            Dog dog2 = new Dog();
            dog2._name = "dog";
            for (int i = 0; i < dogseArr.Length; i++)
            {

                if (dogseArr[i] == null)
                {
                    dogseArr[i] = dog1;
                    dogseArr[i + 1] = dog2;
                    break;
                }
                

            }
        }

       /* private void ButPrint_Click(object sender, EventArgs e)
        {
            foreach (Dog d in dogseArr) 
            {
                if (d != null)
                {
                    Console.WriteLine(d.GetValues());
                }
                else
                {
                    break;
                }
            }

        }*/

        private void BtnPersonAge_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.Age = 10;
        }
    }
}
