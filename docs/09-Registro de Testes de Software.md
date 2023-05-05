# Registro de Testes de Software

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>, <a href="8-Plano de Testes de Software.md"> Plano de Testes de Software</a>

Para cada caso de teste definido no Plano de Testes de Software, realize o registro das evidências dos testes feitos na aplicação pela equipe, que comprovem que o critério de êxito foi alcançado (ou não!!!). Para isso, utilize uma ferramenta de captura de tela que mostre cada um dos casos de teste definidos (obs.: cada caso de teste deverá possuir um vídeo do tipo _screencast_ para caracterizar uma evidência do referido caso).

# Avaliação 

| Caso de teste 01     |  CT 01 - Efeutar Login                                                                   | 
| ------- | ------------------------------------------------------------------------------------------------------------ | 
| Objetivo do teste | Verificar se a tela de login do sistema permite que usuários autorizados acessem o sistema e que usuários não autorizados sejam impedidos de acessar o sistema. | 
| Escopo | Testar a funcionalidade da tela de login para usuários válidos e inválidos. |
| Ambiente de Teste | Sistema operacional Windows 10, navegador Google Chrome, ambiente de desenvolvimento integrado (IDE) Visual Studio, versão 2019. |
<br>

| Teste 01     |  Autenticação bem-sucedida do usuário válido                                                                  | 
| ------- | ------------------------------------------------------------------------------------------------------------ | 
| Descrição | Tentativa de login com as credenciais corretas de um usuário autorizado. | 
| Ações esperadas | 1- Acessar a tela de login. 2- Digitar o nome de usuário e senha corretos. 3- Clicar no botão de login. 4- Verificar se o usuário é redirecionado para a página inicial do sistema. |
| Resultado | O usuário é autenticado e redirecionado para a página inicial do sistema. |
| Telas | ![WhatsApp Image 2023-05-04 at 21 15 49](https://user-images.githubusercontent.com/115122394/236355836-e6a3c0ba-6c11-4ee7-b8f5-f458b1c95bcb.jpeg)|
| Telas |![WhatsApp Image 2023-05-04 at 21 48 02](https://user-images.githubusercontent.com/115122394/236455525-6b82d423-3d3e-4926-b2f7-68b1fdfd83f0.jpeg)|
<br>

| Teste 02     |  Autenticação mal-sucedida do usuário inválido                                                                  | 
| ------- | ------------------------------------------------------------------------------------------------------------ | 
| Descrição | Tentativa de login com as credenciais inválidas. | 
| Ações esperadas | 1- Acessar a tela de login. 2- Digitar um nome de usuário inválido e uma senha inválida. 3- Clicar no botão de login. 4- Verificar se uma mensagem de erro é exibida indicando que as credenciais são inválidas. |
| Resultado | Uma mensagem de erro é exibida indicando que as credenciais são inválidas. |
| Tela | ![WhatsApp Image 2023-05-04 at 21 20 24 (1)](https://user-images.githubusercontent.com/115122394/236456567-a423d0ed-e55c-4d9b-9593-7402dc09066d.jpeg) |
<br>

| Teste 03     |  Autenticação mal-sucedida devido à falta de credenciais                                                                  | 
| ------- | ------------------------------------------------------------------------------------------------------------ | 
| Descrição | Tentativa de login com as credenciais inválidas. | 
| Ações esperadas | 1- Acessar a tela de login. 2- Clicar no botão de login sem digitar nenhum nome de usuário ou senha. 3- Verificar se uma mensagem de erro é exibida indicando que as credenciais são inválidas. |
| Resultado | Uma mensagem de erro é exibida indicando que as credenciais são inválidas. |
<br>
