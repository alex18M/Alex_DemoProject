# Alex_DemoProject

# Pokemon Game


https://github.com/alex18M/Alex_DemoProject/assets/76572279/059d4ac5-253e-4222-8dec-d35707e444e5


Este es un juego de Pokemon donde puedes seleccionar un Pokemon de una lista y usarlo en diferentes partes del juego. Los Pokemon están definidos como objetos ScriptableObject y se pueden usar un máximo de 3 veces antes de ser destruidos automáticamente.

## Características

- Llenado automático de la interfaz de usuario (UI) con base en la cantidad de Pokemon listados en un ScriptableObject.
- Solo se puede seleccionar un Pokemon en la interfaz de usuario.
- El Pokemon seleccionado puede usarse en otras escenas y partes del juego mediante el uso de un ScriptableObject para guardar la selección.
- Cada Pokemon tiene los siguientes campos:
  - Nombre
  - ID
  - Salud
  - Nivel
  - Usos restantes
  - Prefab
- El Pokemon se puede usar un máximo de 3 veces mediante un botón. Se instancia una copia del Pokemon en cada clic. Cuando se alcanzan los 3 usos, se inicia un contador para destruir automáticamente los Pokemon después de 5 segundos.
- Existe un manager de Pokemon que crea y destruye los Pokemon según la lógica mencionada anteriormente en cada escena distinta a la de la interfaz de selección.

## Instrucciones de juego

1. Ejecuta el juego y verás la interfaz de selección de Pokemon.
2. Selecciona un Pokemon de la lista mostrada en la interfaz.
3. Aparecerán los datos del Pokemon seleccionado, como su nombre, ID, salud y nivel.
4. Haz clic en el botón "Play" para usar el Pokemon. Puedes hacerlo un máximo de 3 veces.
5. Si alcanzas los 3 usos, el contador se iniciará y los Pokemon se destruirán automáticamente después de 5 segundos.
6. Cuando cambies de escena, aparecerás con el Pokemon seleccionado y podrás usarlo nuevamente siguiendo los pasos anteriores.

## Requisitos del sistema

- Unity 2022.3.3f1 o superior

## Instalación

1. Clona este repositorio en tu máquina local.
2. Abre Unity y selecciona "Abrir proyecto".
3. Navega hasta la carpeta donde clonaste el repositorio y selecciona la carpeta del proyecto.
4. Espera a que Unity importe todos los archivos y configure el proyecto.
5. Una vez que se complete la importación, puedes ejecutar el juego.

## Contribuciones

Si deseas contribuir a este proyecto, siéntete libre de hacerlo. Puedes abrir un "Pull Request" con tus mejoras o correcciones y estaré encantado de revisarlas.

## Licencia

Este proyecto está bajo la Licencia de Inmersys.
