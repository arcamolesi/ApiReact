using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Produto
    {
        [Key]
        public int id { get; set; }

        [DisplayName("Descrição: ")]
        [Required(ErrorMessage = "Campo descrição é obrigatório")]
        public string descricao { get; set; }

        [DisplayName("Unidade: ")]
        public int unidade { get; set; }

        [DisplayName("Quantidade: ")]
        [Required(ErrorMessage = "Campo quantidade é obrigatório")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public float quantidade { get; set; }

        [DisplayName("Valor: ")]
        [Required(ErrorMessage = "Campo valor é obrigatório")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public float valor { get; set; }
    }
}
