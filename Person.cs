using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    public struct Person
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }

        private string address;
        public string Address { get { return address; } set { address = value; } }

        private int age;
        public int Age { get { return age; } set { age = value; } }

        private string mobile;
        public string Mobile { get { return mobile; } set { mobile = value; } }

        public enum Type { Home, Workplace, Mobile}
        
        private Type typeEnum;
        public Type TypeEnum { get { return typeEnum; } set { typeEnum = value; } }

        /*public Person(string name)
        {
            this.name = name;
        }*/

        public override string ToString()
        {
            return name;
        }
    }
}
