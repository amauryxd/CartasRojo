# Instrucciones para agregar tus armas
 ## Como Preparar tus armas para exportar
 Hola :D<br>
 Para empezar vamos a habrir el proyecto donde tienes tus armas _(el proyecto que le enseñaste a rojo)_<br><br>
 Ahora necesitamos crear un cubo, resetamos su transform, y modifcamos su escala con 1, 5.5 , 8
<br>
![Como modificar la escala](./imgTuto/Escala.png)<br>
Tendran este cubito
![Cubo](./imgTuto/CuboZ.png)<br>
### Esta sera la pantalla que tendran para mostrar su arma<br>
Ahora el caso es tratar de meter tus armas dentro de este cubo<br>
Para saber que estamos viendo del lado correcto, la "Z" de nuestro navegador debe de estar a la derecha<br>
![Navegador](./imgTuto/Navegador.png)<br>
Ahora tenemos que ajustar nuestra arma<br>
De ejemplo pongamos mi arma y esto sera algo común:
- El arma no esta en 0,0,0
- Esta gigante
- Esta Rotada
- No esta cerca del cubo

![Hielo](./imgTuto/EjemploNo1.png)![Hielo2](./imgTuto/EjemploNo2.png)<br>
### TODOS ESTOS DETALLES HARÁN QUE TU ARMA NO SE VEA
Ahora vamos a corregirlo<br>
**Primero** vamos resetear el transform del arma

![Ejemplo1](./imgTuto/Ejemplo1.png)![Ejemplo2](./imgTuto/Ejemplo2.png)<br>
todavia no esta dentro del cubo<br>
ahora manualmente trata de que tu arma este dentro del cubo _(Recuerden que la "Z" del navegador este a la derecha)_

![Ahorasi](./imgTuto/Ahorasi.png)![Ahorasi2](./imgTuto/Ahorasi2.png)<br>

Si por algun motivo el arma queda un tantito más afuera del cubo, solo por si acaso les recomiendo meterlo tantito

![Afuera1](./imgTuto/Afuera1.png)![Afuera2](./imgTuto/Afuera2.png)

Perfecto, ahora creamos el prefab del arma que tenemos crear el prefab de lo que acabamos de mover

![Comogif](./imgTuto/tutogif%20(2).gif)
## Como exportar
Ahora para exportar les voy a pedir un poco más de cuidado, ya que se pueden llegar a exportar codigos o dependencias inecesarias que pueden hacer que el proyecto se muera<br>
No lo digo por mala onda pero es probable que algunos tengamos un desastre en el proyecto, y esto tambien se exportara<br>
Para evitar que esto llege al otro proyecto y luego tengamos problemas para encontrar cosas o se haga un despapaye vamos a hacer lo siguiente:<br>
**Empezamos por crear una carpeta con nuestro nombre**

![ExportarTuto1](./imgTuto/ExportarParta1.png)<br>
Ahora vamos a empezar a meter cosas<br>
Les recomiendo crear carpetas con los nombres de los elementos adentro

![ExportarTuto2](./imgTuto/ExportarParte2.png)<br>

Ahora empiezen a pasar todo lo que necesiten dentro de estas carpetas<br>
Probablemente tengan que pasar:
- Modelo del arma
- Shader Graphs
- Materiales
- Animaciones
- Prefab del arma que crearon antes

Esta lista solo es una sugerencia, si su arma necesita algo mas de lo que puse en la lista, metanlo también<br>
Lo que trato de decir:
> Metan todo lo que tu arma necesite y deja fuera todo lo que no es necesario

Por ejemplo mi arma de hielo necesita esto:
![ExportarTuto3](./imgTuto/ExportarParte3.png)<br>

Ya con esto, mi arma no deberia de pasarle nada al momento de pasarla al otro proyecto<br>
lo que sigue es repetir el proceso hasta terminar todas sus armas<br><br>
**Una vez Terminadas todas las armas ahora si es momento de exportar**<br>
Nos dirigimos en la parte de arriba En Assets>Export Package...
![Donde](./imgTuto/ExportarDonde.png)<br>

### CHECAMOS QUE SOLO IMPORTEMOS LA CARPETA CON NUESTRO NOMBRE
Si por algun motivo no solo aparece nuestra carpeta con nuestro nombre **ESTA MAL**<br>
Como en el siguiente caso:

![exportalMal](./imgTuto/ExportarNo.png)

Aparece la carpeta con mi nombre pero tambien otras mas<br>
En este caso hay de 2
- No metiste todo lo que necesitaba tu arma y en estas carpetas se encuentran
- Son dependencias de unity o similares

**¿Como las diferencio?**<br>
Pues tendrás que checar cuales de las cosas que faltan si las usan tus armas y cuales no<br>

En caso de comprobar que a tus armas no les falta nada, y aun asi sigan apareciendo carpetas, probablemente sean dependecias, lo único que hacemos es deseleccionarlas<br>
![Exporting1](./imgTuto/ExportarNo4.png)
![Exporting](./imgTuto/ExportarNo3.png)<br>

Ahora le asignamos un nombre y lo guardamos

![Guardado](./imgTuto/ExportarParte4.png)

Genial, ahora ya tenemos nuestro packete exportado, solo falta 2 paso más
## Como importar
Para empezar vamos a importar nuestras armas<br>
Para ello vamos a Assets>Import Package...>Custom Package...

![Importar](./imgTuto/Importar1.png)

Seleccionamos el que creamos

![Importar2](./imgTuto/Importar2.png)

Nos saldra esta ventana, solo le damos a importar

![Importar3](./imgTuto/Importar3.png)

Su carpeta con su nombre deberia aparecer, porfa **Pasenlo dentro de la carpeta _Armas_**

![importar4](./imgTuto/tutogif1%20(2).gif)

Ahora dentro de la carpeta con tu nombre, crean un nueva carpeta<br>
De preferencia que se llame como tu + SOB<br>
En mi caso es `AmaurySOB`

![Importar5](./imgTuto/SOB1.png)

Genial ahora solo falta agregar tus armas

## Como agregar las armas
Dentro de su carpeta con terminacion _SOB_ damos click derecho en create > Crea una nueva descripcion de arma

![Sob2](./imgTuto/SOB2.png)

Nos creara este archivo:

![Sob3](./imgTuto/SOB3.png)

El nombre de preferencia que sea del arma que van a describir

![Sob4](./imgTuto/SOb4.png)

Ahora, al seleccionar el objeto dentro del inspector aparecera lo siguiente:

![Sob5](./imgTuto/SOB5.png)

los campos son los siguientes:

-   Carta Nombre
    - `Tipo String` Es el nombre de tu arma
- Elemento
    - `Tipo Sprite o imagen` Es la imagen del elemento de la carta _(más adelante te explico donde agragarlo)_
- Habilidad Nombre
    - `Tipo String` Es el nombre de la habilidad de tu arma
- Habilidad Descripción
    - `Tipo String` Es la descripción de lo que hace la habilidad de tu arma
- Arma descripción
    - `Tipo String` Es el transfondo de tu arma
- Nombre Persona
    - `Tipo String` Es tu nombre
- Carta Color
    - `Tipo Color` Es el color que quieres que tu carta tenga
- Modelo Arma
    - `Tipo GameObject` Aquí va a tu prefab

Empezamos a rellenar todos los espacios, en el caso de Elemento, podemos encontrar las imagenes en `Asstes/ElementosImagenes`

![SOB6](./imgTuto/SOB6.png)<br>

En el caso de Modelo Arma, Fijense muy bien que metieron el prefab y no el modelo:

![so](./imgTuto/so.png)

Cuando llegemos a modelo de arma tienen que buscar tu **prefab del arma**, no el modelo<br>
**Un consejo que puedo para que sea más fácil, en el inspector, en los 3 puntos, da click en _Properties..._ soltara una ventana flotante que te dejara navegar entre los archivos**

![SOB7](./imgTuto/SOB8.png)

### PORFAVOR RELLENEN TODOS LOS CAMPOS
porque si no se van a tronar el programa<br>

Cuando terminen debería de verse algo parecido a esto:

![Sob9](./imgTuto/SOB9.png)

genial, ahora hacemos eso con todas nuestras armas