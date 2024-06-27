# API de Receitas

Boas-vindas ao repositório do projeto API de Receitas

Para realizar o projeto, atente-se a cada passo descrito a seguir, e se tiver **qualquer dúvida**, nos envie no _Slack_ da turma! #vqv 🚀

Aqui, você vai encontrar os detalhes de como estruturar o desenvolvimento do seu projeto a partir desse repositório, utilizando uma branch específica e um _Pull Request_ para colocar seus códigos.

## Termos e acordos

Ao iniciar este projeto, você concorda com as diretrizes do [Código de Conduta e do Manual da Pessoa Estudante da Trybe](https://app.betrybe.com/learn/student-manual/codigo-de-conduta-da-pessoa-estudante).

## Entregáveis
---

<details>
<summary><strong>🤷🏽‍♀️ Como entregar</strong></summary>

Para entregar o seu projeto você deverá criar um _Pull Request_ neste repositório.

Lembre-se que você pode consultar nosso conteúdo sobre [Git & GitHub](https://app.betrybe.com/learn/course/5e938f69-6e32-43b3-9685-c936530fd326/module/fc998c60-386e-46bc-83ca-4269beb17e17/section/fe827a71-3222-4b4d-a66f-ed98e09961af/day/1a530297-e176-4c79-8ed9-291ae2950540/lesson/2b2edce7-9c49-4907-92a2-aa571f823b79) e nosso [Blog - Git & GitHub](https://blog.betrybe.com/tecnologia/git-e-github/) sempre que precisar!

</details>
  
<details>
<summary><strong>🧑‍💻 O que deverá ser desenvolvido</strong></summary>

Sua empresa do coração desenvolveu um aplicativo de Receitas que está totalmente funcional 😉.
Agora, ela quer expandir esse negócio e criar uma **api de receitas** que vai retornar todas as receitas disponíveis, adicionar, remover e atualizar as mesmas. Além disso, a empresa deseja que seja possível cadastrar, remover, consultar e atualizar dados de usuários do app e permitir o cadastro e consulta de comentários nessas receitas.

Você recebeu a atribuição de desenvolver essa api de receitas com ASP.NET. Todos os services com os modelos de dados já estão disponíveis.

</details>
  
<details>
  <summary><strong>📝 Habilidades a serem trabalhadas </strong></summary>

Neste projeto, verificamos se você é capaz de:

- Entender do funcionamento do ASP.NET e como ele se integra ao C#.
- Entender da arquitetura MVC.
- Criar controllers que recebam dados pelo corpo e pela URL da requisição.
- Lançar códigos de retorno que respeitem o padrão do HTTP Status Code.


</details>


## Orientações
---

<details>
  <summary><strong>‼️ Antes de começar a desenvolver</strong></summary><br />

  1. Clone o repositório

  - Use o comando: `git clone git@github.com:tryber/csharp-034-csharp-projeto-api-de-receitas.git`.
  - Entre na pasta do repositório que você acabou de clonar:
    - `cd csharp-034-csharp-projeto-api-de-receitas`

  2. Instale as dependências
  
  - Entre na pasta `src/`.
  - Execute o comando: `dotnet restore`.
  
  3. Crie uma branch a partir da branch `master`

  - Verifique se você está na branch `master`
    - Exemplo: `git branch`
  - Se não estiver, mude para a branch `master`
    - Exemplo: `git checkout master`
  - Agora crie uma branch à qual você vai submeter os `commits` do seu projeto
    - Você deve criar uma branch no seguinte formato: `nome-de-usuario-nome-do-projeto`
    - Exemplo: `git checkout -b joaozinho-csharp-034-csharp-projeto-api-de-receitas`

  4. Adicione as mudanças ao _stage_ do Git e faça um `commit`

  - Verifique que as mudanças ainda não estão no _stage_
    - Exemplo: `git status` (deve aparecer listada a pasta _joaozinho_ em vermelho)
  - Adicione o novo arquivo ao _stage_ do Git
    - Exemplo:
      - `git add .` (adicionando todas as mudanças - _que estavam em vermelho_ - ao stage do Git)
      - `git status` (deve aparecer listado o arquivo _joaozinho/README.md_ em verde)
  - Faça o `commit` inicial
    - Exemplo:
      - `git commit -m 'iniciando o projeto x'` (fazendo o primeiro commit)
      - `git status` (deve aparecer uma mensagem tipo essa: _nothing to commit_ )

  5. Adicione a sua branch com o novo `commit` ao repositório remoto

  - Usando o exemplo anterior: `git push -u origin joaozinho-csharp-034-csharp-projeto-api-de-receitas`

  6. Crie um novo `Pull Request` _(PR)_

  - Vá até a página de _Pull Requests_ do [repositório no GitHub](https://github.com/tryber/csharp-034-csharp-projeto-api-de-receitas/pulls)
  - Clique no botão verde _"New pull request"_
  - Clique na caixa de seleção _"Compare"_ e escolha a sua branch **com atenção**
  - Coloque um título para a sua _Pull Request_
    - Exemplo: _"Cria tela de busca"_
  - Clique no botão verde _"Create pull request"_
  - Adicione uma descrição para o _Pull Request_ e clique no botão verde _"Create pull request"_
  - **Não se preocupe em preencher mais nada por enquanto!**
  - Volte até a [página de _Pull Requests_ do repositório](https://github.com/tryber/csharp-034-csharp-projeto-api-de-receitas/pulls) e confira que o seu _Pull Request_ está criado

</details>

<details>
  <summary><strong>⌨️ Durante o desenvolvimento</strong></summary><br/>

  - Faça `commits` das alterações que você fizer no código regularmente

  - Lembre-se sempre de, após um (ou alguns) `commits`, atualizar o repositório remoto

  - Os comandos que você utilizará com mais frequência são:
    1. `git status` _(para verificar o que está em vermelho - fora do stage - e o que está em verde - no stage)_
    2. `git add` _(para adicionar arquivos ao stage do Git)_
    3. `git commit` _(para criar um commit com os arquivos que estão no stage do Git)_
    4. `git push -u origin nome-da-branch` _(para enviar o commit para o repositório remoto na primeira vez que fizer o `push` de uma nova branch)_
    5. `git push` _(para enviar o commit para o repositório remoto após o passo anterior)_

</details>

<details>
  <summary><strong>🤝 Depois de terminar o desenvolvimento (opcional)</strong></summary><br/>

  Para sinalizar que o seu projeto está pronto para o _"Code Review"_, faça o seguinte:

  - Vá até a página **DO SEU** _Pull Request_, adicione a label de _"code-review"_ e marque seus colegas:

    - No menu à direita, clique no _link_ **"Labels"** e escolha a _label_ **code-review**;

    - No menu à direita, clique no _link_ **"Assignees"** e escolha **o seu usuário**;

    - No menu à direita, clique no _link_ **"Reviewers"** e digite `students`, selecione o time `tryber/students-sd-034-csharp`.

  Caso tenha alguma dúvida, [aqui tem um vídeo explicativo](https://vimeo.com/362189205).

</details>

<details>
  <summary><strong>🕵🏿 Revisando um pull request</strong></summary><br />

  Use o conteúdo sobre [Code Review](https://app.betrybe.com/course/real-life-engineer/code-review) para te ajudar a revisar os _Pull Requests_.

</details>

<details>
  <summary><strong>🎛 Linter</strong></summary><br />

  Usaremos o [NetAnalyzer](https://docs.microsoft.com/pt-br/dotnet/fundamentals/code-analysis/overview) para fazer a análise estática do seu código.

  Este projeto já vem com as dependências relacionadas ao _linter_ configuradas no arquivo `.csproj`.

  O analisador já é instalado pelo plugin da `Microsoft C#` no `VSCode`. Para isso, basta fazer o download do [plugin](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) e instalá-lo.
</details>

<details>
  <summary><strong>🛠 Testes</strong></summary><br />

  O .NET já possui sua própria plataforma de testes.
  
  Este projeto já vem configurado e com suas dependências.

  ### Executando todos os testes

  Para executar os testes com o .NET, execute o comando dentro do diretório do seu projeto `src`!

  ```
  dotnet test
  ```

  ### Executando um teste específico

  Para executar um teste específico, basta executar o comando `dotnet test --filter Name~TestMethod1`.

  :warning: **Importante:** o comando irá executar testes cujo nome contém `TestMethod1`.

  :warning: **O avaliador automático não necessariamente avalia seu projeto na ordem em que os requisitos aparecem no readme. Isso acontece para deixar o processo de avaliação mais rápido. Então, não se assuste se isso acontecer, ok?**

  ### Outras opções para testes
  - Algumas opções que podem lhe ajudar são:
    -  `-?|-h|--help`: exibe a descrição completa de como utilizar o comando.
    -  `-t|--list-tests`: lista todos os testes, ao invés de executá-los.
    -  `-v|--verbosity <LEVEL>`: define o nível de detalhe na resposta dos testes.
      - `q | quiet`
      - `m | minimal`
      - `n | normal`
      - `d | detailed`
      - `diag | diagnostic`
      - Exemplo de uso: 
         ```
           dotnet test -v diag
         ```
         ou
         ```            
           dotnet test --verbosity=diagnostic
         ``` 
</details>

## Requisitos do projeto

### 1. Desenvolva o endpoint GET `/recipe`

<details>
  <summary><strong>Mais informações:</strong></summary>

- O endpoint deve ser acessível através do URL `/recipe`;
- O corpo da requisição é vazio.
- Os dados são manipulados através da service `/Services/RecipeService.cs` já criada.
- A estrutura de recipe são instâncias da classe `Recipe.cs`

* **O que será testado:**

  - Se a requisição for feita com sucesso o resultado retornado deverá ser conforme exibido abaixo, com um status http `200`:
    ```json
    [
	    {
		    "name": "Bolo de cenoura",
		    "recipeType": 1,
        "preparationTime": 0.4,
		    "ingredients": [
  			  "1/2 xícara (chá) de óleo", "..."
        ],
        "directions": "Em um liquidificador, ...",
        "rating": 10
	    },

      /*...*/
    ]
    ```

</details>

### 2. Desenvolva o endpoint GET `/recipe/:name`

<details>
  <summary><strong>Mais informações:</strong></summary>

- O endpoint deve ser acessível através do URL `/recipe/:name`;
- O endpoint irá buscar apenas uma receita consultando pelo `name` da receita
- O corpo da requisição é vazio.
- Os dados são manipulados através da service `/Services/RecipeService.cs` já criada.
- A estrutura de recipe são instâncias da classe `Recipe.cs`

* **O que será testado:**

  - Se a requisição for feita com sucesso o resultado retornado deverá ser conforme exibido abaixo, com um status http `200`:
    ```json
	  {
		  "name": "Bolo de cenoura",
		  "recipeType": 1,
      "preparationTime": 0.4,
		  "ingredients": [
  	    "1/2 xícara (chá) de óleo", "..."
      ],
      "directions": "Em um liquidificador, ...",
      "rating": 10
	  },
    ```

  - Se a requisição não encontrar nenhuma receita que atenda o filtro de nome, o resultado retornado deverá ter um status http `404`:
  - O retorno em json poderá ser o padrão do ASP.NET

</details>

### 3. Desenvolva o endpoint POST `/recipe`

<details>
  <summary><strong>Mais informações:</strong></summary>

- O endpoint deve ser acessível através do URL `/recipe`;
- Os dados são manipulados através da service `/Services/RecipeService.cs` já criada.
- A estrutura de recipe são instâncias da classe `Recipe.cs`
- O corpo da requisição deverá seguir o formato abaixo:
  ```json
  {
	  "Name": "Mousse de maracuja",
	  "RecipeType": 0,
	  "PreparationTime": "0.2",
	  "Ingredients": [
  		"1 lata de leite condensado",
	  ],
	  "Directions": "Em um liquidificador, ...",
	  "Rating": "9"
  }
  ```
* **O que será testado:**

  - Se a requisição for feita com sucesso o resultado retornado deverá ser conforme exibido abaixo, com um status http `201`:
    ```json
    {
  	  "Name": "Mousse de maracuja",
	    "RecipeType": 0,
	    "PreparationTime": "0.2",
	    "Ingredients": [
    		"1 lata de leite condensado",
	    ],
	    "Directions": "Em um liquidificador, ...",
	    "Rating": "9"
    }
    ```
</details>

### 4. Desenvolva o endpoint PUT `/recipe`

<details>
  <summary><strong>Mais informações:</strong></summary>

- O endpoint deve ser acessível através do URL `/recipe`;
- Os dados são manipulados através da service `/Services/RecipeService.cs` já criada.
- A estrutura de recipe são instâncias da classe `Recipe.cs`
- O dado de referência (chave primária) da receita será o `Name`
- O corpo da requisição deverá seguir o formato abaixo:
  ```json
  {
	  "Name": "Mousse de maracuja",
	  "RecipeType": 0,
	  "PreparationTime": "0.2",
	  "Ingredients": [
  		"1 lata de leite condensado",
	  ],
	  "Directions": "Em um liquidificador, ...",
	  "Rating": "9"
  }
  ```
* **O que será testado:**

  - Se a requisição for feita com sucesso o resultado retornado deverá ser um status http `204` sem conteúdo:
  - Se a requisição for feita com erro o resultado retornado deverá ser um status http `400`.

</details>

### 5. Desenvolva o endpoint DEL `/recipe/:name`

<details>
  <summary><strong>Mais informações:</strong></summary>

- O endpoint deve ser acessível através do URL `/recipe/:name`;
- O endpoint irá buscar apenas uma receita consultando pelo `name` da receita
- O corpo da requisição é vazio.
- Os dados são manipulados através da service `/Services/RecipeService.cs` já criada.
- A estrutura de recipe são instâncias da classe `Recipe.cs`

* **O que será testado:**

  - Se a requisição for feita com sucesso o resultado retornado deverá ser um status http `204` sem conteúdo:
  - Se a requisição não encontrar nenhuma receita que atenda o filtro de nome, o resultado retornado deverá ter um status http `404`:
  - O retorno em json poderá ser o padrão do ASP.NET

</details>

### 6. Desenvolva o endpoint GET `/user/:email`

<details>
  <summary><strong>Mais informações:</strong></summary>

- O endpoint deve ser acessível através do URL `/user/:email`;
- O endpoint irá buscar apenas uma pessoa usuária consultando pelo `email` da pessoa
- O corpo da requisição é vazio.
- Os dados são manipulados através da service `/Services/UserService.cs` já criada.
- A estrutura de user são instâncias da classe `User.cs`

* **O que será testado:**

  - Se a requisição for feita com sucesso o resultado retornado deverá ser conforme exibido abaixo, com um status http `200`:
    ```json
	  {
  	  "email": "pessoa@betrybe.com",
	    "name": "Pessoa tryber",
	    "password": "senhaTryber"
    }
    ```
  - Se a requisição não encontrar nenhuma pessoa usuária que atenda o filtro de e-mail, o resultado retornado deverá ter um status http `404`:
  - O retorno em json poderá ser o padrão do ASP.NET

</details>

### 7. Desenvolva o endpoint POST `/user`

<details>
  <summary><strong>Mais informações:</strong></summary>

- O endpoint deve ser acessível através do URL `/user`;
- Os dados são manipulados através da service `/Services/UserService.cs` já criada.
- A estrutura de user são instâncias da classe `User.cs`
- O corpo da requisição deverá seguir o formato abaixo:
  ```json
  {
  	"email": "pessoa.nova@betrybe.com",
  	"name": "Pessoa Nova",
  	"password": "senhaDaPessoaNova"
  }
  ```
* **O que será testado:**

  - Se a requisição for feita com sucesso o resultado retornado deverá ser conforme exibido abaixo, com um status http `201`:
    ```json
    {
  	  "email": "pessoa.nova@betrybe.com",
  	  "name": "Pessoa Nova",
  	  "password": "senhaDaPessoaNova"
    }
    ```
</details>

### 8. Desenvolva o endpoint PUT `/user/:email`

<details>
  <summary><strong>Mais informações:</strong></summary>

- O endpoint deve ser acessível através do URL `/user/:email`;
- Os dados são manipulados através da service `/Services/UserService.cs` já criada.
- A estrutura de user são instâncias da classe `User.cs`
- O dado de referência (chave primária) da pessoa usuária será o `Email`
- O corpo da requisição deverá seguir o formato abaixo:

  ```json
  {
  	"email": "pessoa@betrybe.com",
  	"name": "Pessoa Nova",
  	"password": "senhaDaPessoaNova"
  }
  ```

* **O que será testado:**

  - Se a requisição for feita com sucesso o resultado retornado deverá ser conforme exibido abaixo, com um status http `200`:

    ```json
    {
  	  "email": "pessoa.nova@betrybe.com",
  	  "name": "Pessoa Nova",
  	  "password": "senhaDaPessoaNova"
    }
    ```

    - Se a requisição não encontrar nenhuma pessoa usuária que atenda o filtro de e-mail, o resultado retornado deverá ter um status http `404`:
    - Se a requisição tentar atualizar o e-mail pessoa usuária, o resultado retornado deverá ter um status http `400`:
    - O retorno em json poderá ser o padrão do ASP.NET

</details>

### 9. Desenvolva o endpoint DEL `/user/:email`

<details>
  <summary><strong>Mais informações:</strong></summary>

- O endpoint deve ser acessível através do URL `/recipe/:email`;
- O endpoint irá buscar apenas uma pessoa usuária consultando pelo `email`.
- O corpo da requisição é vazio.
- Os dados são manipulados através da service `/Services/UserService.cs` já criada.
- A estrutura de pessoas usuárias são instâncias da classe `User.cs`

* **O que será testado:**
    - Se a requisição for feita com sucesso o resultado retornado deverá ser um status http `204` sem conteúdo:
    - Se a requisição não encontrar nenhuma pessoa usuária que atenda o filtro de e-mail, o resultado retornado deverá ter um status http `404`:
    - O retorno em json poderá ser o padrão do ASP.NET

</details>

### 10. Desenvolva o endpoint POST `/comment`

<details>
  <summary><strong>Mais informações:</strong></summary>

- O endpoint deve ser acessível através do URL `/comment`;
- Os dados são manipulados através da service `/Services/CommentService.cs` já criada.
- A estrutura de comentários são instâncias da classe `Comment.cs`
- O corpo da requisição deverá seguir o formato abaixo:
  ```json
  {
  	"Email": "pessoa@betrybe.com",
  	"RecipeName": "Coxinha",
  	"CommentText": "Fiz a receita de Coxinha na minha casa. Fiz o passo a passo e funcionou."
  } 
  ```

* **O que será testado:**

    - Se a requisição for feita com sucesso o resultado retornado deverá ser conforme exibido abaixo, com um status http `201`:
    
    ```json
    {
  	  "Email": "pessoa@betrybe.com",
  	  "RecipeName": "Coxinha",
  	  "CommentText": "Fiz a receita de Coxinha na minha casa. Fiz o passo a passo e funcionou."
    } 
    ```
</details>

### 11. Desenvolva o endpoint GET `/comment/:recipeName`

<details>
  <summary><strong>Mais informações:</strong></summary>

- O endpoint deve ser acessível através do URL `/comment/:recipeName`;
- O endpoint irá buscar apenas os comentários consultando pelo `Name` da receita
- O corpo da requisição é vazio.
- Os dados são manipulados através da service `/Services/CommentService.cs` já criada.
- A estrutura de comentários são instâncias da classe `Comment.cs`

* **O que será testado:**
    - Se a requisição for feita com sucesso o resultado retornado deverá ser conforme exibido abaixo, com um status http `200`:
    ```json
	  [
	    {
		    "email": "pessoa@betrybe.com",
		    "recipeName": "Coxinha",
		    "commentText": "Fiz a receita de Coxinha na minha casa. Fiz o passo a passo e saiu certinho."
	    },

      /* ... */
    ]
    ```

</details>

<details>
  <summary><strong>🗣 Nos dê feedbacks sobre o projeto!</strong></summary><br />

Ao finalizar e submeter o projeto, não se esqueça de avaliar sua experiência preenchendo o formulário. 
**Leva menos de 3 minutos!**

[FORMULÁRIO DE AVALIAÇÃO DE PROJETO](https://be-trybe.typeform.com/to/ZTeR4IbH#cohort_hidden=CH34-CSHARP&template=betrybe/csharp-0x-projeto-api-de-receitas)

</details>

<details>
  <summary><strong>🗂 Compartilhe seu portfólio!</strong></summary><br />

  Você sabia que o LinkedIn é a principal rede social profissional e que compartilhar aprendizados lá é muito importante para quem deseja construir uma carreira de sucesso? Compartilhe este projeto no seu LinkedIn, marque o perfil da Trybe (@trybe) e mostre para a sua rede toda a sua evolução.

</details>
