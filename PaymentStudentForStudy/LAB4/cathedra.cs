using System;
using System.Collections.Generic;
using System.Text;

namespace LAB4
{
    class cathedra:discipline
    {
        public cathedra() : base(){ }
        public cathedra(int id, string name, int floor, int audience):base() {
            Floor = floor;
            Audience = audience;
        }
        private int _Floor { get; set; }
        private int _Audience { get; set; }
        private const int MinFloorAndAudience = 1;
        private const int MaxFloor= 7;
        private const int MaxAudience = 500;

        public int Floor
        {
            get { return _Floor; }
            set { _Floor = Math.Clamp(value, MinFloorAndAudience, MaxFloor); } 

        } 
        public int Audience
        {
            get { return _Audience; }
            set { _Audience = Math.Clamp(value, MinFloorAndAudience, MaxAudience); }
        }
        public override string ToString()
        {
            return $"Id: {Id} \n" +
                   $"Кафедра: {Name} \n" +
                   $"Поверх: {Floor} \n" +
                   $"Аудиторія: {Audience} \n";
        }
    }
}
