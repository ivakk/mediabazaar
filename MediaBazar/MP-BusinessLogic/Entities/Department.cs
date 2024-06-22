using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_EntityLibrary
{
    public class Department
    {
        public int Id { get; }
        public string Name { get; set; }

        public string AccessString { get; set; }
        public string Description { get; set; }  // New property
        public int RequiredPersonnel { get; set; }  // New property
        public string Positions { get; set; }  // New property
        public string PointOfContact { get; set; }  // New property

        public Department(int id, string name, string accessString)
        {
            Id = id;
            Name = name;
            this.AccessString = accessString;
        }

        public Department(int id, string name, string accessString, string description = "", int requiredPersonnel = 0, string positions = "", string pointOfContact = "")
        {
            Id = id;
            Name = name;
            accessString = accessString;
            Description = description;
            RequiredPersonnel = requiredPersonnel;
            Positions = positions;
            PointOfContact = pointOfContact;
        }
        //public Department()
        //{
        //}

        //public Department(int id)
        //{
        //    DepartmentDALManager controller = new DepartmentDALManager();

        //    Department dep = controller.GetDepartmentById(id);

        //    this.Id = dep.Id;
        //    this.Name = dep.Name;
        //    this.AccessString = dep.AccessString;
        //}

        public override string ToString()
        {
            return Name;
        }
    }
}
