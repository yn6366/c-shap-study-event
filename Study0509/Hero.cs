using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study0509
{
    class Hero
    {
        public string Name { get; private set; }

        public void Init(string name)
        {
            this.Name = name;
        }

        internal void ActiveSkill()
        {
            Console.WriteLine("스킬사용");
        }
    }
}
