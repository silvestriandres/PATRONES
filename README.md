# 🧠 PATRONES — Diseño y Arquitectura de Software en .NET

Este repositorio es una colección de ejemplos prácticos de **patrones de diseño y arquitectura**, implementados en .NET, con un enfoque claro en **entender problemas reales y sus soluciones**.

No se trata solo de implementar patrones, sino de comprender:

* **Cuándo usarlos**
* **Qué problema resuelven**
* **Qué pasa si no los usamos**
* **Cómo impactan en la calidad del software**

---

## 🎯 Objetivo

Este proyecto tiene como objetivo principal construir **criterio de diseño de software**, más allá de la teoría.

Busca:

* Comprender los patrones desde un enfoque práctico
* Analizar problemas reales de diseño
* Comparar implementaciones incorrectas vs correctas
* Aplicar buenas prácticas de ingeniería
* Generar ejemplos reutilizables y didácticos

---

## 🧭 Enfoque

Cada patrón en este repositorio está pensado como un **ejercicio aislado**, generalmente implementado como una **Console App**, para:

* Reducir ruido (sin frameworks innecesarios)
* Enfocar en el problema y la solución
* Facilitar la comprensión

---

## 🧱 Estructura del Repositorio

El proyecto está organizado por **categorías clásicas de patrones**, siguiendo una clasificación ampliamente utilizada:

```id="0c8o8o"
/src/
 ├── Creational/
 ├── Structural/
 ├── Behavioral/
 └── Architectural/
```

---

### 🏭 Creational

Patrones enfocados en la **creación de objetos**.

```id="m2rqws"
/src/Creational/
 ├── Factory/
 ├── AbstractFactory/
 ├── Builder/
 └── Singleton/
```

**Problemas que resuelven:**

* Creación compleja de objetos
* Dependencias rígidas
* Falta de flexibilidad al instanciar clases

---

### 🧱 Structural

Patrones enfocados en la **composición y estructura del sistema**.

```id="v57z0x"
/src/Structural/
 ├── Decorator/
 ├── Adapter/
 ├── Facade/
 └── Composite/
```

**Problemas que resuelven:**

* Acoplamiento entre componentes
* Rigidez en la estructura del sistema
* Dificultad para extender comportamiento

---

### 🔁 Behavioral

Patrones enfocados en el **comportamiento e interacción entre objetos**.

```id="fh43y7"
/src/Behavioral/
 ├── Strategy/
 ├── Mediator/
 ├── Observer/
 └── Command/
```

**Problemas que resuelven:**

* Lógica condicional compleja
* Alto acoplamiento entre clases
* Dificultad para cambiar comportamientos

---

### 🏗️ Architectural

Patrones a nivel de **arquitectura de sistema**.

```id="v8g6lw"
/src/Architectural/
 ├── Layered/
 ├── CleanArchitecture/
 ├── CQRS/
 └── EventDriven/
```

**Problemas que resuelven:**

* Escalabilidad
* Separación de responsabilidades
* Mantenibilidad en sistemas grandes

---

## 🧪 Estructura de cada patrón

Cada patrón sigue una estructura consistente para facilitar el aprendizaje:

```id="t9d9vn"
PatternName/
 ├── PatternName.Console/
 └── README.md
```

---

### 📁 Dentro de cada proyecto

```id="a9a6u7"
PatternName.Console/
 ├── Program.cs
 ├── BadExample/
 ├── GoodExample/
 ├── Domain/
 ├── Implementations/
 └── Context/ (si aplica)
```

---

## 🧠 Metodología de aprendizaje

Cada ejemplo está diseñado siguiendo este flujo:

### 1. Problema

Situación real donde aparece una limitación de diseño.

### 2. Implementación incorrecta (Bad Example)

Código típico con problemas como:

* Alto acoplamiento
* Violación de principios SOLID
* Dificultad de extensión

### 3. Problemas detectados

Análisis de por qué esa solución no escala.

### 4. Refactor con patrón (Good Example)

Aplicación del patrón correspondiente.

### 5. Resultado

Comparación clara entre ambas soluciones.

---

## 🔗 Relación con principios de diseño

Este repositorio se apoya fuertemente en principios como:

* SOLID
* GRASP
* KISS
* YAGNI

Los patrones no existen en el vacío:
son **respuestas concretas a problemas que estos principios ayudan a identificar**.

---

## ⚠️ Filosofía importante

> No todos los problemas necesitan un patrón.

Este repositorio promueve:

✔ Uso consciente de patrones
✔ Evitar sobreingeniería
✔ Priorizar simplicidad cuando sea posible

---

## 🛠️ Tecnologías utilizadas

* .NET (C#)
* Console Applications (principalmente)
* Estructuras simples, sin frameworks innecesarios

---

## 🚀 Cómo usar este repositorio

1. Navegar por categoría (Creational, Structural, etc.)
2. Elegir un patrón
3. Leer el README del patrón
4. Ejecutar el proyecto de consola
5. Analizar diferencias entre Bad vs Good
6. Extender el ejemplo por cuenta propia

---

## 📈 Evolución del proyecto

Este repositorio puede crecer hacia:

* Integración de múltiples patrones en un mismo ejemplo
* Versiones con ASP.NET Core
* Casos más cercanos a entornos productivos
* Testing unitario aplicado a cada patrón

---

## 👨‍💻 Enfoque profesional

Este proyecto está diseñado como:

* 📘 Material de estudio estructurado
* 🧪 Laboratorio práctico
* 🧠 Entrenamiento de pensamiento arquitectónico

---

## 📌 Nota final

El objetivo no es memorizar patrones, sino **desarrollar criterio para diseñar software mantenible, escalable y limpio**.

---

## 👨‍💻 Autor

Repositorio orientado al aprendizaje profundo de diseño de software en .NET, con enfoque práctico y profesional.
