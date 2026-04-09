# 🔁 Strategy Pattern — .NET Example

El **Strategy Pattern** es un patrón de comportamiento que permite definir una familia de algoritmos, encapsular cada uno de ellos y hacerlos intercambiables en tiempo de ejecución.

Este patrón es especialmente útil cuando un sistema necesita soportar múltiples variantes de una misma operación sin recurrir a estructuras condicionales complejas.

---

## 🎯 Problema

Supongamos un sistema de pagos que soporta distintos métodos:

* Tarjeta de crédito
* PayPal
* Criptomonedas

Una implementación inicial suele verse así:

```csharp
if (method == "CreditCard") { ... }
else if (method == "PayPal") { ... }
else if (method == "Crypto") { ... }
```

---

## ❌ Problemas de esta aproximación

### 🔴 1. Violación de Open/Closed Principle (OCP)

Cada nuevo método de pago obliga a modificar la clase existente.

---

### 🔴 2. Alto acoplamiento

La lógica de todos los comportamientos está concentrada en una única clase.

---

### 🔴 3. Baja mantenibilidad

El crecimiento de condicionales genera código difícil de leer y mantener.

---

### 🔴 4. Difícil testeo

No se pueden testear los comportamientos de forma aislada.

---

### 🔴 5. Escalabilidad limitada

Agregar nuevas variantes implica riesgo de romper código existente.

---

## 💡 Idea del patrón

El Strategy Pattern propone:

* Definir una **interfaz común** para un conjunto de algoritmos
* Implementar cada algoritmo en una clase separada
* Permitir que el cliente elija cuál usar en tiempo de ejecución

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

## 🔄 Flujo de ejecución

1. El usuario selecciona un método de pago
2. El sistema determina qué estrategia usar
3. Se instancia la estrategia correspondiente
4. El contexto ejecuta el comportamiento

---

## 🧪 Ejecución

```bash
dotnet run
```

El programa:

1. Ejecuta el **BadExample**
2. Ejecuta el **GoodExample**
3. Permite seleccionar dinámicamente el método de pago

---

## ⚙️ Componentes del patrón

### 📌 Strategy (Interfaz)

```csharp
public interface IPaymentStrategy
{
    void ProcessPayment(decimal amount);
}
```

Define el contrato común para todos los algoritmos.

---

### 📌 Concrete Strategies

Cada implementación representa una variante del algoritmo:

* `CreditCardPaymentStrategy`
* `PayPalPaymentStrategy`
* `CryptoPaymentStrategy`

---

### 📌 Context

```csharp
public class PaymentContext
```

* Recibe una estrategia
* Delega la ejecución en ella
* No conoce detalles concretos

---

### 📌 Selector (adaptación simple)

```csharp
PaymentStrategySelector
```

Permite seleccionar la estrategia en base a input del usuario.

👉 **Nota:** esto no es un Factory formal, sino una solución simple para mantener el ejemplo enfocado.

---

## 🧠 Beneficios

✔ Eliminación de estructuras condicionales complejas
✔ Bajo acoplamiento
✔ Alta cohesión
✔ Fácil extensión
✔ Mejora la testabilidad
✔ Cumple Open/Closed Principle

---

## ⚠️ Trade-offs

Como todo patrón, Strategy tiene costos:

* Aumenta la cantidad de clases
* Puede ser innecesario para casos simples
* Introduce una capa de abstracción adicional

---

## 🚫 Cuándo NO usarlo

* Cuando hay una única implementación
* Cuando las variantes son muy simples
* Cuando no se espera crecimiento del sistema
* Cuando agrega complejidad innecesaria (violando KISS)

---

## 🔗 Relación con principios de diseño

Este patrón está fuertemente alineado con:

* **Open/Closed Principle (OCP)** → extensible sin modificar
* **Single Responsibility Principle (SRP)** → cada estrategia tiene una responsabilidad
* **Dependency Inversion Principle (DIP)** → el contexto depende de abstracciones

---

## 🧪 Comparación: Antes vs Después

| Aspecto        | Bad Example | Strategy |
| -------------- | ----------- | -------- |
| Extensibilidad | ❌ Baja      | ✅ Alta   |
| Acoplamiento   | ❌ Alto      | ✅ Bajo   |
| Testeo         | ❌ Difícil   | ✅ Fácil  |
| Mantenimiento  | ❌ Complejo  | ✅ Simple |

---

## 🧠 Insight importante

El Strategy Pattern no es solo una forma de eliminar `if/else`.

Es una forma de:

👉 **modelar comportamientos que pueden variar independientemente del contexto**

---

## 🚀 Posibles mejoras

Este ejemplo puede evolucionar hacia:

* Uso de enums en lugar de strings
* Integración con Dependency Injection
* Aplicación de Factory Pattern
* Testing unitario de estrategias
* Integración en APIs reales (.NET)

---

## 📌 Nota final

El objetivo no es usar Strategy en todos los casos, sino reconocer cuándo el problema lo justifica.

Este ejemplo muestra claramente el paso de una solución simple pero limitada hacia una solución flexible, mantenible y escalable.
