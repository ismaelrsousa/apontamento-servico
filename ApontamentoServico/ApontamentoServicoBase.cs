namespace ApontamentoServico
{
    public class ApontamentoServicoBase
    {
        public string Constante { get; set; }
        public string Nome { get; set; }

        public static Dictionary<string, Type> Servicos { get; } = new Dictionary<string, Type>
        {
            { "CS_ARMAZENAGEM1", typeof(ApontamentoServicoArmazenagem) },
            { "CS_ARMAZENAGEM2", typeof(ApontamentoServicoArmazenagem) },
            { "CS_ARMAZENAGEM3", typeof(ApontamentoServicoArmazenagem) },
            { "CS_IMO1", typeof(ApontamentoServicoIMO) },
            { "CS_IMO2", typeof(ApontamentoServicoIMO) },
            { "CS_IMO3", typeof(ApontamentoServicoIMO) },
        };

        virtual public bool Apontar() {
            Console.WriteLine("Apontando serviço PADRÃO");

            return true;
        }
        virtual public decimal Valorar() {
            decimal valor = 200;

            Console.WriteLine("Valorando serviço PADRÃO");

            return valor;
        }
    }
}
