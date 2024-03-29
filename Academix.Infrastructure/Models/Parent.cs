﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academix.Infrastructure.Models
{
    public class Parent
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ParentIdentityId { get; set; } = null!;

        [ForeignKey(nameof(ParentIdentityId))]
        public ApplicationUser ParentIdentity { get; set; } = null!;
    }
}
