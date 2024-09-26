# BUENAS PRÁCTICAS Y CÓDILO LIMPIO EN LENGUAJE C#
En este repositorio podrás encontrar conceptos y ejemplos del uso de código limpio y buenas prácticas en lenguaje de programación c#.

## Estándares y buenas prácticas: 

  **1. Nombramiento Variables**

    Las varibales deben ser descriptibles e indicar el propósito de lo que se guarda en ella.
    Se recomienda usar el estándar de nombramiento de la empresa o de las fuente certificadas. 

```
// Mala práctica
var a = 'Hello world';
Console.WriteLine(a);
```

```
// Buena práctica
var message = 'Hello world';
Console.WriteLine(message);
```

  **2. Nombramiento de Métodos**

    Al igual que las variables, los métodos se deben nombrar con nombres descriptivos. Se recomienda usar PascalCase. 
    Recordemos que en los lenguajes de programación modernos ya no se usa la codificación húngara. 
    Finalmente, no usar nombres de métodos o clases con números.      

  **3. Code Smell**

    El code smell hace referencia a la existencia de:

    * Código duplicado
    * Métodos y clases con código extenso. 
    * Constructores o métodos con demasiados parámetros.
    * Números mágicos (magic numbers).
    * Código quemado.
    * Nombres de métodos, clases, variables, etc consufusos.
    * Código comentado.
    * Código muerto (código que nunca se ejecuta), falta de encapsulación, dependencias circulares.

  **4. Principio DRY (Dont repeat yourself)** 

    Este principio se refiere a reutilizar las rutinas de código y maximizar la ejecución y visualización del mismo. 

  **5. Principio KISS (Keep it simple stupid - Keep it short and simple)**

    Simplificar el código para evitar extender el diseño o complejidad de la solucion.   
    Facilitar el mantenimiento de las aplicaciones. 

  **6. Uso correcto Try-Catch**

    Se recomienda usar try-catch en excenarios exepcionales o inusuales en el código, donde se puede producir un error no controlado. 
    Es una mala práctica implementar dicha sentencia, donde se evidencie un control o validación que se pueda resolver de forma manual o con otra sentencia de código mas liviana. 
    El rendimiento de try-catch se ve afectado al capturar la excepción, por eso es recomendable usarlo solo en excenarios exepcionales. 

  **7. Recomendaciones de los comentarios**

    * No abusar de los comentarios en el código fuente. 
    * No poner comentarios si son obvios.
    * Escribir código fácil para entender la filosofía.
    * No comentar la trazabilidad de los cambios, para eso tenemos la herramienta de versionamiento de  código.
    * Escribir cometarios cortos y claros.
    * No dejar código comentado.

  **8. Recomendaciones finales**

    * Leer siempre sobre buenas prácticas
    * Realiza code review entre colegas o entre compañeros de trabajo. 
    * Realizar refactoring al código cuando sea necesario. 
    * Utiliza herramientas que te ayudena limpiar el código: Sonarqube, sonarcloud, etc
    * Implementar estándares y prácticas comunes en empresa o proyectos. 

