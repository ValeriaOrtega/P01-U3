using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P01_U3.Models
{
    public class Cine
    {
        public int Id { get; set; }
        public string Película { get; set; }
        public DateTime Horario { get; set; }
        public string Duración { get; set; }
    }
}