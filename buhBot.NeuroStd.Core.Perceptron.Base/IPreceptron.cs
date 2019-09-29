using System;
using System.Collections.Generic;

namespace buhBot.NeuroStd.Core.Perceptron.Base
{
    public interface IPreceptron
    {
        IList<INeuroLink> Dendrites { get; }
        IList<INeuroLink> Axons { get; }
        double Delta { get; set; }
        double Signal { get; }
    }
