# State pattern

## Problem
Für ein Objekt sind verschiedene Zustände, die möglichen Übergänge zwischen diesen Zuständen und das davon abhängige Verhalten zu definieren. Dies ist hier in Form eines endlichen Automaten dargestellt. Dabei zeigt der schwarze Kreis auf den Startzustand und der schwarze Kreis mit der weißen Umrandung auf den Endzustand. Die gerichteten Kanten (Pfeile) zwischen den Zuständen Closed, Open und Deleted definieren den Zustandswechsel. 
![](https://github.com/KastSimon/DesignPatterns/blob/master/UML%20Diagramme/State%20Pattern/StatePattern_Statechart.png)

## Lösung
Das zustandsabhängige Verhalten des Objekts wird in separate Klassen ausgelagert, wobei für jeden möglichen Zustand eine eigene Klasse eingeführt wird, die das Verhalten des Objekts in diesem Zustand definiert. Damit der Kontext die separaten Zustandsklassen einheitlich behandeln kann, wird eine gemeinsame Abstrahierung dieser Klassen definiert.

Bei einem Zustandsübergang tauscht der Kontext das von ihm verwendete Zustandsobjekt aus. 

## UML
![](https://github.com/KastSimon/DesignPatterns/blob/master/UML%20Diagramme/State%20Pattern/StatePattern_Classdiagramm.png)

## Vorteile
* Ein Vorteil des Systems ist, dass komplexe und schwer zu lesende Bedingungsanweisungen vermieden werden können. Außerdem können neue Zustände und neues Verhalten auf einfache Weise hinzugefügt werden. Die Wartbarkeit wird erhöht und Zustandsobjekte können wiederverwendet werden.

## Nachteile
* Auf der anderen Seite rechtfertigt der Nutzen bei sehr einfachem zustandsbehaftetem Verhalten unter Umständen nicht den teils beträchtlichen Implementierungsaufwand. Kann das Objekt sehr viele Zustände annehmen, in denen jeweils nur sehr wenige Aktionen erlaubt sind, muss dennoch jeder Zustand für jede Aktion der anderen Zustände Code enthalten, um die Schnittstelle korrekt zu implementieren, auch wenn in diesen jeweils nur eine Ausnahmebehandlung stattfindet. In einer großen Bedingungsanweisung ließe sich die Ausnahmebehandlung hingegen in einem gemeinsamen "sonst"-Zweig vereinen. 