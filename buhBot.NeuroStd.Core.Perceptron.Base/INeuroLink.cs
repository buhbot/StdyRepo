using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace buhBot.NeuroStd.Core.Perceptron.Base
{
    public interface INeuroLink
    {
        IPreceptron PerceptronFrom { get;  }
        IPreceptron PerceptronTo { get;  }
        Task SetLink(IPreceptron PerceptronFrom, IPreceptron PerceptronTo, double? preWeight);
        double Weight { get; set; }        
    }
}
