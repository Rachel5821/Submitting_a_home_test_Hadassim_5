﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace IBL
{
    public interface IMerchandiseBL
    {
        List<MerchandiseDTO> GetMerchandises();
    }
}
