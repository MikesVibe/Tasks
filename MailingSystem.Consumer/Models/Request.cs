﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailingSystem.Consumer.Models
{
    public class Request
    {
        public string RequestedMailingServiceName { get; set; }
        public Mail Mail { get; set; }
    }
}
