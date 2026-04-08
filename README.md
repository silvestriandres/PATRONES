# 🧠 Fundamentos de Diseño de Software en .NET

Este repositorio reúne una colección de ejemplos prácticos enfocados en **principios fundamentales de diseño de software**, aplicados en .NET.

A diferencia de repositorios centrados únicamente en patrones de diseño, este proyecto pone el foco en **los conceptos que guían las decisiones de diseño**, como principios, buenas prácticas y fundamentos teóricos llevados a código real.

---

## 🎯 Objetivo

El objetivo de este proyecto es:

* Entender **por qué** surgen los patrones de diseño
* Aplicar principios como **SOLID**, **GRASP**, **KISS** y **YAGNI**
* Analizar problemas reales de diseño
* Comparar implementaciones incorrectas vs correctas
* Construir criterio de ingeniería, no solo conocimiento teórico

---

## 🧱 Estructura del Proyecto

El repositorio está organizado por conceptos clave de diseño:

```
/COMPOSICIÓN-HERENCIA
/GRASP
/INVERSIÓN-DEPENDENCIAS
/SOLID
/YAGNI-KISS
```

Cada carpeta contiene ejemplos prácticos y casos de uso enfocados en ese principio o conjunto de principios.

---

## 📚 Contenido

### 🧩 COMPOSICIÓN vs HERENCIA

Explora cuándo usar composición en lugar de herencia.

**Conceptos clave:**

* "Favor composition over inheritance"
* Reutilización de comportamiento
* Bajo acoplamiento

**Problema típico:**
Jerarquías rígidas difíciles de extender y mantener.

---

### 🧠 GRASP (General Responsibility Assignment Software Patterns)

Conjunto de principios para asignar responsabilidades correctamente.

**Incluye:**

* Information Expert
* Creator
* Controller
* Low Coupling
* High Cohesion

**Objetivo:**
Diseñar clases con responsabilidades claras y bien distribuidas.

---

### 🔌 INVERSIÓN DE DEPENDENCIAS

Aplicación del principio Dependency Inversion Principle (DIP).

**Conceptos clave:**

* Dependencia de abstracciones en lugar de implementaciones
* Inversión de control
* Desacoplamiento entre capas

**Problema típico:**
Clases fuertemente acopladas a implementaciones concretas, difíciles de testear y extender.

---

### 🧱 SOLID

Implementación de los 5 principios SOLID:

* S — Single Responsibility Principle (SRP)
* O — Open/Closed Principle (OCP)
* L — Liskov Substitution Principle (LSP)
* I — Interface Segregation Principle (ISP)
* D — Dependency Inversion Principle (DIP)

**Objetivo:**
Construir software mantenible, extensible y testeable.

---

### ⚖️ YAGNI & KISS

Principios de simplicidad en el diseño.

* **YAGNI (You Aren’t Gonna Need It):** evitar implementar funcionalidad innecesaria
* **KISS (Keep It Simple, Stupid):** mantener el diseño simple y claro

**Problema típico:**
Sobreingeniería, complejidad innecesaria y código difícil de mantener.

---

## 🧪 Enfoque de los Ejemplos

Cada módulo sigue una estructura didáctica:

1. **Problema**
2. **Implementación inicial (naive / incorrecta)**
3. **Problemas de esa implementación**
4. **Refactor aplicando el principio**
5. **Resultado y beneficios**

Este enfoque permite entender no solo *qué hacer*, sino también *qué evitar*.

---

## 🔗 Relación con Patrones de Diseño

Este repositorio complementa el estudio de patrones de diseño.

* Los **principios** explican el **por qué**
* Los **patrones** explican el **cómo**

Ejemplo:

* SOLID → base conceptual
* Strategy Pattern → implementación concreta basada en Open/Closed

---

## 🧠 Filosofía del Proyecto

Este repo está pensado como:

* 📘 Material de estudio progresivo
* 🧪 Laboratorio de experimentación
* 🧱 Base para construir criterio de diseño

No busca ser un framework ni una librería productiva, sino una herramienta para aprender a diseñar mejor software.

---

## 🚀 Cómo usar este repositorio

1. Explorar cada carpeta por separado
2. Leer el contexto del problema
3. Ejecutar los ejemplos
4. Comparar implementaciones
5. Intentar extender o refactorizar el código

---

## 📌 Próximos pasos

Este proyecto puede evolucionar hacia:

* Integración con patrones de diseño clásicos
* Ejemplos combinando múltiples principios
* Casos más cercanos a aplicaciones reales (.NET APIs, servicios, etc.)

---

## 👨‍💻 Autor

Proyecto orientado al aprendizaje y profundización en diseño de software en .NET, con enfoque práctico y profesional.
