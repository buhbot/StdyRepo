using buhBot.NeuroStd.Core.Perceptron.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace buhBot.NeuroStd.Core.Perceptron.Impl
{
    public class PreceptronStd : PreceptronAbstract
    {


        public override double Signal
        {
            get
            {
                var rsult = .0;
                foreach (var dendrite in Dendrites)
                {
                    rsult += dendrite.PerceptronFrom.Signal * dendrite.Weight;
                }
                return ActivationFunc(Dendrites.Sum(s => s.PerceptronFrom.Signal * s.Weight) + Delta);
            }
        }
       
    }
}
