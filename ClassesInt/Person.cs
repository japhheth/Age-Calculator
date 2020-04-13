using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesInt
{
   public class Person
    {
        public DateTime BirthDate { get; private  set; }

        public Person(DateTime _birthdate)
        {
            BirthDate = _birthdate;
        }

        //Calculate age Method
        public int CalculateAge()
        {
            var timeSpan = DateTime.Today - BirthDate;

            var years = timeSpan.Days / 365;

            return years;
        }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - BirthDate;

                var years = timeSpan.Days / 365;

                return years;
            }
        }
            
    }

    public class Human
    {
        private string _name;


        public void SetName(string name)
        {
            if (!String.IsNullOrEmpty(name))
            {
                this._name = name;
            }
        }

        public string GetName()
        {
            return _name;
        }
    }
}
