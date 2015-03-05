﻿using System;
using System.Runtime.Serialization;
using LibGit2Sharp.Core;

namespace LibGit2Sharp
{
    /// <summary>
    /// The exception that is thrown when an operation is canceled.
    /// </summary>
    [Serializable]
    public class UserCancelledException : LibGit2SharpException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LibGit2Sharp.UserCancelledException"/> class.
        /// </summary>
        public UserCancelledException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LibGit2Sharp.UserCancelledException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">A message that describes the error.</param>
        public UserCancelledException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LibGit2Sharp.UserCancelledException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception. If the <paramref name="innerException"/> parameter is not a null reference, the current exception is raised in a catch block that handles the inner exception.</param>
        public UserCancelledException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LibGit2Sharp.UserCancelledException"/> class with a serialized data.
        /// </summary>
        /// <param name="info">The <see cref="SerializationInfo"/> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="StreamingContext"/> that contains contextual information about the source or destination.</param>
        protected UserCancelledException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public UserCancelledException(string message, GitErrorCode code, GitErrorCategory category)
            : base(message, code, category)
        {
        }
    }
}
