using Devops_Infnet.Controllers;
using Xunit;

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
    }
}