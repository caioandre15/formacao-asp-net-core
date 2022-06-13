using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.Api.Configuration
{
    public class AppSettings
    {

        public string Secret { get; set; } //Nossa chave de criptografia
        public int ExpiracaoHoras { get; set; }// Quantas horas o token vai levar até perder a validade
        public string Emissor { get; set; }// Quem emite, no a aplicação
        public string ValidoEm { get; set; }// Qm quais URL este token é valido

    }
}
