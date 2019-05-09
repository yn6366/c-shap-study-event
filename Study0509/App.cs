using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study0509
{


    class App
    {
        public void Start()
        {
            var gl = new GameLauncher();

            gl.Init();
            gl.Strat();
        }

    }
}
