﻿using System;
using System.Runtime.Serialization;

namespace Renci.SshNet.Common
{
    /// <summary>
    /// The exception that is thrown when operation permission is denied.
    /// </summary>
    [Serializable]
    public class SftpPermissionDeniedException : SshException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SftpPermissionDeniedException"/> class.
        /// </summary>
        public SftpPermissionDeniedException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SftpPermissionDeniedException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public SftpPermissionDeniedException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SftpPermissionDeniedException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="innerException">The inner exception.</param>
        public SftpPermissionDeniedException(string message, Exception innerException) :
            base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SftpPermissionDeniedException"/> class.
        /// </summary>
        /// <param name="info">The <see cref="SerializationInfo"/> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="StreamingContext"/> that contains contextual information about the source or destination.</param>
        /// <exception cref="ArgumentNullException">The <paramref name="info"/> parameter is <c>null</c>.</exception>
        /// <exception cref="SerializationException">The class name is <c>null</c> or <see cref="Exception.HResult"/> is zero (0). </exception>
        protected SftpPermissionDeniedException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
