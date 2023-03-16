# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas

Pedro Paulo tem 26 anos, é arquiteto recém-formado e autônomo. Pensa em se desenvolver profissionalmente através de um mestrado fora do país, pois adora viajar, é solteiro e sempre quis fazer um intercâmbio. Está buscando uma agência que o ajude a encontrar universidades na Europa que aceitem alunos estrangeiros.

Enumere e detalhe as personas da sua solução. Para tanto, baseie-se tanto nos documentos disponibilizados na disciplina e/ou nos seguintes links:

> **Links Úteis**:
> - [Rock Content](https://rockcontent.com/blog/personas/)
> - [Hotmart](https://blog.hotmart.com/pt-br/como-criar-persona-negocio/)
> - [O que é persona?](https://resultadosdigitais.com.br/blog/persona-o-que-e/)
> - [Persona x Público-alvo](https://flammo.com.br/blog/persona-e-publico-alvo-qual-a-diferenca/)
> - [Mapa de Empatia](https://resultadosdigitais.com.br/blog/mapa-da-empatia/)
> - [Mapa de Stalkeholders](https://www.racecomunicacao.com.br/blog/como-fazer-o-mapeamento-de-stakeholders/)
>
Lembre-se que você deve ser enumerar e descrever precisamente e personalizada todos os clientes ideais que sua solução almeja.

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|ícaro Silva |  conseguir controlar os pedidos diariamente         | realizar o controle contábil diário           |
|ícaro Silva | visualizar qual funcionário(a) realizou os pedidos  |entender a produtividade de cada vendedor |
|ícaro Silva |O relatório de todas as vendas | para calcular o faturamento do mês |
|Kelly Cristina|Fazer login para solicitar o pedido do meu cliente|conseguir medir suas vendas|
|Kelly Cristina| acompanhar o pedido do cliente|conseguir realizar um atendimento completo e eficiente|
|Kelly Cristina|cadastrar novos clientes|para manter um registro atualizado dos clientes|
|Renan Oliveira|receber a entrada dos pedidos diariamente|conseguir se programar para a produção de pedidos, em questão de organização dos espaços|
|Renan Oliveira|consultar os relatórios com as demandas| para consultar o estoque de materiais|
|Renan Oliveira|um sistema que permita monitorar todos os fluxos de caixa da empresa | garantir que sempre temos dinheiro o suficiente para arcar com os custos operacionais da empresa|


## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-01| O sistema deve permitir cadastrar novos clientes | ALTA | 
|RF-02| O sistema deve permitir fazer login com usuário e senha | ALTA |
|RF-03|O sistema deve calcular, de acordo com o pedido do cliente, o valor a ser pago |ALTA|
|RF-04|O sistema enviará um email/whatsapp de confirmação do pedido e informação sobre seu status |MÉDIA|
|RF-05|O sistema informará a produção os novos pedidos que entraram |ALTA|
|RF-06|O sistema vai gerar um relatório de controle contábil diário |ALTA|
### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001|O site deve ser compatível com todos os navegadores   | ALTA | 
|RNF-002|A interface do usuário será uma aplicação web e WhatsApp do cliente   |  MÉDIA |
|RNF-003| O sistema deve ter criptografia de informações sigilosas do cliente |ALTA|
|RNF-004| O sistema terá um melhor desempenho utilizado o navegador Chrome, melhor confiabilidade |ALTA|


## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre letivo, não podendo extrapolar a data de 19/06/2023|
|02| O aplicativo deve se restringir às tecnologias básicas da Web no Backend         |
|03| A equipe não pode subcontratar o desenvolvimento do trabalho. |



## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
