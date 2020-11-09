using System;
namespace AbstractTest
{
    public  abstract class Animal
    {
       
    
        private string Name{get;set;}


        public string SetName()
        {
            return Name;
        }

        public void GetName()
        {
            Console.WriteLine(SetName());
        }
       

       public abstract void Eat();
    }
}