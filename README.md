[TOC]

# Conceitos importantes

## DDD (Domain Driven Designer)

O Domain Driven Design combina práticas de design e desenvolvimento. Oferece ferramentas de modelagem estratégica e tática para entregar um software de alta qualidade. O objetivo é acelerar o desenvolvimento de software que lidam com complexos processos de negócio.

O DDD é um conjunto de princípios com foco em **domínio**, **exploração de modelos de forma criativa** e **definir e falar a linguagem ubiqua**[^*] baseada em um contexto delimitado.

- **Domínio**: é o coração do negócio que você está trabalhando. É baseado em um conjunto de ideias, conhecimento e processos de negócio.
- **Exploração de modelos criativos**: DDD preza que desenvolvedores façam parte do processo de entender o negócio e todos os seus modelos nos mais diversos ângulos ao invés de simplesmente entrevistar especialistas.
- **Definir e falar a linguagem ubíqua**: Linguagem Ubíqua é a linguagem falada no dia a dia no contexto da empresa. É a linguagem que utiliza as terminologias da realidade do negócio.

### Características

- Combina muito com microsserviços;
- Utilizado para aplicações complexas;
- Fácil de entender;
- Difícil de aplicar;
- Utilização de diversos padrões de projetos.

### Pilares do DDD

#### Linguagem Ubíqua

- A linguagem Ubíqua tem como objetivo fazer a ligação entre os experts do negócio e os desenvolvedores. Ou seja definir os termos que mais vão usar.
- Fazer um glossário com o significado de cada termo é essencial.

#### Bounded Contexts (Contexto delimitado)

- Delimita os contextos da aplicação.

- Cada contexto possui suas responsabilidades claramente definidas.

- Cada contexto pode ter sua própria linguagem Ubíqua.

- Utilização de histórias e levantamento do escopo do projeto com o "Domain expert" auxilia no processo de delimitação de contextos. (Exemplo de utilização do sistema, exemplo os passos para a criação de um usuário em um sistema)

  Depois que entendemos o contexto, conseguiu definir a linguagem ubíqua e tem uma visão geral do funcionamento do sistema nós partimos para a **modelagem estratégica**. Nela é onde vou definir, necessariamente, os contextos que eu vou utilizar no meu sistema, ou seja, esses são os meus **contextos delimitados**.

#### Context Maps (Mapas de contexto)

Depois de ter todos os contextos definidos nós partimos para a criação de uma mapa destes contextos. Esse mapa serve para entendermos, definitivamente, a relação entre estes contextos.

[![Mapa de contextos](https://camo.githubusercontent.com/24d28b1da24c4d154b52eaf2b1f997f758b50a5a416a2eb41e10be93b2b5f2b4/687474703a2f2f66756c6c6379636c652e636f6d2e62722f77702d636f6e74656e742f75706c6f6164732f323031392f30372f696d6167652d35352d31303234783436322e706e67)](https://camo.githubusercontent.com/24d28b1da24c4d154b52eaf2b1f997f758b50a5a416a2eb41e10be93b2b5f2b4/687474703a2f2f66756c6c6379636c652e636f6d2e62722f77702d636f6e74656e742f75706c6f6164732f323031392f30372f696d6167652d35352d31303234783436322e706e67)

D → Downstream

U → Upstream

Quando existe um relacionamento upstream (Supplier) e downstream (Customer), significa que a equipe upstream pode ter êxito interdependente da equipe downstream. Modificações no contexto upstream impactam a downstream.

### Domain Model Patterns

- São padrões de desenvolvimento e estruturação de aplicações cujo domínio é o principal foco

  - **Focados em Entidades de Agregadores**

    [![img](https://camo.githubusercontent.com/1b1f9bccae3ac8f2d5dc665b12844512b82e26b1a252a111c76583e4495e1ed7/68747470733a2f2f6d69726f2e6d656469756d2e636f6d2f6d61782f3730302f312a4a68704e49634e37716d6948413974454d43736a6f772e706e67)](https://camo.githubusercontent.com/1b1f9bccae3ac8f2d5dc665b12844512b82e26b1a252a111c76583e4495e1ed7/68747470733a2f2f6d69726f2e6d656469756d2e636f6d2f6d61782f3730302f312a4a68704e49634e37716d6948413974454d43736a6f772e706e67)

    Quando falamos em Entidade de Agregadores, estamos falando no ponto principal desse contexto, que nesse caso é o pagamento. No caso do pagamento, sempre há uma transação, que também é considerada uma Entidade. Quando trabalhamos com DDD, chamamos essas entidades de agregadores ou Aggregate Objects.

    Aggregate Objects são diversas entidades que estão no mesmo contexto e que se consomem. Como exemplo, para cada pagamento realizado há um registro de uma transação. Logo, na tabela, para cada pagamento realizado há um registro ID de transação relacionado. Sempre que falamos em agregador, devemos informar quem é o root aggregator. Em nosso exemplo é o pagamento.

  - **Objetos de valor**

    - Imutáveis
    - Coleções de atributos
    - Normalmente não possuem métodos setters
    - Entrada dos valores por um construtor
    - Tipagem forte ao invés da utilização de dados primitivos

  - **Repositórios**

    - Tem acesso direto a camada de dados
    - Persiste dados utilizando as entidades
    - Possui os métodos necessários para realizar consultas
    - Utilize sempre um repositório por agregação
    - Pode consultar diretamente serviços externos

  - **Serviços de domínio**

    - Implementam lógica de negócios a partir da definição de um expert de domínio
    - Trabalham com diversos fluxos de diversas entidades e agregações
    - Utilizam os repositórios como interface de acesso aos dados
    - Consumem recursos da camada de infraestrutura como enviar email, disparar eventos, entre outros

## LinQ

LINQ é um acrônimo para *Language Integrated Query*, ou *Consulta Integrada à Linguagem* . Trata-se de um “framework” dentro do .NET destinado a auxiliar os desenvolvedores a escrever expressões de consulta diretamente em C# de maneira agnóstica.

O LINQ abstrai a complexidade envolvida na utilização de diferentes linguagens de consulta, como SQL, xPath e xQuery. Essa abstração é feita em cima de uma API de alto nível compatível com as linguagens integrantes do .NET Framework. Com esse Framework conseguimos consultar uma base de dados relacional, um arquivo XML uma coleção de objetos através de uma API unificada, invocada através de uma linguagem integrante do .NET Framework. Você consegue unicamente com código C# fazer consultas a conjuntos de objetos, bases de dados relacionais e arquivos XML, sendo o LINQ o encarregado de fazer a devida “tradução” para cada uma das fontes a serem consultadas.

## Azure

Azure é um serviço que permite a empresas e desenvolvedores adquirirem as capacidades de processamento e armazenamento dos datacenters da Microsoft para aplicação em seus negócios como alternativa ao modelo convencional.

### Serviços

- **Máquinas virtuais**
- **Gerenciamento de redes**
- **Aplicações em nuvem**
- **Armazenamento e Backup**
- StorSimple
  - Com esse serviço, qualquer negócio é capaz de gerenciar facilmente dados entre datacenters na nuvem e matrizes fixas. A gestão é automatizada, o que aumenta a agilidade da TI, e o tempo de recuperação de desastres é ainda mais curto.
- **Automação de serviços e processos em nuvem**
- Contêineres
  - Contêineres são pacotes de códigos e ferramentas isolados do sistema em que estão funcionando. São a solução mais popular hoje para dar portabilidade e flexibilidade ao desenvolvimento de produtos digitais.
- **Bancos de dados SQL**
- **Análise de dados com IA e Machine Learning**
- IoT
  - O Azure oferece um Hub específico para IoT, que conecta e gerencia potencialmente bilhões de dispositivos em um único sistema de gestão apoiado pela nuvem.

## SAP

O ERP tem como função principal integrar todas as áreas de uma empresa: logística, contabilidade, vendas, fiscal, contabilidade e outras. O sistema SAP é um tipo de ERP.

Ele nada mais é que um sistema que ajuda a gerenciar os dados das empresas. Por exemplo, gerencia se a empresa tem estoque, materiais, produtos. Então, tudo que engloba os processos empresariais, o SAP auxilia a administrar.

O SAP é um sistema totalmente modular. Essa divisão permite melhor o controle dos diferentes setores da empresa.

1. **FI (Financial Accounting)** é responsável por rastrear o fluxo de dados financeiros em toda a organização de maneira controlada e integrar todas as informações para uma tomada estratégica eficaz de decisões.
2. **CO (Controlling)** coordena, monitora e otimiza todos os processos em uma organização. Ajuda também na análise dos números reais fazendo uma comparação com os dados planejados nas estratégias de negócio.
3. **SD (Sales and Distribution)** dá suporte às atividades de vendas e distribuição de produtos e serviços de uma empresa, desde a consulta ao pedido até finalização com a entrega.
4. **MM (Material Management)** se relaciona com o movimento de materiais da organização – incluindo atividades como logística, gerenciamento da cadeia de suprimentos, vendas e entrega, gerenciamento de depósitos, produção e planejamento.
5. **PP (Production Planning and Control)** faz o planejamento e gerenciamento da produção. Funciona em conjunto com vendas, atuando junto com operações, planejamento de recursos de distribuição, planejamento de necessidades, entre outros.
6. **QM (Quality Management)** contribui com a gestão da qualidade nos processos de uma organização. Para alcançar sua finalidade, o módulo possui integração com diversos outros processos: aquisição e vendas, produção, planejamento, inspeção, notificação, controle e outros.
7. **PM (Manutenção)** gerencia todas as atividades de manutenção em uma organização. Na prática, corresponde às atividades-chave que incluem inspeção, notificações, manutenção corretiva e preventiva, reparos e outras medidas para manter um sistema técnico ideal.

## Swagger

Trata-se de uma aplicação *open source* que auxilia desenvolvedores nos processos de definir, criar, documentar e consumir APIs REST. Em suma, o *Swagger* visa padronizar este tipo de integração, descrevendo os recursos que uma API deve possuir, como *endpoints*, dados recebidos, dados retornados, códigos HTTP e métodos de autenticação, entre outros.

Ele simplifica o processo de escrever APIs, especificando os padrões e fornecendo as ferramentas necessárias para escrever APIs seguras, com alto desempenho e escaláveis.

Escrito em YAML ou JSON.

## ElasticSearch

O Elasticsearch é um mecanismo de busca e análise de dados distribuído, gratuito e aberto para todos os tipos de dados, incluindo textuais, numéricos, geoespaciais, estruturados e não estruturados. Conhecido por suas REST APIs simples, natureza distribuída, velocidade e escalabilidade, o Elasticsearch é o componente central do Elastic Stack, um conjunto de ferramentas gratuitas e abertas para ingestão, enriquecimento, armazenamento, análise e visualização de dados. Comumente chamado de ELK Stack (pelas iniciais de Elasticsearch, Logstash e Kibana), o Elastic Stack agora inclui uma rica coleção de agentes lightweight conhecidos como Beats para enviar dados ao Elasticsearch.

## Active directory

O AD é implementado em protocolo LDAP (Lightweight Directory Access Protocol), que, traduzido ao pé da letra, significa: Protocolo Leve de Acesso a Diretório. Trata-se de um protocolo livre que é conhecido como o padrão do mercado para gerenciamento de informações de diretório distribuído sobre uma rede de Protocolo da Internet (IP).

Através da implementação de serviço LDAP, o Active Directory permite o uso de um único diretório para controle de acesso a todos sistemas e serviços dentro de uma rede corporativa. Isso significa que o colaborador de uma empresa não precisa criar um usuário e senha para cada sistema que tiver acesso, e sim utilizar seu usuário e senhas únicos(as).

São alguns dos principais recursos do AD:

- Autenticação centralizada
- Nível de segurança controlado
- Facilita a Delegação de tarefas administrativas
- Torna eficiente o gerenciamento de acesso
- Proporciona um índice dos recursos na rede
- Subdivisão de domínios em unidades lógicas
- Fornece recursos de replicação de dados
- Facilita a atribuição e manutenção de múltiplos domínios
- Unificação do sistema de nomes baseado em DNS
- Facilita a implementação de políticas de utilização (Políticas de Grupos)

## API - Application Programming Interface

Conjunto de rotinas e padrões estabelecidos e documentados por uma aplicação para que outras aplicações consigam utilizar suas funcionalidades sem precisar conhecer detalhes da sua implementação.

## Web Services

são um conjunto de métodos invocados por outras aplicações utilizando tecnologias Web sendo uma solução utilizada na integração de sistemas e na comunicação entre aplicações distintas.

## API x Web Services

| Todos os Web Services são APIs                               | Nem toda API é um Web Service                                |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| Usam apenas três meios de comunicação: SOAP, REST e XML-RPC  | Uma API pode usar qualquer meio de comunicação.              |
| São **autocontidas** e **autodescritivas** que podem ser publicados, localizados e invocados na Web. | São de código aberto e podem ser usadas em qualquer lugar.   |
| Podem não realizar todas as operações que uma API faz.       | Podem realizar todas as operações dos web services           |
| Requer um protocolo SOAP para receber e envia dados pela rede, portanto não é uma arquitetura leve | É uma arquitetura leve para dispositivos com largura de banda limitada, como dispositivos móveis. |
| Necessita de uma rede para o seu funcionamento               | Não precisa de uma rede para funcionar                       |
| Tendem a oferecer funcionalidades específicas a usuários específicos | Tendem a serem abertas a qualquer tipo de usuário que a pretende consumir |

## Web API

É uma API na internet, com um conjunto de serviços expostos via web para realizar a integração da aplicação com diversos tipos de clientes (web, mobile, desktop, etc.)

1. Podem ser desenvolvidas com Java, .Net, Ruby on Rayls, JavaScript, Node.js, etc.
2. Resposta em um formato específico com XML, JSON, etc.
3. Pode ser acessada usando o protocolo HTTP.
4. Tipos de resposta: arquivo texto, imagem, som, operação, banco de dados, objetos, etc.
5. Pode seguir dois estilos de desenvolvimento: o SOAP ou o REST.

### SOAP

É um protocolo (W3C) baseado em XML, usado para trocar informações entre aplicações no mesmo ou em diferentes sistemas operacionais.

- Todas as mensagens SOAP usam o mesmo formato
- É independente de protocolo (HTTP, SMTP, etc.) e devem retornar XML
- Um navegador não pode armazenar em cache uma solicitação concluída a uma API SOAP

### REST

É um estilo arquitetural sem estado que consiste de um conjunto coordenado de restrições arquiteturais aplicadas a componentes, conectores e elementos de dados dentro de um sistema de hipermídia distribuído.

- Tratam cada entidade como um recurso que pode ser acessado por uma interface comum.
- O acesso é baseado no protocolo HTTP (GET, POST, PUT e DELETE).

### REST X SOAP

| É um estilo arquitetural                                     | É um protocolo                                               |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| Usa JSON ou XML para enviar e receber dados                  | Usa WSDL(Web Services Description Language) para comunicação entre o cliente e o provedor |
| REST não precisa de muita largura de banda                   | SOAP precisa de mais largura de banda para seu uso           |
| Trabalha com texto, XML, JSON e HTML                         | Trabalha praticamente com o formato XML                      |
| Usa os verbos HTTP GET, POST, PUT e DELETE para acessar um serviço (pode usar outros protocolos) | Independente de protocolo (HTTP, SMTP, TCP, IMS, etc.)       |
| Invoca os serviços via URI                                   | Invoca os serviços usando métodos RPC                        |

## Entity Framework

O recurso Migrations no EF Core oferece uma maneira de atualizar de forma incremental o esquema de banco de dados para mantê-lo em sincronia com o modelo de dados do aplicativo, preservando os dados existentes no banco de dados.

### EF Core Migrations e as Convenções

As convenções do EF Core são um conjunto de regras que são usadas para criar e atualizar o esquema do banco de dados com base no modelo do EF Core.

Para o MySQL o tipo string é mapeado para llongtext e o tipo decimal usa uma precisão de 65 dígitos com 30 casas decimais.

Podemos sobrescrever as convenções do EF Core e otimizar as definições usadas para gerar as colunas nas tabelas.

Usa os atributos da plataforma .NET chamado Data Annotations

### Data Annotations

São atributos que podem ser aplicados a classes e seus membros para realizar as seguintes tarefas:

1. Definir regras de validação para o modelo
2. Definir como os dados devem ser exibidos na interface
3. Especificar o relacionamento entre as entidades do modelo
4. Sobrescrever as convenções padrão do Entity Framework Core

#### Atributos para sobrescrever as convenções do EF Core

- **[Key]** - Indentifica a propriedade como uma chave primária na tabela
- **[Table("nome")]** - Define o nome da tabela para a qual a classe será mapeada
- **[Column]** - Define a coluna na tabela para a qual a propriedade será mapeada
- **[DataType]** - associa um tipo de dado adicional a uma propriedade
- **[ForeignKey]** - Especifica que a propriedade é usada como uma chave estrangeira
- **[NotMapped]** - Exclui a propriedade do mapeamento
- **[StringLength]** - Define o tamanho mínimo e máximo permitido para o tipo
- **[Required]** - Especifica que o valor do campo é obrigatório

## Estrutura de um API

### [APIController]

O atributo [APIController] permite decorar os controladores habilitando recursos como:

- Requisito de roteamento de atributo;
- Respostas HTTP 400 automáticas (Validação do Model State);
- Inferência de parâmetro de origem de associação;
- Inferência de solicitação de dados de várias partes/formulário;
- Uso de Problem Details para códigos de status de erro;

### [Route]

O atributo [Route] especifíca um padrão URL para acessar um controller ou Action

[Route("[Controller]")] → indica a rota com o nome do controlador

### JSON - Serialização e Desserialização

A biblioteca **Newtonsoft.Json** era usada para serializar e desserializar (até a versão 2.2)

A biblioteca **System.Text.Json** for incluída a partir da versão 3.0 (É o padrão)

### JSON - Serialização e Desserialização - Referência Cíclica

Na [API](https://github.com/GabrielTernesSan/Cantinho-da-bagunca/tree/master/APICatalogo) temos um problema de referência cíclica pois no model "Categorias" temos uma referência à uma lista de "Produtos" e em produtos temos uma referência à uma lista de "Categorias" isso causa um erro.

Para resolvermos podemos ignorar essa referência.

```
builder.Services.AddControllers().AddJsonOptions( options => {
   options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles; 
});
```

Reference Handler → Define como o JsonSerializer lido com referências sobre serialização e desserialização.

### JSON - Serialização e Desserialização - Propriedades Públicas

Ao serializar objetos C# para JavaScript Object Notation (JSON), por padrão, todas as propriedades públicas são serializadas.

**Como resolver**

1. Ignorando propriedades individuais;

   [JsonIgnore] / [JsonIgnore(Condition = JsonIgnoreCondition.Always)] → (Em cima da propriedade) Sempre ignora a propriedade

   [JsonIgnore(Condition = JsonIgnoreCondition.Never)] → Sempre serializa e desserializa a propriedade

   [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] → A propriedade será ignorada na serialização se for um tipo de referência null, um tipo de valor nullable com valor null ou um tipo de valor padrão.

   [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)] → A propriedade será ignorada na serialização se for um tipo de referência null, ou um tipo de valor que pode ser anulado com valor null.

2. Ignorando todas as propriedades (Configuração na classe Program)

   ```
   builder.Service.AddController().AddJsonOptions(options => options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.<condição>);
   /*
   - Always
   - Never
   - WhenWritingDefault
   - WhenWritingNull
   */
   ```

### Otimizando o código nas consultas com HTTP GET

Quando consultamos entidades usando o entity framework ele armazena as entidades no contexto (em cache) realizando o *tracking* ou *rastreamento* das entidades para acompanhar o estado das entidades.

Este recurso adiciona uma sobrecarga que afeta o desempenho das consultas rastreadas.

Para melhorar o desempenho podemos usar o método: `AsNoTracking()`

```
var produtos = _context.Produtos.AsNotracking().ToList();
```

Usar `AsNoTracking()` apenas para consultas somente leitura sem a necessidade de alterar os dados.

### Otimizando o desempenho *

Nunca retorne todos os registros em uma consulta.

```
_context.Produtos.Take(10).ToList();
```

Nunca retorne objetos relacionados sem aplicar algum filtro

```
 _context.Categorias.Include(p => p.Produtos).Where(c => c.CategoriaId <= 5).ToList();
```

### Tratamento de erros

#### Ambiente de desenvolvimento

Usa por padrão a página de exceção do desenvolvedor que exibe informações detalhadas sobre as exceções como:

- Stack Trace (Rastreamento de pilha)
- Parâmetros de cadeia de caracteres de consulta
- Cookies
- Headers (Cabeçalhos)

#### Ambiente de produção

Para configurar um página de tratamento de erros personalizada para o ambiente de produção usamos o middleware `UseExceptionHandler`

- Captura e registra exceções não tratadas
- Executa novamente o *request* em um pipeline alternativo usando o caminho indicado (quando o response não foi iniciado). O código gerado executa o request usando o caminho /Error.

```
if(!app.Environment.IsDelepment()){
    app.UseExceptionHandler("/Error");
    // [...]
}
// [...]
```

### Roteamento

O roteamento é responsável por corresponder a solicitações HTTP de entrada e enviar essas solicitações para os pontos de extremidade executáveis do aplicativo. Os pontos de extremidade são as unidades do aplicativo de código executável de tratamento de solicitações. Os pontos de extremidade são definidos no aplicativo e configurados quando o aplicativo é iniciado.

- Mapeia as requisições feitas via URI;
- Despacha as requisições para os endpoints;
- Pode extrair valores da URL da requisição;
- Pode gerar URLs que mapeiam para os endpoints.

Os aplicativos podem configurar o roteamento usando:

- Controladores
- Razor Páginas
- SignalR
- gRPC Services
- [Middleware](https://docs.microsoft.com/pt-br/aspnet/core/fundamentals/middleware/?view=aspnetcore-6.0) habilitado para ponto de extremidade, como [Verificações de Integridade](https://docs.microsoft.com/pt-br/aspnet/core/host-and-deploy/health-checks?view=aspnetcore-6.0).
- Delegados e lambdas registrados com roteamento.

`````c#
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
`````

### Roteamento nas Web APIs é baseado em atributos

`[Route("[Controller]")]`

- A rota é determinada om base nos atributos definidos no Controladores e métodos Action.
- As definições nos atributos irão realizar o mapeamento para as Actions do controlador.
- Podemos definir rotas nos atributos HttpGet, HttpPost, HttpPut e HttpDelete que irão compor a rota definida no atributo Route.

### Restrições de rotas

As restrições de rota nos ajudam a filtrar ou impedir que os valores indesejados atinjam os métodos Action do controlador.

Isso é feito verificando a restrição com relação ao valor do parâmetro da URL.

### Método Action Síncrono

1. O servidor web de uma aplicação .NET possui um pool de threads que são usadas para servir as requisições que chegam em um método Action.
2. Quando um request chega, uma thread desse pool é encarregada de processar esse request.
   1. Se o request for processado de forma síncrona, a thread encarregada ficará bloqueada até finalizar a request.
3. Assim, a execução dos métodos é contínua, e se uma thread começar a executar um método, ele irá ficar ocupada até a execução do método terminar.

### Método Action Assíncrono

1. O servidor web de uma aplicação .NET possui um pool de threads que são usadas para servir as requisições que chegam em um método Action.
2. Quando um request chega, uma thread desse pool é encarregada de processar esse request.
   1. Se o request fot processado de forma assíncrona, a thread é devolvida ao pool para servir novos requests.
3. Assim, a execução dos métodos não é contínua. Quando a operação assíncrona terminar, a thread é avisada e retoma o controle de execução da Action.

### Programação Assíncrona

A plataforma .NET oferece uma abordagem simplificada à programação assíncrona fazendo uso das palavras-chaves `async` e `await` para criar métodos assíncronos usando o padrão TASK.

#### Regras e convenções

1. A assinatura do método deve incluir o modificador `async`;
2. O método deve ter um tipo de retorno da `Task<TResult>`, `Task` ou `void`;
3. As declarações de método devem incluir pelo menos uma única expressão `await` - isso diz ao compilador que o método precisa ser suspenso enquanto a operação aguardada estiver ocupada.
4. Por último, o nome do método deve terminar com o sufixo `Async` (mesmo que isso seja mais convencional do que o necessário).

#### Async, await e Task

- A instrução `async` faz com que um método possa ser executado de forma assíncrona;
- A palavra `await` indica que um trecho de código deve esperar por outro trecho de código e o controle retorna ao chamador do método; (não bloqueia a thread)
- A classe `Task<TResult>` representa uma única operação que retorna um valor; e essa operação pode ser executada de forma assíncrona;

### Model Binding

O Model Binding ou vinculação de modelos é um recurso que nos permite mapear dados de uma requisição HTTP para os parâmetros de uma Action de um Controlador.

Esse mapeamento inclui todos os tipo de parâmetros: números, strings, arrays, listas, tipos complexos, lista de objetos, etc.

Sempre que uma requisição é recebida, o framework ASP .NET Core precisa tratar essa requisição de forma que possa passar valores apropriados nos parâmetros das Actions.

Toda vez que implementamos Actions que recebem parâmetros estamos usando model binding.

#### Como funciona

Quando nossa API recebe uma requisição HTTP, ela a roteia para um método Action específico de um controlador com base na rota definida.

Ela determina qual o método Action será executado com base no que está definido na rota e, em seguida, vincula os valores da requisição HTTP aos parâmetros desse método Action.

`````c#
[HttpGet("{id}")]
public async Task<ActionResult<Produto>> GET(int id){
    [...]
}
`````

#### Fonte de dados

1. Valores de formulário: (POST e PUT) - enviados no corpo do request
2. Rotas: `[Route("api/[controller]")]` ou `HttpGet("{id}")`
3. Query Strings: `api/produtos/4?nome=Suco&stivo=true`

#### Atributos que indicam a fonte de dados dos parâmetros

1. `FromForm` - Utilize somente os dados recebidos do formulário enviado
2. `FromRoute` - Vincula apenas os dados que são oriundos da rota de dados
3. `FromQuery` - Recebe apenas os dados da cadeia de consulta (querystring)
4. `FromHeader` - Vincula os valores que vêm no cabeçalho da requisição HTTP
5. `FromBody` - Vincula os dados a partir do Body do request
6. `FromServices` - Vincula o valor especificado à implementação que foi configurada no seu container de injeção de dependência.

## Minimal API's

As Minimals API's usam os novos recursos do C# como *Global using* e instruções de nível superior, de forma a otimizar a experiência da inicialização do aplicativo.

Usando o novo template para criar uma Web API no VS 2022 temos que:

- Não existe mais o arquivo `Startup.cs`
- É usado o novo recurso `implicit usings`
- É usado o novo modelo de hospedagem com `WebApplication.CreateBuilder`
- As instruções de nível superior são usadas no arquivo `Progam.cs`(sem namespace, classe ou declarações de método)
- São usados os tipos de referência anuláveis

## Docker

É uma ferramenta que se apoia em recursos existentes no kernel, inicialmente Linux, para isolar a execução de processos. As ferramentas que o Docker traz são basicamente uma camada de administração de containers, baseado originalmente no LXC. 

Alguns isolamentos possíveis

- Limites de uso de memória
- Limites de uso de CPU
- Limites de uso de I/O
- Limites de uso de rede
- Isolamento da rede (que redes e portas são acessíveis)
- Isolamento do file system
- Permissões e Políticas
- Capacidades do kernel

O Docker tende a utilizar menos recursos que uma VM tradicional, um dos motivos é não precisar de uma pilha completa como vemos em Comparação VMs × Containers. O Docker utiliza o mesmo kernel do host, e ainda pode compartilhar bibliotecas.

![Containers vs VM & Virtual Machines | eG Innovations](https://www.eginnovations.com/blog/wp-content/uploads/2020/12/container-vms.jpg)

### Container

Container é o nome dado para a segregação de processos no mesmo kernel, de forma que o processo seja isolado o máximo possível de todo o resto do ambiente. 

Em termos práticos são File Systems[^1], criados a partir de uma "imagem" e que podem possuir também algumas características próprias.

### Imagens

Uma imagem Docker é a materialização de um modelo de um sistema de arquivos, modelo este produzido através de um processo chamado build. 

Esta imagem é representada por um ou mais arquivos e pode ser armazenada em um repositório.

### Namespaces

​	Os Namespaces são responsáveis por gerar o isolamento de grupos de processos em seu nível lógico, como o gerenciamento de usuários, rede, etc., garantido que o container não enxergue os processos do host e vice-versa. Logo, ao criar um container, são criados namespaces como pid(Process ID) para isolar processos, net(Network) para controlar e isolar as redes de cada container,ipc(Inter Process Communication) que permite a comunicação entre processos, etc.

### Isolamento

Um container normalmente roda com o máximo de isolamento possível do host, este isolamento é possível através do Docker Engine e diversas características provídas pelo kernel.

Mas normalmente não queremos um isolamento total, e sim um isolamento controlado, em que os recursos que o container terá acesso são explicitamente indicados. 

Principais recursos de controle do isolamento

- Mapeamento de portas
- Mapeamento de volumes
- Copia de arquivos para o container ou a partir do container
- Comunicação entre os containers

#### Mapeamento de portas

É possível mapear tanto portas TCP como UDP diretamente para o host, permitindo acesso através de toda a rede, não necessitando ser a mesma porta do container. O método mais comum para este fim é o parâmetro -p no comando docker container run, o -p recebe um parâmetro que normalmente é composto por dois números separados por : (dois pontos). O primeiro é no host e o segundo é no container.

#### Mapeamento de volumes

É possível mapear tanto diretórios no host como entidades especiais conhecidas como volumes para diretórios no container. Por enquanto vamos nos concentrar no mapeamento mais simples, uma diretório no host para um diretório no container. O método mais comum para este fim é o parâmetro -v no comando docker container run, o -v recebe um parâmetro que normalmente é composto por dois caminhos absolutos separados por : (dois pontos). Assim como diversos outros parâmetros, o primeiro é no host e o segundo é no container.

### Modo daemon

O parâmetro -d do docker container run indica ao Docker para iniciar o container em background (modo daemon).

## Comandos Docker

docker run (nome do container, ou o ID) - para criar um container;

docker ps - exibe os containers que estão rodando;

docker ps -a - exibe todos os containers, inclusive os que não estão rodando;

docker rm (ID ou nome do container) - remove os containers se não estiverem rodando

docker rm -f (ID ou nome do container) - força a parada e a exclusão do container

docker inspect meu-mysql | findstr "IPAddress" - descobre o IP para acessar o servidor do container

### Configurações do MySQL

docker run -e MYSQL_ROOT_PASSWORD=(senha) - define uma senha

docker run -e MYSQL_ROOT_PASSWORD=(senha) --name (nome do container) -d mysql - define um nome para o container e a senha

docker run -e MYSQL_ROOT_PASSWORD=(senha) --name (nome do container) -d mysql (mysql : (versão específica))

docker run -e MYSQL_ROOT_PASSWORD=(senha) --name (nome do container) -d -p 3306:3306  mysql - [mapeia a porta](https://stack.desenvolvedor.expert/appendix/docker/comandos.html#:~:text=Mapeamento%20de%20portas,j%C3%A1%20dito%20anteriormente.)

### Configurações do Postgres

docker run -e POSTGRES_PASSWORD=(senha) - define uma senha

docker run -e POSTGRES_PASSWORD=(senha) --name (nome do container) -d postgres - define um nome para o container e a senha

docker run -e POSTGRES_PASSWORD=(senha) --name (nome do container) -d postgres (postgres : (versão específica))

docker run -e POSTGRES_PASSWORD=(senha) --name (nome do container) -d -p 3306:3306  postgres - mapeia a porta

[^1]: O Docker utiliza file systems especiais para otimizar o uso, transferência e armazenamento das imagens, containers e volumes.
[^*]: Podemos defini-la então como uma linguagem que seja comum entre os envolvidos.
