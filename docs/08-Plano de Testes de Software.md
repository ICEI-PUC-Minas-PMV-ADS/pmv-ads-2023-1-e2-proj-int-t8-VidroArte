# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Os requisitos para realização dos testes de software são:     

●	Site publicado na Internet   
●	Navegador da Internet - Chrome, Firefox ou Edge   
●	Conectividade de Internet para acesso às plataformas (APISs)  

Os testes funcionais a serem realizados no aplicativo são descritos a seguir.



| **Caso de Teste** 	| **CT-01 – Efetuar Login**	|
|:---:	|:---:	|
|Requisito Associado | RF-001	- O sistema deve permitir fazer login com usuário e senha do vendedor. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site **https://**<br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail?????? <br> - Preencher o campo da senha <br> - Clicar em "Login" |
|Critério de Êxito | - O login foi realizado com sucesso. |    


 
| **Caso de Teste** 	| **CT-02 – Cadastrar Novos Clientes** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-002 - O sistema deve permitir cadastrar novos clientes. |
| Objetivo do Teste 	| Verificar se o usuário consegue cadastrar novos clientes na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site **https://**<br> - Clicar em "Cadastrar Cliente" <br> - Preencher os campos obrigatórios **(e-mail, nome, sobrenome, celular, CPF, senha, confirmação de senha)** <br> - **Aceitar os termos de uso** <br> - Clicar em "Cadastrar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |     



| **Caso de Teste** 	| **CT-03 – Cadastrar e Calcular Pedido do Cliente e Prazo de Entrega**	|
|:---:	|:---:	|
|Requisito Associado | RF-004	- O sistema deve possuir opção de cadastrar pedido do cliente.  
 RF-005 O sistema deve permitir calcular, de acordo com o pedido do cliente, o preço de venda do produto.   
 RF-006 O sistema deve permitir calcular o prazo de entrega do pedido do cliente|
| Objetivo do Teste 	| Verificar se o usuário consegue cadastrar pedido do cliente. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site **https://**<br> - Buscar pelo Cliente que irá fazer o pedido - Clicar no botão "Cadastrar Pedido" <br> - Selecionar os serviços solicitados, preenchendo com os valores de quantidade para cada serviço <br> - Clicar em "Finalizar Pedido" |
|Critério de Êxito | - O pedido foi cadastrado com sucesso. |     



| **Caso de Teste** 	| **CT-04 – Calcular Pedido do Cliente**	|
|:---:	|:---:	|
|Requisito Associado | RF-05	- O sistema deve possuir opção de calcular pedido do cliente. |
| Objetivo do Teste 	| Verificar se o usuário consegue calcular pedido do cliente. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site **https://**<br> - Buscar pelo Cliente que irá fazer o pedido - Clicar no botão "Cadastrar Pedido" <br> - Selecionar os serviços solicitados, preenchendo com os valores de quantidade para cada serviço <br> - Clicar em "Finalizar Pedido" <br> Clicar em "Calcular Pedido"|
|Critério de Êxito | - O pedido foi calculado com sucesso. |   

 
