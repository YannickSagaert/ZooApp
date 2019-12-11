using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.lib
{
    public enum Sex { F, M };
    /// <summary>
    /// This class describes léoné veri dangeros enimel
    /// </summary>
    public class Lion
    {
        public Sex Sex { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        public Lion(string name): this(name,Sex.F)
        {

        }

        public Lion(string name, Sex sex): this(name,sex,0)
        {
           
        }

        public Lion(string name, Sex sex, int age)
        {
            Name = name;
            Sex = sex;
            Age = age;
        }
    }
}
