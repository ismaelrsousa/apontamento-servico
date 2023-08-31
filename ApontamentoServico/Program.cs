using ApontamentoServico;

string servico = "CS_IMO1";

ApontamentoServicoBase.Servicos.TryGetValue(servico, out var tipoApontamento);

var apontamento = (ApontamentoServicoBase)Activator.CreateInstance(tipoApontamento ?? typeof(ApontamentoServicoBase));

apontamento.Apontar();