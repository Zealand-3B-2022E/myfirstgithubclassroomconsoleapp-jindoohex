using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitHubClassRoomConsoleApp60
{
    public class Demo
    {
        #region Instance Fields
        private string? _name;
        private int _age;
        #endregion

        #region Properties
        public string Name { get; set; }
        public int Age { get; set; }
        #endregion

        #region Constructors
        public Demo()   // Default constructor
        {
        }

        public Demo(string name, int age)
        {
            Name = name;
            Age = age;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Age)}: {Age}";
        }
        #endregion
    }
}
