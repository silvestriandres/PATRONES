# 🔁 Strategy Pattern — .NET Example

El **Strategy Pattern** es un patrón de comportamiento que permite definir una familia de algoritmos, encapsular cada uno de ellos y hacerlos intercambiables en tiempo de ejecución.

---

## 🎯 Problema

Supongamos que tenemos un sistema de pagos que soporta múltiples métodos:

* Tarjeta de crédito
* PayPal
* Criptomonedas

Una implementación inicial podría verse así:

```csharp
if (method == "CreditCard") { ... }
else if (method == "PayPal") { ... }
else if (method == "Crypto") { ... }
```

---

## ❌ Problemas de esta aproximación

* Alto acoplamiento
* Violación del principio Open/Closed (OCP)
* Difícil de extender (cada nuevo método requiere modificar código existente)
* Código difícil de testear y mantener

---

## ✅ Solución: Strategy Pattern

El patrón propone:

* Definir una **interfaz común**
* Implementar cada comportamiento en una clase separada
* Permitir intercambiar comportamientos dinámicamente

---

## 🧱 Estructura del ejemplo

```id="2ylk7g"
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
├── BadExample/
│   └── PaymentProcessorBad.cs
│
└── GoodExample/
    └── PaymentProcessorGood.cs
```

---

## 🧠 Cómo funciona

1. El cliente define una estrategia concreta
2. El contexto utiliza esa estrategia
3. Se puede cambiar en runtime sin modificar el contexto

---

## 🧪 Ejecución

El proyecto incluye:

* **BadExample** → implementación con `if/else`
* **GoodExample** → implementación con Strategy

Ejecutar:

```bash
dotnet run
```

---

## 📌 Beneficios

✔ Bajo acoplamiento
✔ Alta extensibilidad
✔ Cumple Open/Closed Principle
✔ Código más limpio y mantenible

---

## ⚠️ Cuándo usarlo

Usar Strategy cuando:

* Tenés múltiples variantes de un algoritmo
* Querés evitar estructuras condicionales complejas
* Necesitás cambiar comportamiento en runtime

---

## 🚫 Cuándo NO usarlo

* Si solo hay 1 o 2 variantes simples
* Si agrega complejidad innecesaria
* Si no hay probabilidad real de extensión

---

## 🔗 Relación con principios

Este patrón está fuertemente ligado a:

* Open/Closed Principle (OCP)
* Single Responsibility Principle (SRP)
* Dependency Inversion Principle (DIP)

---

## 🧠 Nota final

El objetivo no es usar Strategy siempre, sino reconocer cuándo el problema lo justifica.

Este ejemplo busca mostrar claramente esa transición desde una solución simple pero limitada hacia una solución flexible y escalable.
