using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MP_EntityLibrary
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Position { get; set; }
        public DateTime Birthdate { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public Department Department { get; set; }
        public DateTime StartContract { get; set; }
        public DateTime EndContract { get; set; }
        public int SalaryLevel { get; set; }

        public int HoursWorked { get; set; }

        public User(int id, string firstName, string lastName, string email, string phoneNumber, string position, DateTime birthdate, string passwordHash, string passwordSalt, Department department, DateTime strartContract, DateTime endContract, int salaryLevel)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Position = position;
            Birthdate = birthdate;
            PasswordHash = passwordHash;
            PasswordSalt = passwordSalt;
            Department = department;
            StartContract = strartContract;
            EndContract = endContract;
            SalaryLevel = salaryLevel;
        }
        public User()
        {

        }

        //public User()
        //{
        //}

        //public User(string email, string password)
        //{
        //    UserDALManager controller = new UserDALManager();

        //    if (!controller.IsPasswordCorrect(email, password))
        //    {
        //        throw new ArgumentException("Password and or email are incorrect");
        //    }

        //    User user = controller.GetUserByEmail(email);

        //    Id = user.Id;
        //    FirstName = user.FirstName;
        //    LastName = user.LastName;
        //    Email = user.Email;
        //    PhoneNumber = user.PhoneNumber;
        //    Position = user.Position;
        //    Birthdate = user.Birthdate;
        //    PasswordHash = user.PasswordHash;
        //    PasswordSalt = user.PasswordSalt;
        //    Department = user.Department;
        //    StartContract = user.StartContract;
        //    EndContract = user.EndContract;
        //    SalaryLevel = user.SalaryLevel;
        //}

        //public User(int id)
        //{
        //    UserDALManager controller = new UserDALManager();

        //    User user = controller.GetUserById(id);

        //    Id = user.Id;
        //    FirstName = user.FirstName;
        //    LastName = user.LastName;
        //    Email = user.Email;
        //    PhoneNumber = user.PhoneNumber;
        //    Position = user.Position;
        //    Birthdate = user.Birthdate;
        //    PasswordHash = user.PasswordHash;
        //    PasswordSalt = user.PasswordSalt;
        //    Department = user.Department;
        //    StartContract = user.StartContract;
        //    EndContract = user.EndContract;
        //    SalaryLevel = user.SalaryLevel;
        //}

        protected bool Equals(User other)
        {
            return FirstName == other.FirstName && LastName == other.LastName
                                                && Email == other.Email && PhoneNumber == other.PhoneNumber
                                                && Position == other.Position && Birthdate.Equals(other.Birthdate);
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((User)obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FirstName, LastName, Email, PhoneNumber,
                Position, Birthdate);
        }

        public string GetObjectString()
        {
            return Id.ToString() + FirstName + LastName + Email + PhoneNumber + Position + Birthdate.ToString() + Department.Name;
        }
    }
}
