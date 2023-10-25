using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldDatabaseFirst.Repository.Models;

[Table("gbp_alm_cat_libros")]
public partial class GbpAlmCatLibro
{
    [Key]
    [Column("id_libro")]
    public long IdLibro { get; set; }

    [Column("titulo", TypeName = "character varying")]
    public string? Titulo { get; set; }

    [Column("autor", TypeName = "character varying")]
    public string? Autor { get; set; }

    [Column("isbn", TypeName = "character varying")]
    public string? Isbn { get; set; }

    [Column("edicion")]
    public long? Edicion { get; set; }
}
