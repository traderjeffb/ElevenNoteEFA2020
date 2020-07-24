using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Data
{
    class Category
    {
        [Required]
        [Key]
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
    }
}
