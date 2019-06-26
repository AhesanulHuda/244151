using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInformationAppWalkthrough2
{
   public class Person
    {
       public string firstName;
       public string middleName;
       public string lastName;

        string fullName;
        string reverseName;

        public string GetFullName()
        {
            fullName = firstName+" " + middleName+" " + lastName;
            return fullName;
        }
        public string ReverseName()
        {
            reverseName = "";
            for(int count =fullName.Length-1; count>=0; count--)
            {
                reverseName += fullName[count];
            }
            return reverseName;
        }

    }
}
