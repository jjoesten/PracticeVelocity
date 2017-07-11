using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeVelocity.Model
{
    public class RegisterEvent : Event
    {
        public RegisterEvent()
        {
            ProcessItem();
        }

        public override void ProcessItem()
        {
            for (int i = 1; i <= 101; i++)
            {
                string value = string.Empty;

                if (i % 3 == 0)
                    value += "Register ";
                if (i % 5 == 0)
                    value += "Patient";
                if (string.IsNullOrEmpty(value))
                    value = i.ToString();

                Items.Add(value.Trim());
            }
        }
    }
}
