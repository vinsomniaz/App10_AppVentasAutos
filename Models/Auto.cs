using System.ComponentModel.DataAnnotations;
namespace App10_AppVentasAutos.Models
{
    public class Auto
    {
        public int Id { get; set; }

        [Required]
        public string Marca { get; set; }

        [Required]
        public string Modelo { get; set; }

        public int Anio { get; set; }

        public decimal Precio { get; set; }

        public string Color { get; set; }

        public bool EsNuevo { get; set; }

        public DateTime FechaRegistro { get; set; }

    }
}
