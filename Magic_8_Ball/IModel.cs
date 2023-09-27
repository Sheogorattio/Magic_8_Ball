using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_8_Ball
{
    internal interface IModel
    {
        public string Answer { get; }
        void GenerateAnswer();
    }
}
