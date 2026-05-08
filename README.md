
# Calculadora Generica

## Descripcion
Sistema enfocado en calcular una lista de numeros de manera generica, el usuario ingresa cualquier tipo de numero (entero, decimal o flotante),
y se guardan dentro de una lista para mas adelantes usarlas en operaciones de suma, resta, multiplicacion o division.

El proyecot esta desarrollado con un enfoque modular, sus partes las describimos de la siguiente manera:

## Estructura

### UI: Aqui estan las clases que contienen los menus de navegacion que interactuara el cliente.
- MenuOperacion: Consiste en metodo que le muestra al usuario las opciones que hay para calcular con los numeros.
- MostrarMenu: Es el menu principal, el usuario eligira el tipo de dato que usara.

### Services: Estos son los metodos que usaran los datos.
- IngresarValores: Metodo generico que permite al usuario ingresar los numeros a usar.
- RealizarOperaciones: Metodo generico que usa los valores que ingresamos, consiste de un delegado que recibe la operacion y los valores
y el metodo que lo calcula.

