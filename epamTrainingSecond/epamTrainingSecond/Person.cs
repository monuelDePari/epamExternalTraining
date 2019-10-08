﻿
namespace epamTrainingSecond
{
    struct Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string CheckIfElder(int n)
        {
            if (n > 0)
                return (Age > n) ? $"{Name} {Surname} older than {n}" : $"{Name} {Surname} younger than {n}";
            else return "0";
        }
    }
}