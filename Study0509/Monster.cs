﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study0509
{
    class Monster
    {
        public string Name { get; private set; }
        public MonsterInfo Info { get; private set; }

        public void Init(string name)
        {
            this.Info = new MonsterInfo()
            {
                id = 1,
                hp = 100
            };

            this.Name = name; 
        }

        public void TakeDamage(int damage)
        {
            var eventArgs = new GameEvent.MonsterEventArgs()
            {
                info = this.Info
            };
            EventDispatcher.GetInstance().DispatchEvent("Monster_Die" , EventArgs.Empty);
        }
    }
}
