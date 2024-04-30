using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace Day2
{
    // class that displays name, roll number, section of a student
    internal class OOP1
    {
        // fields
        private string name;            
        private int roll_number;
        private string section;

        // properties
        public string Name
        {
            // Getter method retrieves the name
            get
            {
                // Returns the assigned value to name field
                return name;
            }
            // Setter method assigns a value to the name
            set
            {
                // Assigns the new value to the name field
                name = value; 
            }
        }
        
       public int Roll_number
        {
            // retrieves the roll_number
            get
            { 
                return roll_number;
            }
            // assigns a value to roll_number
            set
            {
                roll_number = value;
            }
        }

        public string Section
        {
            // retrieves the section
            get
            {
                return section;
            }
            // assigns a value to section
            set
            {
                section = value;
            }
        }

        

        //Method to display object details
        public void showDetails()
        {
            Console.WriteLine("Name is {0}\nRoll Number is {1}\nSection is {2}" , name, roll_number, section);
        }

        static void Main(string[] args)
        {
            // Creates an instance of the OOP2 class
            OOP1 oOP2 =new OOP1();

            // Setting values for object properties
            oOP2.Name = "Jack";
            oOP2.Roll_number = 1;
            oOP2.Section = "I-A";

            // Calling the showDetails method to display object details
            oOP2.showDetails();

           
            
        }
    }
}
