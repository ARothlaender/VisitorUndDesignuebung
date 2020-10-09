﻿using Bundesbank.Rc1.Übungen.Instruments;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bundesbank.Rc1.Übungen.Portfolios
{
    public interface IPosition
    {
        public IInstrument Instrument { get; }
        public decimal NominalAmount { get; set; }
        public decimal MarketValue { get; set; }
    }
}
