using System;
using System.Net;

namespace KoenZomers.OneDrive.Api.Exceptions
{
    /// <summary>
    /// Exception thrown when OneDrive does not hand out a resumable upload session. Carries what the
    /// service answered, which used to be discarded: the caller only saw a null session and then an
    /// ArgumentNullException for "oneDriveUploadSession", whatever the real reason was.
    /// </summary>
    public class UploadSessionFailedException : Exception
    {
        /// <summary>
        /// HTTP status OneDrive answered with, or NULL if there was no response at all
        /// </summary>
        public HttpStatusCode? StatusCode { get; private set; }

        /// <summary>
        /// Body of the response received from the OneDrive service (may be empty)
        /// </summary>
        public string Response { get; private set; }

        /// <summary>
        /// Exception to indicate OneDrive refused, or failed, to create an upload session
        /// </summary>
        /// <param name="statusCode">HTTP status OneDrive answered with, or NULL if there was no response</param>
        /// <param name="reason">Reason phrase and/or the error OneDrive gave, in words</param>
        /// <param name="response">Body of the response received from the OneDrive service</param>
        public UploadSessionFailedException(HttpStatusCode? statusCode, string reason, string response)
            : base("OneDrive did not start the upload" + (statusCode.HasValue ? " (" + (int)statusCode.Value + " " + reason + ")" : ": " + reason))
        {
            StatusCode = statusCode;
            Response = response;
        }
    }
}
