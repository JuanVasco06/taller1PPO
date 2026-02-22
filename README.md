# taller1PPO

## Descripción

Este proyecto es una aplicación de consola en **C# (.NET)** desarrollada como solución de una tarea de PPO.

El programa implementa una clase `Time` que permite:

- Crear horas con diferentes constructores
- Validar valores de hora, minutos, segundos y milisegundos
- Obtener el tiempo en:
  - Milisegundos
  - Segundos
  - Minutos
- Sumar dos objetos `Time`
- Validar si la suma corresponde a otro día
- Mostrar la salida en consola con el formato solicitado en el enunciado

---

## Estructura del proyecto

- `Program.cs` → Contiene el método `Main` y las pruebas de ejecución
- `Time.cs` → Contiene la clase `Time` con atributos, constructores y métodos
- `taller1PPO.csproj` → Archivo del proyecto C#
- `taller1PPO.sln` → Archivo de solución para Visual Studio

---

## Requisitos

- **.NET SDK 8.0 o superior** (también puede correr en .NET 10 si lo tienes instalado)
- **Visual Studio 2022** (opcional, para ejecución desde IDE)

---

## Cómo ejecutar el proyecto

### Opción 1: Desde terminal (recomendada)

Ubícate en la carpeta del proyecto y ejecuta:

```bash
dotnet run
