using System;
using System.Collections.Generic;
using System.Text;

namespace class_fall_24sep
{
    class Person
    {
        public static string salutationMr = "Mr";
        public static string salutationMs = "Ms";
        public static string defaultlastName = "NLN";

        public string firstName;
        public string lastName;
        public string salutation;


        public Person()
        {
            firstName = "";
            lastName = defaultlastName;
            salutation = salutationMs;
        }


        public Person(string salutation, string fName, string lName)
        {
            this.salutation = salutation;    // needs refinement
            firstName = fName;
            lastName = lName;
        }

        public string getPrintName()
        {
            return ("Name is "+salutation +" " +firstName+" " + lastName);
        }



    }
}
