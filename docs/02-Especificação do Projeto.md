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
|--------|-----------------------------------------|----|
|RF-001   | O sistema deve permitir o cadastro, edição e exclusão de ONGs| ALTA | 
|RF-002   | O sistema deve permitir o cadastro, edição e exclusão de voluntários. | ALTA |
|RF-003   | O sistema deve permitir a criação, edição e exclusão de eventos pelas ONGs, podendo definir data, horário, local e descrição de cada evento.| ALTA |
|RF-004   | O sistema deve permitir que os voluntários se inscrevam em eventos de seu interesse.| ALTA |
|RF-005   | O sistema deve permitir login com autenticação segura.| ALTA |
|RF-006   | O sistema deve permitir que os voluntários avaliem os eventos, fornecendo feedback sobre a experiência.| MÉDIA |
|RF-007   | O sistema deve permitir o compartilhamento de eventos em redes sociais para promover o engajamento.| MÉDIA |
|RF-008   | O sistema deve ter uma área de comunicação entre ONGs e voluntários para facilitar a comunicação entre os interessados.| MÉDIA |
|RF-009   | O sistema deve permitir que os usuários busquem ONGs e voluntários cadastrados.| MÉDIA |
|RF-010   | O sistema deve permitir notificações automáticas para eventos e novas oportunidades.| MÉDIA |
|RF-011   | O sistema deve permitir que as ONGs gerem relatórios de impacto, mostrando o número de voluntários envolvidos, horas de trabalho e resultados alcançados.| BAIXA |
|RF-012   | O sistema deve possibilitar que voluntários façam busca por eventos de acordo com filtros como área de interesse, localização e data. | BAIXA |



### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|----------|-------------------------|----|
|RNF-001| O sistema deve oferecer feedback visual para ações do usuário (exemplo: carregamento, sucesso, erro). |  ALTA | 
|RNF-002| O sistema deve ser acessível em navegadores web e dispositivos móveis. |  ALTA | 
|RNF-003| A aplicação deve ter uma interface responsiva para diferentes tamanhos de tela.|  ALTA |
|RNF-004| O sistema deve ser implementado na linguagem C#.|  ALTA | 
|RNF-005| O sistema deve ter uma interface intuitiva e fácil de usar, sem necessidade de treinamentos complexos. |  ALTA |
|RNF-006| O sistema deve ser acessível a pessoas com deficiência e cumprir as normas de acessibilidade WCAG, como textos alternativos para imagens, contrastes de cores adequados, navegação por teclado. |  ALTA | 
|RNF-007| O sistema deve ter um código que siga padrões de qualidade e boas práticas para facilitar manutenção e expansão. |  ALTA | 
|RNF-008| O sistema deve ter um tempo de resposta inferior a 5 segundos para consultas. | MÉDIA | 
|RNF-009| O sistema deve utilizar HTTPS para segurança nas transações. |  MÉDIA | 



## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição de gestão                                   |
|--|-------------------------------------------------------|
|01| O sistema deve ser desenvolvido e entregue em até 6 meses |
|02| A equipe de desenvolvimento será composta por apenas 6 desenvolvedores. |
|03| O projeto deve seguir a metodologia Agile (Scrum) |
|04|  O código deve ser armazenado e versionado em um repositório privado no GitHub para garantir rastreabilidade e segurança |

|ID| Restrição de negócio                                  |
|--|-------------------------------------------------------|
|01|  A plataforma deve ser gratuita para ONGs e voluntários |
|02|  ONGs e voluntários devem aceitar os termos de uso e política de privacidade para utilizar o sistema. |
|03|  Apenas ONGs com CNPJ válido podem se cadastrar na plataforma. |


## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

![DiagramaDeCasoDeUso](https://github.com/user-attachments/assets/a1a4dfad-0488-4339-a9c3-65c52b15c822)

