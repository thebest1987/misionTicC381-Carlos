using System;
using System.ComponentModel.DataAnnotations;

namespace ProyectoCiclo3.App.Dominio{
    
    public class Encomienda{
        public int id { get; set; }
        [Required]
        public string descripcion { get; set; }
        public int peso { get; set; }
        public string tipo { get; set; }
        public string presentacion { get; set; }
    }

}