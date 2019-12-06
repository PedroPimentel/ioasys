using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IoasysApi.Models.Entities
{
    public class Enterprise
    {
        [Key]
        public int enterpriseId { get; set; }
        public int type { get; set; }
        public string name { get; set; }
    }
}
