using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PC1.Models
{
    public class Bolsa
    {
        public string? Nombres {get;set;}
        public string? Correo {get;set;}
        public DateOnly FechaOperacion {get;set;}
        public bool Syp {get;set;}
        public bool Dowjones {get;set;}
        public bool Bonos {get;set;}
        public decimal MontoAbonar {get;set;}
        public decimal Cobro{get;}
        public decimal Igv {get;}
        public decimal Total {get;}
        public Bolsa() { }
        public Bolsa(string _nombre, string _correo, DateOnly _FechaOperacion, bool _syp, bool _dj, bool _bonos, decimal _montoabonar){
                Nombres = _nombre;
                Correo = _correo;
                FechaOperacion = _FechaOperacion;
                Syp = _syp;
                Dowjones = _dj;
                Bonos = _bonos;
                MontoAbonar = _montoabonar;
             Cobro = MontoAbonar > 300 ? 1 : 3;

                Total = MontoAbonar + Cobro;
                Igv = 0.18m * Total;
                Total = MontoAbonar + Igv;
        }

    }
}