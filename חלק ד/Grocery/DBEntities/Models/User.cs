﻿using System;
using System.Collections.Generic;

namespace DBEntities.Models;
public partial class User
{
    public int Id { get; set; }

    public bool? IsManager { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

}
