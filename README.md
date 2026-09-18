<div align="center">

# Laboratorio #1 — Controles Básicos de C#

### Aplicaciones Windows Forms con C#

<img src="./assets/banner-laboratorio.jpg" alt="Banner del Laboratorio" width="100%">

**Universidad Tecnológica de Panamá · Facultad de Ingeniería de Sistemas Computacionales**

<br>

<img src="https://skillicons.dev/icons?i=cs,dotnet,visualstudio,git,github" alt="Tecnologías utilizadas" />

<br><br>

![C#](https://img.shields.io/badge/C%23-512BD4?style=for-the-badge\&logo=csharp\&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge\&logo=dotnet\&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-0078D4?style=for-the-badge\&logo=windows\&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91?style=for-the-badge\&logo=visualstudio\&logoColor=white)
![Git](https://img.shields.io/badge/Git-F05032?style=for-the-badge\&logo=git\&logoColor=white)
![GitHub](https://img.shields.io/badge/GitHub-181717?style=for-the-badge\&logo=github\&logoColor=white)

<br>

**Fecha de realización:** 16 de agosto de 2026

</div>
---

## Contenido

* [Descripción](#descripción)
* [Objetivos](#objetivos)
* [Tecnologías utilizadas](#tecnologías-utilizadas)
* [Descripción de las prácticas](#descripción-de-las-prácticas)
* [Capturas de pantalla y problemas](#capturas-de-pantalla-y-problemas)
* [Flujo general del laboratorio](#flujo-general-del-laboratorio)
* [Estructura del repositorio](#estructura-del-repositorio)
* [Comprobación mediante Excel](#comprobación-mediante-excel)
* [Requisitos](#requisitos)
* [Ejecución](#ejecución)
* [Autor y contexto académico](#autor-y-contexto-académico)

---

## Descripción

Este repositorio contiene el desarrollo del **Laboratorio #1 de Programación**, realizado utilizando el lenguaje **C#** y la tecnología **Windows Forms**.

La práctica está orientada al aprendizaje y aplicación de conceptos fundamentales relacionados con:

* Controles de interfaz gráfica.
* Captura de datos.
* Eventos de botones.
* Conversión de datos.
* Operaciones matemáticas.
* Cálculos porcentuales.
* Estructuras condicionales.
* Selección de opciones mediante `RadioButton`.
* Presentación de resultados.
* Validación de cálculos mediante Microsoft Excel.

El laboratorio está compuesto por **tres problemas independientes**, cada uno implementado como un proyecto de Windows Forms.

---

## Objetivos

### Objetivo general

Desarrollar aplicaciones gráficas sencillas utilizando **C# y Windows Forms**, aplicando controles básicos de interfaz y lógica de programación para resolver diferentes problemas.

### Objetivos específicos

* Utilizar controles básicos de Windows Forms.
* Capturar información introducida por el usuario.
* Manipular valores numéricos.
* Realizar operaciones aritméticas.
* Implementar cálculos de porcentajes.
* Utilizar botones para ejecutar acciones.
* Utilizar `RadioButton` para seleccionar operaciones.
* Mostrar resultados dinámicamente.
* Aplicar estructuras condicionales.
* Verificar los resultados obtenidos mediante Microsoft Excel.

---

## Tecnologías utilizadas

<div align="center">

|                                    Tecnología                                   | Utilización         |
| :-----------------------------------------------------------------------------: | ------------------- |
|             <img src="https://skillicons.dev/icons?i=cs" width="45">            | **C#**              |
|           <img src="https://skillicons.dev/icons?i=dotnet" width="45">          | **.NET**            |
|        <img src="https://skillicons.dev/icons?i=visualstudio" width="45">       | **Visual Studio**   |
|            <img src="https://skillicons.dev/icons?i=git" width="45">            | **Git**             |
|           <img src="https://skillicons.dev/icons?i=github" width="45">          | **GitHub**          |
| <img src="https://img.icons8.com/color/48/microsoft-excel-2019.png" width="45"> | **Microsoft Excel** |

</div>

### Stack tecnológico

```text
┌─────────────────────────────────────────────────────┐
│                  LABORATORIO #1                     │
├─────────────────────────────────────────────────────┤
│                                                     │
│  Lenguaje             C#                            │
│                                                     │
│  Plataforma            .NET                         │
│                                                     │
│  Interfaz              Windows Forms                │
│                                                     │
│  IDE                   Visual Studio                │
│                                                     │
│  Control de versiones  Git / GitHub                 │
│                                                     │
│  Validación            Microsoft Excel              │
│                                                     │
└─────────────────────────────────────────────────────┘
```

---

# Descripción de las prácticas

## Problema 1 — Ingreso y visualización de una fecha

La primera práctica consiste en desarrollar una interfaz que permita al usuario introducir una fecha mediante diferentes campos.

El formulario solicita:

* Día.
* Mes.
* Año.

Posteriormente, mediante un botón, los valores introducidos son procesados y la fecha es mostrada al usuario.

### Flujo de funcionamiento

```mermaid
flowchart LR
    A["Inicio"] --> B["Ingresar día"]
    B --> C["Ingresar mes"]
    C --> D["Ingresar año"]
    D --> E["Presionar botón"]
    E --> F["Procesar datos"]
    F --> G["Mostrar fecha"]
    
    style A fill:#7C3AED,color:#fff,stroke:#A78BFA
    style B fill:#06B6D4,color:#fff,stroke:#67E8F9
    style C fill:#06B6D4,color:#fff,stroke:#67E8F9
    style D fill:#06B6D4,color:#fff,stroke:#67E8F9
    style E fill:#F97316,color:#fff,stroke:#FDBA74
    style F fill:#EC4899,color:#fff,stroke:#F9A8D4
    style G fill:#22C55E,color:#fff,stroke:#86EFAC
```

### Conceptos aplicados

* `TextBox`
* `Button`
* Captura de datos
* Conversión de valores
* Manipulación de información
* Eventos de Windows Forms

---

## Problema 2 — Cálculo de descuento

La segunda práctica desarrolla una aplicación capaz de calcular el descuento aplicado sobre el precio de un producto.

El usuario proporciona:

* Precio.
* Porcentaje de descuento.

El programa calcula automáticamente:

1. El valor monetario del descuento.
2. El precio final a pagar.

### Fórmula del descuento

```text
Descuento = Precio × (Porcentaje / 100)
```

### Fórmula del precio final

```text
Total = Precio - Descuento
```

### Flujo de funcionamiento

```mermaid
flowchart TD
    A["Inicio"] --> B["Ingresar precio"]
    B --> C["Ingresar porcentaje"]
    C --> D["Presionar calcular"]
    D --> E["Calcular descuento"]
    E --> F["Calcular total"]
    F --> G["Mostrar resultados"]
    
    style A fill:#7C3AED,color:#fff,stroke:#A78BFA
    style B fill:#06B6D4,color:#fff,stroke:#67E8F9
    style C fill:#06B6D4,color:#fff,stroke:#67E8F9
    style D fill:#F97316,color:#fff,stroke:#FDBA74
    style E fill:#EC4899,color:#fff,stroke:#F9A8D4
    style F fill:#EC4899,color:#fff,stroke:#F9A8D4
    style G fill:#22C55E,color:#fff,stroke:#86EFAC
```

### Ejemplo

```text
Precio:       $100.00
Descuento:       15%

Descuento:     $15.00
Total:         $85.00
```

### Conceptos aplicados

* `TextBox`
* `Button`
* Variables numéricas
* Porcentajes
* Operaciones aritméticas
* Conversión de datos
* Presentación de resultados

---

## Problema 3 — Operaciones matemáticas

La tercera práctica permite realizar diferentes operaciones matemáticas utilizando dos números introducidos por el usuario.

Las operaciones implementadas son:

| Operación | Expresión           |
| --------- | ------------------- |
| Suma      | `Número1 + Número2` |
| Resta     | `Número1 - Número2` |
| División  | `Número1 / Número2` |

La operación es seleccionada mediante controles `RadioButton`.

### Flujo de funcionamiento

```mermaid
flowchart TD
    A["Inicio"] --> B["Ingresar número 1"]
    B --> C["Ingresar número 2"]
    C --> D["Seleccionar operación"]
    D --> E{"¿Qué operación?"}
    
    E -->|Suma| F["Número 1 + Número 2"]
    E -->|Resta| G["Número 1 - Número 2"]
    E -->|División| H["Número 1 / Número 2"]
    
    F --> I["Mostrar resultado"]
    G --> I
    H --> I
    
    style A fill:#7C3AED,color:#fff,stroke:#A78BFA
    style B fill:#06B6D4,color:#fff,stroke:#67E8F9
    style C fill:#06B6D4,color:#fff,stroke:#67E8F9
    style D fill:#F97316,color:#fff,stroke:#FDBA74
    style E fill:#E11D48,color:#fff,stroke:#FDA4AF
    style F fill:#8B5CF6,color:#fff,stroke:#C4B5FD
    style G fill:#8B5CF6,color:#fff,stroke:#C4B5FD
    style H fill:#8B5CF6,color:#fff,stroke:#C4B5FD
    style I fill:#22C55E,color:#fff,stroke:#86EFAC
```

### Consideración importante

En la operación de división debe evitarse que el segundo número sea `0`, ya que no es posible realizar una división entre cero.

---

# Capturas de pantalla y problemas

Las siguientes capturas corresponden a la ejecución de cada uno de los problemas desarrollados durante el laboratorio.

---

## Interfaz — Problema 1

### Ingreso y visualización de fecha

![Captura del Problema 1](./assets/NOMBRE-EXACTO-PROBLEMA-1.png)

**Descripción:**
Interfaz desarrollada en Windows Forms para ingresar día, mes y año, y posteriormente mostrar la fecha resultante.

---

## Interfaz — Problema 2

### Cálculo de descuento

![Captura del Problema 2](./assets/NOMBRE-EXACTO-PROBLEMA-2.png)

**Descripción:**
Interfaz encargada de recibir el precio y el porcentaje de descuento para calcular el valor descontado y el total final.

---

## Interfaz — Problema 3

### Operaciones matemáticas

![Captura del Problema 3](./assets/NOMBRE-EXACTO-PROBLEMA-3.png)

**Descripción:**
Interfaz que permite ingresar dos valores y seleccionar mediante `RadioButton` la operación matemática que se desea ejecutar.

---

# Flujo general del laboratorio

El funcionamiento general del laboratorio puede representarse mediante el siguiente flujo:

```mermaid
flowchart TB
    A["LABORATORIO #1<br/>Controles Básicos de C#"]
    
    A --> B["Problema 1<br/>Fecha"]
    A --> C["Problema 2<br/>Descuento"]
    A --> D["Problema 3<br/>Operaciones"]
    
    B --> E["Windows Forms"]
    C --> E
    D --> E
    
    E --> F["Captura de datos"]
    F --> G["Procesamiento"]
    G --> H["Resultado"]
    
    C --> I["Validación"]
    D --> I
    
    I --> J["Microsoft Excel"]
    
    style A fill:#7C3AED,color:#fff,stroke:#C4B5FD,stroke-width:3px
    style B fill:#06B6D4,color:#fff,stroke:#67E8F9
    style C fill:#F97316,color:#fff,stroke:#FDBA74
    style D fill:#EC4899,color:#fff,stroke:#F9A8D4
    style E fill:#2563EB,color:#fff,stroke:#93C5FD
    style F fill:#8B5CF6,color:#fff,stroke:#C4B5FD
    style G fill:#E11D48,color:#fff,stroke:#FDA4AF
    style H fill:#22C55E,color:#fff,stroke:#86EFAC
    style I fill:#F59E0B,color:#fff,stroke:#FCD34D
    style J fill:#16A34A,color:#fff,stroke:#86EFAC
```

---

# Estructura del repositorio

El repositorio está organizado en tres proyectos independientes correspondientes a las prácticas del laboratorio.

```text
LABORATORIO-CONTROLES-BASICOS-DE-C-SHARP-Victor-Montes/
│
├── README.md
│
├── Pract1 - Controles - Victor Montes/
│   │
│   ├── Pract1-Controles.slnx
│   │
│   └── Pract1-Controles/
│       ├── Form1.cs
│       ├── Form1.Designer.cs
│       ├── Form1.resx
│       ├── Program.cs
│       └── Pract1-Controles.csproj
│
├── Pract2 - ProyectoDescuento - Victor_Montes/
│   │
│   ├── ProyectoDescuento - Victor_Montes.slnx
│   │
│   └── ProyectoDescuento - Victor_Montes/
│       ├── Form1.cs
│       ├── Form1.Designer.cs
│       ├── Form1.resx
│       ├── Program.cs
│       └── ProyectoDescuento - Victor_Montes.csproj
│
├── Pract3 - EstructuraIf 3 - Victor Montes/
│   │
│   ├── Pract8-EstructuraIf 3 - Victor Montes.slnx
│   │
│   └── Pract8-EstructuraIf 3 - Victor Montes/
│       ├── Form1.cs
│       ├── Form1.Designer.cs
│       ├── Form1.resx
│       ├── Program.cs
│       └── Pract8-EstructuraIf 3 - Victor Montes.csproj
│
└── docs/
    └── images/
        ├── problema-1.png
        ├── problema-2.png
        └── problema-3.png
```

### Organización lógica

```mermaid
flowchart LR
    R["Repositorio"]
    
    R --> P1["Práctica 1"]
    R --> P2["Práctica 2"]
    R --> P3["Práctica 3"]
    R --> DOC["Documentación"]
    
    P1 --> F1["Form1.cs"]
    P1 --> D1["Designer"]
    P1 --> S1["Solution"]
    
    P2 --> F2["Form1.cs"]
    P2 --> D2["Designer"]
    P2 --> S2["Solution"]
    
    P3 --> F3["Form1.cs"]
    P3 --> D3["Designer"]
    P3 --> S3["Solution"]
    
    DOC --> IMG["Capturas"]
    DOC --> README["README.md"]
    
    style R fill:#7C3AED,color:#fff,stroke:#C4B5FD,stroke-width:3px
    style P1 fill:#06B6D4,color:#fff,stroke:#67E8F9
    style P2 fill:#F97316,color:#fff,stroke:#FDBA74
    style P3 fill:#EC4899,color:#fff,stroke:#F9A8D4
    style DOC fill:#22C55E,color:#fff,stroke:#86EFAC
    style IMG fill:#10B981,color:#fff,stroke:#6EE7B7
    style README fill:#10B981,color:#fff,stroke:#6EE7B7
```

---

# Comprobación mediante Excel

Como complemento del laboratorio, se utilizó **Microsoft Excel** para comprobar los resultados obtenidos en determinadas operaciones.

La validación permite comparar los resultados producidos por el programa con cálculos independientes.

### Operaciones verificadas

```text
                    VALIDACIÓN
                        │
             ┌──────────┴──────────┐
             │                     │
        Problema 2             Problema 3
             │                     │
             ▼                     ▼
       Descuento               Suma
       Total final             Resta
                               División
             │                     │
             └──────────┬──────────┘
                        ▼
                Microsoft Excel
                        │
                        ▼
                 Comparación
                        │
                        ▼
                Resultado válido
```

---

# Requisitos

Para ejecutar los proyectos se requiere un entorno compatible con aplicaciones Windows Forms desarrolladas en C#.

### Software

* Windows.
* Visual Studio.
* .NET compatible con el proyecto.
* Microsoft Excel para consultar la validación de resultados.

### Conocimientos recomendados

* Fundamentos de programación.
* Variables.
* Operadores aritméticos.
* Estructuras condicionales.
* Eventos.
* C# básico.
* Conceptos básicos de Windows Forms.

---

# Ejecución

## 1. Clonar el repositorio

```bash
git clone https://github.com/VITIDEV06/LABORATORIO-CONTROLES-BASICOS-DE-C-SHARP-Victor-Montes.git
```

## 2. Acceder al repositorio

```bash
cd LABORATORIO-CONTROLES-BASICOS-DE-C-SHARP-Victor-Montes
```

## 3. Abrir el proyecto

Abrir cualquiera de las tres soluciones `.slnx` utilizando **Visual Studio**.

```text
Pract1 - Controles - Victor Montes/
Pract2 - ProyectoDescuento - Victor_Montes/
Pract3 - EstructuraIf 3 - Victor Montes/
```

## 4. Compilar

Desde Visual Studio:

```text
Build
   ↓
Build Solution
```

## 5. Ejecutar

Ejecutar la aplicación utilizando:

```text
Start
```

o mediante:

```text
F5
```

---

# Controles de Windows Forms utilizados

El laboratorio permite trabajar con diferentes controles básicos de la interfaz gráfica.

| Control       | Función                            |
| ------------- | ---------------------------------- |
| `TextBox`     | Entrada de información             |
| `Label`       | Presentación de texto              |
| `Button`      | Ejecución de acciones              |
| `RadioButton` | Selección de una operación         |
| `Form`        | Ventana principal de la aplicación |

---

# Conceptos de programación aplicados

```mermaid
mindmap
  root((C# Windows Forms))
    Interfaz gráfica
      Form
      Label
      TextBox
      Button
      RadioButton
    Entrada
      Datos del usuario
      Conversión numérica
    Procesamiento
      Operaciones aritméticas
      Porcentajes
      Condicionales
    Salida
      Resultados
      Mensajes
    Validación
      Microsoft Excel
      Comparación de resultados
```

---

# Resumen de las prácticas

|  #  | Práctica    | Conceptos principales                     |
| :-: | ----------- | ----------------------------------------- |
|  01 | Fecha       | Entrada de datos y presentación           |
|  02 | Descuento   | Porcentajes y operaciones matemáticas     |
|  03 | Operaciones | `RadioButton`, condicionales y aritmética |

---

# Resultado del laboratorio

El laboratorio permitió implementar tres aplicaciones gráficas independientes utilizando C# y Windows Forms.

```text
                   LABORATORIO #1
                         │
           ┌─────────────┼─────────────┐
           │             │             │
           ▼             ▼             ▼
       PROBLEMA 1    PROBLEMA 2    PROBLEMA 3
           │             │             │
         FECHA        DESCUENTO    OPERACIONES
           │             │             │
           └─────────────┼─────────────┘
                         │
                         ▼
                WINDOWS FORMS
                         │
                         ▼
                  C# + .NET
                         │
                         ▼
                  RESULTADOS
                         │
                         ▼
                VALIDACIÓN EXCEL
```

---

# Autor y contexto académico

<div align="center">

### Victor Montes

**Universidad Tecnológica de Panamá (UTP)**

**Facultad de Ingeniería de Sistemas Computacionales**

**Laboratorio #1 — Controles Básicos de C#**

**Fecha de realización:** 16 de agosto de 2026

<br>

<img src="https://skillicons.dev/icons?i=cs,dotnet,visualstudio" alt="C# .NET Visual Studio" />

</div>

---

# Referencia

Este repositorio corresponde al desarrollo académico del **Laboratorio #1 de Controles Básicos de C#**, realizado como parte de las actividades prácticas de programación de la **Universidad Tecnológica de Panamá**.

---

<div align="center">

**C# · .NET · Windows Forms · Visual Studio · Git · GitHub**

<br>

Desarrollado por **Victor Montes**

</div>
