using Microsoft.AspNetCore.Identity;
using static House_renting_system_Project.Data.Data.Entities.DataConstants
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Net.Cache;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Security.Principal;
using System.Text;

namespace House_renting_system_Project.Data.Data.Entities
{
    public class House
    {
        [Key]
        public int Id { get; init; }

        [MaxLength(50)]
        [MinLength(10)]
        [Required]
        public string Title { get; set; } = null!;

        [MaxLength(150)]
        [MinLength(30)]
        [Required]
        public string Address { get; set; } = null!;

        [MaxLength(500)]
        [MinLength(50)]
        [Required]
        public string Description { get; set; } = null!;

        [Required]
        public string ImageUrl { get; set; } = null!;

        [MaxLength(2000)]
        [Required]
        public decimal PricePerMonth { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; init; } = null!;

        public int AgentId { get; set; }
        public Agent Agent { get; set; }
        public string? RenterId { get; set; }
        public IdentityUser? Renter { get; set; }


    }
}