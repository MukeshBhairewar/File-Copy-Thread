namespace FileCopy_Thread
{
    public class Constant
    {
        /// <summary>
        /// One minute, in seconds 
        /// </summary>
        public const int OneMinuteInSeconds = 60;

        /// <summary>
        /// One hour, in seconds 
        /// </summary>
        public const int OneHourInSeconds = 60 * 60;

        /// <summary>
        /// One day, in seconds 
        /// </summary>
        public const int OneDayInSeconds = 60 * 60 * 24;

        /// <summary>
        /// Error message
        /// </summary>
        public const string argumentException = "Arguments provided to a method is not valid.";

        /// <summary>
        /// Error message
        /// </summary>
        public const string fileNotFoundException = "File Not Found";

        /// <summary>
        /// One Kilobyte in byte
        /// </summary>
        public const long OneKiloByteIntoByte = 1024;

        /// <summary>
        /// One megabyte in byte
        /// </summary>
        public const long OneMegaByteIntoByte = 1024 * 1024;

        /// <summary>
        /// One terabyte in byte
        /// </summary>
        public const long OneTeraByteIntoByte = (long)1024 * 1024 * 1024 * 1024;

        /// <summary>
        /// One gigabyte in byte
        /// </summary>
        public const long OneGigaByteIntoByte = 1024 * 1024 * 1024;
    }
}