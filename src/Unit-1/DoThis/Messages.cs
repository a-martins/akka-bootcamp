namespace WinTail
{
    public class Messages
    {
        #region Neutral/system messages

        /// <summary>
        /// Marker class to continue processing.
        /// </summary>
        public class ContinueProcessing { }

        #endregion Neutral/system messages

        #region Sucess messages

        /// <summary>
        /// Base class for signalling that user input was valid.
        /// </summary>
        public class InputSucces
        {
            public InputSucces(string reason)
            {
                Reason = reason;
            }

            public string Reason { get; private set; }
        }

        #endregion Sucess messages

        #region Error messages

        /// <summary>
        /// Base class for signalling that user input was invalid.
        /// </summary>
        public class InputError
        {
            public InputError(string reason)
            {
                Reason = reason;
            }

            public string Reason { get; private set; }
        }

        /// <summary>
        /// User provided blank input
        /// </summary>
        public class NullInputError : InputError
        {
            public NullInputError(string reason) : base(reason)
            {
            }
        }

        /// <summary>
        /// User provided invalid input (currently, input w/ odd # chars)
        /// </summary>
        public class ValidationError : InputError
        {
            public ValidationError(string reason) : base(reason)
            {
            }
        }

        #endregion Error messages
    }
}