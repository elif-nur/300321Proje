﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Submit:IEntity
    {
        public int Id { get; set; }
      
        public string Filee { get; set; }
        public string Selection { get; set; }
    }
}
