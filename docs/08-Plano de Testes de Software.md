# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Os requisitos para realização dos testes de software são:     

●	Site publicado na Internet   
●	Navegador da Internet - Chrome, Firefox ou Edge   
●	Conectividade de Internet para acesso ao sistema  

Os testes funcionais a serem realizados no aplicativo são descritos a seguir.

| **Caso de Teste** 	| **CT-01 – Cadastrar Novos Usuários** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - O sistema deve permitir fazer cadastro de usuário para o vendedor. |
| Objetivo do Teste 	| Verificar se o vendedor consegue se cadastrar como novo usuário no sistema. |
| Passos 	| - Acessar a página de cadastro de usuário <br> - Preencher o formulário de cadastro com informações válidas (nome, e-mail, senha) <br> - Clicar no botão de "Cadastrar" |
| Critério de Êxito | - O cadastro foi realizado com sucesso e o usuário é redirecionado para a página de login. |

| **Caso de Teste** 	| **CT-02 – Fazer Login com Usuário** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-002 - O sistema deve permitir fazer login com usuário e senha do vendedor. |
| Objetivo do Teste 	| Verificar se o vendedor consegue fazer login no sistema utilizando suas credenciais corretas. |
| Passos 	| - Acessar a página de login <br> - Informar o e-mail e senha cadastrados anteriormente <br> - Clicar no botão de "Login" |
| Critério de Êxito | - O login foi realizado com sucesso e o usuário é redirecionado para a página inicial do sistema. |

| **Caso de Teste** 	| **CT-03 – Cadastrar Pedidos** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-003 - O sistema deve permitir cadastrar pedidos. |
| Objetivo do Teste 	| Verificar se o vendedor consegue cadastrar novos pedidos no sistema. |
| Passos 	| - Acessar a página de cadastro de pedidos <br> - Preencher as informações do pedido, como cliente associado, produtos solicitados e quantidade desejada <br> - Clicar no botão de "Cadastrar" |
| Critério de Êxito | - O pedido foi cadastrado com sucesso e é armazenado no sistema. |

| **Caso de Teste** 	| **CT-04 – Cadastrar Orçamentos** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-004 - O sistema deve permitir cadastrar orçamentos. |
| Objetivo do Teste 	| Verificar se o vendedor consegue cadastrar novos orçamentos no sistema. |
| Passos 	| - Acessar a página de cadastro de orçamentos <br> - Preencher as informações do orçamento, como produtos oferecidos, preços e condições de pagamento <br> - Clicar no botão de "Cadastrar" |
| Critério de Êxito | - O orçamento foi cadastrado com sucesso e é armazenado no sistema. |

| **Caso de Teste** 	| **CT-05 – Cadastrar Clientes** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-005 - O sistema deve permitir cadastrar clientes. |
| Objetivo do Teste 	| Verificar se o vendedor consegue cadastrar novos clientes no sistema. |
| Passos 	| - Acessar a página de cadastro de clientes <br> - Preencher as informações do cliente, como nome, endereço, telefone, etc. <br> - Clicar no botão de "Cadastrar" |
| Critério de Êxito | - O cliente foi cadastrado com sucesso e é armazenado no sistema. |

| **Caso de Teste** 	| **CT-06 – Consultar Pedidos** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-006 - O sistema deve permitir consultar pedidos. |
| Objetivo do Teste 	| Verificar se o vendedor consegue consultar os pedidos existentes no sistema. |
| Passos 	| - Acessar a página de consulta de pedidos <br> - Visualizar a lista de pedidos disponíveis no sistema |
| Critério de Êxito | - Os pedidos são exibidos corretamente na página de consulta. |

| **Caso de Teste** 	| **CT-07 – Consultar Orçamentos** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-007 - O sistema deve permitir consultar orçamentos. |
| Objetivo do Teste 		| Verificar se o vendedor consegue consultar os orçamentos existentes no sistema. |
| Passos 					| - Acessar a página de consulta de orçamentos <br> - Visualizar a lista de orçamentos disponíveis no sistema |
| Critério de Êxito 	| - Os orçamentos são exibidos corretamente na página de consulta. |

| **Caso de Teste** 	| **CT-08 – Consultar Clientes** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-008 - O sistema deve permitir consultar clientes. |
| Objetivo do Teste 		| Verificar se o vendedor consegue consultar os clientes cadastrados no sistema. |
| Passos 					| - Acessar a página de consulta de clientes <br> - Visualizar a lista de clientes cadastrados no sistema |
| Critério de Êxito 	| - Os clientes são exibidos corretamente na página de consulta. |
