using System.ComponentModel;

namespace MP_SchedulingDAL
{
    public class User
    {
        [Browsable(false)]
        public int Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        [Browsable(false)]
        public string PhoneNumber { get; set; }
        public string Position { get; set; }
        [Browsable(false)]
        public DateTime Birthdate { get; set; }
        [Browsable(false)]
        public string PasswordHash { get; set; }
        [Browsable(false)]
        public string PasswordSalt { get; set; }
        public Department Department { get; set; }
        [Browsable(false)]
        public DateTime StartContract { get; set; }
        [Browsable(false)]
        public DateTime EndContract { get; set; }
        [Browsable(false)]
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

        public User(string email, string password)
        {
            UserController controller = new UserController();

            if (!controller.IsPasswordCorrect(email, password))
            {
                throw new ArgumentException("Password and or email are incorrect");
            }

            User user = controller.GetUserByEmail(email);

            Id = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Email = user.Email;
            PhoneNumber = user.PhoneNumber;
            Position = user.Position;
            Birthdate = user.Birthdate;
            PasswordHash = user.PasswordHash;
            PasswordSalt = user.PasswordSalt;
            Department = user.Department;
            StartContract = user.StartContract;
            EndContract = user.EndContract;
            SalaryLevel = user.SalaryLevel;
        }

        public User(int id)
        {
            UserController controller = new UserController();

            User user = controller.GetUserById(id);

            Id = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Email = user.Email;
            PhoneNumber = user.PhoneNumber;
            Position = user.Position;
            Birthdate = user.Birthdate;
            PasswordHash = user.PasswordHash;
            PasswordSalt = user.PasswordSalt;
            Department = user.Department;
            StartContract = user.StartContract;
            EndContract = user.EndContract;
            SalaryLevel = user.SalaryLevel;
        }

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
