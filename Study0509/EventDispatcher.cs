using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study0509
{
    class EventDispatcher
    {
        private static EventDispatcher Istance;

        private EventHandler<EventArgs> eventHandler;

        private Dictionary<string, EventHandler<EventArgs>>
            dicEventHandler = new Dictionary<string, EventHandler<EventArgs>>();

        private EventDispatcher()
        {

        }

        public static EventDispatcher GetInstance()
        {
            if(EventDispatcher.Istance == null)
            {
                EventDispatcher.Istance = new EventDispatcher();
            }
            return EventDispatcher.Istance;
        }

        public void AddEventHandler(string eventName , EventHandler<EventArgs> handler )
        {
            if(!this.dicEventHandler.ContainsKey(eventName))
            {
                this.dicEventHandler.Add(eventName, handler);
                Console.WriteLine("이벤트 ({0}) 가 등록 되었습니다.", eventName, handler);
            }
        }

        public void DispatchEvent(string eventName , EventArgs e)
        {
            var handler = this.dicEventHandler[eventName];
            handler?.DynamicInvoke(EventDispatcher.GetInstance() ,e);
        }

    }

}
