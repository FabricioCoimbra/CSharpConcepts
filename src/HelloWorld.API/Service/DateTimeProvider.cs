namespace HelloWorld.API.Service;

/// <summary>
/// Proxy to Get current DateTime on UTC 0 or Local timezones.
/// </summary>
public static class DateTimeProvider
{
    private static Func<DateTime> getCurrentDateTimeFunc = () => DateTime.UtcNow;
    /// <summary>
    /// Return current DateTime in UTC 0
    /// </summary>
    /// <returns>2024-03-30T04:55:42.024Z</returns>
    public static DateTime GetUTCDateTime()
    {
        return getCurrentDateTimeFunc();
    }
    /// <summary>
    /// Return current DateTime in Local Timezone. 
    /// </summary>
    /// <example></example>
    /// <returns>2024-03-29T01:55:42.024-03:00</returns>
    public static DateTime GetLocalDateTime()
    {
        return getCurrentDateTimeFunc().ToLocalTime();
    }
    /// <summary>
    /// Can reconfigure default function to use in tests.
    /// </summary>
    /// <param name="getCurrentDateTimeFunc"></param>
    public static void SetCurrentDateTimeProvider(Func<DateTime> getCurrentDateTimeFunc)
    {
        DateTimeProvider.getCurrentDateTimeFunc = getCurrentDateTimeFunc;
    }
    /// <summary>
    /// Reconfigure default function delegate.
    /// </summary>
    public static void ResetCurrentDateTimeProvider()
    {
        getCurrentDateTimeFunc = () => DateTime.UtcNow;
    }
}
