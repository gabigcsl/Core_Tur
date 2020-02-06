using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Senai.CodeTur.Dominio.Entidades
{
    [Table("Pacotes")]
    public class PacotesDominio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [Column("Nome", TypeName = "VARCHAR(150)")]
        public string Nome { get; set; }

        [Required]
        [Column("Valor", TypeName = "VARCHAR(150)")]
        public string Valor { get; set; }

        [Required]
        [Column("Descricao", TypeName = "VARCHAR(250)")]
        public string Descricao { get; set; }

        [Required]
        [Column("Imagem", TypeName = "varchar(350)")]
        public string Imagem { get; set; }

        [Column("Ativo", TypeName = "bit")]
        public bool Ativo { get; set; }

    }
}
