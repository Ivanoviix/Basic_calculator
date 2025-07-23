# 🧮 Calculadora en C# (Consola)

Este es un proyecto simple de una **calculadora en C# por consola**, creado como práctica inicial al aprender el lenguaje. Incluye funcionalidades básicas como suma, resta, multiplicación, división, memoria y una extensión para aplicar descuentos.

---

## 📌 Objetivo

El propósito de este proyecto fue **practicar conceptos fundamentales de C#**, como:

- Clases y herencia
- Métodos
- Tipos de datos
- Interacción por consola
- Encapsulamiento y propiedades

---

## 🚀 Cómo usar

1. Abre el proyecto en **Visual Studio 2022**.
2. Ejecuta `Program.cs`.
3. El programa te pedirá que introduzcas tu nombre y luego mostrará un saludo personalizado.
4. A continuación, se ejecutan varias operaciones con la calculadora, mostrando los resultados en pantalla.

---

## 🧠 Funcionalidades

### ✅ Clase `Calculadora`

- `Add(a, b)` – Suma dos números  
- `Subtract(a, b)` – Resta dos números  
- `Multiply(a, b)` – Multiplica dos números  
- `Divide(a, b)` – Divide dos números (con manejo de división por cero)  
- `StoreInMemory(value)` – Guarda un valor en memoria  
- `RecallMemory()` – Recupera el valor almacenado  

### ✅ Clase `CalculadoraConDescuento`

- Hereda de `Calculadora`
- `AplicarDescuento(cantidad)` – Aplica un descuento del 10%

---

## 🧪 Ejemplo de ejecución

```plaintext
Escribe tu nombre: Iván
¡Hola, Iván!
Suma: 8
Resta: 6
Producto: 24
Cociente: 5
Precio original: 100
Precio con descuento: 90
Valor en memoria: 50
