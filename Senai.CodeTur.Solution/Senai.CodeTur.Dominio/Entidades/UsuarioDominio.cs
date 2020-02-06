using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Senai.CodeTur.Dominio.Entidades
{
    [Table("Usuarios")]
    public class UsuarioDominio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [Column("Email",TypeName = "VARCHAR(150)")]
        public string Email { get; set; }

        [Required]
        [Column("Senha",TypeName = "VARCHAR(20)")]
        public string Senha { get; set; }

        [Required]
        [Column("Tipo",TypeName = "VARCHAR(50)")]
        public string Tipo { get; set; }

    }
}
