﻿using System;
using System.Collections.Generic;

namespace ScholarshipApplicationProject.Console.DbModels;

public partial class Scholarship
{
    public string? Email { get; set; }

    public string? Name { get; set; }

    public int? Amount { get; set; }
}
