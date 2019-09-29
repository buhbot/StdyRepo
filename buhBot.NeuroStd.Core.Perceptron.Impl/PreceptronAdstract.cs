using buhBot.NeuroStd.Core.Perceptron.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace buhBot.NeuroStd.Core.Perceptron.Impl
{
    public abstract class PreceptronAbstract : IPreceptron
    {
        private IList<INeuroLink> dendrites = new List<INeuroLink>();
        public IList<INeuroLink> Dendrites => dendrites;

        public IList<INeuroLink> axons = new List<INeuroLink>();
        public IList<INeuroLink> Axons => axons;

        public virtual Func<double, double> ActivationFunc => a => Math.Tanh(a); //in base use Sigmoid

        public abstract double Signal { get; }        

        public double Delta { get; set; } = 1.0;
    }
}
