using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebApiEF.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Code { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        [Column(TypeName = "decimal(11,2)")]
        public decimal Sales { get; set; }//will automatically default to 0
        public bool Active { get; set; } = true;//will default to false if not set
        [Column(TypeName = "datetime")]
        public DateTime Created { get; set; } = DateTime.Now; //save from typing more

        public Customer()
        {

        }

    }
}
