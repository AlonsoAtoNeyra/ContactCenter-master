﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactCenterBE.Base;
using ContactCenterBE.CC.TH.Entidades.ReservaBE;

namespace ContactCenterBE.CC.TH.Entidades.LogEmailBE
{
    public class LogEmail : BaseEntity
    {
        public int IdLog { get; set; }
        public string CorreoOrigen { get; set; }
        public string CorreoDestino { get; set; }
        public DateTime FechaEnvio { get; set; }
        public string Mensaje { get; set; }
        public string Estado { get; set; }
        public Reserva Reserva { get; set; }
    }
}
