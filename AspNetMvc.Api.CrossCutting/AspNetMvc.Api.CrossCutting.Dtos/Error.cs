using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetMvc.Api.CrossCutting.Dtos
{
    public class Error
    {
        public string ErrorCode { get; set; }
        public string CallStack { get; set; }
        public string ErrorMessage { get; set; }

        public Error(string ErrorMessage, string ErrorCode, string CallStack)
        {
            this.ErrorCode = ErrorCode;
            this.CallStack = CallStack;
            this.ErrorMessage = ErrorMessage;
        }
    }
}
