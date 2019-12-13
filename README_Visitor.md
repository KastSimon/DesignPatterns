"# DesignPatterns" 

#Problem
Wie kann man das Verhalten auf einzelnen Elementen einer Datenstruktur verändern/austauschen,
ohne die einzelnen Elemente zu verändern?


#Lösung
Kapsle eine auf den Elementen einer Objektstruktur auszuführende Operation als ein Objekt.
Der Visitor ermöglicht es, eine neue Operation zu definieren, ohne die Klasse der von ihr
bearbeiteten Elemente zu ändern

#UML



#Vorteile
-Neue Operationen lassen sich leicht durch die Definition neuer Besucher hinzufügen.
-Verwandte Operationen werden im Besucher zentral verwaltet und von besucherfremden Operationen getrennt.
-Besucher können mit Objekten aus voneinander unabhängigen Klassenhierarchien arbeiten.

#Nachteile
Die gute Erweiterungsmöglichkeit der Klassen von Besuchern muss mit einer schlechten Erweiterbarkeit 
der Klassen der konkreten Elemente erkauft werden. Müssen neue konkrete Elemente hinzugefügt werden, 
so führt dies dazu, dass viele Besucher-besuche-Methoden implementiert werden müssen.

#Beispiel




