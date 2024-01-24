# CRUD_Colegio-Net6
Api en Net 6 CRUD _Colegio


Api en Net 6 CRUD

Se Realiza Api en .Net Core 6 y se Instala los siguientes paquetes como

1 Microsoft.EntityFrameworkCore.SqlServer
2 Microsoft.EntityFrameworkCore.Tools 
3 swagger

Por se uso Microsoft.EntityFrameworkCore.SqlServer en CRUD_Colegio ? 😱🤔

Microsoft.EntityFrameworkCore.SqlServer Me permite interactuar con una base de datos SQL Server de manera eficiente y abstraída de la complejidad subyacente de las consultas SQL y la manipulación directa de la base de datos.

Ventajas de usar Microsoft.EntityFrameworkCore.SqlServer 🤔

#1. Abstracción de la Base de Datos: EF Core maneja la comunicación con la base de datos que me permite trabajar con objetos y consultas LINQ en lugar de SQL directo.

#2.Portabilidad: Puedo cambiar de proveedor de base de datos sin tener que cambiar mucho (o nada) en el código de la Api. Si en el futuro Quiero utilizar una base de datos diferente que sea compatible con EF Core, como PostgreSQL o MySQL, podría hacerlo con cambios mínimos.

#3.Seguridad: EF Core ayuda a prevenir ataques de inyección de SQL y manejar las consultas de manera segura.

#4.Productividad: Reduce la cantidad de código que necesito escribir para interactuar con la base de datos y simplifica las operaciones CRUD.

RESUMEN

Microsoft.EntityFrameworkCore.SqlServer Me facilita la implementación de operaciones de base de datos en la aplicación .NET y proporciona una interfaz más amigable para interactuar con SQL Server.

Por se uso Microsoft.EntityFrameworkCore.Tools en CRUD_Colegio ? 😱🤔

Microsoft.EntityFrameworkCore.Tools es una herramienta que proporciona comandos de línea de comandos (CLI) para realizar tareas relacionadas con Entity Framework Core (EF Core) en este proyecto. Estas herramientas son esenciales durante el desarrollo para realizar tareas como la creación y aplicación de migraciones, la actualización de la base de datos y otras operaciones de administración de esquemas.

Ventajas de usar Microsoft.EntityFrameworkCore.Tool 🤔

#1. Migraciones: Me permite la creación y aplicación de migraciones para realizar cambios en el esquema de la base de datos. Las migraciones son scripts que describen cómo evoluciona la estructura de la base de datos a lo largo del tiempo.

#2. Actualizacion de la Base de Datos: Me facilita la aplicación de migraciones para actualizar la base de datos al último estado del modelo de datos.

#3. Generación de Código: Brinda la capacidad de generar código C# basado en un modelo de datos existente. Esto puede ser útil para la creación de clases de entidad basadas en la estructura de la base de datos.

#4.Scripting: Esto permite la generación de scripts SQL correspondientes a las migraciones planificadas.

Por que se uso swagger en CRUD_Colegio ? 😱🤔

Swashbuckle.AspNetCore es una herramienta que utilice para generar automáticamente la documentación de la API basada en Swagger para aplicaciones ASP.NET Core. Swagger es el marco de trabajo que permite describir, producir y consumir servicios web RESTful.

Con Swashbuckle.AspNetCore obtengo los siguientes beneficios 😎

#1 Documentación Automática

#2. Interfaz de Usuario Interactiva

#3. Generación de Cliente

#4. Pruebas y Depuración

#5. Consistencia y Estandarización

RESUMEN

Swashbuckle.AspNetCore simplifica la tarea de documentar y explorar APIs en proyectos ASP.NET Core, mejorando la experiencia como desarrollador y fomentando la adopción de las API por parte de otros equipos y servicios.
