﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestNetCalc.Models
{
    public abstract class AbsractBaseCalculator<T>
    {
        public abstract T Addition(T a, T b);
        public abstract T Subtraction(T a, T b);
        public abstract T Multiplication(T a, T b);
        public abstract T Division(T a, T b);
    }
}
