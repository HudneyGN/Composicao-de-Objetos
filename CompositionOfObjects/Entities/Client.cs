using System;

namespace CompositionOfObjects.Entities {
    class Client {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client() {
        }
        public Client(string name, string emil, DateTime birthDate) {
            Name = name;
            Email = emil;
            BirthDate = birthDate;
        }
        public override string ToString() {
            return ", "
                + Name
                + ", "
                + BirthDate.ToString("dd/MM/yyyy")
                + ", "
                + Email;
        }
    }
}
