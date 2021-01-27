
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PesquisaWebCrawler.Models
{
    public class Refeição
    {
        [Key]
        [Column("PROCODIGO")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string codigoProduto { get; set; }

        [Column("PRONOME")]
        public string nomeProduto { get; set; }

        [Column("PRODESCRICAO")]
        public string descricaoProduto { get; set; }

        [Column("PROIMAGEM")]
        public string imagemProduto { get; set; }

        [Column("PROLINK")]
        public string linkProduto { get; set; }
    }
}
