using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Cars
    {
        private string color;
        private int year;
        public int speed;
       
        //Constructor Overloading

        public Cars()
        {

        }

        public Cars(int speed,string color, int year)
        {
            this.speed = speed;
            this.color = color;
            this.year = year;
        }

        public string Make { get; set; }
        public string Manifacturer { get; set; }

        public string Color
        {
            get => color;
            set => color = value;
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        //Method Overloading ==> Polymorphism
        public int Accerelate(int initSpeed)
        {
            return speed = initSpeed + 5;
        }

        public void Accerelate()
        {
            
        }

       

        private void Salary(double monthlySalary)
        {

        }

        private void Salary(int hours, double hourlyRate)
        {

        }

        private void Salary(int hours, double hourlyRate, double bonus)
        {

        }

        public int Decerelate(int initSpeed)
        {
            return speed = initSpeed-5;
        }
    }
}
