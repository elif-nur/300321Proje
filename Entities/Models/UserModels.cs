using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [NotMapped]
    public class UserModels

    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    }
}
