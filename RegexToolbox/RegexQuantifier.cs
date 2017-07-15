namespace RegexToolbox
{
    /// <summary>
    /// Quantifiers that can be applied to regex elements or groups
    /// </summary>
    public class RegexQuantifier
    {
        #region Private property and constructor

        private string RegexString { get; }

        private RegexQuantifier(string regexString)
        {
            RegexString = regexString;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Quantifier to match the preceding element zero or more times
        /// </summary>
        public static RegexQuantifier ZeroOrMore
        {
            get
            {
                return new RegexQuantifier("*");
            }
        }

        /// <summary>
        /// Quantifier to match the preceding element one or more times
        /// </summary>
        public static RegexQuantifier OneOrMore
        {
            get
            {
                return new RegexQuantifier("+");
            }
        }

        /// <summary>
        /// Quantifier to match the preceding element once or not at all
        /// </summary>
        public static RegexQuantifier NoneOrOne
        {
            get
            {
                return new RegexQuantifier("?");
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Quantifier to match an exact number of occurrences of the preceding element
        /// </summary>
        /// <param name="times">The exact number of occurrences to match</param>
        public static RegexQuantifier Exactly(int times)
        {
            return new RegexQuantifier("{" + times + "}");
        }

        /// <summary>
        /// Quantifier to match at least a minimum number of occurrences of the preceding element
        /// </summary>
        /// <param name="minimum">The minimum number of occurrences to match</param>
        public static RegexQuantifier AtLeast(int minimum)
        {
            return new RegexQuantifier("{" + minimum + ",}");
        }

        /// <summary>
        /// Quantifier to match no more than a maximum number of occurrences of the preceding element
        /// </summary>
        /// <param name="maximum">The maximum number of occurrences to match</param>
        public static RegexQuantifier NoMoreThan(int maximum)
        {
            return new RegexQuantifier("{0," + maximum + "}");
        }

        /// <summary>
        /// Quantifier to match at least a minimum, and no more than a maximum, occurrences of the preceding element
        /// </summary>
        /// <param name="minimum">The minimum number of occurrences to match</param>
        /// <param name="maximum">The maximum number of occurrences to match</param>
        public static RegexQuantifier Between(int minimum, int maximum)
        {
            return new RegexQuantifier("{" + minimum + "," + maximum + "}");
        }

        public override string ToString()
        {
            return RegexString;
        }

        #endregion
    }
}