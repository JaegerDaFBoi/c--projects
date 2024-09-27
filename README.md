Tutorial inicial ASP .NET Core 5.0

    dotnet start: Para ejecutar el programa
    dotnet build: Para compilar y revisar errores
    dotnet --version: Para visualizar la version de .Net


    1) Descargar e instalar .net core 5.0  Link: https://dotnet.microsoft.com/download/dotnet/5.0

    2) Instalar Visual Studio Code
        2.1) Instalar extensiones: 
                            a) C# for Microsoft
                            b) C# Extensions Jchannon
                            c) C# Extensions JosKreativ  

    3) Instalar Framework Entity de forma global
        a) dotnet tool install --global dotnet-ef (Instalacion del Entity Framework)
        b) dotnet tool update --global dotnet-ef  (Actualizacion del Entity Framework)

    4) Instalar la solucion de Entity Framework (El programa que se va a construir)
        dotnet new sln -o Proyecto (Proyecto es el nombre del programa a construir)

    5) Instalar las librerias para generar la conexion con la base de datos e implementar las entidades del programa
        a) dotnet new classlib -o Ejercicio.App.Persistencia
        b) dotnet new classlib -o Ejercicio.App.Dominio

    6) Instalar la aplicacion web para crear el frontend del programa
        a) dotnet new webapp -o Proyecto.App.FrontEnd 

    7) Instalar la libreria de consola para realizar pruebas del programa
        a) dotnet new console -o Ejercicio.App.Consola

    8) Instalar paquetes
        dotnet add package Microsoft.EntityFrameworkCore 
        dotnet add package Microsoft.EntityFrameworkCore.Tools
        dotnet add package Microsoft.EntityFrameworkCore.Design
        dotnet add package Microsoft.EntityFrameworkCore.SqlServer

            a) Carpeta Consola
                dotnet add package Microsoft.EntityFrameworkCore.Design
            b) Carpeta FrontEnd
            c) Carpeta Persistencia
                dotnet add package Microsoft.EntityFrameworkCore 
                dotnet add package Microsoft.EntityFrameworkCore.Tools
                dotnet add package Microsoft.EntityFrameworkCore.Design
                dotnet add package Microsoft.EntityFrameworkCore.SqlServer

    9) Crear las referencias a las carpetas de persistencia y dominio, siempre y cuando analicemos que uniones debemos realizar dentro de los .csproj
        dotnet add reference ..\Ejercicio.App.Dominio
            a)Carpeta Consola referencia a Persistencia y Dominio
            b)Carpeta Persistencia referencia a Dominio

    10) Crear las entidades en la carpeta Dominio

    11) Crear el AppContext para realizar el mapeo de las entidades para crear la migracion y crear la conexion con la base de datos (SQL Server)       

    12) Crear la migracion a la base de datos
        a) dotnet ef migrations add Inicial --startup-projetc ..\Proyecto.App.Consola\
        b) dotnet ef database update --startup-project ..\Proyecto.App.Consola\ 


