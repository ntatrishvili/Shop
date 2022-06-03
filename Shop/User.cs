using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Address Address { get; set; }
        public bool IsAdmin { get; set; }
        public User(int id, string name, string surname, string email, string password, bool isAdmin = false)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Email = email;
            Password = password;
            Address = new Address();
            IsAdmin = isAdmin;
        }
        public User(string name, string surname, string email, string password, Address address, bool isAdmin = false)
        {
            Id = -1;
            Name = name;
            Surname = surname;
            Email = email;
            Password = password;
            Address = address;
            IsAdmin = isAdmin;
        }

        public User()
        {
            Id = -1;
            IsAdmin = false;
            Address = new Address();
        }
        public override string ToString()
        {
            return $"{Name} {Surname}, Email: {Email}";
        }

    }
}
