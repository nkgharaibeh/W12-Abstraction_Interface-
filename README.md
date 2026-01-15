# W12 — Abstraction (Abstract Class) + Interface (C# OOP)

This repository is part of our C# OOP lab sequence:
**Inheritance → Polymorphism → Abstraction (Abstract / Interface)**.

In this week, we focus on **Abstraction** using:
1) **Abstract classes & abstract methods** (covered previously in the earlier repo), and  
2) **Interfaces** (the main focus in this repo).

---

## 0) Why Abstraction now? (from Inheritance & Polymorphism to Interfaces)

After **Inheritance**, we learned how a derived class can reuse base functionality.
After **Polymorphism**, we learned how calling the same method name can produce different behaviors.

Now **Abstraction** answers:
> “What should an object be able to do?” (the contract)  
instead of  
> “How exactly will it do it?” (the implementation)

That’s why abstraction is a bridge toward **SOLID**, especially:
- **OCP** (Open/Closed Principle): extend behavior without modifying existing code
- **DIP** (Dependency Inversion Principle): depend on abstractions, not concrete classes

---

## 1) Interface Concept (Based on Slides)

### What is an Interface?
An **interface** is a “pure contract”.
It contains **declarations** (signatures) of:
- methods
- properties  
✅ but **NOT fields** (no state)

Key notes (matching slides):
- Interface members are **public by default**
- You **cannot instantiate** an interface directly  
  (you cannot do: `new ISomething()`)
- A class **implements** an interface using `:`  
  just like inheritance syntax, but conceptually it is **contract implementation**, not code reuse.

Naming convention:
- Start interface name with **I** (e.g., `IUser`, `IPolygon`, `IColor`)

---

## 2) Why C# avoids multiple inheritance (and uses interfaces instead)

C# does **NOT** allow multiple inheritance with classes because it may cause:
1. **Too much complexity** with little benefit
2. **Conflicting members** (two base classes might define the same method differently)
3. Heavy implementation burden and potential ambiguity

Interfaces give us:
✅ “multiple inheritance of behavior contracts”  
without inheriting conflicting implementation

---

# 3) Interface Examples (01 → 05)

> Each example below contains code + comments that explain the important ideas from the slides.

---

## Example 01 — Interface Basics (One Interface, Two Implementations)

**Idea:** Two different classes implement the same interface, but each provides its own implementation.

🔗 Code: [Example 01 — Interface Basics.cs](https://github.com/nkgharaibeh/W12-Abstraction_Interface-/blob/main/Example%2001%20%E2%80%94%20Interface%20Basics.cs)

**What to learn**
- Interface = contract (method signature only)
- Multiple classes can implement the same contract
- Polymorphism idea starts to appear: “same interface, different implementations”

---

## Example 02 — Implementing Multiple Interfaces (INamed / ILocation / IAge)

**Idea:** A class can implement **many interfaces**.

🔗 Code: [Example 02 — Implementing Multiple Interfaces.cs](https://github.com/nkgharaibeh/W12-Abstraction_Interface-/blob/main/Example%2002%20%E2%80%94%20Implementing%20Multiple%20Interfaces.cs)

**Slide adaptation requested**
- Name changed to: **Ahmad Ali**
- Age changed to: **12**

**What to learn**
- This is how C# achieves “multiple inheritance style” safely
- Interfaces let you compose capabilities:
  - `IName` → can provide a name
  - `ILocation` → can provide a location
  - `IAge` → can provide an age

---

## Example 03 — Implementing an Interface (IPolygon → Rectangle)

**Idea:** Implement an interface then provide a real calculation.

🔗 Code: [Example 03 — Implementing an Interface (IPolygon → Rectangle).cs](https://github.com/nkgharaibeh/W12-Abstraction_Interface-/blob/main/Example%2003%20%E2%80%94%20Implementing%20an%20Interface%20(IPolygon%20%E2%86%92%20Rectangle).cs)

**What to learn**
- The interface declares: `calculateArea(...)`
- The class `Rectangle` must implement it (otherwise compilation error)
- You are forced into a disciplined design: *the “what” is fixed, the “how” is up to you*

---

## Example 04 — Interface Reference Variable (Using Interface Type as a Reference)

**Idea:** You can use an **interface reference** to point to a class instance that implements it.

🔗 Code: [Example 04 (Variant in slides)_Using Interface Reference Variable.cs](https://github.com/nkgharaibeh/W12-Abstraction_Interface-/blob/main/Example%2004%20(Variant%20in%20slides)_Using%20Interface%20Reference%20Variable.cs)

**What to learn**
- This is a key step toward SOLID (especially DIP):
  - write code that depends on `IPolygon`
  - not on `Rectangle`
- You can switch implementations later without changing the calling code much.

---

## Example 04 — Implementing Multiple Interfaces (IPolygon + IColor)

**Idea:** One class can provide multiple responsibilities as “contracts”.

🔗 Code: [Example 04 — Implementing Multiple Interfaces (IPolygon + IColor).cs](https://github.com/nkgharaibeh/W12-Abstraction_Interface-/blob/main/Example%2004%20%E2%80%94%20Implementing%20Multiple%20Interfaces%20(IPolygon%20%2B%20IColor).cs)

**What to learn**
- A class can be “calculatable” and also “color-aware”
- In real systems: this is composition of capabilities.

---

## Example 05 — Practical Example (Same Interface, Two Classes)

**Idea:** One interface, multiple classes (Rectangle and Square) each calculates area differently.

🔗 Code: [Example 05 — Practical Example (Same Interface, Two Classes: Rectangle + Square).cs](https://github.com/nkgharaibeh/W12-Abstraction_Interface-/blob/main/Example%2005%20%E2%80%94%20Practical%20Example%20(Same%20Interface%2C%20Two%20Classes%3A%20Rectangle%20%2B%20Square).cs)

**What to learn**
- This is the clean “bridge” between:
  - Polymorphism (same method name `calculateArea()`)
  - and Abstraction (same interface contract)
- Your code becomes extensible: adding `Triangle` later is easy.

---

# 4) Summary (Key Takeaways)

✅ Interfaces provide **abstraction without implementation**  
✅ They help build flexible systems and reduce coupling  
✅ They are the clean solution for “multiple inheritance problems”  
✅ They strongly support SOLID design:
- **OCP**: add new shapes/classes without touching existing client logic
- **DIP**: depend on interfaces (contracts), not concrete classes

---

# 5) What’s next?

Next week we connect Interfaces to:
- **SOLID** (especially DIP + ISP)
- **Design Patterns** (Strategy, Factory, Adapter)
- Writing code that is ready for real software engineering projects

---
**Tip for students:** Read code comments carefully.  
The comments are written to match the lecture slides and explain the “why”, not only the “how”.
