using buhBot.NeuroStd.Core.Perceptron.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace buhBot.NeuroStd.Core.Perceptron.Impl
{
    public class PreceptronSensor : PreceptronAbstract
    {
        public Double InputSignal { get; set; }
        public override double Signal
        {
            get
            {
                return InputSignal;
            }
        }

    }
}
