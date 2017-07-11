using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeVelocity.Model
{
    public interface IEvent
    {
        List<string> Items { get; set; }
    }
}
