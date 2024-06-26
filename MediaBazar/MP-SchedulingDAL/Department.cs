using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP_SchedulingDAL
{
    public class Department
    {
        public int Id { get; }
        public string Name { get; set; }

        public string accessString { get; set; }

        public Department(int id, string name, string accessString)
        {
            Id = id;
            Name = name;
            this.accessString = accessString;
        }

        public Department()
        {
        }

        public Department(int id)
        {
            DepartmentController controller = new DepartmentController();

            Department dep = controller.GetDepartmentById(id);

            this.Id = dep.Id;
            this.Name = dep.Name;
            this.accessString = dep.accessString;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
