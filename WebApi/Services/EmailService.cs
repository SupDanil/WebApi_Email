using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Contracts;
using WebApi.Models;

namespace WebApi.Services
{
    public class EmailService
    {
        public string SendEmail(EmailModel model)
        {
            //TODO Логика отправки имейла
            return $"Email \"{model.Title}\" sended";
        }
       
    }
}
