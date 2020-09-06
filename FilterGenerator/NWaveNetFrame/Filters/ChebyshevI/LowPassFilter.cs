﻿using NWaves.Filters.Base;
using NWaves.Filters.Base64;
using NWaves.Filters.Fda;

namespace NWaves.Filters.ChebyshevI
{
    /// <summary>
    /// Low-pass Chebyshev-I filter
    /// </summary>
    public class LowPassFilter : IirFilter64
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="freq"></param>
        /// <param name="order"></param>
        /// <param name="ripple"></param>
        public LowPassFilter(double freq, int order, double ripple = 0.1) : base(MakeTf(freq, order, ripple))
        {
        }

        /// <summary>
        /// TF generator
        /// </summary>
        /// <param name="freq"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        private static TransferFunction MakeTf(double freq, int order, double ripple = 0.1)
        {
            return DesignFilter.IirLpTf(freq, PrototypeChebyshevI.Poles(order, ripple));
        }
    }
}
