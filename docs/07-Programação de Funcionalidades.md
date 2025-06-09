# Programação de Funcionalidades

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="4-Metodologia.md"> Metodologia</a>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="5-Arquitetura da Solução.md"> Arquitetura da Solução</a>

Nesta seção, a implementação do sistema descrita por meio dos requisitos funcionais e/ou não funcionais. Nesta seção, é essencial relacionar os requisitos atendidos com os artefatos criados (código fonte) e com o(s) responsável(is) pelo desenvolvimento de cada artefato a cada etapa. Nesta seção também deverão ser apresentadas, se necessário, as instruções para acesso e verificação da **implementação que deve estar funcional no ambiente de hospedagem, OBRIGATORIAMENTE, a partir da Etapa 03**.

**O que DEVE ser utilizado para o desenvolvimento da aplicação:**
- Microsoft Visual Studio (IDE de Codificação)
- HTML e CSS (frontend)
- Javascript (frontend)
- C# (backend)
- MySQL ou SQLServer(Base de Dados)
- Bootstrap (template responsivo para frontend)
- Github (documentação e controle de versão)

**O que NÃO PODE ser utilizado:**
- Template React (e qualquer outro template - exceto o Bootstrap)
- Qualquer outra liguagem de programação diferente de C#

A tabela a seguir é um exemplo de como ela deverá ser preenchida considerando os artefatos desenvolvidos.

|ID    | Descrição do Requisito  | Artefatos produzidos | Aluno(a) responsável |
|------|-----------------------------------------|----|----|
|RF-001| O sistema deve permitir o cadastro de ONGs| Tela de cadastro, formulário de entrada de dados, rota de API POST /Organization/Add, model Organization | Amanda  |
|RF-002| O sistema deve permitir a edição de ONGs | Tela de edição, formulário pré-preenchido, rota de API POST /Organization/Edit/{id}  | Amanda |
|RF-003| O sistema deve permitir a exclusão de ONGs | Botão de exclusão na tela de edição, rota de API POST /Organization/{id}  | Amanda |
|RF-004| O sistema deve permitir o cadastro de voluntários | Tela de cadastro de voluntários, formulário de entrada de dados, rota de API POST /Volunteer/Add, model Volunteer | Maria Julia |
|RF-005| O sistema deve permitir editar um voluntário | Tela de edição de voluntários, formulário pré-preenchido com dados existentes, rota de API POST /Volunteer/Edit/{id} | Maria Julia |
|RF-006| O sistema deve permitir a exclusão de voluntários | Botão de exclusão na tela de detalhes de voluntários, tela de confirmação antes da exclusão, rota de API DELETE /Volunteer/Delete/{id} | Maria Julia |
|RF-007| 	O sistema deve permitir o cadastro de Eventos | Botão de criar na tela de listagem de eventos, caso o usuário logado seja uma ONG, rota de API POST /Event/Add | Eric Martins |
|RF-008| O sistema deve permitir editar Eventos | Botão de editar na tela de listagem de eventos, rota de API POST /Event/Edit/[id] | Eric Martins |
|RF-009| O sistema deve permitir deletar Eventos | Botão de deletar na tela de listagem de eventos, caso o usuário logado seja uma ONG e seja a criadora do evento, rota de API DELETE /Event/Delete | Eric Martins |
|RF-010| O sistema deve permitir que os voluntários se inscrevam em eventos de seu interesse. | Botão de inscrever-se na tela de detalhes do evento, caso o usuário logado seja um voluntario, rota de API POST /Event/Details/[id] | Frederico Amantino |
|RF-011| 	O sistema deve possibilitar que voluntários façam busca por eventos de acordo com filtros como área de interesse, localização e data. | Botão de busca na tela de listagem de eventos | Eric Martins |
|RF-012| O sistema deve permitir o compartilhamento de eventos em redes sociais para promover o engajamento | Botão na tela home para compartilhamento de eventos, criação de modal com lista de eventos disponíveis e botões de compartilhamento de rede social (whatsapp, facebook e instagram)  | Guilherme |


# Instruções de acesso

Não deixe de informar o link onde a aplicação estiver disponível para acesso (por exemplo: https://adota-pet.herokuapp.com/src/index.html).

Se houver usuário de teste, o login e a senha também deverão ser informados aqui (por exemplo: usuário - admin / senha - admin).

O link e o usuário/senha descritos acima são apenas exemplos de como tais informações deverão ser apresentadas.

> **Links Úteis**:
>
> - [Trabalhando com HTML5 Local Storage e JSON](https://www.devmedia.com.br/trabalhando-com-html5-local-storage-e-json/29045)
> - [JSON Tutorial](https://www.w3resource.com/JSON)
> - [JSON Data Set Sample](https://opensource.adobe.com/Spry/samples/data_region/JSONDataSetSample.html)
> - [JSON - Introduction (W3Schools)](https://www.w3schools.com/js/js_json_intro.asp)
> - [JSON Tutorial (TutorialsPoint)](https://www.tutorialspoint.com/json/index.htm)
