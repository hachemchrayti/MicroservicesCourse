using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PLAY.CATALOG.Service.Dtos;
using PLAY.CATALOG.Service.Entities;

namespace PLAY.CATALOG.Service
{
    public static class Extensions
    {
        public static ItemDto AsDto(this Item item)
        {
            return new ItemDto(item.Id, item.Name, item.Description, item.Price, item.CreationDate);
        }
    }
}