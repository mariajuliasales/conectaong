### Caso de teste - Requisitos funcionais

### Requisitos funcionais

- CT-001 - **Realizar cadastro de uma ONG**
    
    **Requisito Associado**: RF-001 - O sistema deve permitir o cadastro de ONGs
    
    **Pré-condições:**
    
    - O usuário deve estar autenticado no sistema com perfil autorizado (administrador ou gestor).
    - A tela de cadastro de ONG deve estar acessível.
    
    **Objetivo do teste:**
    
    Verificar se o sistema permite o cadastro de uma ONG com todos os dados obrigatórios preenchidos corretamente.
    
    **Critérios de Aceitação:**
    
    - Todos os campos obrigatórios devem ser validados.
    - A ONG deve ser salva corretamente no banco de dados.
    - Mensagem de sucesso deve ser exibida ao término do processo.
    
    **Cenários:**
    
    - **Cenário 1: Cadastro de uma ONG**
        
        **Passos:**
        
        1. Acessar a funcionalidade "Cadastrar ONG".
        2. Preencher os campos obrigatórios: Nome da ONG, CNPJ, E-mail, Telefone, Endereço.
        3. Clicar no botão "Salvar".
        
        **Resultado Esperado:**
        
        - A ONG é cadastrada com sucesso.
        - O sistema exibe a mensagem: "Cadastro realizado com sucesso."
        - A nova ONG aparece na listagem de ONGs.
        
- CT-002 - **Realizar edição de uma ONG**
    
    **Requisito Associado**: RF-002 - O sistema deve permitir a edição de ONGs
    
    **Pré-condições:**
    
    - O usuário deve estar autenticado e possuir permissões para editar dados de ONGs.
    - A ONG a ser editada já deve estar cadastrada no sistema.
    
    **Objetivo do teste:**
    
    Verificar se o sistema permite editar corretamente os dados de uma ONG já cadastrada, garantindo a persistência das alterações.
    
    **Critérios de Aceitação:**
    
    - Os campos devem ser carregados com os dados atuais da ONG.
    - As alterações devem ser validadas e salvas corretamente.
    - O sistema deve exibir uma mensagem de sucesso ao finalizar a edição.
    - A nova informação deve estar refletida na listagem de ONGs.
    - Campos obrigatórios não podem ser deixados em branco durante a edição.
    
    **Cenários:**
    
    - **Cenário 1: Edição bem-sucedida de uma ONG**
        
        **Passos:**
        
        1. Acessar a listagem de ONGs.
        2. Selecionar uma ONG existente e clicar em “Editar”.
        3. Modificar campos como: nome da ONG, E-mail e Telefone.
        4. Clicar no botão “Salvar alterações”.
        
        **Resultado Esperado:**
        
        - O sistema salva as alterações e exibe a mensagem: “Dados atualizados com sucesso.”
        - As novas informações aparecem corretamente na listagem.
    
    ---
    
    - **Cenário 2: Tentativa de salvar com campos obrigatórios em branco**
        
        **Passos:**
        
        1. Acessar a listagem de ONGs.
        2. Clicar em “Editar” para uma ONG.
        3. Limpar os campos obrigatórios como Nome da ONG e CNPJ.
        4. Clicar em “Salvar alterações”.
        
        **Resultado Esperado:**
        
        - O sistema exibe mensagens de validação informando os campos obrigatórios.
        - Nenhuma alteração é salva.
    
    ---
    
- CT-003 - **Exclusão de ONG**
    
    **Requisito Associado**: RF-003 - O sistema deve permitir a exclusão de ONGs
    
    **Pré-condições:**
    
    - O usuário deve estar autenticado com permissões de administrador ou equivalente.
    - A ONG a ser excluída deve estar previamente cadastrada no sistema.
    - A tela de listagem de ONGs deve estar acessível.
    
    **Objetivo do teste:**
    
    Verificar se o sistema permite a exclusão correta de uma ONG e se o comportamento do sistema após a exclusão está de acordo com o esperado (remoção da listagem, confirmação da ação, etc.).
    
    **Critérios de Aceitação:**
    
    - O sistema deve solicitar confirmação antes de excluir definitivamente uma ONG.
    - Após confirmação, a ONG deve ser removida da base de dados e da listagem.
    - O sistema deve apresentar uma mensagem de sucesso.
    - O sistema não deve permitir a exclusão de uma ONG associada a entidades dependentes (se aplicável).
    - A exclusão não deve ser realizada caso o usuário cancele a operação.
    
    ---
    
    ### **Cenários:**
    
    ---
    
    - **Cenário 1: Exclusão bem-sucedida de uma ONG**
        
        **Passos:**
        
        1. Acessar a tela de listagem de ONGs.
        2. Selecionar uma ONG e clicar no botão “Excluir”.
        3. Confirmar a exclusão na janela/modal de confirmação.
        
        **Resultado Esperado:**
        
        - A ONG é removida da listagem.
        - O sistema exibe a mensagem: “ONG excluída com sucesso.”
    
    ---
    
    - **Cenário 2: Cancelamento da exclusão**
        
        **Passos:**
        
        1. Acessar a tela de listagem de ONGs.
        2. Selecionar uma ONG e clicar no botão “Excluir”.
        3. Clicar em “Cancelar” na janela/modal de confirmação.
        
        **Resultado Esperado:**
        
        - A ONG permanece cadastrada e visível na listagem.
        - Nenhuma exclusão é realizada.
    
    ---
    
    - **Cenário 3: Tentativa de exclusão de uma ONG com dependências**
        
        **Passos:**
        
        1. Acessar a tela de listagem de ONGs.
        2. Selecionar uma ONG que possua vínculos com outras entidades (ex: projetos ativos).
        3. Clicar em “Excluir” e confirmar a operação.
        
        **Resultado Esperado:**
        
        - O sistema bloqueia a exclusão e exibe mensagem: “Não é possível excluir a ONG. Existem entidades vinculadas.”
- CT-004 - **Cadastro de Voluntário**
    
    **Requisito Associado**: RF-004 - O sistema deve permitir o cadastro de voluntários
    
    **Pré-condições:**
    
    O usuário deve estar autenticado no sistema com permissão para cadastrar voluntários. A ONG à qual o voluntário será vinculado já deve estar cadastrada.
    
    **Objetivo do teste:**
    
    Verificar se o sistema permite o cadastro correto de um voluntário, com todos os dados obrigatórios preenchidos e validando cenários de erro e sucesso.
    
    **Critérios de Aceitação:**
    
    - O sistema deve permitir cadastrar voluntários com dados válidos.
    - Campos obrigatórios devem ser validados.
    - Deve exibir mensagens de erro em caso de campos inválidos ou em branco.
    - O voluntário deve ser vinculado corretamente a uma ONG existente.
    
    **Cenários:**
    
    - **Cenário 1: Cadastro de voluntário com dados válidos**
        
        **Passos:**
        
        1. Acessar a área de gestão de voluntários.
        2. Clicar em "Cadastrar voluntário".
        3. Preencher os campos: nome, e-mail, telefone, área de interesse, ONG vinculada.
        4. Clicar em "Salvar".
        
        **Resultado Esperado:**
        
        O sistema deve exibir uma mensagem de sucesso e o novo voluntário deve constar na lista de voluntários cadastrados.
        
    
    ---
    
    - **Cenário 2: Cadastro com campos obrigatórios em branco**
        
        **Passos:**
        
        1. Acessar a área de gestão de voluntários.
        2. Clicar em "Cadastrar voluntário".
        3. Deixar um ou mais campos obrigatórios (como nome ou e-mail) em branco.
        4. Clicar em "Salvar".
        
        **Resultado Esperado:**
        
        O sistema deve exibir mensagens de erro informando os campos obrigatórios que precisam ser preenchidos e não deve salvar o cadastro.
        
    
    ---
    
    - **Cenário 3: Cadastro com e-mail inválido**
        
        **Passos:**
        
        1. Acessar a área de gestão de voluntários.
        2. Preencher o formulário com e-mail em formato incorreto (ex: "voluntario@semcom").
        3. Clicar em "Salvar".
        
        **Resultado Esperado:**
        
        O sistema deve exibir uma mensagem de erro indicando que o e-mail é inválido e impedir o cadastro.
        
- CT-005 - **Editar um Voluntário**
    
    **Requisito Associado**: RF-005 - O sistema deve permitir editar um voluntário
    
    **Pré-condições:**
    
    O usuário deve estar autenticado no sistema com permissão para editar voluntários. O voluntário a ser editado já deve estar previamente cadastrado no sistema.
    
    **Objetivo do teste:**
    
    Verificar se o sistema permite a edição correta dos dados de um voluntário já cadastrado, mantendo a integridade e validação das informações.
    
    **Critérios de Aceitação:**
    
    - O sistema deve permitir a atualização de qualquer campo editável do voluntário.
    - Deve haver validação dos dados editados, como campos obrigatórios e formato de e-mail.
    - O sistema deve exibir uma mensagem de sucesso ao editar com sucesso.
    - Em caso de erro ou dado inválido, o sistema deve informar o motivo e impedir a alteração.
    
    **Cenários:**
    
    - **Cenário 1: Edição bem-sucedida de um voluntário**
        
        **Passos:**
        
        1. Acessar a área de gestão de voluntários.
        2. Localizar e selecionar um voluntário existente.
        3. Clicar na opção "Editar".
        4. Alterar um ou mais campos válidos (ex: telefone e área de interesse).
        5. Clicar em "Salvar".
        
        **Resultado Esperado:**
        
        O sistema deve salvar as alterações e exibir uma mensagem de sucesso. Os novos dados devem ser refletidos na visualização do voluntário.
        
    
    ---
    
    - **Cenário 2: Edição com campos obrigatórios apagados**
        
        **Passos:**
        
        1. Acessar a área de gestão de voluntários.
        2. Selecionar um voluntário existente.
        3. Clicar na opção "Editar".
        4. Apagar um campo obrigatório (ex: nome ou e-mail).
        5. Clicar em "Salvar".
        
        **Resultado Esperado:**
        
        O sistema deve impedir a edição e exibir uma mensagem informando os campos obrigatórios que precisam ser preenchidos.
        
    
    ---
    
    - **Cenário 3: Edição com e-mail em formato inválido**
        
        **Passos:**
        
        1. Acessar a área de gestão de voluntários.
        2. Selecionar um voluntário existente.
        3. Clicar na opção "Editar".
        4. Alterar o e-mail para um formato inválido (ex: "voluntario@sem").
        5. Clicar em "Salvar".
        
        **Resultado Esperado:**
        
        O sistema deve exibir uma mensagem de erro informando que o e-mail é inválido e não deve concluir a edição.
        
- CT-006 - **Excluir um Voluntário**
    
    **Requisito Associado**: RF-006 - O sistema deve permitir a exclusão de voluntários
    
    **Pré-condições:**
    
    O usuário deve estar autenticado no sistema com permissão para excluir voluntários. Deve existir ao menos um voluntário cadastrado no sistema.
    
    **Objetivo do teste:**
    
    Verificar se o sistema permite a exclusão de voluntários de forma correta, removendo seus dados e impedindo que continuem acessando ou sendo listados.
    
    **Critérios de Aceitação:**
    
    - O sistema deve permitir excluir voluntários existentes.
    - Deve ser exibida uma confirmação antes da exclusão.
    - O voluntário excluído não deve mais aparecer nas listagens.
    - O sistema deve exibir uma mensagem de sucesso após a exclusão.
    - Caso a exclusão seja cancelada, nenhuma alteração deve ser realizada.
    
    **Cenários:**
    
    - **Cenário 1: Exclusão bem-sucedida de um voluntário**
        
        **Passos:**
        
        1. Acessar a área de gestão de voluntários.
        2. Selecionar um voluntário existente.
        3. Clicar na opção "Excluir".
        4. Confirmar a exclusão quando solicitado.
        
        **Resultado Esperado:**
        
        O voluntário deve ser removido do sistema e uma mensagem de sucesso deve ser exibida. O nome do voluntário não deve mais constar na lista.
        
    
    ---
    
    - **Cenário 2: Cancelamento da exclusão**
        
        **Passos:**
        
        1. Acessar a área de gestão de voluntários.
        2. Selecionar um voluntário existente.
        3. Clicar na opção "Excluir".
        4. Na janela de confirmação, clicar em "Cancelar".
        
        **Resultado Esperado:**
        
        Nenhuma exclusão deve ser realizada. O voluntário continua listado e acessível normalmente no sistema.
        
    
    ---
    
    - **Cenário 3: Tentativa de exclusão sem voluntário selecionado**
        
        **Passos:**
        
        1. Acessar a área de gestão de voluntários.
        2. Clicar em "Excluir" sem selecionar nenhum voluntário.
        
        **Resultado Esperado:**
        
        O sistema deve exibir uma mensagem informando que é necessário selecionar um voluntário antes de realizar a exclusão.
        
- CT-007 - **Cadastro de Evento**
    
    **Requisito Associado**: RF-007 - O sistema deve permitir o cadastro de Eventos
    
    **Pré-condições:**
    
    O usuário deve estar autenticado no sistema com permissões de administrador ou responsável por eventos.
    
    **Objetivo do teste:**
    
    Verificar se o sistema permite o cadastro de eventos com todas as informações necessárias e se armazena corretamente os dados.
    
    **Critérios de Aceitação:**
    
    - O sistema deve permitir o preenchimento de todos os campos obrigatórios do evento.
    - O sistema deve validar os dados inseridos.
    - O sistema deve confirmar a criação do evento com uma mensagem de sucesso.
    - O evento cadastrado deve estar disponível na listagem de eventos após a criação.
    
    **Cenários:**
    
    - **Cenário 1: Cadastro de evento com dados válidos**
        
        **Passos:**
        
        1. Acessar o sistema com um usuário autorizado.
        2. Navegar até a área de cadastro de eventos.
        3. Preencher os campos obrigatórios (nome, data, local, descrição, etc.).
        4. Clicar no botão "Cadastrar".
        
        **Resultado Esperado:**
        
        O sistema salva os dados e exibe uma mensagem de sucesso. O evento aparece na listagem.
        
    
    ---
    
    - **Cenário 2: Tentativa de cadastro com campos obrigatórios vazios**
        
        **Passos:**
        
        1. Acessar a tela de cadastro de eventos.
        2. Deixar um ou mais campos obrigatórios em branco.
        3. Clicar em "Cadastrar".
        
        **Resultado Esperado:**
        
        O sistema exibe mensagens de erro informando os campos obrigatórios que devem ser preenchidos.
        
    
    ---
    
    - **Cenário 3: Tentativa de cadastro com data inválida**
        
        **Passos:**
        
        1. Acessar a tela de cadastro de eventos.
        2. Preencher os campos com uma data inválida (ex: data no passado ou formato incorreto).
        3. Clicar em "Cadastrar".
        
        **Resultado Esperado:**
        
        O sistema impede o cadastro e exibe uma mensagem de erro específica sobre o campo de data.
        
- CT-008 - **Editar um Evento**
    
    **Requisito Associado**: RF-008 - O sistema deve permitir editar Eventos
    
    **Pré-condições:**
    
    O usuário deve estar autenticado e ter permissões para editar eventos. O evento a ser editado deve já estar previamente cadastrado no sistema.
    
    **Objetivo do teste:**
    
    Verificar se o sistema permite que eventos previamente cadastrados sejam editados com sucesso, atualizando corretamente as informações.
    
    **Critérios de Aceitação:**
    
    - O sistema deve permitir alterar qualquer campo do evento.
    - As alterações devem ser salvas corretamente e refletidas na visualização do evento.
    - Uma mensagem de confirmação deve ser exibida após a edição bem-sucedida.
    
    **Cenários:**
    
    - **Cenário 1: Edição bem-sucedida de um evento**
        
        **Passos:**
        
        1. Acessar o sistema com um usuário com permissões.
        2. Navegar até a lista de eventos.
        3. Selecionar um evento existente e clicar em "Editar".
        4. Alterar os campos desejados (ex: data, local, descrição).
        5. Clicar no botão "Salvar".
        
        **Resultado Esperado:**
        
        O sistema atualiza os dados e exibe uma mensagem de sucesso. As novas informações são exibidas corretamente.
        
    
    ---
    
    - **Cenário 2: Edição com campos obrigatórios vazios**
        
        **Passos:**
        
        1. Acessar a tela de edição de um evento existente.
        2. Apagar o conteúdo de um campo obrigatório (ex: nome ou data).
        3. Tentar salvar as alterações.
        
        **Resultado Esperado:**
        
        O sistema impede a edição e exibe mensagens de erro informando quais campos precisam ser preenchidos.
        
    
    ---
    
    - **Cenário 3: Edição com dados inválidos (ex: data no passado)**
        
        **Passos:**
        
        1. Acessar a tela de edição de um evento.
        2. Alterar a data do evento para uma data passada.
        3. Clicar em "Salvar".
        
        **Resultado Esperado:**
        
        O sistema exibe uma mensagem de erro informando que a data informada é inválida.
        
- CT-009 - **Excluir um Evento**
    
    **Requisito Associado**: RF-009 - O sistema deve permitir a exclusão de Eventos
    
    **Pré-condições:**
    
    O usuário deve estar autenticado e possuir permissões para excluir eventos. O evento a ser excluído deve estar previamente cadastrado no sistema.
    
    **Objetivo do teste:**
    
    Verificar se o sistema permite a exclusão de eventos e se essa exclusão é refletida corretamente na interface e nos dados persistidos.
    
    **Critérios de Aceitação:**
    
    - O sistema deve solicitar confirmação antes da exclusão do evento.
    - Após a exclusão, o evento não deve mais aparecer na lista de eventos.
    - Uma mensagem de sucesso deve ser exibida após a exclusão.
    
    **Cenários:**
    
    - **Cenário 1: Exclusão bem-sucedida de um evento**
        
        **Passos:**
        
        1. Acessar o sistema com um usuário com permissões.
        2. Navegar até a lista de eventos.
        3. Selecionar um evento existente e clicar em "Excluir".
        4. Confirmar a exclusão na janela/modal de confirmação.
        
        **Resultado Esperado:**
        
        O sistema exclui o evento, remove da lista e exibe uma mensagem de sucesso. O evento não pode mais ser acessado.
        
    
    ---
    
    - **Cenário 2: Cancelamento da exclusão após confirmação**
        
        **Passos:**
        
        1. Acessar a tela de eventos.
        2. Clicar em "Excluir" em um evento da lista.
        3. Quando solicitado, clicar em "Cancelar".
        
        **Resultado Esperado:**
        
        O evento não é excluído, permanece listado, e nenhuma alteração é feita.
        
    
    ---
    
- CT-010 - **O sistema deve permitir que os voluntários se inscrevam em eventos de seu interesse**
    
    **Requisito Associado**: RF-010 - O sistema deve permitir que os voluntários se inscrevam em eventos de seu interesse.
    
    **Pré-condições:**
    
    - O voluntário deve estar autenticado no sistema.
    - Deve haver eventos cadastrados no sistema.
    
    **Objetivo do teste:**
    
    Validar a funcionalidade de inscrição de voluntários em eventos.
    
    **Critérios de Aceitação:**
    
    - O voluntário consegue se inscrever em eventos disponíveis sem erros.
    - O sistema impede inscrições em eventos lotados.
    - O voluntário pode cancelar sua inscrição quando desejar.
    - O sistema exibe mensagens de erro claras em caso de falha.
    - Apenas usuários autenticados podem se inscrever em eventos.
    
    **Cenários**
    
    - **Cenário 1: Inscrição bem-sucedida em um evento**
        
        **Passos:**
        
        1. Acessar a lista de eventos disponíveis.
        2. Selecionar um evento de interesse.
        3. Clicar no botão "Inscrever-se".
        4. Confirmar a inscrição.
        
        **Resultado Esperado:**
        
        - O sistema deve exibir uma mensagem de sucesso.
        - O evento deve aparecer na lista de eventos inscritos do voluntário.
    - **Cenário 2: Inscrição em um evento já lotado**
        
        **Passos:**
        
        1. Acessar a lista de eventos disponíveis.
        2. Selecionar um evento que já atingiu o limite de participantes.
        3. Clicar no botão "Inscrever-se".
        
        **Resultado Esperado:**
        
        - O sistema deve exibir uma mensagem informando que o evento está lotado e não permitir a inscrição.
    - **Cenário 3: Cancelamento de inscrição em um evento**
        
        **Passos:**
        
        1. Acessar a lista de eventos inscritos.
        2. Selecionar um evento e clicar no botão "Cancelar Inscrição".
        3. Confirmar o cancelamento.
        
        **Resultado Esperado:**
        
        - O sistema deve exibir uma mensagem de sucesso.
        - O evento deve ser removido da lista de eventos inscritos do voluntário
- CT-011 - **Busca de eventos por filtros**
    
    **Requisito Associado**: RF-011 - O sistema deve possibilitar que voluntários façam busca por eventos de acordo com filtros como área de interesse, localização e data.
    
    **Pré-condições:**
    
    O usuário deve estar autenticado como voluntário e haver eventos previamente cadastrados com diferentes áreas de interesse, localizações e datas.
    
    **Objetivo do teste:**
    
    Verificar se o sistema permite que o voluntário filtre corretamente os eventos por área de interesse, status, localização e data, retornando resultados condizentes com os critérios informados.
    
    **Critérios de Aceitação:**
    
    - Os filtros devem estar visíveis e acessíveis ao voluntário.
    - O sistema deve retornar apenas os eventos que correspondem aos filtros aplicados.
    - A busca deve funcionar mesmo com a aplicação de múltiplos filtros combinados.
    - Caso não haja eventos que correspondam aos filtros, o sistema deve informar adequadamente.
    - A lista de eventos deve ser atualizada de acordo com os filtros aplicados sem necessidade de recarregar a página.
    
    **Cenários:**
    
    - **Cenário 1: Busca de eventos por área de interesse**
        
        **Passos:**
        
        1. Acessar a área de busca de eventos.
        2. Selecionar um filtro de área de interesse (ex: Meio Ambiente).
        3. Aplicar o filtro.
        
        **Resultado Esperado:**
        
        O sistema exibe somente os eventos relacionados à área de interesse selecionada.
        
    
    ---
    
    - **Cenário 2: Busca de eventos por localização**
        
        **Passos:**
        
        1. Acessar a área de busca de eventos.
        2. Informar uma cidade ou estado no campo de localização.
        3. Aplicar o filtro.
        
        **Resultado Esperado:**
        
        O sistema exibe apenas os eventos que ocorrerão na localização informada.
        
    
    ---
    
    - **Cenário 3: Busca de eventos por data**
        
        **Passos:**
        
        1. Acessar a área de busca de eventos.
        2. Informar um intervalo de datas ou uma data específica.
        3. Aplicar o filtro.
        
        **Resultado Esperado:**
        
        O sistema retorna eventos que ocorrerão dentro do período especificado.
        
    
    ---
    
    - **Cenário 4: Combinação de filtros (área de interesse + localização + data)**
        
        **Passos:**
        
        1. Selecionar uma área de interesse.
        2. Informar uma localização.
        3. Definir um intervalo de datas.
        4. Aplicar os filtros.
        
        **Resultado Esperado:**
        
        O sistema exibe somente os eventos que correspondem a todos os critérios aplicados.
        
    
    ---
    
    - **Cenário 5: Nenhum evento encontrado**
        
        **Passos:**
        
        1. Aplicar filtros com critérios muito restritivos ou sem correspondência.
        2. Executar a busca.
        
        **Resultado Esperado:**
        
        O sistema informa que nenhum evento foi encontrado com os critérios fornecidos.
        
- CT-012 - **Compartilhamento de eventos via redes sociais**
    
    R**equisito Associado**: RF-012 - O sistema deve permitir o compartilhamento de eventos em redes sociais para promover o engajamento.
    
    **Pré-condições:**
    
    O usuário deve estar autenticado no sistema e visualizar um evento válido e público na plataforma. As redes sociais (como Facebook, WhatsApp ou Instagram) devem estar disponíveis no dispositivo.
    
    **Objetivo do teste:**
    
    Verificar se o sistema oferece a funcionalidade de compartilhamento de eventos em redes sociais, e se o link compartilhado direciona corretamente para a página do evento.
    
    **Critérios de Aceitação:**
    
    - O botão de compartilhamento deve estar visível e acessível na visualização do evento.
    - Ao clicar no botão, o sistema deve apresentar as opções de redes sociais disponíveis.
    - O compartilhamento deve incluir as informações do evento (nome, data, breve descrição e link).
    - O link compartilhado deve direcionar corretamente à página do evento no sistema.
    
    **Cenários:**
    
    - **Cenário 1: Compartilhamento por cópia do link**
        
        **Passos:**
        
        1. Acessar o evento.
        2. Clicar no botão de "Copiar link" para compartilhamento manual.
        3. Colar o link em um navegador ou mensagem.
        
        **Resultado Esperado:**
        
        O link copiado deve funcionar corretamente, levando à página do evento com todas as informações visíveis.
        
    
    ---
    
- CT-013 - **Emissão de relatórios**
    
    **Requisito Associado**: RF-013 - O sistema deve permitir que as ONGs gerem relatórios mostrando o número de voluntários
    
    **Pré-condições:**
    
    A ONG deve estar cadastrada e autenticada no sistema. Deve haver voluntários cadastrados e vinculados à ONG. O módulo de relatórios deve estar disponível e funcionando.
    
    **Objetivo do teste:**
    
    Verificar se o sistema gera corretamente relatórios com o número de voluntários cadastrados por ONG, garantindo a exatidão das informações e a funcionalidade do recurso.
    
    **Critérios de Aceitação:**
    
    - A ONG deve conseguir acessar a funcionalidade de geração de relatórios.
    - O relatório deve conter o número total de voluntários vinculados à ONG.
    - O sistema deve permitir exportar o relatório em formato PDF e/ou Excel.
    - Caso a ONG não possua voluntários cadastrados, o relatório deve indicar essa condição com clareza.
    
    **Cenários:**
    
    - **Cenário 1: Geração de relatório com voluntários cadastrados**
        
        **Passos:**
        
        1. ONG acessa o sistema com login válido.
        2. Navega até a seção de relatórios.
        3. Seleciona a opção "Relatório de voluntários".
        4. Clica em "Gerar relatório".
        
        **Resultado Esperado:**
        
        O sistema gera um relatório exibindo corretamente o número total de voluntários cadastrados, com opção de exportação em PDF/Excel.
        
    
    ---
    
    - **Cenário 2: Exportação de relatório**
        
        **Passos:**
        
        1. Após gerar o relatório, a ONG clica na opção "Exportar para PDF" ou "Exportar para Excel".
        
        **Resultado Esperado:**
        
        O sistema exporta corretamente o arquivo no formato escolhido, contendo os dados apresentados na interface.
        

### Requisitos não funcionais

- CT-001 - **O sistema deve oferecer feedback visual para ações do usuário (exemplo: carregamento, sucesso, erro)**
    
    **Requisito Associado:** RNF-001 - O sistema deve oferecer feedback visual para ações do usuário (exemplo: carregamento, sucesso, erro).
    
    **Pré-condições:**
    
    - O usuário deve estar autenticado no sistema.
    - O sistema deve estar operacional e responsivo.
    
    **Objetivo do teste:**
    
    Validar se o sistema fornece feedback visual adequado para diferentes ações do usuário.
    
    **Critérios de Aceitação:**
    
    - O sistema exibe feedback visual para ações de carregamento, sucesso e erro.
    - O feedback visual deve ser claro e perceptível.
    - O feedback desaparece de forma apropriada após um tempo ou interação do usuário.
    
    **Cenários:** 
    
    - Cenário 1: Indicação de Carregamento
        
        **Passos:**
        
        1. O usuário realiza uma ação que requer processamento (exemplo: envio de um formulário).
        2. O sistema deve exibir um indicador de carregamento (exemplo: spinner, barra de progresso).
        3. O sistema conclui o processamento.
        
        **Resultado Esperado:**
        
        - O indicador de carregamento é exibido corretamente durante o processamento.
        - O indicador desaparece quando a ação é concluída.
    - Cenário 2: Confirmação de Sucesso
        
        **Passos:**
        
        1. O usuário conclui uma ação bem-sucedida (exemplo: salvar um formulário).
        2. O sistema exibe uma mensagem de sucesso (exemplo: “Salvo com sucesso”).
        
        **Resultado Esperado:**
        
        - A mensagem de sucesso deve ser visível e clara.
        - O feedback visual desaparece após um tempo ou quando o usuário interage com ele.
    - Cenário 3: Exibição de Erro
        
        **Passos:**
        
        1. O usuário tenta realizar uma ação inválida (exemplo: enviar um formulário sem preencher um campo obrigatório).
        2. O sistema exibe um feedback visual de erro (exemplo: borda vermelha no campo, mensagem de erro).
        
        **Resultado Esperado:**
        
        - O erro é claramente indicado ao usuário.
        - A mensagem deve explicar como corrigir o erro.
- CT-002 - **Acessibilidade do sistema**
    
    **Requisito Associado**: RNF-002 - O sistema deve ser acessível, com textos alternativos para imagens, contrastes de cores adequados e navegação por teclado.
    
    **Pré-condições:**
    
    O sistema deve estar em funcionamento e acessível por um navegador web atualizado. O avaliador deve ter acesso às ferramentas de acessibilidade, como leitores de tela, e inspeção de contraste de cores. Navegação por teclado deve estar habilitada.
    
    **Objetivo do teste:**
    
    Garantir que a aplicação siga os padrões de acessibilidade, oferecendo suporte a usuários com deficiências visuais ou motoras, através de textos alternativos em imagens, bom contraste de cores e possibilidade de navegação por teclado.
    
    **Critérios de Aceitação:**
    
    - Todas as imagens devem conter atributos `alt` com descrições relevantes.
    - O contraste de cores entre texto e fundo deve obedecer aos padrões WCAG (nível AA ou superior).
    - Todos os elementos interativos devem ser acessíveis por teclado (tab, enter, setas).
    - O foco visual deve ser claramente visível ao navegar por teclado.
    - Elementos importantes não devem depender exclusivamente do uso do mouse.
    
    ---
    
    ### **Cenários:**
    
    - **Cenário 1: Verificação de textos alternativos em imagens**
        
        **Passos:**
        
        1. Acessar a página inicial do sistema.
        2. Inspecionar todas as imagens visíveis.
        3. Verificar se todas possuem o atributo `alt` com descrição adequada.
        4. Utilizar um leitor de tela para confirmar a leitura dos textos alternativos.
        
        **Resultado Esperado:**
        
        Todas as imagens relevantes possuem descrições alternativas adequadas e compreensíveis pelo leitor de tela.
        
    
    ---
    
    - **Cenário 2: Verificação de contraste de cores**
        
        **Passos:**
        
        1. Acessar diferentes páginas do sistema (cadastro, login, eventos, etc).
        2. Usar uma ferramenta de verificação de contraste (como o plugin WAVE ou o Color Contrast Analyzer).
        3. Comparar os contrastes de texto e fundo com os padrões WCAG.
        
        **Resultado Esperado:**
        
        O contraste entre texto e fundo é suficiente (mínimo 4.5:1 para textos normais e 3:1 para textos grandes), garantindo legibilidade.
        
    
    ---
    
    - **Cenário 3: Navegação por teclado**
        
        **Passos:**
        
        1. Abrir qualquer página do sistema.
        2. Utilizar apenas o teclado (Tab, Shift+Tab, Enter, setas) para navegar entre os elementos interativos.
        3. Verificar se é possível acessar todos os botões, campos e links.
        4. Observar se o foco é visível em todos os elementos focados.
        
        **Resultado Esperado:**
        
        O usuário consegue navegar por todo o sistema utilizando apenas o teclado, com foco visível e funcionalidade completa.
        
- CT-003 - **Interface responsiva**
    
    **Requisito Associado:** RNF-003 - A aplicação deve ter uma interface responsiva para diferentes tamanhos de tela.
    
    **Pré-condições:**
    
    - O sistema deve estar implantado e acessível via internet.
    - O dispositivo de teste deve estar conectado à internet.
    - As principais funcionalidades devem estar implementadas.
    
    **Objetivo do teste:**
    
    Validar se a interface do sistema se adapta corretamente a diferentes tamanhos de tela, garantindo uma experiência de uso adequada em cada dispositivo.
    
    **Critérios de Aceitação:**
    
    - A interface deve ser responsiva e adaptar-se corretamente a telas grandes e pequenas.
    - O sistema deve permanecer usável e organizado em diferentes resoluções.
    - A experiência do usuário não deve ser comprometida por problemas de layout.
    
    **Cenários:**
    
    - Cenário 1: Teste em Diferentes Resoluções de Tela (Desktop, Tablet e Mobile)
        
        **Passos:**
        
        1. Acessar o sistema em um computador (resolução Full HD ou superior).
        2. Acessar o sistema em um tablet (resolução entre 768px e 1024px).
        3. Acessar o sistema em um smartphone (resolução menor que 768px).
        4. Verificar se os elementos da interface se ajustam corretamente em cada caso.
        
        **Resultado Esperado:**
        
        - O layout deve ser adaptável, sem quebras ou sobreposição de elementos.
        - O conteúdo deve ser reorganizado conforme o tamanho da tela.
        - A experiência do usuário deve ser fluida e intuitiva em todas as resoluções.
    - Cenário 2: Teste de Redimensionamento do Navegador
        
        **Passos:**
        
        1. Abrir o sistema em um navegador desktop.
        2. Redimensionar a janela do navegador para tamanhos diferentes (maior, menor, estreito, largo).
        3. Observar se os elementos da interface se ajustam corretamente.
        
        **Resultado Esperado:**
        
        - Os elementos da interface devem ser reposicionados conforme necessário.
        - O sistema deve manter a usabilidade sem exigir rolagem excessiva ou zoom manual.
    - Cenário 3: Teste de Usabilidade em Dispositivos Móveis
        
        **Passos:**
        
        1. Acessar o sistema via smartphone.
        2. Verificar se os menus, botões e formulários são facilmente utilizáveis por toque.
        
        **Resultado Esperado:**
        
        - Botões e menus devem estar acessíveis e fáceis de clicar.
        - O usuário não deve precisar ampliar a tela para utilizar funcionalidades básicas.
- CT-004 - **O sistema deve ser implementado na linguagem C#**
    
    **Requisito Associado**: RF-004 - O sistema deve ser implementado na linguagem C#.
    
    **Pré-condições:**
    
    - O ambiente de desenvolvimento deve estar configurado corretamente com suporte para C#.
    - O repositório de código-fonte deve conter arquivos desenvolvidos em C#.
    - As ferramentas de compilação e execução devem estar instaladas.
    
    **Objetivo do teste:**
    
    Garantir que o sistema seja desenvolvido e executado integralmente na linguagem C#.
    
    - **Cenário 1: Verificação da linguagem de implementação**
        - **Passos:**
            1. Acessar o repositório de código-fonte.
            2. Verificar se os arquivos principais estão escritos em C# (.cs).
            3. Identificar a presença de arquivos de projeto compatíveis com .NET (exemplo: .csproj).
            
            **Resultado Esperado:**
            
            - O repositório deve conter apenas arquivos de implementação em C#.
            - O projeto deve possuir arquivos de configuração e dependências do .NET.
    - **Cenário 2: Compilação e execução do sistema**
        
        **Passos:**
        
        1. Abrir o projeto em um ambiente de desenvolvimento compatível (exemplo: Visual Studio, JetBrains Rider, VS Code com extensão C#).
        2. Realizar a compilação do código-fonte.
        3. Executar o sistema.
        
        **Resultado Esperado:**
        
        - O sistema deve compilar sem erros.
        - O sistema deve ser executado corretamente.
    - **Cenário 3: Teste de integração com funcionalidades específicas do C#**
        
        **Passos:**
        
        1. Avaliar se o sistema utiliza recursos nativos do C#, como LINQ, Entity Framework e ASP.NET (se aplicável).
        2. Testar funcionalidades que dependam desses recursos.
        
        **Resultado Esperado:**
        
        - O sistema deve apresentar compatibilidade com as bibliotecas e recursos do C#.
        - As funcionalidades devem operar corretamente sem erros de compatibilidade.
    
    **Critérios de Aceitação:**
    
    - Todo o código-fonte principal deve estar escrito em C#.
    - O sistema deve ser compilado e executado com sucesso em um ambiente .NET.
    - Não devem existir dependências de outras linguagens para a implementação principal.
    - O sistema deve fazer uso adequado dos recursos da linguagem C#.
- CT-005 - **Interface Intuitiva**
    
    **Requisito Associado**: RNF-005 - O sistema deve ter uma interface intuitiva e fácil de usar, sem necessidade de treinamentos complexos.
    
    **Pré-condições:**
    
    O sistema deve estar disponível em ambiente de teste. O usuário deve ter acesso a um navegador atualizado e não pode ter recebido treinamento prévio sobre o uso da aplicação.
    
    **Objetivo do teste:**
    
    Avaliar se a interface permite que novos usuários compreendam facilmente o funcionamento do sistema e realizem tarefas básicas sem ajuda externa ou documentação.
    
    **Critérios de Aceitação:**
    
    - O usuário consegue realizar tarefas principais (ex: cadastro de ONG, busca de eventos, etc) sem instruções adicionais.
    - Os ícones, rótulos e botões são claros e autodescritivos.
    - O fluxo de navegação é natural e consistente entre as telas.
    - As mensagens de erro e confirmação são compreensíveis e ajudam o usuário a corrigir ações.
    
    ---
    
    ### **Cenários:**
    
    - **Cenário 1: Cadastro de uma ONG por novo usuário**
        
        **Passos:**
        
        1. Um usuário sem familiaridade prévia acessa o sistema.
        2. Ele tenta localizar e utilizar a funcionalidade de cadastro de ONG.
        3. O usuário preenche o formulário e submete o cadastro.
        4. Caso ocorra algum erro, o usuário deve conseguir interpretá-lo e corrigir.
        
        **Resultado Esperado:**
        
        O usuário consegue realizar o cadastro de uma ONG sem ajuda externa, interpretando corretamente os elementos da interface e eventuais mensagens de erro.
        
    
    ---
    
    - **Cenário 2: Navegação entre páginas principais**
        
        **Passos:**
        
        1. Um usuário acessa a página inicial do sistema.
        2. Ele tenta navegar entre as seções como "Eventos", "Voluntários", "ONGs", "Perfil", etc.
        3. Observa se há consistência nos menus, cabeçalhos e botões.
        
        **Resultado Esperado:**
        
        O usuário consegue se localizar e acessar as principais áreas do sistema com facilidade, sem se perder ou precisar de ajuda.
        
    
    ---
    
    - **Cenário 3: Interpretação de mensagens do sistema**
        
        **Passos:**
        
        1. O usuário tenta cadastrar uma ONG deixando campos obrigatórios em branco.
        2. Observa a mensagem de erro exibida.
        3. Com base na mensagem, ele preenche os campos corretamente e submete novamente.
        
        **Resultado Esperado:**
        
        A mensagem de erro é clara, objetiva e ajuda o usuário a entender o problema e corrigi-lo sem frustração.
        
- CT-006 - **O sistema deve ter um código que siga padrões de qualidade e boas práticas para facilitar manutenção e expansão**
    - **Requisito Associado**: RNF-006 - O sistema deve ter um código que siga padrões de qualidade e boas práticas para facilitar manutenção e expansão.
        
        **Pré-condições:**
        
        O repositório do código-fonte deve estar disponível para análise. 
        
        **Objetivo do teste:**
        
        Verificar se o código-fonte do sistema está estruturado conforme boas práticas de desenvolvimento de software, incluindo legibilidade, organização, modularização, nomenclatura adequada e ausência de código duplicado ou desnecessário.
        
        **Critérios de Aceitação:**
        
        - O código está devidamente comentado quando necessário.
        - O sistema segue um padrão de arquitetura definido (MVC).
        - Há separação de responsabilidades entre os módulos.
        - O código é reutilizável e de fácil manutenção.
        - Não há trechos comentados ou código morto no repositório principal.
    
    ---
    
    ### **Cenários:**
    
    - **Cenário 1: Verificação de nomenclatura e organização**
        
        **Passos:**
        
        1. Acessar os arquivos de código-fonte.
        2. Verificar se nomes de variáveis, funções, classes e arquivos seguem o padrão definido pela equipe.
        3. Validar a estrutura de diretórios e separação por responsabilidade.
        
        **Resultado Esperado:**
        
        O código está organizado em módulos coerentes, com nomes claros e sem ambiguidade, seguindo uma convenção consistente.
        
    
    ---
    
    - **Cenário 2: Reutilização e modularização**
        
        **Passos:**
        
        1. Identificar funcionalidades semelhantes implementadas em diferentes partes do sistema.
        2. Verificar se há duplicação de lógica.
        
        **Resultado Esperado:**
        
        O sistema evita duplicação e promove a reutilização de código através de módulos reutilizáveis e bem definidos.
        
    
    ---
    
    - **Cenário 3: Ausência de código morto ou comentado**
        
        **Passos:**
        
        1. Revisar o código procurando trechos comentados ou blocos de código obsoletos.
        2. Validar com a equipe se esses trechos ainda têm uso futuro ou podem ser removidos.
        
        **Resultado Esperado:**
        
        O código de produção não contém trechos comentados desnecessariamente ou código que não está mais em uso.
        
- CT-007 - **O sistema deve utilizar HTTPS para segurança**
    
    **Requisito Associado**: RNF-007 - O sistema deve utilizar HTTPS para segurança.
    
    **Pré-condições:**
    
    O sistema deve estar implantado em um ambiente acessível via navegador. Deve possuir um certificado SSL/TLS válido e corretamente configurado.
    
    **Objetivo do teste:**
    
    Garantir que todas as comunicações entre o cliente e o servidor utilizem o protocolo HTTPS, protegendo os dados contra interceptações e garantindo a integridade e confidencialidade da informação.
    
    **Critérios de Aceitação:**
    
    - Todas as requisições devem utilizar HTTPS.
    - O certificado SSL deve ser válido e emitido por uma autoridade confiável.
    - Navegadores não devem exibir alertas de segurança ao acessar o sistema.
    - Requisições feitas via HTTP devem ser redirecionadas automaticamente para HTTPS.
    
    ---
    
    ### **Cenários:**
    
    - **Cenário 1: Acesso à aplicação via HTTPS**
        
        **Passos:**
        
        1. Abrir um navegador.
        2. Digitar a URL da aplicação iniciando com `https://`.
        3. Observar se a conexão é segura (ícone de cadeado).
        4. Verificar os detalhes do certificado digital.
        
        **Resultado Esperado:**
        
        A aplicação é carregada corretamente, o navegador exibe o ícone de conexão segura e o certificado está válido e emitido por uma autoridade reconhecida.
        
    
    ---
    
    - **Cenário 2: Redirecionamento de HTTP para HTTPS**
        
        **Passos:**
        
        1. Acessar a aplicação digitando a URL com `http://`.
        2. Observar se há redirecionamento automático para `https://`.
        
        **Resultado Esperado:**
        
        O sistema redireciona automaticamente o usuário de HTTP para HTTPS, garantindo a navegação segura.
        
    
    ---
    
    - **Cenário 3: Inspeção de requisições da aplicação**
        
        **Passos:**
        
        1. Acessar a aplicação normalmente via navegador.
        2. Abrir as ferramentas de desenvolvedor (F12) e acessar a aba "Network".
        3. Realizar ações como login ou cadastro.
        4. Verificar se todas as requisições utilizam o protocolo HTTPS.
        
        **Resultado Esperado:**
        
        Todas as requisições (inclusive as de APIs, recursos estáticos e formulários) são feitas utilizando o protocolo HTTPS.
