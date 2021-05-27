# ARSolaris
Bienvenido a Solaris Web, este sitio fue creado con el objetivo de mostrar una forma de aprendizaje de la Astronomía, haciendo uso de la realidad aumentada para mostrar las maravillas de nuestro sistema como pocas veces se ha explorado, todo esto a través de un simple dispositivo móvil.

# ¿Cómo funciona?

La integración de la Realidad Aumentada dentro del sitio es controlada empleando el framework de código abierto llamada A-Frame a través del cual se usaron los componentes que esta herramienta contiene para la generación del entorno en el que se mostrará el modelo del planeta que sea elegido, todo usando la cámara de un dispositivo e.g celular/smartphone, tablet o laptop/PC.

Los modelados de los planetas fueron creados a partir del uso de la aplicación de Blender, en la cual se generó la figura o primitiva, en este caso una esfera sobre la cual se le aplicó una textura, dado el enfoque del proyecto se usaron las de los planetas del sistema solar. Exportando dichos modelos ya generado, usando de igual manera Blender a formato “.gtlf” el cual es necesario para mostrar este tipo de componentes en el framework de A-Frame.
