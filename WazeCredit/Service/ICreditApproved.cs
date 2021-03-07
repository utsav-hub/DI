﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WazeCredit.Models;

namespace WazeCredit.Service
{
    public interface ICreditApproved
    {
        double GetCreditApproved(CreditApplication creditApplication);
    }
}
