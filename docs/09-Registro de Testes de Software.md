# Registro de Testes de Software

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>, <a href="8-Plano de Testes de Software.md"> Plano de Testes de Software</a>

Para cada caso de teste definido no Plano de Testes de Software, realize o registro das evidências dos testes feitos na aplicação pela equipe, que comprovem que o critério de êxito foi alcançado (ou não!!!). Para isso, utilize uma ferramenta de captura de tela que mostre cada um dos casos de teste definidos (obs.: cada caso de teste deverá possuir um vídeo do tipo _screencast_ para caracterizar uma evidência do referido caso).

# Avaliação 

| Caso de teste 01     |  CT 01 - Efetuar Login                                                                   | 
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
| Telas |![WhatsApp Image 2023-05-25 at 20 55 45](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t8-VidroArte/assets/115122394/6c426cfd-8598-4ad7-adae-9bca8ba6c57b)|
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
| Tela | ![WhatsApp Image 2023-05-04 at 21 46 46](https://user-images.githubusercontent.com/115122394/236457061-1873aae8-7ff6-4624-b172-d8e6217e4d94.jpeg) |
<br>

| Caso de teste 02     |  CT 02 - Cadastrar Novos Clientes                                                                   | 
| ------- | ------------------------------------------------------------------------------------------------------------ | 
| Objetivo do teste | Verificar se a tela de cadastro de clientes do sistema permite o cadastro correto de novos clientes e que as informações são armazenadas e exibidas corretamente. | 
| Escopo | Testar a funcionalidade da tela de cadastro de clientes para diferentes cenários, incluindo clientes válidos e inválidos. |
| Ambiente de Teste | Sistema operacional Windows 10, navegador Google Chrome, ambiente de desenvolvimento integrado (IDE) Visual Studio, versão 2019. |
<br>

| Teste 01     |  Cadastro bem-sucedido de um novo cliente                                                                  | 
| ------- | ------------------------------------------------------------------------------------------------------------ | 
| Descrição | Tentativa de cadastro de um novo cliente com informações válidas. | 
| Ações esperadas | 1- Acessar a tela de cadastro de clientes. 2- Preencher as informações válidas do novo cliente, como nome/razão social, CPF/CNPJ, RG/Inscrição Estadual, endereço, telefone, e-mail e outros campos relevantes. 3- Clicar no botão de Salvar. 4- Verificar se o cliente é cadastrado com sucesso no sistema e exibido corretamente na lista de clientes. |
| Resultado | O novo cliente é cadastrado com sucesso e exibido corretamente na lista de clientes. |
| Telas | ![WhatsApp Image 2023-05-25 at 21 03 56](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t8-VidroArte/assets/115122394/cb42a24d-7ec5-4191-9d0a-3758f408f021)|
| Telas | ![WhatsApp Image 2023-05-25 at 21 11 48](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t8-VidroArte/assets/115122394/33cb09c7-a5ac-4823-a291-f673e0fe326e)|
| Telas | FAlTA TELA CONSULTA LISTA CLIENTES|
<br>

| Teste 02     |  Cadastro mal-sucedido de um novo cliente devido a informações inválidas                                                                  | 
| ------- | ------------------------------------------------------------------------------------------------------------ | 
| Descrição |  Tentativa de cadastro de um novo cliente com informações inválidas. | 
| Ações esperadas | 1- Acessar a tela de cadastro de clientes. 2- Preencher as informações inválidas do novo cliente. 3- Clicar no botão de Salvar. 4- Verificar se uma mensagem de erro é exibida indicando que as informações do cliente são inválidas. |
| Resultado | Uma mensagem de erro é exibida indicando que as informações do cliente são inválidas. |
| Telas | ![WhatsApp Image 2023-05-25 at 21 02 03](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t8-VidroArte/assets/115122394/667fc5e3-90e8-4fa5-bb5d-56c50e750e56)|
<br>


| Teste 03     |  Cadastro mal-sucedido devido à falta de informações obrigatórias                                                                | 
| ------- | ------------------------------------------------------------------------------------------------------------ | 
| Descrição |  Tentativa de cadastro de um novo cliente sem fornecer informações obrigatórias. | 
| Ações esperadas | 1- Acessar a tela de cadastro de clientes. 2- Deixar em branco um ou mais campos obrigatórios do novo cliente. 3- Clicar no botão de Salvar. 4- Verificar se uma mensagem de erro é exibida indicando que as informações obrigatórias do cliente não foram fornecidas. |
| Resultado | Uma mensagem de erro é exibida indicando que as informações obrigatórias do cliente não foram fornecidas. |
| Telas | FALTA TELA DE ERRO SOLICITANDO INFORMAÇÕES OBRIGATÓRIAS|
<br>

| Caso de teste 03     |  CT 03 - Cadastrar Pedido do Cliente                                                                   | 
| ------- | ------------------------------------------------------------------------------------------------------------ | 
| Objetivo do teste | Verificar se a tela de cadastro de pedidos do sistema permite que os usuários cadastrem pedidos corretamente e que o sistema armazene e exiba essas informações corretamente. | 
| Escopo | Testar a funcionalidade da tela de cadastro de pedidos para diferentes cenários, incluindo pedidos válidos e inválidos. |
| Ambiente de Teste | Sistema operacional Windows 10, navegador Google Chrome, ambiente de desenvolvimento integrado (IDE) Visual Studio, versão 2019. |
<br>

| Teste 01     |  Cadastro bem-sucedido de um novo pedido                                                                  | 
| ------- | ------------------------------------------------------------------------------------------------------------ | 
| Descrição | Tentativa de cadastro de um novo pedido com informações válidas. | 
| Ações esperadas | 1- Acessar a tela de cadastro de pedidos. 2- Preencher as informações válidas do novo pedido, incluindo dados do cliente, itens do pedido, quantidades, preços, formas de pagamento e outros campos relevantes. 3- Clicar no botão de Salvar Pedido. 4- Verificar se o pedido é registrado com sucesso no sistema e exibido corretamente na lista de pedidos. |
| Resultado | O novo pedido é cadastrado com sucesso e exibido corretamente na lista de pedidos. |
| Telas | ![WhatsApp Image 2023-05-25 at 21 41 27](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t8-VidroArte/assets/115122394/26e28508-881b-4607-aca7-9ae003bd65e9)|
| Telas | FAlTA TELA PREENCHIDA E A TELA DE CONSULTA LISTA PEDIDOS|
<br>

| Teste 02    |  Cadastro mal-sucedido de um novo pedido devido a informações inválidas                                                                  | 
| ------- | ------------------------------------------------------------------------------------------------------------ | 
| Descrição | Tentativa de cadastro de um novo pedido com informações inválidas. | 
| Ações esperadas | 1- Acessar a tela de cadastro de pedidos. 2- Preencher as informações inválidas do novo pedido, incluindo dados do cliente, itens do pedido, quantidades, preços, formas de pagamento e outros campos relevantes. 3- Clicar no botão de Salvar Pedido. 4- Verificar se uma mensagem de erro é exibida indicando que as informações do pedido são inválidas. |
| Resultado | Uma mensagem de erro é exibida indicando que as informações do pedido são inválidas. |
| Telas | |
| Telas | FAlTA TELA DE ERRO PREENCHIDA COM INFORMAÇÕES INVÁLIDAS |
<br>

| Teste 03    |  Cadastro mal-sucedido devido à falta de informações obrigatórias                                                                  | 
| ------- | ------------------------------------------------------------------------------------------------------------ | 
| Descrição |Tentativa de cadastro de um novo pedido sem fornecer informações obrigatórias. | 
| Ações esperadas | 1- Acessar a tela de cadastro de pedidos. 2- Deixar em branco um ou mais campos obrigatórios do novo pedido, incluindo dados do cliente, itens do pedido, quantidades, preços, formas de pagamento e outros campos relevantes. 3- Clicar no botão de cadastro de pedido. 4- Verificar se uma mensagem de erro é exibida indicando que as informações obrigatórias do pedido não foram fornecidas.|
| Resultado | Uma mensagem de erro é exibida indicando que as informações obrigatórias do pedido não foram fornecidas. |
| Telas | |
| Telas | FAlTA TELA DE ERRO INDICANDO QUE AS INFORMAÇÕES OBRIGATÓRIAS NÃO FORAM PREENCHIDAS |
<br>

| Teste 04    |  Exclusão bem-sucedida de um pedido                                                                | 
| ------- | ------------------------------------------------------------------------------------------------------------ | 
| Descrição |  Tentativa de exclusão bem-sucedida de um pedido existente. | 
| Ações esperadas | 1- Acessar a tela de lista de pedidos. 2- Selecionar o pedido a ser excluído. 3- Clicar no botão de exclusão de pedido. 4- Confirmar a exclusão quando solicitado. 5- Verificar se o pedido é removido com sucesso do sistema e não é mais exibido na lista de pedidos. |
| Resultado | O pedido é excluído com sucesso do sistema e não é mais exibido na lista de pedidos. |
| Telas | |
| Telas | FAlTA TELA DO PEDIDO PREENCHIDO E DEPOIS DE EXCLUÍDO |
<br>

| Caso de teste 04     |  CT 04 - Calcular Pedido/Orçamento do Cliente                                                                   | 
| ------- | ------------------------------------------------------------------------------------------------------------ | 
| Objetivo do teste | Verificar se a tela de cadastro de orçamento do sistema permite o cadastro correto de novos orçamentos e se as informações são armazenadas e exibidas corretamente.  | 
| Escopo | Testar a funcionalidade da tela de cadastro de orçamento para diferentes cenários, incluindo orçamentos válidos e inválidos. |
| Ambiente de Teste | Sistema operacional Windows 10, navegador Google Chrome, ambiente de desenvolvimento integrado (IDE) Visual Studio, versão 2019. |
<br>

| Teste 01     |  Cadastro bem-sucedido de um novo orçamento                                                                  | 
| ------- | ------------------------------------------------------------------------------------------------------------ | 
| Descrição | Tentativa de cadastro de um novo orçamento com informações válidas. | 
| Ações esperadas | 1- Acessar a tela de cadastro de orçamento. 2- Preencher as informações válidas do novo orçamento, como nome do cliente, descrição, itens do orçamento, preços, quantidades e outros campos relevantes. 3- Clicar no botão de cadastro de orçamento. 4- Verificar se o orçamento é cadastrado com sucesso no sistema e exibido corretamente na lista de orçamentos.|
| Resultado | O novo orçamento é cadastrado com sucesso e exibido corretamente na lista de orçamentos. |
| Telas | ![WhatsApp Image 2023-05-25 at 21 54 22](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t8-VidroArte/assets/115122394/80fe9789-fe06-4274-9e1a-e160d651143c)|
| Telas | FAlTA TELA PREENCHIDA E A TELA DE CONSULTA LISTA DE ORÇAMENTOS|
<br>

| Teste 02    |  Cadastro mal-sucedido de um novo orçamento devido a informações inválidas                                                                  | 
| ------- | ------------------------------------------------------------------------------------------------------------ | 
| Descrição | Tentativa de cadastro de um novo orçamento com informações inválidas. | 
| Ações esperadas | 1- Acessar a tela de cadastro de orçamento. 2- Preencher as informações inválidas do novo orçamento, como descrição em branco, preços negativos ou quantidades inválidas. 3- Clicar no botão de cadastro de orçamento. 4- Verificar se uma mensagem de erro é exibida indicando que as informações do orçamento são inválidas.|
| Resultado |  Uma mensagem de erro é exibida indicando que as informações do orçamento são inválidas. |
| Telas | |
| Telas | FAlTA TELA PREENCHIDA COM INFORMAÇÕES INVÁLIDAS E COM ERRO |
<br>

| Teste 03    |  Cadastro mal-sucedido devido à falta de informações obrigatórias                                                                  | 
| ------- | ------------------------------------------------------------------------------------------------------------ | 
| Descrição | Tentativa de cadastro de um novo orçamento sem fornecer informações obrigatórias. | 
| Ações esperadas | 1- Acessar a tela de cadastro de orçamento. 2- Deixar em branco um ou mais campos obrigatórios do novo orçamento, como nome do cliente, descrição ou preços. 3- Clicar no botão de cadastro de orçamento. 3- Verificar se uma mensagem de erro é exibida indicando que as informações obrigatórias do orçamento não foram fornecidas. |
| Resultado | Uma mensagem de erro é exibida indicando que as informações obrigatórias do orçamento não foram fornecidas. |
| Telas | |
| Telas | FAlTA TELA PREENCHIDA INFORMANDO QUE FALTAM INFORMAÇÕES A SEREM FORNECIDAS |
<br>

| Teste 04    |  Exclusão bem-sucedida de um orçamento                                                                  | 
| ------- | ------------------------------------------------------------------------------------------------------------ | 
| Descrição | Tentativa de exclusão bem-sucedida de um orçamento existente. | 
| Ações esperadas | 1- Acessar a tela de lista de orçamentos. 2- Selecionar o orçamento a ser excluído. 3- Clicar no botão de exclusão de orçamento. 4- Confirmar a exclusão quando solicitado. 5- Verificar se o orçamento é removido com sucesso do sistema e não é mais exibido na lista de orçamentos. |
| Resultado | O orçamento é excluído com sucesso do sistema e não é mais exibido na lista de orçamentos. |
| Telas | |
| Telas | FAlTA TELA DE EDIÇÃO DE ORÇAMENTO |
<br>

| Caso de teste 06     |  CT-06 – Consultar Pedidos                                                                   | 
| ------- | ------------------------------------------------------------------------------------------------------------ | 
| Objetivo do teste | Verificar se a funcionalidade de consulta de pedidos exibe corretamente os pedidos existentes no sistema. | 
| Escopo | Testar a página de consulta de pedidos do sistema. |
| Ambiente de Teste | Sistema operacional Windows 10, navegador Google Chrome, banco de dados Azure SQL Server. |
<br>

| Teste 01     |  Consultar os pedidos cadastrados no sistema                                                                  | 
| ------- | ------------------------------------------------------------------------------------------------------------ | 
| Descrição | Verificar se a página de consulta de pedidos exibe corretamente os pedidos cadastrados no sistema. | 
| Ações esperadas | 1- Acessar a página de consulta de pedidos. 2- Verificar a lista de pedidos exibidos na tela. |
| Resultado | A página exibe corretamente a lista de pedidos cadastrados no sistema. |
| Telas | |
| Telas | ![Consulta de Pedidos](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t8-VidroArte/blob/main/docs/img/Captura%20de%20tela%202023-06-04%20232037.png) |
<br>

| Caso de teste 07     |  CT-07 – Consultar Orçamentos                                                                   | 
| ------- | ------------------------------------------------------------------------------------------------------------ | 
| Objetivo do teste | Verificar se a funcionalidade de consulta de orçamentos exibe corretamente os orçamentos existentes no sistema. | 
| Escopo | Testar a página de consulta de orçamentos do sistema. |
| Ambiente de Teste | Sistema operacional Windows 10, navegador Google Chrome, banco de dados Azure SQL Server. |
<br>

| Teste 01     |  Consultar orçamentos cadastrados                                                                  | 
| ------- | ------------------------------------------------------------------------------------------------------------ | 
| Descrição | Verificar se a página de consulta de orçamentos exibe corretamente os orçamentos cadastrados no sistema. | 
| Ações esperadas | 1- Acessar a página de consulta de orçamentos. 2- Verificar a lista de orçamentos exibidos na tela. |
| Resultado | A página exibe corretamente a lista de orçamentos cadastrados no sistema. |
| Telas | |
| Telas | FAlTA TELA DE CONSULTA DE ORÇAMENTOS |
<br>

| Caso de teste 08     |  CT-08 – Consultar Clientes                                                                   | 
| ------- | ------------------------------------------------------------------------------------------------------------ | 
| Objetivo do teste | Verificar se a funcionalidade de consulta de clientes exibe corretamente os clientes cadastrados no sistema. | 
| Escopo | Testar a página de consulta de clientes do sistema. |
| Ambiente de Teste | Sistema operacional Windows 10, navegador Google Chrome, banco de dados Azure SQL Server. |
<br>

| Teste 01     |  Consultar clientes cadastrados                                                                  | 
| ------- | ------------------------------------------------------------------------------------------------------------ | 
| Descrição | Verificar se a página de consulta de clientes exibe corretamente os clientes cadastrados no sistema. | 
| Ações esperadas | 1- Acessar a página de consulta de clientes. 2- Verificar a lista de clientes exibidos na tela. |
| Resultado | A página exibe corretamente a lista de clientes cadastrados no sistema. |
| Telas | |
| Telas | ![Consulta de Clientes](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t8-VidroArte/blob/main/docs/img/consulta_clientes.png) |
<br>

| Teste 02     |  Pesquisar clientes por nome e verificar se os resultados correspondem aos critérios de busca                                                                  | 
| ------- | ------------------------------------------------------------------------------------------------------------ | 
| Descrição | Verificar se os resultados exibidos correspondem ao critério de busca | 
| Ações esperadas | 1- Acessar a tela de consulta de clientes. 2- Digitar o nome do cliente na barra de pesquisa. 3- Clicar no botão de busca. 4- Verificar se os resultados exibidos correspondem ao critério de busca |
| Resultado | A página exibe corretamente a lista de clientes pesquisados. |
| Telas | |
| Telas | ![Consulta de Clientes Pesquisados]() |
<br>

