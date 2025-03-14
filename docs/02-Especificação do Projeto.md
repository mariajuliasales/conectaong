# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas
### Persona 01
![Persona Mariana](https://github.com/user-attachments/assets/7bd4b7b6-1678-4536-9b98-0a6597631a23)

### Persona 02
![Persona Carlos](https://github.com/user-attachments/assets/302989eb-def9-4c40-889e-2c863c7aed16)

### Persona 03 
![Persona Ricardo](https://github.com/user-attachments/assets/9d91a38f-1e24-46f7-8f38-27600235bc91)

### Persona 04 
![Persona Roberto](https://github.com/user-attachments/assets/d900eebd-814f-437c-9859-1ee989aeca29)

### Persona 05 
![Persona Idalina](https://github.com/user-attachments/assets/23ac42d3-f8c0-4934-8225-2ab327412175)

As imagens de perfil das personas foram criadas usando o site [https://this-person-does-not-exist.com/pt](https://this-person-does-not-exist.com/pt)

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
| Mariana  | Encontrar projetos confiáveis e bem organizados de voluntariado | Participar de ações sem perder tempo com buscas difíceis e evitar experiências negativas |
| Mariana | Ter acesso a informações claras sobre datas, horários e programação| Conseguir organizar sua rotina e participar sem imprevistos |
| Carlos | Encontrar projetos de voluntariado próximos à minha cidade | Atuar em mais projetos sociais e ajudar mais pessoas |
| Carlos | Conhecer outras pessoas engajadas em causas sociais | Trocar experiências|
| Ricardo | Encontrar professores voluntários dispostos a ajudar | Garantir a continuidade da ONG|
| Ricardo | Aumentar a visibilidade da ONG | Atrair mais voluntários |
| Roberto | Ter uma plataforma para divulgar os eventos realizado pela ONG| Aumentar a participação das pessoas |
| Roberto | Gerar relatórios sobre cada evento da ONG | Melhorar a transparência da ONG |
| Idalina | Recrutar voluntários comprometidos e interessados em causas ambientais | Ter apoio de pessoas realmente comprometidas com a causa |
| Idalina | Ter um canal eficiente de comunicação com os voluntários | Garantir a permanência em ações de longo prazo |

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| A aplicação deve permitir que o usuário avalie uma agência de intercâmbio com base na sua experiência| ALTA | 
|RF-002| A aplicação deve permitir que o usuário inclua comentários ao fazer uma avaliação de uma agência de intercâmbio    | ALTA |
|RF-003| A aplicação deve permitir que o usuário consulte todas as agências de intercâmbio cadastradas ordenando-as com base em suas notas | ALTA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| A aplicação deve ser responsiva | MÉDIA | 
|RNF-002| A aplicação deve processar requisições do usuário em no máximo 3s |  BAIXA | 

Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

![DiagramaDeCasoDeUso](https://github.com/user-attachments/assets/a1a4dfad-0488-4339-a9c3-65c52b15c822)

