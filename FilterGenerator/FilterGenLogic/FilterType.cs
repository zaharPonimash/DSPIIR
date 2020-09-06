using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterGenLogic
{
    /// <summary>
    /// Тип фильтра
    /// </summary>
    public enum FilterType
    {
        /// <summary>
        /// ПФ
        /// </summary>
        BandPass,
        /// <summary>
        /// Полосно-заграждающий
        /// </summary>
        BandStop,
        /// <summary>
        /// ФНЧ
        /// </summary>
        LowPass,
        /// <summary>
        /// ФВЧ
        /// </summary>
        HPass
    }
}
