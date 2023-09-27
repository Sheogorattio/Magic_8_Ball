using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_8_Ball
{
    internal interface IView
    {
        string Answer { get; set; }
        event EventHandler<EventArgs> GotQuestion;
    }
}
