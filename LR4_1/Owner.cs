using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4_1
{
    public class Owner
    {
        private int id;
        private string name;
        private string name_organization;

        public Owner()
        {
            this.id = 2142;
            this.name = "Sergey";
            this.name_organization = "BSTU";
        }

        public void Print()
        {
            Console.WriteLine("id:" + id);
            Console.WriteLine("name: " + name);
            Console.WriteLine("name organization: " + name_organization);
        }
    }
}
