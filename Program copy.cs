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
            List<Person> idPersonList = new List<Person>();

            Person person1 = new Person("First","Last","13 May 2021",100,idPersonList);
            idPersonList.Add(person1);

            Person person2 = new Person("Second", "Last", "13 May 2001",120,idPersonList);
            idPersonList.Add(person2);

            Person person3 = new Person("Third", "Final", "13 June 2021", 80, idPersonList);
            idPersonList.Add(person3);

            foreach (var item in idPersonList)
            {
                foreach (var item2 in idPersonList)
                {
                    Console.WriteLine("Difference in height between {0} and {1} is {2}cm", 
                        item.GetFullName(), item2.GetFullName(), item.GetHeightDifference(item2));
                }
            }

            foreach (var person in idPersonList)
            {
                Console.WriteLine(person.Id);
            }

            // To the Person class, add an attribute called Id.  Use the Random class from the C# library to assign each person an Id between 1000 and 9999.
            // Create a Subject class
            // Name,
            // YearOfDelivery
            Subject s1 = new Subject("object oriented",2020);
            Subject s2 = new Subject("object oriented",2021);

            person1.NewSubject(s1);
            person1.Grade(s1,40);
            person1.ListSubjects();
            person1.NewSubject(s2);
            person1.ListSubjects();
            
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
    public class Person
    {
        // A person has the attributes:
        // Firstname
        string Firstname;
        // Surname
        string Surname;
        // Dob
        string Dob;
        // Height (cm)
        int Heightcm;
        // A person has the methods:
        public int Id;
        public Dictionary<Subject,int> grades;
        public Person(string pFirstname, string pSurname, string pDob, int pHeightcm, List<Person> list){
            Firstname=pFirstname;
            Surname=pSurname;
            Dob=pDob;
            Heightcm=pHeightcm;
            var random = new Random();
            int num = random.Next(1000,10000);
            List<int> idChecklist = new List<int>();
            foreach (var item in list)
            {
                idChecklist.Add(item.Id);
            }
            if(idChecklist.Count>0 && idChecklist.Count<9000){
                while(idChecklist.Contains(num)){
                    num = random.Next(1000,10000);
                }
            }
            this.Id=num;
            grades=new Dictionary<Subject, int>();
        }
        // GetFullName() -> returns their whole name
        public string GetFullName(){
            return this.Firstname+" "+this.Surname;
        }
        // GetHeightDifference(Person other) -> another person (other), return the difference in height.
        public int GetHeightDifference(Person compare){
            return Math.Abs(this.Heightcm-compare.Heightcm);
        }
        public void NewSubject(Subject pSubject){
            grades.Add(pSubject,0);
        }
        public void ListSubjects(){
            Console.WriteLine(this.GetFullName()+" Grades: ");
            foreach (var item in grades)
            {
                if(item.Value == 0){
                Console.WriteLine(item.Key+", grade: ungraded");
                } else{
                Console.WriteLine(item.Key+", grade: "+item.Value);
                }
            }
        }
        public Dictionary<Subject,int> Grade(Subject pSubject, int pGrade){
            List<Subject> subjectlist=new List<Subject>();
            foreach(var item in grades){
                subjectlist.Add(item.Key);
            }
            if(subjectlist.Contains(pSubject)){
                grades[pSubject]=pGrade;
            } else{
            grades.Add(pSubject,pGrade);
            }
            return grades;
        }
    }
    // Create a Subject class
            // Name,
            // YearOfDelivery
    public class Subject{
        string Name;
        int YearOfDelivery;
        public Subject(string pName, int pYearOfDelivery){
            Name=pName;
            YearOfDelivery=pYearOfDelivery;
        }
    }
}
