# 🧪 Laboratorio de C# — Windows Forms

Proyecto desarrollado en **C# utilizando Windows Forms**, como parte de las prácticas de programación. El laboratorio contiene diferentes ejercicios orientados al manejo de formularios, entrada de datos, eventos de botones, operaciones matemáticas y cálculos.

## 📌 Descripción

El proyecto está compuesto por **tres prácticas principales**, cada una enfocada en una funcionalidad diferente:

1. 📅 **Ingreso y visualización de fecha**
2. **Cálculo de descuentos**
3. 🧮 **Operaciones matemáticas**

Además, se elaboró un archivo de **Excel para comprobar y validar los resultados obtenidos en las prácticas 2 y 3**.

---

## 🛠️ Tecnologías utilizadas

* **C#**
* **Windows Forms**
* **.NET**
* **Visual Studio**
* **Microsoft Excel**

---

# 📚 Prácticas realizadas

## 📅 Práctica 1 — Fecha

Esta práctica permite ingresar los datos correspondientes a:

* Día
* Mes
* Año

El usuario introduce cada valor en el formulario y posteriormente presiona un botón para mostrar la fecha ingresada.

### Funcionamiento

```text
Día: 24
Mes: 08
Año: 2026

        ↓

    [ Mostrar ]

        ↓

24/08/2026
```

El objetivo es practicar la **captura de datos mediante controles de Windows Forms y la interacción mediante botones**.

---

## Práctica 2 — Cálculo de descuento

En esta práctica se introduce un **precio** y se realiza el cálculo de un descuento.

El programa muestra:

* Precio indicado
* Descuento en porcentaje
* Descuento en dólares
* Total a pagar

### Ejemplo

Si el usuario introduce:

```text
Precio: $100.00
Descuento: 15%
```

El programa calcula:

```text
Descuento en dólares: $15.00
Total a pagar: $85.00
```

### Fórmulas utilizadas

**Descuento en dólares:**

```text
Descuento = Precio × (Porcentaje / 100)
```

**Total a pagar:**

```text
Total = Precio - Descuento
```

Los resultados de esta práctica también fueron **comprobados mediante el archivo de Excel desarrollado para el laboratorio**.

---

## 🧮 Práctica 3 — Operaciones matemáticas

La tercera práctica permite realizar operaciones matemáticas utilizando **dos números ingresados por el usuario**.

Las operaciones disponibles son:

* Suma
* Resta
* División

El usuario introduce los dos números y selecciona la operación mediante un **RadioButton**.

Posteriormente, al presionar el botón correspondiente, el programa realiza la operación seleccionada y muestra el resultado.

### Ejemplo

```text
Número 1: 20
Número 2: 5

Operación:
( ) Suma
( ) Resta
(x) División

        ↓

    [ Calcular ]

        ↓

Resultado: 4
```

### Operaciones

| Operación | Fórmula             |
| --------- | ------------------- |
| Suma      | `Número1 + Número2` |
| Resta     | `Número1 - Número2` |
| División  | `Número1 / Número2` |

Los resultados de esta práctica también fueron **verificados utilizando el archivo de Excel**.

> ⚠️ En el caso de la división, se debe considerar que el segundo número no sea `0`.

---

# 📊 Comprobación mediante Excel

Como parte del laboratorio se desarrolló un archivo de **Microsoft Excel** utilizado para comprobar los resultados obtenidos por el programa.

El Excel permite comparar los cálculos realizados manualmente con los resultados generados por la aplicación.

Se utilizó principalmente para validar:

* Cálculo del descuento en dólares.
* Cálculo del total a pagar.
* Suma de dos números.
* Resta de dos números.
* División de dos números.

Esto permite comprobar que las operaciones implementadas en C# producen los resultados esperados.

---

# 🎯 Objetivos del laboratorio

Con este laboratorio se busca practicar:

* Uso de **C#**.
* Desarrollo de aplicaciones con **Windows Forms**.
* Captura de información mediante controles.
* Uso de `TextBox`.
* Uso de `Button`.
* Uso de `RadioButton`.
* Manejo de eventos.
* Operaciones matemáticas.
* Cálculos con porcentajes.
* Conversión de datos introducidos por el usuario.
* Validación de resultados mediante Excel.

---

# 🖥️ Estructura general

El funcionamiento del laboratorio puede resumirse de la siguiente manera:

```text
                  LABORATORIO C#
                       │
          ┌────────────┼────────────┐
          │            │            │
          ▼            ▼            ▼
      PRÁCTICA 1   PRÁCTICA 2   PRÁCTICA 3
          │            │            │
          ▼            ▼            ▼
        Fecha       Descuento    Operaciones
                       │            │
                       └──────┬─────┘
                              ▼
                         EXCEL
                       Comprobación
```

---

# 🚀 Ejecución del proyecto

Para ejecutar el proyecto:

1. Clonar o descargar el repositorio.
2. Abrir la solución en **Visual Studio**.
3. Abrir el archivo de solución `.sln`.
4. Compilar el proyecto.
5. Ejecutar la aplicación.

---

# 👨‍💻 Autor

**Victor Montes**

Proyecto académico desarrollado como práctica de programación utilizando **C# y Windows Forms**.
