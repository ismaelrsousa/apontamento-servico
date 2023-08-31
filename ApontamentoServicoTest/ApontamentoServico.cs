using ApontamentoServico;

namespace ApontamentoServicoTest
{
    [TestClass]
    public class ApontamentoServico
    {
        string mensagem;

        [AssemblyInitialize]
        public static void AssembyInitialize(TestContext testContext)
        {

        }

        [AssemblyCleanup]
        public static void AssembyCleanup()
        {

        }

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {

        }

        [TestMethod]
        [DataRow(20, DisplayName = "Teste de apontamento de armazenagem")]
        public void ApontarArmazenagem_Teste(int diasArmazenados)
        {
            string servico = "CS_ARMAZENAGEM1";

            Console.WriteLine($"Dias armazenados: {diasArmazenados} DIAS");

            ApontamentoServicoBase.Servicos.TryGetValue(servico, out var tipoApontamento);

            ApontamentoServicoBase apontamento = (ApontamentoServicoBase)Activator.CreateInstance(tipoApontamento ?? typeof(ApontamentoServicoBase));

            decimal valor = apontamento.Valorar();

            Console.WriteLine($"Valor calculado do serviço {valor}");

            Assert.AreEqual(valor, 300);
            // Assert.IsTrue(result);
        }

        [TestMethod]
        [DataRow(DisplayName = "Teste de apontamento de IMO")]
        public void ApontarImo_Teste()
        {
            string servico = "CS_IMO1";

            ApontamentoServicoBase.Servicos.TryGetValue(servico, out var tipoApontamento);

            ApontamentoServicoBase apontamento = (ApontamentoServicoBase)Activator.CreateInstance(tipoApontamento ?? typeof(ApontamentoServicoBase));

            decimal valor = apontamento.Valorar();

            Assert.AreEqual(300, valor);
            // Assert.IsTrue(result);
        }
    }
}