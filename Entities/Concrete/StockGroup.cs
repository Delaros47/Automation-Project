﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Entities.Abstract;

namespace Entities.Concrete
{
    public class StockGroup:IEntity
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public string GroupCode { get; set; }
        public int GroupSaveUser { get; set; }
        public DateTime GroupSaveDate { get; set; }
        public int GroupEditUser { get; set; }
        public DateTime GroupEditDate { get; set; }



    }
}
