/*
using System;
using System.Collections.Generic;

namespace ClassesTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1.) Cookie 
            // What would be the code to instantiate a Cookie?
            Cookie cookieA = new Cookie();
            // Create class called Colour that represents a colour as a mix red, green and blue (rgb) values.  A colour should also have a name
            // Include your Colour class inside the Cookie class.
            // Instatiate four different Cookies, with two different Colours.

            // colours
            Colour colour1 = new Colour("magenta", 176, 11, 105);
            Colour colour2 = new Colour("indigo", 4, 32, 105);
            
            // cookies
            Cookie cookie1 = new Cookie(10,"round",colour1);
            Cookie cookie2 = new Cookie(8,"round",colour2);
            Cookie cookie3 = new Cookie(22,"square",colour1);
            Cookie cookie4 = new Cookie(15,"round",colour2);

            // gather cookies
            Cookie[] cookieList = {cookie1, cookie2, cookie3, cookie4};

            // eat them
            for(int i=0;i<cookieList.Length;i++){
                while(cookieList[i].Weight>1){
                    cookieList[i].MyInfo();    
                    cookieList[i].Eat();
                }
                cookieList[i].MyInfo();
                
            }

            // Instantiate 3 people and get them to give their full names and differences in height from the others.

            // create a list for comparing ids. ids for people in a list will be unique within that list up to the first 9000 entries in the list.
            PersonList idPersonList= new PersonList();

            Person person1 = new Person(idPersonList);
            person1.Firstname="First";
            person1.Surname="Last";
            person1.Dob="13 May 2021";
            person1.Heightcm=100;

            Person person2 = new Person(idPersonList);
            person2.Firstname="Second";
            person2.Surname="Last";
            person2.Dob="13 May 2001";
            person2.Heightcm=120;

            Person person3 = new Person(idPersonList);
            person3.Firstname="Third";
            person3.Surname="Final";
            person3.Dob="13 June 2021";
            person3.Heightcm=80;

            Person[] personArray = {person1, person2, person3};

            for(int i=0;i<3;i++){
                for(int j=0;j<3;j++){
                    Console.WriteLine("Difference in height between {0} and {1} is {2}cm", 
                        personArray[i].GetFullName(), personArray[j].GetFullName(), personArray[i].GetHeightDifference(personArray[j]));
                }
            }

            foreach (var item in idPersonList.people)
            {
                foreach (var item2 in idPersonList.people)
                {
                    Console.WriteLine("Difference in height between {0} and {1} is {2}cm", 
                        item.GetFullName(), item2.GetFullName(), item.GetHeightDifference(item2));
                }
            }

            foreach (var id in idPersonList.idListUpdated)
            {
                Console.WriteLine(id);
                
            }

            // To the Person class, add an attribute called Id.  Use the Random class from the C# library to assign each person an Id between 1000 and 9999.
            // Create a Subject class
            // Name,
            // YearOfDelivery
            // To the Person class, add a property that is a list of subjects.  Add methods to Person to allow addition of new subjects and to return or print a list of subjects associated with a person.
            // (optional) Modify the Person and/or the Subject class so that a person doing a subject can be allocated a numerical grade.

            Console.WriteLine("That's all folks!");
        }
    }
    // Cookie
    // Weight: int
    // Shape: string
    // Create basic class for a Cookie as above.
    public class Cookie {
        public int Weight;
        string Shape;
        Colour cookieColour;
        public Cookie(){}
        public Cookie(int inWeight, string inShape, Colour inColour){
            Weight=inWeight;
            Shape=inShape;
            cookieColour=inColour;
        }
        public void MyInfo()
        {
            Console.WriteLine("Weight {0}, Shape {1}, Colour {2}", 
            this.Weight, this.Shape, this.cookieColour.Name);
        }
        public void Eat()
        {
            Console.WriteLine("Eating the cookie");
            this.Weight=this.Weight/2;
        }
    }
    public class Colour{
        public string Name;
        int Red;
        int Green;
        int Blue;
        public Colour(string inName, int inRed, int inGreen, int inBlue){
            Name = inName;
            Red = inRed;
            Green = inGreen;
            Blue = inBlue;
        }
    }
    // Task 2. Create a class to represent a Person. 
    public class PersonList{
        public List<Person> people = new List<Person>();
        public List<int> idListUpdated = new List<int>();
        public void AddPerson(Person addedPerson){
            this.people.Add(addedPerson);
            this.idListUpdated.Add(addedPerson.id);
            }
        }
    public class Person
    {
        // A person has the attributes:
        // Firstname
        string firstname;
        public string Firstname{
            get {return firstname; }
            set {firstname=value; }
        }
        // Surname
        public string Surname { get; set; }
        // Dob
        public string Dob { get; set; }
        // Height (cm)
        public int Heightcm { get; set; }
        // A person has the methods:
        // GetFullName() -> returns their whole name
        public int id;
        public Person(PersonList list){
            var random = new Random();
            int num = random.Next(1000,10000);
            List<int> idChecklist = list.idListUpdated;
            if(idChecklist.Count>0 && idChecklist.Count<9000){
                while(idChecklist.Contains(num)){
                    num = random.Next(1000,10000);
                }
            }
            this.id=num;
            list.AddPerson(this);
        }
        public string GetFullName(){
            return this.firstname+" "+this.Surname;
        }
        // GetHeightDifference(Person other) -> another person (other), return the difference in height.
        public int GetHeightDifference(Person compare){
            return Math.Abs(this.Heightcm-compare.Heightcm);
        }
    }
}
*/