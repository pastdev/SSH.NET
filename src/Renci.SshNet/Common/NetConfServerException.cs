using System;
using System.Runtime.Serialization;

namespace Renci.SshNet.Common
{
    /// <summary>
    /// The exception that is thrown when there is something wrong with the server capabilities.
    /// </summary>
    [Serializable]
    public class NetConfServerException : SshException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetConfServerException"/> class.
        /// </summary>
        public NetConfServerException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetConfServerException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public NetConfServerException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetConfServerException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="innerException">The inner exception.</param>
        public NetConfServerException(string message, Exception innerException) :
            base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SshAuthenticationException"/> class.
        /// </summary>
        /// <param name="info">The <see cref="SerializationInfo"/> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="StreamingContext"/> that contains contextual information about the source or destination.</param>
        /// <exception cref="ArgumentNullException">The <paramref name="info"/> parameter is <c>null</c>.</exception>
        /// <exception cref="SerializationException">The class name is <c>null</c> or <see cref="Exception.HResult"/> is zero (0). </exception>
        protected NetConfServerException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
