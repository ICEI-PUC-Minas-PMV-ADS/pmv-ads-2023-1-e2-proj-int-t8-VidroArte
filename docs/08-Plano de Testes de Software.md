# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Os requisitos para realização dos testes de software são:     

●	Site publicado na Internet   
●	Navegador da Internet - Chrome, Firefox ou Edge   
●	Conectividade de Internet para acesso às plataformas (APISs)  

Os testes funcionais a serem realizados no aplicativo são descritos a seguir.


**Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.**

**Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto". **

**Por exemplo:**

| **Caso de Teste** 	| **CT-01 – Efetuar Login**	|
|:---:	|:---:	|
|Requisito Associado | RF-01	- O sistema deve permitir fazer login com usuário e senha do vendedor. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site **https://adota-pet.herokuapp.com/src/index.html**<br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail?????? <br> - Preencher o campo da senha <br> - Clicar em "Login" |
|Critério de Êxito | - O login foi realizado com sucesso. |

 
| **Caso de Teste** 	| **CT-02 – Cadastrar Novos Clientes** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-02 - O sistema deve permitir cadastrar novos clientes. |
| Objetivo do Teste 	| Verificar se o usuário consegue cadastrar novos clientes na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site **https://adota-pet.herokuapp.com/src/index.html**<br> - Clicar em "Cadastrar Cliente" <br> - Preencher os campos obrigatórios **(e-mail, nome, sobrenome, celular, CPF, senha, confirmação de senha)** <br> - **Aceitar os termos de uso** <br> - Clicar em "Cadastrar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |  


| **Caso de Teste** 	| **CT-03 – Cadastrar Pedido do Cliente**	|
|:---:	|:---:	|
|Requisito Associado | RF-04	- O sistema deve possuir opção de cadastrar pedido do cliente. |
| Objetivo do Teste 	| Verificar se o usuário consegue cadastrar pedido do cliente. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site **https://adota-pet.herokuapp.com/src/index.html**<br> - Buscar pelo Cliente que irá fazer o pedido - Clicar no botão "Cadastrar Pedido" <br> - Selecionar os serviços solicitados, preenchendo com os valores de quantidade para cada serviço <br> - Clicar em "Finalizar Pedido" |
|Critério de Êxito | - O pedido foi cadastrado com sucesso. |  

| **Caso de Teste** 	| **CT-04 – Calcular Pedido do Cliente**	|
|:---:	|:---:	|
|Requisito Associado | RF-05	- O sistema deve possuir opção de calcular pedido do cliente. |
| Objetivo do Teste 	| Verificar se o usuário consegue calcular pedido do cliente. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site **https://adota-pet.herokuapp.com/src/index.html**<br> - Buscar pelo Cliente que irá fazer o pedido - Clicar no botão "Cadastrar Pedido" <br> - Selecionar os serviços solicitados, preenchendo com os valores de quantidade para cada serviço <br> - Clicar em "Finalizar Pedido" <br> Clicar em "Calcular Pedido"|
|Critério de Êxito | - O pedido foi calculado com sucesso. |   

 
