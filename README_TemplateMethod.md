# Template Method Pattern

# Problem
Die Struktur eines Algorithmus ist die gleiche in verschiedenen Unterklassen, aber die Verarbeitungsdetails variieren von Unterklasse zu Unterklasse.

# Lösung
Definiere die Struktur des Algorithmus (Skelett) in der Basisklasse. Diese Template Methode ruft andere Methoden für die variierenden Details auf. Diese anderen Methoden (Hook methods) werden in den Unterklassen entsprechend überschrieben. 

# UML
![TemplatePattern] (TemplatePattern.png?raw=true "UML")

# Vorteile


# Nachteile
