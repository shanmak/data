using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data
{
   public class Person
    {
        string name;
        string addres;
        string gender;
        string phone;

        public Person(string a, string b, string c, string d)
        {
            name = a;
            addres = b;
            gender = c;
            phone = d;
        }

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public string Address
        {
            set
            {
                addres = value;
            }
            get
            {
                return addres;
            }
        }
        public string Gender
        {
            set
            {
                gender = value;
            }
            get
            {
                return gender;
            }
        }
        public string Phone
        {
            set
            {
                phone = value;
            }
            get
            {
                return phone;
            }
        }
        public string Display()
        {
            string s = string.Format("name={0}\ngender={1}\naddress={2}\nphone={3}", Name, Gender, Address, Phone);
            return s;
        }
    }

    class Gender:Person
    {
        public Gender(string a, string b, string c, string d) : base(a, b, c, d)
        {
        }
        public string DIsplay()
        {
            return base.Display();
        }
    }
}
