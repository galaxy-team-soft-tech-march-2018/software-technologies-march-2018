![Image](https://raw.githubusercontent.com/galaxy-team-soft-tech-march-2018/software-technologies-march-2018/master/Images/Facebook%20image/Galaxy%20Team.jpg)

# software-technologies-march-2018

# Galaxy Team Project

## Exercises: C# Intro and Basic Syntax

Problems for exercises and homework for the [&quot;Programming Fundamentals Extended&quot; course @ SoftUni](https://softuni.bg/courses/programming-fundamentals).

### Problem 1.Debit Card Number
Write a progran, which receives **4 integers** on the console and **prints them** in **4-digit debit card format**. See the examples below for the appropriate formatting.

### Examples
| **Input** | **Output** |
| --- | --- |
| 12 | 0012 0433 0001 5331 |
| 433   |
| 1   |
| 5331   |

| **Input** | **Output** |
| --- | --- |
| 9182 | 9182 4221 0012 0003 |
| 4221   |
| 12   |
| 3   |

| **Input** | **Output** |
| --- | --- |
| 812 | 0812 0321 0123 0022 |
| 321   |
| 123   |
| 22   |

---

### Problem 2. Rectangle Area

Write a program, which calculates a **rectangle�s area**,
based on its **width** and **height**. The **width** and **height** come as floating point numbers on the console, 
**formatted to the 2nd character after the decimal point**.

### Examples

| **Input** | **Output** |
| --- | --- |
| 2 | 14.00 |
| 7 |  |

| **Input** | **Output** |
| --- | --- |
| 7 | 56.00 |
| 8 |  |

| **Input** | **Output** |
| --- | --- |
| 12.33 | 61.65 |
| 5 |  |

---

### Problem 3.Miles to Kilometers

Write a program, which **converts** miles **to** kilometers **.** Format **the output to the** 2nd **decimal place**.

Note: **1 mile == 1.60934 kilometers**

### Examples

| **Input** | **Output** |
| --- | --- |
| 60 | 96.56 |

| **Input** | **Output** |
| --- | --- |
| 1 | 1.61 |

| **Input** | **Output** |
| --- | --- |
| 52.1113 | 83.86 |

---

### Problem 4.Beverage Labels

Write a program, which reads a food product **name** , **volume** , **energy content**** per 100ml **and** sugar content per 100ml **. Calculate the** energy **and** sugar content **for the** given volume** and print them on the console in the following format:

- Name – as per the input
- Volume – **integer** , **suffixed** by &quot; **ml**&quot; (e.g. &quot; **220ml**&quot;)
- Energy content – **integer** , **suffixed** by &quot; **kcal**&quot; (e.g. &quot; **500kcal**&quot;)
- Sugar content – **integer** , **suffixed** by &quot; **g**&quot; (e.g. &quot; **30g**&quot;)

### Examples

| **Input** | **Output** |
| --- | --- |
| Nuka-Cola | 220ml Nuka-Cola: |
| 220 | 660kcal, 154g sugars |
| 300 |  |
| 70 |  |

| **Input** | **Output** |
| --- | --- |
| Ice Cold Nuka-Cola | 250ml Ice Cold Nuka-Cola: |
| 250 | 875kcal, 162.5g sugars |
| 350 |  |
| 65 |  |

| **Input** | **Output** |
| --- | --- |
| Nuka-Cola Quantum | 350ml Nuka-Cola Quantum: |
| 350 | 2100kcal, 490g sugars |
| 600 |  |
| 140 |  |

---

### Problem 5.\* Character Stats

Write a program, which **displays information** about a video game character. You will receive their **name** , **current health** , **maximum health** , **current energy** and **maximum energy** on separate lines. The **current** values will **always** be valid ( **equal or lower** than their respective **max** values). Print them in the format as per the examples.

### Examples

| **Input** | **Output** |
| --- | --- |
| Mayro | Name: Mayro |
| 5 | Health: \|\|\|\|\|\|\.\.\.\.\.\| |
| 10 | Energy: \|\|\|\|\|\|\|\|\|\|\.\| |
| 9 |  |
| 10 |  |

| **Input** | **Output** |
| --- | --- |
| Bauser | Name: Bauser |
| 10 | Health: \|\|\|\|\|\|\|\|\|\|\|\| |
| 10 | Energy: \|\|\|\|\|\|\|\|\|\|\|\| |
| 10 |  |
| 10 |  |

| **Input** | **Output** |
| --- | --- |
| Loogi | Name: Loogi |
| 8 | Health: \|\|\|\|\|\|\|\|\|\.\.\.\.\.\.\.\.\.\.\.\.\| |
| 20 | Energy: \|\|\|\|\|\|\|\|\|\.\.\.\.\.\.\.\.\.\.\.\.\| |
| 2 |  |
| 14 |  |

| **Input** | **Output** |
| --- | --- |
| Toad | Name: Toad |
| 0 | Health: \|\.\.\.\.\.\| |
| 5 | Energy: \|\.\.\.\.\.\.\.\.\.\.\| |
| 0 |  |
| 10 |  |

### Hints

- You can print a character **multiple** times, using **new string(character, count)**.
