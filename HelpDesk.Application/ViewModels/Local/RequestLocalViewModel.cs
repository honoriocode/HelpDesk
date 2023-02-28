﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Application.ViewModels.Local;

public sealed record RequestLocalViewModel
{
    public string Description { get; set; } = null!;

    public DateTime ProductionDate { get; set; }

    public DateTime ExpirationDate { get; set; }

    public bool IsActive { get; set; } = true;

    public RequestLocalViewModel Local { get; set; } = null!;
}
