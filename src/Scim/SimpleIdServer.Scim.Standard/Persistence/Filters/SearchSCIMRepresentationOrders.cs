namespace SimpleIdServer.Persistence.Filters
{
    public enum SearchSCIMRepresentationOrders
    {
        /// <summary>
        /// Ascending
        /// </summary>
        /// <example>ascending</example>
        Ascending = 0,
        /// <summary>
        /// Descending
        /// </summary>
        /// <example>descending</example>
        Descending = 1,
        /// <summary>
        /// Unspecified, meaning that any code that is processing the order may treat it as ascending or descending.
        /// This is a workaround because enums cannot be null in .NET Standard 2.0.
        /// </summary>
        /// <example>var order = parameter.Order == SearchSCIMRepresentationOrders.Unspecified ? SearchSCIMRepresentationOrders.Ascending : parameter.Order;</example>
        Unspecified = 2
    }
}
