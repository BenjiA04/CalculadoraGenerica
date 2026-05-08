
# Calculadora Genérica

## 📌 Descripción
Aplicación de consola desarrollada en **C#** que permite al usuario ingresar una lista de números de manera genérica (**enteros, decimales o flotantes**) para posteriormente realizar diferentes operaciones matemáticas.

Los valores ingresados se almacenan en una lista y luego pueden utilizarse en las siguientes operaciones:

- ➕ Suma
- ➖ Resta
- ✖️ Multiplicación
- ➗ División

---

# Estructura del Proyecto
El proyecto fue desarrollado utilizando un enfoque modular para mantener una estructura organizada, reutilizable y fácil de mantener.

## 📂 UI
Contiene las clases encargadas de interactuar con el usuario mediante los menús de navegación.

### `MenuOperacion`
Muestra al usuario las operaciones matemáticas disponibles para realizar con los números ingresados.

### `MostrarMenu`
Es el menú principal donde el usuario selecciona el tipo de dato que desea utilizar.

---

## ⚙️ Services
Contiene la lógica principal del sistema.

### `IngresarValores`
Método genérico encargado de recibir y almacenar los números ingresados por el usuario.

### `RealizarOperaciones`
Método genérico que utiliza los valores almacenados para ejecutar operaciones matemáticas mediante el uso de delegados y expresiones lambda.

---

# 🛡️ Manejo de Excepciones

El sistema incluye validaciones para evitar errores durante la ejecución:

- Validación de formatos inválidos al ingresar datos.
- Manejo de división entre cero.
- Validación de opciones incorrectas dentro del menú.
