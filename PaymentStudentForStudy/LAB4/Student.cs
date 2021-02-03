using System;
using System.Collections.Generic;
using System.Text;

namespace LAB4
{
    partial class Student : Teacher
    {
        

        private int _Group { get; set; }
        private const int MinGroup = 1;
        private const int MaxGroup = 100;

        public Student() : base(){}
        public Student(string name, int age, int disciplinesId, int group) : base(name, age, disciplinesId) {
            Group = group;
        }
        public int Group
        {
            get { return _Group; }
            private set { _Group = Math.Clamp(value, MinGroup, MaxGroup); }

        }

        public override string ToString()
        {
            return $"Cтудент: {Name} \n" +
                   $"Возраст: {Age} \n" +
                   $"Код пары: {DisciplinesId} \n" +
                   $"Номер группы: {Group} \n";
        }
    }

}
