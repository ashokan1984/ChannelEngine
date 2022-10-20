using System;
using System.Collections.Generic;
using System.Text;

namespace ChannelEngineModels
{
    public class ChannelEngineException : Exception
    {
        public ChannelEngineException(int errorCode, string message) : base(message)
        {
            ErrorCode = errorCode;
            ErrorMessage = message;
        }

        public int ErrorCode { get; }

        public string ErrorMessage { get; }
    }
}
