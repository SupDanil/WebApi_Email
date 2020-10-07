using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class EmailModel
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string RecipientName { get; set; }
        public string RecipientEMail { get; set; }
        public string SenderEmail { get; set; }
    }
}
