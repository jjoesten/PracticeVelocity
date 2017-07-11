using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeVelocity.Model
{
    public class DiagnoseEvent : Event
    {
        public DiagnoseEvent()
        {
            ProcessItem();
        }

        public override void ProcessItem()
        {
            for (int i = 1; i < 101; i++)
            {
                string value = string.Empty;

                if (i % 2 == 0)
                    value += "Diagnose ";
                if (i % 7 == 0)
                    value += "Patient";
                if (string.IsNullOrEmpty(value))
                    value = i.ToString();

                Items.Add(value.Trim());
            }
        }
    }
}
