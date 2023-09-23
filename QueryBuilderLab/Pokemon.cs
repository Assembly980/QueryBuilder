using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryBuilderLab
{
    internal class Pokemon : IClassModel
    {
        public int Id { get; set; }
        public int DexNumber { get; set; }
        public string Name { get; set; }
        public string Form { get; set; }
        public string Type1 { get; set; }
        public string? Type2 { get; set; }
        public int Total { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int SpecialAttack { get; set; }
        public int SpecialDefense { get; set; }
        public int Speed { get; set; }
        public int Generation { get; set; }

        public Pokemon() { }

        public Pokemon(int id, int dexNum, string name, string form, string type1, string? type2, int stat1, int stat2, int stat3, int stat4, int stat5, int stat6, int stat7, int gen)
        {
            Id = id;
            DexNumber = dexNum;
            Name = name;
            Form = form;
            Type1 = type1;
            Type2 = type2;
            Total = stat1;
            HP = stat2;
            Attack = stat3;
            Defense = stat4;
            SpecialAttack = stat5;
            SpecialDefense = stat6;
            Speed = stat7;
            Generation = gen;
        }

        public override string ToString()
        {
            string msg = $"Id: {Id}\n";
            msg += $"Name: {Name}\n";
            if (Form != "" || Form != " " || Form != null)
            {
                msg += $"Gender: {Form}\n";
            }
            msg += $"First Type: {Type1}";
            if(Type2 != "" || Type2 != " " || Type2 != null)
            {
                msg += $"Type2: {Type2}\n";
            }
            msg += $"Total Stats: {Total}\n";
            msg += $"HP: {HP}\n";
            msg += $"Attack: {Attack}\n";
            msg += $"Defense: {Defense}\n";
            msg += $"Special Attack: {SpecialAttack}\n";
            msg += $"Special Defense: {SpecialDefense}\n";
            msg += $"Speed: {Speed}\n";
            msg += $"Generation: {Generation} \n";
            return msg;
        }
    }
}
