#region Imports...

//C# imports
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#endregion

namespace PersonListe.BL
{
    public class Person : IComparable
    {
        #region Fields

        public int RecID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public int Age { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default empty constructor
        /// </summary>
        public Person() { }

        /// <summary>
        /// Constructor to initialize a complete object
        /// </summary>
        /// <param name="firstName">The first name of the person</param>
        /// <param name="lastName"></param>
        /// <param name="position"></param>
        /// <param name="age"></param>
        public Person(string firstName, string lastName, string position, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Position = position;
            this.Age = age;
        }

        #endregion

        #region Class Methods

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return FirstName + " " + LastName + " (" + Age + ")";
        }

        /// <summary>
        /// Provides default comparison
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>

        public int CompareTo(object obj)
        {
            if (obj is Person)
            {
                Person tmpPerson = obj as Person;

                return this.LastName.CompareTo(tmpPerson.LastName);
            }
            else
                throw new NotImplementedException("obj is not a Person");
        }

        #endregion

        #region Comparisons

        public static Comparison<Person> AgeComparison = delegate(Person object1, Person object2)
        {
            return object1.Age.CompareTo(object2.Age);
        };

        public static Comparison<Person> LastNameComparison = delegate(Person object1, Person object2)
        {
            return object1.LastName.CompareTo(object2.LastName);
        };

        public static Comparison<Person> FirstNameComparison = delegate(Person object1, Person object2)
        {
            return object1.FirstName.CompareTo(object2.FirstName);
        };


        public static Comparison<Person> PositionComparison = delegate(Person object1, Person object2)
        {
            return object1.Position.CompareTo(object2.Position);
        };


        #endregion
    }
}
