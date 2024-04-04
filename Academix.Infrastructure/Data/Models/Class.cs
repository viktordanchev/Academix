﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Academix.Infrastructure.Data.Models
{
    public class Class
    {
        public Class()
        {
            Students = new List<Student>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        public int? ClassTeacherId { get; set; }

        [ForeignKey(nameof(ClassTeacherId))]
        public Teacher? ClassTeacher { get; set; }

        public IEnumerable<Student> Students { get; set; }
    }
}