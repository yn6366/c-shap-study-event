using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study0509
{
    class UIButton
    {
        public event EventHandler onClickEventHandler;

        public void AddListener(EventHandler call)
        {
            onClickEventHandler = call;
        }
        

        public UIButton()
        {
        }

        public void Click()
        {
            //이벤트 발생

        }

        private void OnClickEvent(EventArgs e)
        {
            EventHandler handler = onClickEventHandler;
            handler?.Invoke(this, e);
        }
    }
}
