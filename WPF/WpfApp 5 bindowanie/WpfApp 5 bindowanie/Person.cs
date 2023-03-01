using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_5_bindowanie
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public Person(int nPersonId, string sFirstName, string sLastName, int nAge, string sGender)
        {
            PersonId = nPersonId;
            FirstName = sFirstName;
            LastName = sLastName;
            Age = nAge;
            Gender = sGender;
        }
        public Person() // Konstruktor domyślny dla DataGrid (w celu dodania nowego rekordu)
        { }
        public override string ToString()
        {
            return $"{PersonId} {FirstName} {LastName} {Age} {Gender}";
        }

    }
}
