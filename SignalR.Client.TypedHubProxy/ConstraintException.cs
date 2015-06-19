using System;

namespace Microsoft.AspNet.SignalR.Client
{
    /// <summary>
    /// ConstraintException
    /// </summary>
    public class ConstraintException : Exception
    {
        /// <summary>
        /// ConstraintException constructor
        /// </summary>
        /// <param name="format"></param>
        public ConstraintException(String format)
            : base(format)
        {
        }
    }
}