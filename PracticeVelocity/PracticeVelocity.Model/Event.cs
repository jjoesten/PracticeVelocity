using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeVelocity.Model
{
    public class Event : IEvent
    {
        private Guid id = Guid.NewGuid();
        public Guid Id { get { return id; } }

        List<string> items = new List<string>();
        public List<string> Items
        {
            get
            {
                return items;
            }

            set
            {
                items = value;
            }
        }

        public virtual void ProcessItem()
        {
            
        }
    }


}
