# 🏭 Factory Method Pattern — .NET Example

El **Factory Method Pattern** es un patrón creacional que define una interfaz para crear objetos, pero permite que las subclases decidan qué clase concreta instanciar.

Este patrón delega la responsabilidad de creación a clases especializadas, evitando el uso directo de `new`.

---

## 🎯 Problema

En muchos sistemas, la creación de objetos depende de condiciones específicas.

Por ejemplo, un sistema de pagos que crea diferentes tipos de objetos según el método:

* Tarjeta de crédito
* PayPal

Una implementación inicial suele verse así:

---

## ❌ Implementación inicial (Bad Example)

```csharp
if (method == "CreditCard")
    return new CreditCardPayment();
else if (method == "PayPal")
    return new PayPalPayment();
```

---

## ❌ Problemas de esta aproximación

* 🔴 Violación del Open/Closed Principle (OCP)
* 🔴 Alto acoplamiento con clases concretas
* 🔴 Difícil de extender
* 🔴 Uso excesivo de condicionales
* 🔴 El cliente necesita conocer tipos concretos

---

## 💡 Solución (Factory Method Pattern)

El patrón propone:

* Definir una **interfaz o clase abstracta para la creación**
* Delegar la creación a subclases concretas
* Evitar el uso directo de `new` en el código cliente

En lugar de crear objetos directamente, se utiliza un método de fábrica.

---

## 🧱 Estructura del ejemplo

```plaintext
FactoryMethodPattern.Console/
│
├── Products/
│   ├── IPayment.cs
│   ├── CreditCardPayment.cs
│   └── PayPalPayment.cs
│
├── Creators/
│   ├── PaymentCreator.cs
│   ├── CreditCardPaymentCreator.cs
│   └── PayPalPaymentCreator.cs
│
├── BadExample/
│
└── GoodExample/
```

---

## ⚙️ Componentes del patrón

### 📌 Product (IPayment)

Define la interfaz común para los objetos que se crean.

---

### 📌 Concrete Products

Implementaciones específicas:

* CreditCardPayment
* PayPalPayment

---

### 📌 Creator (PaymentCreator)

Declara el método de fábrica que devuelve un producto.

---

### 📌 Concrete Creators

Clases que implementan el método de fábrica:

* CreditCardPaymentCreator
* PayPalPaymentCreator

---

## 🔄 Flujo de ejecución

1. El cliente solicita un objeto a través del creator
2. El creator delega la creación a una subclase
3. Se retorna una instancia concreta
4. El cliente utiliza el objeto sin conocer su implementación

---

## 🧪 Ejecución

```bash
dotnet run
```

El proyecto incluye:

* Un **BadExample** con lógica condicional
* Un **GoodExample** aplicando Factory Method

---

## 🧠 Beneficios

✔ Bajo acoplamiento
✔ Cumple Open/Closed Principle
✔ Encapsula la creación de objetos
✔ Facilita la extensión del sistema
✔ Mejora la mantenibilidad

---

## ⚠️ Trade-offs

* Aumenta la cantidad de clases
* Puede ser innecesario en casos simples
* Introduce una capa de abstracción adicional

---

## 🚫 Cuándo NO usarlo

* Cuando la creación de objetos es simple
* Cuando no hay variaciones en los tipos
* Cuando no se espera crecimiento del sistema

---

## 🔗 Relación con principios

* **Open/Closed Principle (OCP)** → permite agregar nuevos tipos sin modificar código existente
* **Single Responsibility Principle (SRP)** → separa creación de uso
* **Dependency Inversion Principle (DIP)** → el cliente depende de abstracciones

---

## 🧪 Comparación: Antes vs Después

| Aspecto              | Sin patrón | Con Factory Method |
| -------------------- | ---------- | ------------------ |
| Creación de objetos  | ❌ Acoplada | ✅ Encapsulada      |
| Extensibilidad       | ❌ Baja     | ✅ Alta             |
| Uso de condicionales | ❌ Alto     | ✅ Bajo             |
| Mantenimiento        | ❌ Complejo | ✅ Simple           |

---

## 🧠 Insight clave

El Factory Method no elimina la creación de objetos.

👉 La **traslada a un punto controlado y extensible**.

Esto permite desacoplar el código cliente de las clases concretas.

---

## 🚀 Posibles mejoras

* Integración con Dependency Injection
* Uso en frameworks (ASP.NET, servicios)
* Combinación con Strategy Pattern
* Implementación de Abstract Factory

---

## 📌 Nota final

El objetivo no es evitar `new`, sino evitar depender de clases concretas.

Factory Method permite crear sistemas más flexibles, extensibles y mantenibles.
