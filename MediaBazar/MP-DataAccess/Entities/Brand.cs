﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_EntityLibrary
{
    public class Brand
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Brand(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Brand()
        {
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
