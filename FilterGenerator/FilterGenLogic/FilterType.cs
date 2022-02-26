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
