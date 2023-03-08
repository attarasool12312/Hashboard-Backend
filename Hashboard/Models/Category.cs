using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Hashboard.Models;

[Table("Category")]
public partial class Category
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(500)]
    public string? CategoryName { get; set; }

    public int? CategoryStatus { get; set; }
}
