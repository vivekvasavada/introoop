using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introtooop
{
    class Cat
    {
        //inside of our class, we create the blueprint of our object.
        //classes are templates in oop that we use to create objects.
        // akways be in Pascal case.
        //in OOP, there are two types of states:
        //Fields-variables of class
        private string name;
        private int age;
        private string furColor;
        private bool isHungry = true;

        //Properties-a sort of mix btwn field and a method
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Age
        {
            get { return this.age; }
        }



        //we also have Behaviors
        //Methods- repeatable/reuseable sections of code
        //Constructors-specialized methods that are used to instantized an object
        //-allow us to control the state of an object upon creation.
        //-allow us perform any actions the object might need upon creation.
        //-always share the name of the class 
        public Cat()
        {
            //This is an an example of a default constructor. A default constuctor takes
            //no arguments/parameters
        }
        public Cat(string name, int age, string furColor)
        {
            this.name = name;
            this.age = age;
            this.furColor = furColor;
        }
        public void Eat()
        {
            if (isHungry)
            {
                isHungry = false;
            }
            Console.WriteLine("Is the cat hungry? " + isHungry);

        }
    }
}
