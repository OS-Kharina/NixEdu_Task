using System;

namespace UniversityLibrary
{
    public abstract class Person
    {
        protected ulong id;
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public DateTime DateBirthday { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
    }
}
