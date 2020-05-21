using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TechTalk.SpecFlow;

namespace AVISA.MSTests
{
    [Binding]
    public class CadastrarHorarioDoMedicamentoSteps
    {
        //private MedicamentoController _medicamentoController;

        [Given(@"Que o Usuario autentica com ""(.*)"" e ""(.*)"" no AVISA como ""(.*)""")]
        public void DadoQueOUsuarioAutenticaComENoAVISAComo(string p0, string p1, string p2)
        {
            //var avisa = new Mock<IAvisa>();
            //avisa.Setup(s => s.GetMedicamentos());
            //this._medicamentoController = new MedicamentoController(avisa.Object);
        }

        [When(@"O Usuario precisa tomar o ""(.*)""")]
        public void QuandoOUsuarioPrecisaTomarO(string p0)
        {
        }

        [Then(@"O ""(.*)"" do medicamento fica registrado")]
        public void EntaoODoMedicamentoFicaRegistrado(string p0)
        {
        }

        [Then(@"O envia a notificacao para o ""(.*)""")]
        public void EntaoOEnviaANotificacaoParaO(string p0)
        {
            Assert.AreEqual(p0, "Fabio");
        }
    }
}