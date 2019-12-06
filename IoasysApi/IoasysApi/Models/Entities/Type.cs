using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IoasysApi.Models.Entities
{
    public class Type
    {
        [Key]
        public int typeId { get; set; }
        public string name { get; set; }
    }
}
