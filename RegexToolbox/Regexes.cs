using System.Text.RegularExpressions;

namespace RegexToolbox
{
    public static class Regexes
    {
        /// <summary>
        /// Matches valid IP addresses (0.0.0.0 to 255.255.255.255) and captures each
        /// of the four parts in a group
        /// </summary>
        public static readonly Regex Ipv4Address = new Regex(
            @"\b(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9]?[0-9])\." +
            @"(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9]?[0-9])\." +
            @"(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9]?[0-9])\." +
            @"(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9]?[0-9])\b");
    }
}