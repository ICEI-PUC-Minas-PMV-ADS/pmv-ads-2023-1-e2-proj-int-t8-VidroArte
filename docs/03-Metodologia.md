
# Metodologia

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Documentação de Especificação</a></span>

A metodologia contempla as definições de ferramental utilizado pela equipe tanto para a manutenção dos códigos e demais artefatos quanto para a organização do time na execução das tarefas do projeto.

## Relação de Ambientes de Trabalho

*Repositório de código Fonte |GitHub| https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t8-VidroArte

*Documentos do Projeto | Google Drive | https://drive.google.com/drive/folders/1-6rtJkMlswNACmbWzMfF00e-pDvjxX9u

*Projeto de Interface e Wireframes | https://marvelapp.com/prototype/1982i90j

*Gerenciamento do Projeto |GitHub| https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t8-VidroArte/projects?query=is%3Aopen

## Gestão de Código Fonte

A gestão do código fonte do projeto foi realizada com base no conteúdo apresentado nos microfundamentos e nas aulas de orientação síncronas do projeto. Esta gestão é realizada através dos commits implementados no GitHub por cada integrante responsável pelas suas tarefas, conforme nosso Project do GitHub, que haviam sido delimitadas e distribuidas durante as sprints realizadas.

## Controle de Versão

A ferramenta de controle de versão adotada no projeto foi o
[Git](https://git-scm.com/), sendo que o [Github](https://github.com)
foi utilizado para hospedagem do repositório.

O modelo Gitflow é um fluxo de trabalho popular que utiliza várias branches para gerenciar o desenvolvimento de software com Git. O este modelo ajuda a manter uma estrutura organizada para o desenvolvimento de software, garantindo que todas as alterações de código sejam feitas nas branches corretas e que as mesclagens sejam feitas de forma adequada e controlada.   

O projeto segue a seguinte convenção para o nome de branches:


- `master`: é a branch principal que contém o código do produto em produção. Todas alterações feitas nessa branch são destinadas à próxima versão de lançamento.
- `develop`: é a branch principal com o código de desenvolvimento mais recente. As alterações de diferentes desenvolvedores são mescladas nesta branch à medida que são concluídas. Esta branch é utilizada como base para as próximas versões do produto.
- `feature`: são as branches de recursos utilizadas para desenvolver novas funcionalidades ou melhorias no código, são criadas a partir da develop branch e juntadas a ela quando o trabalho é finalizado.    
- `release`: são as branches usadas para preparar uma nova versão do produto para lançamento. Essas branches são criadas a partir da develop branch e são usadas para fazer ajustes finais antes do lançamento, como correções de bugs, atualizações de documentação, etc. Após o término dos ajustes, a branch é mesclada em master e develop.
- `hotfix`: são as branches usadas para corrigir bugs críticos no código que está em produção. Essas branches são criadas a partir da master branch e, uma vez concluídas, são mescladas novamente em master e develop.


## Gerenciamento de Projeto

A equipe utiliza metodologias ágeis, tendo escolhido o Scrum como base para definição do processo de desenvolvimento.

A equipe está organizada da seguinte maneira:

●	**Scrum Master**:  
 Rafaella Belisário

●	**Product Owner**:  
 Hebert Eustaquio De Almeida Sandinha

●	**Equipe de Desenvolvimento**:  
 Henrique de Brito Leite   
 Lucas Reis Alves

●	**Equipe de Design**:  
 Elves Teixeira Dias  
 Maria Luiza Goncalves De Sousa


Para organização e distribuição das tarefas do projeto, a equipe está utilizando o GitHub Projects estruturado com as seguintes listas: 

**Product Backlog**: recebe as tarefas a serem trabalhadas. Todas as atividades identificadas no decorrer do projeto devem ser incorporadas a esta lista.  
**To Do**: Esta lista representa o Sprint Backlog. Este é o Sprint atual que estamos trabalhando.   
**In Progress**: Quando uma tarefa tiver sido iniciada, ela é movida para lá.   
**Done**: Nesta lista são colocadas as tarefas que já foram finalizadas.

O quadro com as tarefas do grupo no Projects GitHub pode ser consultado através da URL https://github.com/orgs/ICEI-PUC-Minas-PMV-ADS/projects/315/views/1 e é apresentado, no estado atual, na figura abaixo.

![Tela Projects GitHub](https://user-images.githubusercontent.com/115122394/228994070-504ad674-a0cd-441f-b254-2794a1bec1b9.JPG)   

### Divisão de Papéis

Os membros do grupo distribuiram as tarefas para que o trabalho fosse desenvolvido de forma mais ágil e eficiente, mas durante as reuniões agendadas todos conseguiram participar de todas as fases do desenvolvimento do projeto.

### Processo

A equipe estipulou e distribui as tarefas a serem realizadas a cada etapa e as organizou no GitHub Project e a cada sprint esse quadro é verificado e alterado, conforme necessário.
 
### Ferramentas

As ferramentas empregadas no projeto são:

- Editor de código: Visual Code
- Ferramentas de comunicação: Whatsapp e Temas
- Ferramentas de desenho de tela (_wireframing_)  
- Ferramentas para Diagrama
- 

O editor de código foi escolhido por possuir uma integração com o sistema de versão e em função de ser um programa de fácil acesso a todos do grupo.  
As ferramentas de comunicação utilizadas foram as que os integrantes do grupo já estavam acostumados, por serem mais práticas e usuais.
Por fim, para criar diagramas utilizamos essas ferramentas por melhor captar as necessidades da nossa solução.

