using System;

namespace Dog
{
    public enum Gender 
    {
        Male,
        Female
    }
    class program
    {
        static void Main()
        {
            Dog puppy = new Dog("Orion", "Shawn", 1, Gender.Male);  // create object instance
            puppy.Bark(3); // output: Woof!Woof!Woof!
            Console.WriteLine(puppy.GetTag()); // output: If lost, call Shawn. His name is Orion and he is 1 year old.

            Dog myDog = new Dog("Lileu", "Dale", 4, Gender.Female);  // create object instance
            myDog.Bark(1); // output: Woof!
            Console.WriteLine(myDog.GetTag()); // output: If lost, call Dale. Her name is Lileu and she is 4 years old.
        }
    }

    class Dog 
        {
        public string name;
        public string owner;
        public int age;
        public Gender gender;


        public Dog(string name, string owner, int age, Gender gender) 
        {
            this.name = name;
            this.owner = owner;
            this.age = age;
            this.gender = gender;
        }

        public void Bark(int barks) 
        {
            for (int i = 0; i < barks; i++) 
            {
                Console.WriteLine("Woof!");
            }
        }
        public string GetTag()
        {
            string pronoun1;
            string pronoun2;
            if(this.gender == Gender.male)
            {
                pronoun1 = "his";
                pronoun2 = "he";
            }
            else
            {
                pronoun1 = "hers";
                pronoun2 = "she";
            }
            string year;
            if(this.age == 1)
            {
                year = "year";
            }
            else
            {
                year = "years";
            }
            return "If lost, call "+ owner+ "."+ pronoun1+ " name is " + name+ " and "+ pronoun2+ " is "+ age+ " "+ year+ " old.";
        } 
    }
}
