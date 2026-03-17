# Wissenstest 3AHWII - C# Programmierung

**Datum:** 03.03.2026  
**Dauer:** 20 Minuten  
**Hilfsmittel:** Keine (Closed Book)

---

## Teil A: Multiple Choice (7-12 Fragen)

**Anleitung:** Kreuzen Sie die richtige(n) Antwort(en) an. Es kann eine oder mehrere richtige Antworten geben.

---

### Frage 1
Was versteht man unter "Agentic Coding"?

- [ ] Ein neues Programmierparadigma wie OOP oder funktionale Programmierung
- [X] Die Verwendung von KI-Agenten (wie Opencode.ai) zur Unterstützung bei der Softwareentwicklung
- [ ] Ein spezielles Design Pattern für Multi-Agent-Systeme
- [ ] Die Programmierung von autonomen Robotern

---

### Frage 2
Welche Inference Provider wurden im Unterricht mit Opencode.ai besprochen?

- [ ] Nur OpenAI GPT-4
- [X] GitHub Models, Opencode Zen und OpenRouter
- [ ] Nur lokale Modelle wie Ollama
- [ ] AWS Bedrock und Google Vertex AI

---

### Frage 3
Was ist der Hauptunterschied zwischen Open-Source und Closed-Source KI-Modellen?

- [ ] Open-Source Modelle sind immer schneller als Closed-Source Modelle
- [X] Open-Source Modelle sind öffentlich zugänglich und können selbst gehostet werden, Closed-Source Modelle sind proprietär und nur über APIs erreichbar
- [ ] Closed-Source Modelle sind immer kostenlos, Open-Source Modelle kosten immer Geld
- [-] Es gibt keinen Unterschied, beide funktionieren identisch
// - sie funktionieren gleich aber es gibt Unterschiede
---

### Frage 4
Was ist CSV?

- [ ] Character Separated Values
- [X] Comma Separated Values
- [ ] C# Source Variable
- [ ] Common System Variable

---

### Frage 5
Welche NuGet-Package wird im Unterricht für das Einlesen von CSV-Dateien mit C# empfohlen?

- [ ] Newtonsoft.Json
- [X] CsvHelper
- [ ] EntityFrameworkCore
- [ ] System.Data.SqlClient

---

### Frage 6
Welches Trennzeichen (Delimiter) wird typischerweise in CSV-Dateien verwendet?

- [ ] Nur Komma (,)
- [X] Semikolon (;) oder Komma (,)
- [ ] Nur Tabulator (\t)
- [ ] Nur Pipe (|)

---

### Frage 7
Welche Vorteile bietet die Verwendung von CsvHelper gegenüber manuellem String-Splitting?

- [X] Automatische Typkonvertierung und Mapping auf Klassen
- [ ] Bessere Performance bei kleinen Dateien
- [ ] Keine Vorteile, String-Splitting ist immer besser
- [ ] CsvHelper ist im .NET Framework bereits integriert

---

### Frage 8
Was ist ein "Skill" in Opencode.ai?

- [ ] Eine Zertifizierung für erfahrene Programmierer
- [x] Eine domänenspezifische Anweisung, die dem Agenten spezielle Fähigkeiten gibt (z.B. für .NET, React, etc.)
- [ ] Ein neues C# Keyword
- [ ] Eine Bewertung der Programmierfähigkeiten des Users

---

### Frage 9
Was ist ein wichtiger Best Practice beim Agentic Coding?

- [ ] Dem Agenten niemals Kontext geben, damit er selbstständig denkt
- [X] Klare und präzise Anweisungen geben, Kontext bereitstellen und Ergebnisse überprüfen
- [ ] Den Agenten nur kurze, einwortige Befehle geben
- [ ] Den generierten Code nie testen, da KI-Code immer fehlerfrei ist

---

### Frage 10
Was passiert im Bruch-Konstruktor, wenn der Nenner 0 ist?

- [ ] Es wird eine DivideByZeroException geworfen
- [X] Es wird eine ArgumentException mit der Nachricht "Der Nenner darf nicht Null sein." geworfen
- [ ] Der Bruch wird automatisch auf 1/1 gesetzt
- [ ] Das Programm stürzt ab

---

### Frage 11
Welche xUnit-Attribute werden verwendet, um mehrere Testfälle mit verschiedenen Eingaben zu definieren?

- [ ] `[Fact]` und `[InlineData]`
- [ ] `[Theory]` und `[InlineData]`
- [X] `[Test]` und `[TestCase]`
- [ ] `[Parameterized]` und `[DataRow]`

---

### Frage 12
Was ist OpenRouter im Kontext von Agentic Coding?

- [ ] Ein Router für Open-Source-Netzwerke
- [X] Ein Service, der Zugriff auf verschiedene KI-Modelle von verschiedenen Anbietern über eine einheitliche API bietet
- [ ] Ein Routing-Algorithmus für C#-Anwendungen
- [ ] Ein Tool zur Netzwerkdiagnose

---

## Teil B: Freitext-Fragen (2-3 Fragen)

**Anleitung:** Beantworten Sie die folgenden Fragen in ganzen Sätzen. Achten Sie auf Vollständigkeit und Präzision.

---

### Frage 13
**Agentic Coding - Best Practices (5 Punkte)**

Beschreiben Sie mindestens 3 Best Practices für die effektive Zusammenarbeit mit einem KI-Coding-Agenten wie Opencode.ai. Gehen Sie dabei auf folgende Aspekte ein:
- Wie formuliert man gute Prompts/Anweisungen? Klare und präzise Anweisungen geben und Kontext bereitstellen
- Warum ist Kontext wichtig? Damit der KI-Agent nichts falsch versteht und die richtigen gewünschten Anweisungen erfüllt die für mein Projekt essenziell sind.
- Was sollte man mit dem generierten Code tun? Man sollte sich den Code noch einmal selber anschauen bevor man sich entgültig entscheided es zu benutzen. Bei Fehlern kann man den Agenten noch einmal anschreiben und solange nachfragen bis es eventuell passt für einen. 

---

### Frage 14
**CSV-Verarbeitung mit CsvHelper (5 Punkte)**

Sie haben eine CSV-Datei mit Personendaten (wie persons.csv aus dem Unterricht). Beschreiben Sie die grundlegenden Schritte, um diese Datei mit CsvHelper in C# einzulesen und die Daten in der Konsole auszugeben. Gehen Sie dabei auf folgende Punkte ein:
- Welche Klassen/Modelle benötigen Sie? Wir brauchen eine Personenklasse.
- Wie konfigurieren Sie den CsvReader? Indem man eine neues Objekt erstellt mit der Klasse.
- Wie iterieren Sie über die Datensätze? Mit einem "foreach" Kommando.

---

### Frage 15
**Open-Source vs. Closed-Source KI-Modelle (5 Punkte)**

Diskutieren Sie Vor- und Nachteile von Open-Source und Closed-Source KI-Modellen im Kontext des Software-Engineerings. Berücksichtigen Sie dabei:
- Kostenaspekte
Es gibt viele gute Open-Source Modelle die nicht schlechter als Closed-Source Modelle sind daher. Open-Source sind gratis und Closed-Source Modelle kosten etwas.
- Datenschutz und Datensouveränität
Closed-Source: man braucht Daten, Open-Source: man kann die Modelle lokal und auch privat benutzen ohne das Daten immer rumgeschickt werden müssen
- Qualität und Performance der Modelle
Open-Source Modelle sind auch gut aber für eine bessere Qualität und Performance sind Closed-Source Modell geeigneter.
- Anpassungsmöglichkeiten
Open-Source: eher lockerer, man kann auch eigene "costumized" Anpassen, Closed-Source: hängt vom Anbieter an wie viele Möglichkeiten man für eigene Anpassungen hat.

---

**Viel Erfolg!**
