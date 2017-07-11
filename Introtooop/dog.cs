using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introtooop
{
    class dog //capital Dog
    {
        // Create a dog class
        //your dog should have fields for hair length, height, running speed,
        //and weight
        //your class should have behaviors: run, bark, potty, cuddle
        //fields
        private string hairLength;
        private int height;
        private int runningSpeed;
        private double weight;


        //properties

        public string HairLength
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }
        }
        public int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public int RunningSpeed
        {
            get { return this.runningSpeed; }
            set { this.runningSpeed = value; }
        }

        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }



        //constructors
        public dog()//should be Dog
        {
            //default constructor
        }
        public dog(string hairLength, int height, int runningSpeed, double weight)//sholud be Dog
        {
            this.hairLength = hairLength;
            this.height = height;
            this.runningSpeed = runningSpeed;
            this.weight = weight;
        }









        public int Run()
        {
            Console.WriteLine("Go doggy go!!");
            RunningSpeed -= 1;
            return RunningSpeed;
        }
        public void Bark()
        {
            Console.WriteLine("Bork bork");
        }
        public void Cuddle()
        {
            Console.WriteLine("Awww, doggo is so sweet");
        }




    }
}
