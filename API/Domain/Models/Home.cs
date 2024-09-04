using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minimal_api.Domain.Models
{
    public struct Home
    {
        public string Message {get => "Bem vindo à API de veículos. - Minimal API";}
        public string Documentation {get => "/swagger";}
    }
}