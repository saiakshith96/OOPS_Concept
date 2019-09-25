using System;
using System.Collections.Generic;
using System.Text;

namespace class_fall_24sep
{
    class Relative : Person
    {
        public string relation;

        public Relative(string salutation, string fName, string lName,String relation)
        {
            this.relation = relation;
            this.salutation = salutation;   
            firstName = fName;
            lastName = lName;
        }

        public string getRelation()
        {
            return (this.firstName+" has a relative with a relation of "+ this.relation);
        }

    }
}
