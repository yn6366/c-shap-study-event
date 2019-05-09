using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study0509
{
    class GameLauncher
    {
        public InGameUI inGameUI;
        private Hero hero;
        private Monster monster;


        public GameLauncher()
        {
            this.inGameUI = new InGameUI();

            //이벤트 등록

            EventDispatcher.GetInstance().AddEventHandler("Monster_Die" , (sender ,e) => {
                var eventArgs = (GameEvent.MonsterEventArgs)e;
                Console.WriteLine("{0}",eventArgs);

            });

            //버튼 이벤트
            this.inGameUI.btnHeroSkill.onClickEventHandler
                += BtnHeroSkill_onClickEventHandler;

            this.inGameUI.btnHeroSkill.Click();
        }

        private void BtnHeroSkill_onClickEventHandler(object sender, EventArgs e)
        {
            Console.WriteLine("{0}{1}", sender ,e);
            this.hero.ActiveSkill();
            this.monster.TakeDamage(5);
        }

        public void Init()
        {
            this.hero = new Hero();
            this.monster = new Monster();

            hero.Init("홍길동");
            monster.Init("오우거");

            Console.WriteLine("게임 준비");
        }

        public void Strat()
        {
            Console.WriteLine("게임 시작");
        }
    }
}
