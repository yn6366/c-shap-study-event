using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study0509
{
    class InGameUI
    {
        private UIGauge monsterGauge;
        private UIGauge HeroGauge;
        public UIButton btnHeroSkill { get; private set; }

        public InGameUI()
        {
            this.monsterGauge = new UIGauge();
            this.HeroGauge = new UIGauge();
            this.btnHeroSkill = new UIButton();
        }
    }
}
