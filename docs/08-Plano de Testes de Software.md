### Caso de teste - Requisitos funcionais

- CT-001 - **Cadastro, Edição e Exclusão de ONGs**
    
    **Requisito Associado**: RF-001 - O sistema deve permitir o cadastro, edição e exclusão de ONGs
    
    **Pré-condições:**
    
    - O usuário deve estar autenticado no sistema com permissões adequadas.
    - O sistema deve estar funcionando em sua plenitude.
    
    **Objetivo do teste:**
    
    Validar as funcionalidades de cadastro, edição e exclusão de ONGs
    
    **Critérios de Aceitação:**
    
    - O usuário consegue cadastrar, editar e excluir ONGs sem erros.
    - O sistema impede o cadastro de ONGs sem preencher os campos obrigatórios.
    - O sistema exibe mensagens de erro claras em caso de falha.
    - Apenas usuários autorizados podem realizar essas ações.
    
    **Cenários:**
    
    - **Cenário 1: Cadastro de uma ONG**
        
        **Passos:**
        
        1. Acessar a tela de cadastro de ONGs.
        2. Preencher os campos obrigatórios (Nome, CNPJ, Endereço, Contato, etc.).
        3. Clicar no botão "Salvar".
        
        **Resultado Esperado:**
        
        - O sistema deve exibir uma mensagem de sucesso.
        - A ONG cadastrada deve ser exibida na lista de ONGs.
    - **Cenário 2: Edição de uma ONG**
        
        **Passos:**
        
        1. Acessar a lista de ONGs cadastradas.
        2. Selecionar uma ONG para edição.
        3. Modificar algum dos campos (exemplo: telefone de contato).
        4. Clicar no botão "Salvar".
        
        **Resultado Esperado:**
        
        - O sistema deve exibir uma mensagem de sucesso.
        - As alterações devem ser refletidas na listagem de ONGs.
    - **Cenário 3: Exclusão de uma ONG**
        
        **Passos:**
        
        1. Acessar a lista de ONGs cadastradas.
        2. Selecionar uma ONG para exclusão.
        3. Clicar no botão "Excluir".
        4. Confirmar a exclusão.
        
        **Resultado Esperado:**
        
        - O sistema deve exibir uma mensagem de confirmação.
        - A ONG deve ser removida da listagem de ONGs.
    
- CT-002 - **Cadastro, Edição e Exclusão de Voluntários**
    
    **Requisito Associado**: RF-002 - O sistema deve permitir o cadastro, edição e exclusão de voluntários.
    
    **Pré-condições:**
    
    - O usuário deve estar autenticado no sistema com permissões adequadas.
    - O sistema deve estar funcionando corretamente.
    
    **Objetivo do teste:**
    
    Validar as funcionalidades de cadastro, edição e exclusão de voluntários.
    
    **Critérios de Aceitação:**
    
    - O usuário consegue cadastrar, editar e excluir voluntários sem erros.
    - O sistema impede o cadastro de voluntários sem preencher os campos obrigatórios.
    - O sistema exibe mensagens de erro claras em caso de falha.
    - Apenas usuários autorizados podem realizar essas ações.
    
    **Cenários**
    
    - **Cenário 1: Cadastro de um voluntário**
        
        **Passos:**
        
        1. Acessar a tela de cadastro de voluntários.
        2. Preencher os campos obrigatórios (Nome, CPF, Contato, Endereço, Disponibilidade, etc.).
        3. Clicar no botão "Salvar".
    - **Cenário 2: Edição de um voluntário**
        
        **Passos:**
        
        1. Acessar a lista de voluntários cadastrados.
        2. Selecionar um voluntário para edição.
        3. Modificar algum dos campos (exemplo: telefone de contato).
        4. Clicar no botão "Salvar".
        
        **Resultado Esperado:**
        
        - O sistema deve exibir uma mensagem de sucesso.
        - As alterações devem ser refletidas na listagem de voluntários.
    - **Cenário 3: Exclusão de um voluntário**
        
        **Passos:**
        
        1. Acessar a lista de voluntários cadastrados.
        2. Selecionar um voluntário para exclusão.
        3. Clicar no botão "Excluir".
        4. Confirmar a exclusão.
        
        **Resultado Esperado:**
        
        - O sistema deve exibir uma mensagem de confirmação.
        - O voluntário deve ser removido da listagem de voluntários.
- CT-003 - **Criação, Edição e Exclusão de Eventos pelas ONGs**
    
    **Requisito Associado**: RF-003 - O sistema deve permitir a criação, edição e exclusão de eventos pelas ONGs, podendo definir data, horário, local e descrição de cada evento.
    
    **Pré-condições:**
    
    - O usuário deve estar autenticado no sistema com permissões adequadas.
    - O sistema deve estar funcionando corretamente.
    
    **Objetivo do teste:**
    
    Validar as funcionalidades de criação, edição e exclusão de eventos pelas ONGs.
    
    - **Critérios de Aceitação:**
        - O usuário consegue criar, editar e excluir eventos sem erros.
        - O sistema impede o cadastro de eventos sem preencher os campos obrigatórios.
        - O sistema exibe mensagens de erro claras em caso de falha.
        - Apenas usuários autorizados podem realizar essas ações.
    
    **Cenários**
    
    - **Cenário 1: Criação de um evento**
        
        **Passos:**
        
        1. Acessar a tela de criação de eventos.
        2. Preencher os campos obrigatórios (Nome do evento, Data, Horário, Local, Descrição).
        3. Clicar no botão "Salvar".
        
        **Resultado Esperado:**
        
        - O sistema deve exibir uma mensagem de sucesso.
        - O evento criado deve ser exibido na lista de eventos.
    - **Cenário 2: Edição de um evento**
        
        **Passos:**
        
        1. Acessar a lista de eventos cadastrados.
        2. Selecionar um evento para edição.
        3. Modificar algum dos campos (exemplo: local do evento).
        4. Clicar no botão "Salvar".
    - **Cenário 3: Exclusão de um evento**
        
        **Passos:**
        
        1. Acessar a lista de eventos cadastrados.
        2. Selecionar um evento para exclusão.
        3. Clicar no botão "Excluir".
        4. Confirmar a exclusão.
        
        **Resultado Esperado:**
        
        - O sistema deve exibir uma mensagem de confirmação.
        - O evento deve ser removido da listagem de eventos.
- CT-004 - O sistema deve permitir que os voluntários se inscrevam em eventos de seu interesse
    
    **Requisito Associado**: RF-004 - O sistema deve permitir que os voluntários se inscrevam em eventos de seu interesse.
    
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
- CT-005 - O sistema deve permitir login com autenticação segura
    
    **Requisito Associado**: RF-005 - O sistema deve permitir login com autenticação segura.
    
    **Pré-condições:**
    
    - O usuário deve estar registrado no sistema.
    - O sistema deve estar operante e conectado ao banco de dados.
    
    **Objetivo do teste:**
    Validar o funcionamento do login com autenticação segura.
    
    **Critérios de Aceitação:**
    
    - O login deve ser realizado apenas com credenciais corretas.
    - O sistema deve proteger contra ataques de força bruta e exibir mensagens adequadas.
    - As senhas devem ser armazenadas de forma segura utilizando hashing.
    
    **Cenários**
    
    - **Cenário 1: Login com credenciais corretas**
        
        **Passos:**
        
        1. Acessar a página de login.
        2. Inserir um e-mail e senha válidos.
        3. Clicar no botão "Entrar".
        
        **Resultado Esperado:**
        
        - O sistema deve autenticar o usuário com sucesso.
        - O usuário deve ser redirecionado para a página inicial do sistema.
    - **Cenário 2: Login com credenciais incorretas**
        
        **Passos:**
        
        1. Acessar a página de login.
        2. Inserir um e-mail ou senha inválidos.
        3. Clicar no botão "Entrar".
        
        **Resultado Esperado:**
        
        - O sistema deve exibir uma mensagem de erro informando que as credenciais são inválidas.
        - O usuário não deve ser autenticado.
- CT-006 - Avaliação de Eventos pelos Voluntários
    
    **Requisito Associado:** RF-006 - O sistema deve permitir que os voluntários avaliem os eventos, fornecendo feedback sobre a experiência.
    
    **Pré-condições:**
    
    - O voluntário deve estar autenticado no sistema.
    - O evento avaliado deve ter sido finalizado.
    - O voluntário deve ter participado do evento.
    
    **Objetivo do Teste:**
    
    Validar a funcionalidade de avaliação de eventos pelos voluntários.
    
    **Critérios de Aceitação:**
    
    - O voluntário pode avaliar apenas eventos que participou.
    - O sistema impede o envio de avaliações sem informações obrigatórias.
    - As avaliações ficam acessíveis aos organizadores dos eventos.
    - O sistema exibe mensagens de erro e sucesso conforme o resultado das ações do usuário.
    
    **Cenários**
    
    - **Cenário 1: Avaliação bem-sucedida de um evento**
        
        **Passos:**
        
        1. O voluntário acessa a página de histórico de eventos.
        2. Seleciona um evento que participou.
        3. Insere uma nota e/ou comentário sobre o evento.
        4. Clica no botão "Enviar Avaliação".
        
        **Resultado Esperado:**
        
        - O sistema exibe uma mensagem de sucesso.
        - A avaliação fica registrada no banco de dados.
        - A avaliação pode ser visualizada pelos organizadores do evento.
    - **Cenário 2: Tentativa de avaliar um evento sem participar**
        
        **Passos:**
        
        1. O voluntário acessa a página de histórico de eventos.
        2. Seleciona um evento em que não participou.
        3. Tenta inserir uma avaliação e enviar.
        
        **Resultado Esperado:**
        
        - O sistema exibe uma mensagem de erro informando que apenas participantes podem avaliar o evento.
        - Nenhuma avaliação é registrada.
    - **Cenário 3: Avaliação sem preenchimento dos campos obrigatórios**
        
        **Passos:**
        
        1. O voluntário acessa a página de histórico de eventos.
        2. Seleciona um evento em que participou.
        3. Tenta enviar a avaliação sem preencher nenhum campo.
        
        **Resultado Esperado:**
        
        - O sistema exibe uma mensagem de erro informando que é necessário fornecer uma nota e/ou comentário.
        - Nenhuma avaliação é registrada.

### Caso de teste - Requisitos não funcionais

- CT-001 -  O sistema deve oferecer feedback visual para ações do usuário
    
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
- CT-002 - Acessibilidade em navegadores web e dispositivos móveis
    
    **Requisito Associado:** RNF-002 - O sistema deve ser acessível em navegadores web e dispositivos móveis.
    
    **Pré-condições:**
    
    - O sistema deve estar implantado e acessível via internet.
    - O usuário deve ter um navegador compatível instalado.
    - O dispositivo deve estar conectado à internet.
    
    **Objetivo do teste:**
    
    Validar se o sistema pode ser acessado e utilizado corretamente em diferentes navegadores e dispositivos móveis.
    
    **Critérios de Aceitação:**
    
    - O sistema deve ser acessível nos navegadores mais comuns (Chrome, Firefox, Edge, Safari).
    - O sistema deve ser responsivo e funcional em dispositivos móveis.
    - Nenhuma funcionalidade crítica deve ser comprometida pelo tipo de navegador ou dispositivo.
    
    **Cenários:**
    
    - Cenário 1: Acesso via Navegadores Web
        
        **Passos:**
        
        1. Abrir o sistema em diferentes navegadores (Chrome, Firefox, Edge, Safari).
        2. Navegar pelas principais funcionalidades do sistema.
        
        **Resultado Esperado:**
        
        - O sistema carrega corretamente em todos os navegadores testados.
        - Nenhum erro crítico de interface ou funcionalidade ocorre em navegadores compatíveis.
    - Cenário 2: Acesso via Dispositivos Móveis
        
        **Passos:**
        
        1. Abrir o sistema em um smartphone e um tablet (Android e iOS).
        2. Testar a navegação e as funcionalidades principais.
        
        **Resultado Esperado:**
        
        - O sistema deve ser responsivo e ajustar-se corretamente ao tamanho da tela.
        - Os botões e elementos interativos devem ser utilizáveis sem dificuldades.
    - Cenário 3: Compatibilidade com diferentes resoluções
        
        **Passos:**
        
        1. Redimensionar a janela do navegador para diferentes larguras de tela.
        2. Verificar se o layout e os elementos se adaptam corretamente.
        
        **Resultado Esperado:**
        
        - O layout do sistema deve permanecer funcional e organizado em diferentes resoluções.
        - Nenhum elemento essencial deve ficar inacessível ou desconfigurado.
- CT-003 - Interface Responsiva para diferentes tamanhos de tela
    
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
- CT-004 - Implementação linguagem C#
    
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
