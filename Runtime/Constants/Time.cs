

namespace Holypastry.Bakery
{
    public static class TimeConstant
    {
        private readonly static System.DateTime epochStart = new System.DateTime(1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc);

        public static long MilliSinceEpoch
        {
            get
            {
                return (long)(System.DateTime.UtcNow - epochStart).TotalMilliseconds;
            }
        }

        public static System.DateTime ConvertMillisecondesToDate(long milliseconds)
        {
            return epochStart.AddMilliseconds(milliseconds);
        }
    }
}