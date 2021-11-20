using System;

namespace dd.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        //df
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
