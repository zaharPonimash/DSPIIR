﻿using NWaves.Filters.Base;
using NWaves.Filters.Base64;
using NWaves.Filters.Fda;
using System;

namespace NWaves.Filters.Bessel
{
    /// <summary>
    /// High-pass Bessel filter
    /// </summary>
    public class HighPassFilter : IirFilter64
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="freq"></param>
        /// <param name="order"></param>
        /// <param name="ripple"></param>
        public HighPassFilter(double freq, int order) : base(MakeTf(freq, order))
        {
        }

        /// <summary>
        /// TF generator
        /// </summary>
        /// <param name="freq"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        private static TransferFunction MakeTf(double freq, int order)
        {
            return DesignFilter.IirHpTf(freq, PrototypeBessel.Poles(order));
        }
    }
}
