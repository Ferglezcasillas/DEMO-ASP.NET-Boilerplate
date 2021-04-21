# Demo ASP.NET Boilerplate
#### por Fernando González Casillas

Esta aplicación se ha realizado para realizar una primera acercación al Framework conformado por ASP.NET Boilerplate. Ha sido programado por [Fernando González Casillas](https://www.linkedin.com/in/fernando-gonz%C3%A1lez-casillas/)

## ¿Qué se ha realizado en esta pequeña demo?

Tras haber instalado las herramientas necesarias, a raíz de la plantilla otorgada en la página oficial de [ASP.NET Boilerplate](https://aspnetboilerplate.com/), comencé a ojear la estructura proporcionada por defecto para irme adecuando al proyecto. Las tecnologías con la que comenzaría a trabajar eran nuevas (en términos prácticos) para mí, por lo que debía familiarizarme con ellas.

Por lo que, la finalidad de esta demo, siendo la de familiarizarse con el entorno mencionado previamente, sería la de añadir una nueva pestaña funcional a la aplicación por defecto. Esta pestaña tiene la función de conformar un registro de productos con sus correspondientes operaciones de adición, edición, listado y borrado.

## Con algo más de detalle...

Con un poco más de detalle lo realizado en esta demo es lo siguiente:

### 1. Conexión con la base de datos

Creamos una base de datos y, mediante el "string" de conexión, le indicamos a nuestra aplicación la base de datos con la que trabajará. Para ello, tras indicar lo anterior en el fichero *appsettings.json*, realizamos un *Update-Database* en la consola manejadora de paquetes señalando el proyecto *EntityFrameworkCore*. Esto hará que se generen las migraciones/tablas necesarias en la base de datos para trabajar con la aplicación.

### 2. Instalación de dependencias necesarias de Angular

Desde la consola de Visual Studio Code y en la ruta de la parte *front* de nuestro proyecto (directorio angular) ejecutamos el comando *npm install* para instalar las dependencias necesarias para trabajar. Tras realizar un *ng serve* o *npm start* podremos lanzar la aplicación visual.

### 3. Adición de la operación deseada al *Back-End*

Aquí ya empezamos a trabajar sobre la funcionalidad que deseamos añadir a la aplicación (que es la del registro de productos previamente mencionado). Para esto tendremos que seguir el siguiente proceso:

- Adición de la entidad **Producto**con las propiedades deseadas.
- Adición del denominado contexto de base de datos o **DbContext**.
- Ejecución de comando **Add-Migration "Add-Products"** el cual nos preparará las migraciones necesarias.
- Ejecución de comando **Update-Database** para que genere los cambios preparados en el punto anterior (generará la tabla *products*).
- Adición de un **ProductDto** que nos permitirá la gestión de las operaciones CRUD de la entidad *Producto*.
- Registro de un **PermissionNames.Pages_Products** para la página de gestión de la entidad *Producto*.
- Adición de un **ProductAppService** para para exponer las operaciones de la entidad *Producto* en la API.
- Ahora, si ejecutamos la aplicación, se nos abrirá *Swagger UI* en el navegador y podremos observar la API de nuestro proyecto y observar que las operaciones de la entidad *Producto* se encuentran visibles.

### 4. Adición de la nueva funcionalidad al *Front-end*

Ya en Visual Studio Code, nos centramos en el *Front-end* y, para que las operaciones añadidas en el *Back-End* tengan utilidad de cara al usuario, deberemos realizar los siguientes pasos:

- Adición del componente **products**. Esto es una carpeta dedicada a las operaciones y vistas que tendrá este apartado.
- Adición de la pestaña *Products* en el menú de la aplicación indicando la página (*Page*) correspondiente a *Products*.
- Le damos autorización al *Host* (en el **AuthorizationProvider** de la aplicación) de la vista.
- Realizamos el denominado *routing* para indicar el componente a mostrar cuando se seleccione la pestaña relativa a los productos.
- En la ruta *angular\nswag* ejecutamos el archivo por lotes *refresh.bat* para realizar un actualizado de los denominados *ServicesProxies*.
- Actualizamos el **app-modules.ts** y el **service-proxie.module.ts** mediante el registro de los nuevos componentes.
- Para gestionar las traducciones, volviendo al *Back-End*, cambiamos los ficheros *xml* de *Localization*.
- ¡Ya podemos arrancar la aplicación con nuestra nueva funcionalidad!
