namespace FileCopy_Thread
{
    /// <summary>
    /// Claculation class for calculate day minute hour second for transfer data
    /// </summary>
    public class RemainingTimeCalculation
    {
        /// <summary>
        /// Method for calculate day
        /// </summary>
        /// <param name="totalseconds">Total seconds</param>
        /// <returns>Day</returns>
        public double CalculateDay(double totalSeconds)
        {
            // Calculate whole day
            double day = totalSeconds / Constant.OneDayInSeconds;
            return day;
        }

        /// <summary>
        /// Method for calculate hour
        /// </summary>
        /// <param name="seconds">Total Seconds</param>
        /// <returns>Hour</returns>
        public double CalculateHour(double totalSeconds)
        {
            // Calculate remainder after whole days are consumed
            totalSeconds = totalSeconds % Constant.OneDayInSeconds;
            // Calculate whole hours
            double hour = totalSeconds / Constant.OneHourInSeconds;
            return hour;
        }

        /// <summary>
        /// Method for calculate minute
        /// </summary>
        /// <param name="seconds">Total seconds</param>
        /// <returns>Minute</returns>
        public double CalculateMinute(double totalSeconds)
        {
            // Calculate remainder after whole hour are consumed
            totalSeconds = totalSeconds % Constant.OneHourInSeconds;
            // Calculate whole minute
            double totalMinute = totalSeconds / Constant.OneMinuteInSeconds;
            return totalMinute;
        }

        /// <summary>
        /// Method for calculate Seconds
        /// </summary>
        /// <param name="seconds">Total Seconds</param>
        /// <returns>second to transfer data</returns>
        public double CalculateSeconds(double totalSeconds)
        {
            // Calculate remainder after whole minute are consumed
            totalSeconds = totalSeconds % Constant.OneHourInSeconds;
            // Calculate whole second
            double Seconds = totalSeconds % Constant.OneMinuteInSeconds;
            return Seconds;
        }
    }
}

