﻿using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBL
{
    public interface IItemInOrderBL
    {
        List<ItemInOrderDTO> GetItemsInOrder();
        List<ItemInOrderDTO> GetItemsInOrderByOrderId(int orderId);
    }
}
