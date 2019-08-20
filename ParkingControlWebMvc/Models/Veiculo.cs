﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingControlWebMvc.Models
{
    public class Veiculo
    {
        public string Placa { get; set; }
        public string Fabricante { get; set; }
        public string Modelo { get; set; }

        public Veiculo(string placa, string fabricante, string modelo)
        {
            Placa = placa;
            Fabricante = fabricante;
            Modelo = modelo;
        }
    }
}
