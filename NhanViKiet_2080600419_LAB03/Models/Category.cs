using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NhanViKiet_2080600419_LAB03.Models
{
    public class Category
    {
        
            public byte Id { get; set; }
            [Required]
            [StringLength(255)]
            public string Name { get; set; }
        
    }
}