﻿using SalesApp.DomainLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesApp.DomainLayer.Service
{
    public static class OrderService
    {
        public static List<OrderBasicInfoDTO> GetAllOrdersByUserId(long userId)
        {
            throw new NotImplementedException();
        }

        public static DateTime GetOrderDateById(long orderId)
        {
            throw new NotImplementedException();
        }

        public static OrderDetailsDTO GetOrderDetailsById(long orderId)
        {
            throw new NotImplementedException();
        }

        public static void SetOrderItemAsRecieved(long orderId, long itemId)
        {
            throw new NotImplementedException();
        }
    }
}