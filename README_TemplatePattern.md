# Template pattern

## Problem
Die Struktur eines Algorithmus ist die gleiche und kommt mehrmals in verschiedenen Unterklassen vor, jedoch können die Verarbeitungsdetails variieren von Unterklasse zu Unterklasse.

## Lösung
Beim Schablonenmethoden-Entwurfsmuster wird in einer abstrakten Klasse das Skelett eines Algorithmus definiert. Die konkrete Ausformung der einzelnen Schritte wird an Unterklassen delegiert. Dadurch besteht die Möglichkeit, einzelne Schritte des Algorithmus zu verändern oder zu überschreiben, ohne dass die zu Grunde liegende Struktur des Algorithmus modifiziert werden muss.

## UML
![](https://github.com/KastSimon/DesignPatterns/blob/master/UML%20Diagramme/Template%20Pattern/TemplatePattern.png)

## Vorteile
* Es können durch die Unterklassen details an einem Algoritmus modifiziert werden ohne den zu Grunde liegende Struktur anpassen zu müssen.

## Nachteile
* Es liegt eine grosse Abhängigkeit vor.
