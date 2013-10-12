using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Model
{
    using System.ComponentModel.DataAnnotations;

    public class Item
    {
        [Required]
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime AddDate { get; set; }

        public DateTime ModifyDate { get; set; }
    }
}
