using System;
using System.Collections.Generic;
using System.Text;

namespace LAB4
{
    partial class Teacher
    {
        
        private const int _minAge = 18;
        private const int _maxAge = 80;
        private int _age;

        public int Age {
            get { return _age; }
            private set { _age = Math.Clamp(value, _minAge, _maxAge); }
        }
        public string Name  { get; set; } 
        public int DisciplinesId { get; set; }

        public Teacher()
        {
            Age = 0;
            Name = "-";
            DisciplinesId = 10;
        }
        public Teacher(string name, int age, int disciplinesId)
        {
            Name = name;
            Age = age;
            DisciplinesId = disciplinesId;
        }
    }
}
