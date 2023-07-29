## Implementaci�n de JWT en ASP.NET Core 6
### En este proyecto, se aborda la implementaci�n de JSON Web Tokens (JWT) en ASP.NET Core 6. 

JSON Web Tokens son una forma segura de transmitir informaci�n entre diferentes partes de una aplicaci�n, 
como entre un cliente y un servidor. Esta t�cnica se utiliza ampliamente para habilitar la autenticaci�n y
la autorizaci�n en aplicaciones web y APIs.

El objetivo principal de utilizar JSON Web Tokens (JWT) en una aplicaci�n es habilitar la autenticaci�n y 
la autorizaci�n de manera segura y eficiente. JWT es un est�ndar abierto (RFC 7519) que proporciona un 
mecanismo para transmitir informaci�n entre diferentes partes de una aplicaci�n de una forma compacta y aut�noma.

Algunos de los principales objetivos de usar JWT son:

- Autenticaci�n del usuario: JWT se utiliza com�nmente para autenticar usuarios en aplicaciones web y APIs. Una vez que un usuario inicia sesi�n en la aplicaci�n y se verifica su identidad, se emite un JWT que contiene informaci�n sobre la identidad del usuario. Este token se env�a al cliente y se incluye en las solicitudes posteriores para autenticar al usuario en cada interacci�n con la aplicaci�n.

- Intercambio seguro de informaci�n: Los JWT son firmados digitalmente y pueden cifrarse para garantizar la integridad y confidencialidad de los datos transmitidos. Esto permite intercambiar informaci�n sensible entre diferentes partes de la aplicaci�n de manera segura y protegida contra manipulaciones no autorizadas.

- Sesiones sin estado (stateless): Los JWT son tokens autocontenidos, lo que significa que toda la informaci�n necesaria para autenticar y autorizar a un usuario se encuentra dentro del propio token. Esto permite que las aplicaciones sean "sin estado", es decir, no necesitan almacenar informaci�n de sesi�n del usuario en el servidor. Cada solicitud del cliente incluye el JWT, y el servidor puede verificar y extraer la informaci�n necesaria para responder de manera adecuada.

- Escalabilidad: Al eliminar la necesidad de almacenar informaci�n de sesi�n en el servidor, las aplicaciones que utilizan JWT pueden ser m�s escalables y f�ciles de implementar en entornos distribuidos o con m�ltiples instancias del servidor.

- Interoperabilidad: JWT es un est�ndar ampliamente adoptado, lo que significa que es compatible con una amplia variedad de lenguajes de programaci�n y frameworks. Esto facilita su implementaci�n en diferentes entornos y tecnolog�as.

- Tiempo de expiraci�n: JWT puede incluir una fecha de expiraci�n (exp), lo que permite establecer l�mites de tiempo para la validez del token. Esto es �til para garantizar que los usuarios vuelvan a autenticarse despu�s de un per�odo determinado o para revocar el acceso de un usuario en caso de que sea necesario.

![Texto alternativo](img/jwt.png)
Fuente de la imagen: [openwebinars](https://openwebinars.net/blog/que-es-json-web-token-y-como-funciona/)
