Olá! Após baixar o repositório na sua máquina, você tem que primeiramente configurar a sua string de conexão. Isto é feito no arquivo **Prova_db_context**.
O banco de dados usado foi o SQL server.
Após configurar a conexão com o banco, você terá de abrir o terminal do seu visual studio e digitar o comando:
```
dotnet ef database update
```
Isto garantirá que seja criado no seu banco de dados as tabelas com alguns dados já inseridos.
Já para a utilização do client front-end, você terá de abrir a pasta **ClientApp** um dretóro acima, e a recomendação é fazê-lo com o *VSCode*.
Com o *VSCode* aberto na pasta, abra o termnal ou aperte as teclas **ctrl + shft + '**. Com o terminal aberto, caminhe uma pasta à frente com o comando ```cd .\BlueApp\```.
Agora você já está com o terminal na pasta onde tem-se localizado o arquivo **package.json**, então digite o comando ```npm install``` para instalar as dependências, e depois ```npm run dev```.
*Lembrando que para consumir os serviços da API pelo front-end, é necessário ter a API do .Net em execução*
![swagger completo](https://github.com/FelipeeSaM/ProvaBlue/blob/master/swagger_completo.png)
Testando o formato
