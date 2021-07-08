using System;
using System.ComponentModel.DataAnnotations;

namespace BSImoveis.Models
{
    public class Propertie
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Título Anúncio")]
        [Required(ErrorMessage = "Obrigatório informar um título para o imóvel!")]
        [StringLength(80, MinimumLength = 3, ErrorMessage = "O título deve ter entre 3 e 80 caracteres!")]
        public string Title { get; set; }

        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "Obrigatório informar o endereço!")]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "O endereço deve ter entre 10 e 200 caracteres!")]
        public string Address { get; set; }

        [Display(Name = "CEP")]
        [Required(ErrorMessage = "Obrigatório informar o CEP")]
        [MaxLength(8, ErrorMessage = "O CEP deve conter 8 dígitos")]
        public string Cep { get; set; }

        [Display(Name = "Área m²")]
        [Required(ErrorMessage = "Obrigatório informar área do imóvel")]
        [Range(20, 1000, ErrorMessage = "Área do imóvel deve ser entre 20 e 1000 m²!")]
        public int Area { get; set; }

        [Display(Name = "Qtd Quartos")]
        [Required(ErrorMessage = "Obrigatório informar quantidade de quartos")]
        [Range(1, 20, ErrorMessage = "Quantidade de quartos entre 1 e 20!")]
        public int Room { get; set; }

        [Display(Name = "Valor")]
        [Required(ErrorMessage = "Obrigatório informar valor do imóvel")]
        public decimal Value { get; set; }

        [Display(Name = "Data")]
        [DataType(DataType.Date)]
        public DateTime AdDate { get; set; }
    }
}