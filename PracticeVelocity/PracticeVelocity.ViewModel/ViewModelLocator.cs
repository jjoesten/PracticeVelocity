using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeVelocity.ViewModel
{
    public class ViewModelLocator
    {
        private static EventViewModel eventViewModel;
        public static EventViewModel EventViewModel
        {
            get
            {
                if (eventViewModel == null)
                    eventViewModel = new EventViewModel();

                return eventViewModel;
            }
        }
    }
}
