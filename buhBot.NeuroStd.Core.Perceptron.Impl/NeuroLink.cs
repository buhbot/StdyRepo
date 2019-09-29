using buhBot.NeuroStd.Core.Perceptron.Base;
using System;
using System.Data;
using System.Threading.Tasks;

namespace buhBot.NeuroStd.Core.Perceptron.Impl
{
    public class NeuroLink : INeuroLink
    {
        
        public double Weight { get; set; }
        
        public IPreceptron PerceptronFrom { get; private set; }

        public IPreceptron PerceptronTo { get; private set; }

        public Task SetLink(IPreceptron perceptronFrom, IPreceptron perceptronTo, double? preWeight)
        {
            if (perceptronFrom == null)
                throw new NoNullAllowedException("perceptronFrom can not be null");
            if (perceptronTo == null)
                throw new NoNullAllowedException("perceptronTo can not be null");

            
            PerceptronTo = perceptronTo;
            PerceptronTo.Dendrites.Add(this);

            PerceptronFrom = perceptronFrom;
            PerceptronFrom.Axons.Add(this);

            Weight = preWeight ?? new Random().NextDouble() * 2.0 - 1;
            return Task.FromResult(0);
        }

        public Task DropLink(Action<object[]> postAction = null)
        {
            PerceptronTo.Dendrites.Remove(this);
            PerceptronFrom.Axons.Remove(this);
            return Task.FromResult(0);
        }

        //public double ForwardRecalaBase { get; set; }
    }
}
