﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebJobChollometro.Models
{
    #region table
    //create table CHOLLOS(IDCHOLLO int primary key, TITULO nvarchar(max), LINK nvarchar(max), DESCRIPCION nvarchar(max), FECHA datetime)
    #endregion
    [Table("CHOLLOS")]
    public class Chollo
    {
        [Key]
        [Column("IDCHOLLO")]
        public int IdChollo { get; set; }
        [Column("TITULO")]
        public string Titulo { get; set; }
        [Column("LINK")]
        public string Link { get; set; }
        [Column("DESCRIPCION")]
        public string Descripcion { get; set; }
        [Column("FECHA")]
        public DateTime Fecha { get; set; }


    }
}
