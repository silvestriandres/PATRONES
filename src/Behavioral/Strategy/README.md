# 🔁 Strategy Pattern — .NET Example

El **Strategy Pattern** es un patrón de comportamiento que permite definir una familia de algoritmos, encapsular cada uno de ellos y hacerlos intercambiables en tiempo de ejecución.

Permite cambiar el comportamiento de un objeto sin modificar su código.

---

## 🎯 Problema

En muchos sistemas existe una misma operación con múltiples variantes.

En este caso, un sistema de pagos que soporta:

* Tarjeta de crédito
* PayPal
* Criptomonedas

Una implementación inicial suele resolverse con condicionales.

---

## ❌ Implementación inicial (Bad Example)

```csharp
if (method == "CreditCard") { ... }
else if (method == "PayPal") { ... }
else if (method == "Crypto") { ... }
```

---

## ❌ Problemas de esta aproximación

* 🔴 Violación del Open/Closed Principle (OCP)
* 🔴 Alto acoplamiento
* 🔴 Difícil mantenimiento
* 🔴 Difícil testeo
* 🔴 Escalabilidad limitada

---

## 💡 Solución (Strategy Pattern)

El patrón propone:

* Definir una **interfaz común**
* Encapsular cada comportamiento en una clase
* Permitir intercambiar comportamientos dinámicamente

En lugar de condicionales, el comportamiento se delega a una estrategia.

---

## 🧱 Estructura del ejemplo

```plaintext
StrategyPattern.Console/
│
├── Domain/
│   └── Interfaces/
│       └── IPaymentStrategy.cs
│
├── Strategies/
│   ├── CreditCardPaymentStrategy.cs
│   ├── PayPalPaymentStrategy.cs
│   └── CryptoPaymentStrategy.cs
│
├── Context/
│   └── PaymentContext.cs
│
├── Helpers/
│   └── PaymentStrategySelector.cs
│
├── BadExample/
│   └── PaymentProcessorBad.cs
│
└── GoodExample/
    └── PaymentProcessorGood.cs
```

---

## ⚙️ Componentes del patrón

### 📌 Strategy (IPaymentStrategy)

Define el contrato común para todos los algoritmos.

---

### 📌 Concrete Strategies

Implementaciones específicas:

* CreditCardPaymentStrategy
* PayPalPaymentStrategy
* CryptoPaymentStrategy

---

### 📌 Context (PaymentContext)

Encapsula el uso de la estrategia y delega la ejecución.

---

### 📌 Selector (Helper)

Selecciona la estrategia en base a input del usuario.

> Nota: no es un Factory formal, se mantiene simple a propósito.

---

## 🔄 Flujo de ejecución

1. El usuario selecciona un método de pago
2. El sistema obtiene la estrategia correspondiente
3. Se crea el contexto con esa estrategia
4. El contexto ejecuta el pago

---

## 🧪 Ejecución

```bash
dotnet run
```

El programa:

* Ejecuta el BadExample
* Ejecuta el GoodExample
* Permite seleccionar dinámicamente el método de pago

---

## 🧠 Beneficios

✔ Eliminación de condicionales complejos
✔ Bajo acoplamiento
✔ Alta cohesión
✔ Fácil extensión
✔ Mejora la testabilidad
✔ Cumple Open/Closed Principle

---

## ⚠️ Trade-offs

* Aumenta la cantidad de clases
* Puede ser innecesario en casos simples
* Introduce una capa de abstracción adicional

---

## 🚫 Cuándo NO usarlo

* Cuando existe una única implementación
* Cuando las variantes son muy simples
* Cuando no se espera crecimiento
* Cuando agrega complejidad innecesaria (violando KISS)

---

## 🔗 Relación con principios

* **Open/Closed Principle (OCP)** → extensible sin modificar
* **Single Responsibility Principle (SRP)** → cada estrategia tiene una responsabilidad
* **Dependency Inversion Principle (DIP)** → el contexto depende de abstracciones

---

## 🧪 Comparación: Antes vs Después

| Aspecto        | Sin patrón | Con Strategy |
| -------------- | ---------- | ------------ |
| Extensibilidad | ❌ Baja     | ✅ Alta       |
| Acoplamiento   | ❌ Alto     | ✅ Bajo       |
| Testeo         | ❌ Difícil  | ✅ Fácil      |
| Mantenimiento  | ❌ Complejo | ✅ Simple     |

---

## 🧠 Insight clave

El Strategy Pattern no solo elimina `if/else`.

Permite modelar comportamientos que pueden variar independientemente del contexto, favoreciendo un diseño flexible y extensible.

---

## 🚀 Posibles mejoras

* Reemplazar strings por enums
* Integrar Dependency Injection
* Aplicar Factory Pattern para selección
* Agregar tests unitarios
* Integrar en una API real (.NET)

---

## 📌 Nota final

El objetivo no es usar Strategy siempre, sino reconocer cuándo el problema lo justifica.

Este ejemplo muestra la transición desde una solución simple pero rígida hacia un diseño flexible y mantenible.
