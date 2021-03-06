﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using QHomeGroup.Infrastructure.SharedKernel;

namespace QHomeGroup.Data.Entities.Content
{
    [Table("Tags")]
    public class Tag : DomainEntity<string>
    {
        [MaxLength(50)] [Required] public string Name { get; set; }

        [MaxLength(50)] [Required] public string Type { get; set; }
    }
}