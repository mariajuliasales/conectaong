# Metodologia

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Documentação de Contexto e Especificação do Projeto</a></span>

Para este projeto, utilizaremos a metodologia scrum para gerenciamento. O intuito é facilitar a gestão das atividades dos colaboradores, implementar ou remover requisitos de forma dinâmica e manter uma melhoria contínua do software como um todo.

## Controle de Versão

A ferramenta de controle de versão adotada no projeto foi o
[Git](https://git-scm.com/), sendo que o [Github](https://github.com)
foi utilizado para hospedagem do repositório.

O projeto utiliza o Github Flow pela simplicidade e facilidade em desenvolver novas features de forma contínua.

- `main`: versão estável que reflete o código em produção.
- `feature ou fix` – Branches criadas pelos desenvolvedores a partir de main e mescladas via Pull Requests.

O fluxo segue da seguinte maneira: `feature → PR → main`

O `Pull Request(PR)` deverá ser analisado cautelosamente e `aprovado ou reprovado` em sequência.
Qualquer um dos colaboradores está apto a realizar este tipo de validação.

Quanto à gerência de issues, o projeto adota a seguinte convenção para
etiquetas:

- `bug`: uma funcionalidade encontra-se com problemas
- `test`: tarefas a serem testadas
- `documentation`: melhorias ou acréscimos à documentação
- `infraestructure`: tarefas relacionadas a infra
- `design`: tarefas que se relacionam a desenvolvimento de interfaces, wireframes, etc
- `enhancement`: uma funcionalidade precisa ser melhorada
- `feature`: uma nova funcionalidade precisa ser introduzida
- `development`: tarefas relacionadas ao desenvolvimento de software
- `priority: high/medium/low`: define prioridade para a demanda

Para padronização de commits, seguiremos a seguinte estrutura:

- `feat`: adições de novas funcionalidades ou de quaisquer outras novas implantações ao código.
- `chore`: atualização de tarefas que não ocasionam alteração no código de produção, mas mudanças de ferramentas, mudanças de configuração e bibliotecas.
- `fix`: correções de bugs ou erros em geral
- `refactor`: tilizado em quaisquer mudanças que sejam executados no código, porém não alterem a funcionalidade final da tarefa impactada
- `test`: adicionando testes ausentes ou corrigindo testes existentes nos processos de testes automatizados
- `docs`: inclusão ou alteração somente de arquivos de documentação

## Gerenciamento de Projeto

### Divisão de Papéis

Após alinhamento da equipe, ficou definido a seguinte estrutura:

- <strong>Scrum Master</strong>: Guilherme de Andrade
- <strong>Product Owner</strong>: Eric Esteves
- <strong>Equipe de Desenvolvimento</strong>: Amanda Vitor, Bruna Bricio, Eric Esteves, Frederico Furtado, Maria Julia e Guilherme de Andrade
- <strong>Equipe de Design</strong>: Bruna Bricio

### Processo

Realizaremos <strong>Daily's (Daily scrum)</strong> para a distribuição e organização das tarefas. O time está utilizando o `Github Projects` que possui um quadro Kanban. As reuniões diárias tem duração de no <strong>máximo 15 minutos</strong> e devem ser o mais objetivas possíveis. Detalhando o que foi feito, o que será feito e se existe alguma dificuldade em que o `scrum master` possa ajudar para viabilizar a entrega das tarefas.

As reuniões acontecem todas as quartas, às 20:30. Podendo haver reuniões em casos específicos aos finais de semana, aos domingos as 16:00.

### Ferramentas

As ferramentas empregadas no projeto são:

- <strong>Editor de código</strong>: Visual Studio Community
- <strong>Ferramentas de comunicação</strong>: Whatsapp e Teams
- <strong>Ferramentas de desenho de tela</strong>: Figma

O editor de código <strong>Visual Studio Community</strong> foi selecionado por ter suporte completo ao ambiente .net e por ser uma IDE gratuita para uso.
Para comunicação, foram selecionadas ferramentas que são bastante utilizadas no mercado atualmente, como o <strong>Whatsapp e Teams</strong>.
Por fim, o <strong>Figma</strong> foi selecionado por ter funcionalidades como: colaborações em tempo real, recursos avançados de design e gratuito para pequenas equipes e projetos.

### Backlog e Plano de Sprints

Abaixo, podemos observar a divisão de sprints relacionados ao projeto.
Para este caso, as sprints foram configuradas de acordo com as datas de início e data de entrega das etapas correspondentes.

![image](https://github.com/user-attachments/assets/5c990ced-7fe1-4b75-a0cf-ee62f5be6b75)

Sobre o backlog, configuramos da seguinte maneira: para cada tarefa a ser desenvolvida, deve-se criar um draft no github projects e categorizá-lo corretamente, informando também em qual sprint ele pertence.

![image](https://github.com/user-attachments/assets/df922758-6bed-4d70-b476-f9a1573158aa)

### Tabela de ferramentas

| FERRAMENTAS                 | PLATAFORMA      | LINK                                                                                              |
| --------------------------- | --------------- | ------------------------------------------------------------------------------------------------- |
| Repositório de código fonte | GitHub          | https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2025-1-e2-proj-int-t1-conectaong                |
| Documentos do projeto       | GitHub          | https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2025-1-e2-proj-int-t1-conectaong/tree/main/docs |
| Projeto de Interface        | Figma           | https://www.figma.com/design/ciYST6HKH0QDj7jo5Ltsbg/Untitled?node-id=0-1&p=f&t=7Z5AVvqUT6cpApda-0 |
| Gerenciamento do Projeto    | GitHub Projects | https://github.com/orgs/ICEI-PUC-Minas-PMV-ADS/projects/1824/views/1                              |
| Hospedagem                  | GitHub Pages    | TBD                                                                                               |
| Visual Studio Code          | Microsoft       | https://code.visualstudio.com/Download                                                            |
| Visual Studio Community     | Microsoft       | https://visualstudio.microsoft.com/pt-br/vs/community/                                            |
| Whatsapp                    | Meta            | https://www.whatsapp.com/download?lang=pt_BR/                                                     |
| Teams                       | Microsoft       | https://www.microsoft.com/pt-br/microsoft-teams/download-app/                                     |
