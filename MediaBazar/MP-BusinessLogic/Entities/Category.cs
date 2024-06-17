using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_EntityLibrary
{
    public class Category
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Category(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public Category() { }

        public override string ToString()
        {
            return Name;
        }
    }
}
