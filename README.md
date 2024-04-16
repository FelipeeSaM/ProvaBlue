Olá! Após baixar o repositório na sua máquina, você tem que primeiramente configurar a sua string de conexão. Isto é feito no arquivo **Prova_db_context**.
O banco de dados usado foi o SQL server.
Após configurar a conexão com o banco, você terá de abrir o terminal do seu visual studio e digitar o comando:
```
dotnet ef database update
```
Isto garantirá que seja criado no seu banco de dados as tabelas com alguns dados gerados aleatoriamente com a biblioteca do *Bogus* já inseridos.
Já para a utilização do client front-end, você terá de abrir a pasta **ClientApp** um dretóro acima, e a recomendação é fazê-lo com o *VSCode*.
Com o *VSCode* aberto na pasta, abra o termnal ou aperte as teclas **ctrl + shft + '**. Com o terminal aberto, caminhe uma pasta à frente com o comando ```cd .\BlueApp\```.
Agora você já está com o terminal na pasta onde tem-se localizado o arquivo **package.json**, então digite o comando ```npm install``` para instalar as dependências, e depois ```npm run dev```.
*Lembrando que para consumir os serviços da API pelo front-end, é necessário ter a API do .Net em execução.*


![swagger completo](https://github.com/FelipeeSaM/ProvaBlue/blob/master/swagger_completo.png)
^ Esta é a cara do swagger com as documentações.


v Aqui temos um exemplo da utilização do **AutoMapper**:
![AutoMapper](https://github.com/FelipeeSaM/ProvaBlue/blob/master/automapper.png)

v Já aqui temos uma demonstração do **FluentValidation**
![FluentValidation](https://github.com/FelipeeSaM/ProvaBlue/blob/master/Fluent_validator.png)

v Abaixo, de quebra, um **Error Handler** devidamente configurado para proteger a aplicação de exibir dados sensíveis e partes do código quando houver exceções.
![ErrorHandler](https://github.com/FelipeeSaM/ProvaBlue/blob/master/Error_handler.png)


Agora indo ao **Postman**, vamos fazer uma requisição para a rota do login, como mostra a figura abaixo. Forneça no *body* da requisição, em formato *JSON* e no verbo **POST**, estas mesmas informações.
![Login](https://github.com/FelipeeSaM/ProvaBlue/blob/master/Login.png)


Pronto, agora estamos com o nosso token JWT funcionando. Para acessar as rotas seguintes, será necessário passar esse token no cabeçalho das próximas requisições e com o verbo **GET**, conforme a figura abaixo:
![Authentication](https://github.com/FelipeeSaM/ProvaBlue/blob/master/Authentication.png)
(configure na aba **Authorization** o tipo **Bearer**, e então cole o token recém-gerado no campo ao lado)

Isto testará a autenticação via token JWT. Para testar a autorização, basta seguir para a rota do *employee*, descrita na primeira imagem, e você deverá receber a minha mensagem final e ultra secreta :smile: :smile: .

Obrigado por ler até o final 😊 .
