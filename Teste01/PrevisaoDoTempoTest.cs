using Devops_Infnet.Controllers;
using Devops_Infnet;

using Xunit;
using System;

namespace Teste01
{
    public class PrevisaoDoTempoTest
    {
        [Fact]
        public void GetPrevisaoDoTempoComSucesso()
        {
            var controller = new PrevisaoDoTempoController();
            var resul = controller.Get();
        }
        
        [Fact]
        public void GetPrevisaoDoTempoComFalha()
        {
            var tempoHoje = new PrevisaoDoTempo
            {
                Data = DateTime.Now,
                TemperaturaC = 27
            };
          
          int tempo = tempoHoje.CaculoTemperaturaF(tempoHoje.TemperaturaC);

          Assert.InRange(tempo, 2, 100);
        }
    }
}