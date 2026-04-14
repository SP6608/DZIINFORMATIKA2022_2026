using System;
using System.Collections.Generic;
using System.Text;

namespace DZIINFORMATIKA2024
{
    public abstract class Person
    {
		private string firstName;
		private string lastName;
		private string id;

        public  Person(string firstName, string lastName, string id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Id = id;
        }

        public string Id
		{
			get => id;
			protected set 
			{
				if (value.Length!=10)
				{
					throw new ArgumentException($"{FirstName} {LastName} - invalid identifier!");
				}
				id = value; 
			}
		}
		public string LastName
        {
			get => lastName;
			protected set { lastName = value; }
		}
		public string FirstName
        {
			get => firstName;
			protected set { firstName = value; }
		}

	}
}
