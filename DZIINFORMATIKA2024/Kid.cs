using System;
using System.Collections.Generic;
using System.Text;

namespace DZIINFORMATIKA2024
{
    public class Kid : Person
    {
        private int age;
        private string parentLastName;
        private string parentGSM;
        public string Group 
        {
            get 
            {
                if (age == 3)
                {
                    return "I";
                }
                else if (age == 4)
                {
                    return "II";
                }else if (age == 5)
                {
                    return "III";
                }
                return "IV";
            }
        }
        public string ParentGSM
        {
            get => parentGSM;
            protected set { parentGSM = value; }
        }

        public string ParentLastName
        {
            get => parentLastName;
           protected set { parentLastName = value; }
        }

        public int Age
        {
            get => age;
           protected set 
            {
                if (value<3||value>6)
                {
                    throw new ArgumentException($"The child {FirstName} {LastName} age is invalid - {value}");
                }
                age = value;
            }
        }

        public Kid(string firstName, string lastName, string id, int age, string parentLastName, string parentGSM) 
            : base(firstName, lastName, id)
        {
            this.Age = age;
            this.ParentLastName = parentLastName;
            this.ParentGSM = parentGSM;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}, {Age}, {parentGSM} ({ParentLastName})";
        }
    }
}
