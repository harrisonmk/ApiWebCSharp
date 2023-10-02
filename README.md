# ApiWebCSharp

* Instalaçao de Pacotes

  **dotnet tool install --global dotnet-ef**   //Instala apenas uma vez no computador

* Instalacao do entity FrameWork

  **dotnet add package Microsift.EntityFrameworkCore.Design**

  **dotnet add package Microsift.EntityFrameworkCore.SqlServer**    //para o banco de dados SQlServer
  

* criacao de migrations </b>


  **dotnet-ef migrations add "nomeDaMigration"**

* Conexao com o banco de dados
 
    **dotnet-ef database update**
