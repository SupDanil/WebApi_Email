using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi
{
    public class EmailContract
    {
        public string Subject { get; set; }
        public string Body { get; set; }
        public string RecipientName { get; set; }
        public string RecipientEMail { get; set; }
        public string SenderEmail{ get; set; }

    }
}
