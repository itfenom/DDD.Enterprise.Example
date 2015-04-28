﻿using NServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Library.Command;

namespace Demo.Domain.Accounting.Tax.Commands
{
    public class ChangeRate : DemoCommand
    {
        public Guid TaxId { get; set; }

        public Boolean Fixed { get; set; }

        public Decimal Rate { get; set; }
    }
}