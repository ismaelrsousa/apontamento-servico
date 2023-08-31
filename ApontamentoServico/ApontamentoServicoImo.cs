namespace ApontamentoServico
{
    public class ApontamentoServicoIMO : ApontamentoServicoArmazenagem
    {
        public override decimal ObterDiasArmazenados(DateTime entrada, DateTime atracacao)
        {
            if (atracacao > entrada)
                throw new Exception("Atracação não pode ser maior que a entrada");

            return atracacao.Subtract(entrada).Days;
        }
    }
}