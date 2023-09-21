Version 10

# Grob-Planung

**Robin Müller**

bis zu den *Herbstferien*

## Leit-Satz

Ich möchte meine Kenntnisse in C# verbessern und meine Kenntnisse über das Thema "Aufträge im eigenen Berufsumfeld selbstständig durchführen" verbessern.

## Arbeitspakete für 29.08.2023

- [x] Ein Programm, welches eine Geheimzahl erfindet. Danach fragt es "Wie lautet die Geheimzahl?". Das Programm gibt an, ob die Zahl zu hoch oder zu tief ist. Wenn die Zahl richtig ist, sagt das Programm "Bravo, super gemacht!"
  
  | Vorbereitung             | Eingabe                 | Erwartete Ausgabe                                    |
  | ------------------------ | ----------------------- | ---------------------------------------------------- |
  | Programm in VS gestartet | > drücken in VS         | erstellt eine Zufallszahl`Wie lautet die Geheimzahl` |
  | Programm in VS gestartet | Zahl eingeben (zu hoch) | `Die Zahl ist zu hoch`                               |
  | Programm in VS gestartet | Zahl eingeben (zu tief) | `Die Zahl ist zu tief`                               |
  | Programm in VS gestartet | Zahl eingeben (richtig) | `Bravo, super gemacht die Geheimzahl lautet ...`     |

- [x] Ein Erweiterung, welches das obige Spiel mit einem Highscore erweitert und einen Multiplayer hinzufügt, bei dem zwei Spieler gleichzeitig Zahlen raten können (Jeder Spieler hat natürlich eine eigene Geheimzahl)
  
  | Vorbereitung             | Eingabe                              | Erwartete Ausgabe                                                                      |
  | ------------------------ | ------------------------------------ | -------------------------------------------------------------------------------------- |
  | Programm in VS gestartet | > drücken in VS                      | erstellt eine Zufallszahl`Wie lautet die Geheimzahl`                                   |
  | Programm in VS gestartet | Spieler 1 rät nach seiner Geheimzahl | Highscore um 1 erhöhen oder `Bravo, Spieler 1 hat gewonnen mit einem Hihscore von ...` |
  | Programm in VS gestartet | Spieler 2 rät nach seiner Geheimzahl | Highscore um 1 erhöhen oder `Bravo, Spieler 2 hat gewonnen mit einem Hihscore von ...` |
  | Programm in VS gestartet | Zahl eingeben (zu hoch)              | Highscore um 1 erhöhen (verschlechtern)                                                |
  | Programm in VS gestartet | Zahl eingeben (zu tief)              | Highscore um 1 erhöhen (verschlechtern)                                                |
  | Programm in VS gestartet | Zahl eingeben (richtig)              | `Bravo, dein Hihscore beträgt ...`                                                     |

- [ ] Ich bearbeite Auftrag 1711 vom Modul 431: "Ich kann mit einer Tabellenkalkulation selber einen Plan mit Teilautomation erstellen."

- [ ] Ich bearbeite Auftrag 1712 vom Modul 431: "Ich kann mit einer Tabellenkalkulation in Tabellen Filtern und Sortieren."

✍️  Heute konnte ich einen Single -und Multiplayer für das Spiel "Errate die Geheimzahl" programmieren. Allerdings konnte ich heute die Aufträge 1711 und 1712 vom Modul 431 nicht mehr bearbeiten, da mir beim Programmieren des Spiels immer wieder neue Ideen gekommen sind und ich diese direkt umsetzen wollte. Ich sollte das nächste mal nur das geplante umsetze und nicht noch Ideen, die mir beim Programmieren kommen.

## Arbeitpakete für 5.09.2023

- [x] Ich möchte das Spiel "Errate die Geheimzahl" so erweitern, damit es beim Multiplayer ein Duell gibt, wenn es ein Unentschieden gibt.

- [x] Ich möchte mein Spiel , so erweitern damit es bei Fehleingaben (try catch) nicht abstürtzt. 

- [x] Ich bearbeite Auftrag 1716 vom Modul 431: "Ich kann mit einer Tabellenkalkulation selber eine Checkliste erstellen."

- [ ] Ich bearbeite Auftrag 1717 vom Modul 431: "Ich kann aus einer Auswahl von Techniken eine geeignete auswählen (Problem, Kreativität, Lernen)."

✍️  Heute konnte ich das Duell für das Spiel "Errate die Geheimzahl" programmieren. Danach habe mich der "Try-Catch" Funktion in C# angeschaut. Ich konnte die Funktion allerdings nur im Singelplayer einbauen, weil mir die Zeit davon rannte. Allerdings gibt es immernoch einen kleinen Fehler in bestimmten Situationen, bei dem ein Befehl zu viel ausgeführt wird. Vielleicht kann ich diesen im Lerngespräch besprechen. Von den heutigen Aufträgen aus den Modulen konnte ich einen bearbeiten. Für den zweiten hatte ich keine Zeit mehr, da ich einige Probleme mit der Einrückung hatte, allerdings hat am Schluss nur eine geschweifte Klammer gefehlt. Die Pakete kommen den 45min immer näher.

## Arbeitspakete für 12.09.2023

- [x] Ich programmiere die "Try-Catch" Funktion auch in den Mehrspieler ein.
  
  | Vorbereitung      | Eingabe | Erwartete Ausgabe                                        |
  | ----------------- | ------- | -------------------------------------------------------- |
  | VS Studio starten | string  | `Es ist ein Fehler unterlaufen! Probier es nocheinamal!` |

- [x] Ich programmiere ein einfaches Textadventure. Die Geschichte handelt darum, dass man sich immer zwichen drei Türen entscheiden muss. Jedoch ist nur immer eine die Richtige. Die Geschichte ist zu Ende wenn man alle Räume verlassen kann und ins freie kommt.

- [x] Ich bearbeite Auftrag 1717 vom Modul 431: "Ich kann aus einer Auswahl von Techniken eine geeignete auswählen (Problem, Kreativität, Lernen)."

- [x] Ich bearbeite Auftrag 1718 vom Modul 431: "Ich kann eine Problemlösetechnik zur Bearbeitung eines Auftrages anwenden."

✍️ Heute habe ich die "Try-Catch Funktion" in den Mehrspieler von meinem Zahlenspiel einprogrammiert. Ich konnte sogar den Fehler vom letzten Mal im Singelplayer einbauen. Ausserdem habe ich mit meinem Textadventure begonnen. Die Idee ist mir von einem Wii Party Minigame gekommen. Heute konnte ich zum ersten Mal auch die Modul Aufträge komplett bearbeiten und habe es zum ersten Mal geschafft alle Arbeitspakete auszuführen.

## Arbeitspakete für 19.09.2023

- [x] Ich möchten mein Spiel "Errate die Geheimzahl" so erweitern, dass wenn man bei der Auswahl des Spiel modus eine 3 oder höher eingibt eine witzige Fehlermeldung erscheint (Evtl. mit einem Scherz). Ausserdem programmiere ich, dass wenn man beim Raten eine zu hohe Zahl eingibt, man erneut raten kann. (Im Normalen Spiel nicht über 100 und Im Duell nicht über 10)
  
  | Nummer | Vorbereitung                             | Eingabe              | Ausgabe                                                                         |
  | ------ | ---------------------------------------- | -------------------- | ------------------------------------------------------------------------------- |
  | 1      | Aufforderung zum Modus                   | Zahl kleiner als 0   | `Die Zahl ist zu klein!`                                                        |
  | 2      | Aufforderung zum Modus                   | Zahl grösser als 3   | `Die Zahl ist zu gross!`                                                        |
  | 3      | Aufforderung zum Raten im normalen Spiel | Zahl kleiner als 0   | `Die Zahl ist zu klein! Probiere es nochmal mit einer Zahl zwischen 1 und 100!` |
  | 4      | Aufforderung zum Raten im normalen Spiel | Zahl grösser als 100 | `Die Zahl ist zu gross! Probiere es nochmal mit einer Zahl zwischen 1 und 100!` |
  | 5      | Aufforderung zum Raten im Duell          | Zahl kleiner als 0   | `Die Zahl ist zu gross! Probiere es nochmal mit einer Zahl zwischen 1 und 10!`  |
  | 6      | Aufforderung zum Raten im Duell          | Zahl grösser als 10  | `Die Zahl ist zu gross! Probiere es nochmal mit einer Zahl zwischen 1 und 10!`  |

- [x] Ich programmiere 3 weitere Räume im Spiel "Das Haus der tausend Türen". Im 4. Raum kann man wählen, ob man nach rechts oder links gehen will.

- [x] Ich bearbeite Auftrag 1721 vom Modul 431: "Ich kann einen Auftrag mit den mir bekannten Hilfsmitteln und Methoden vollständig bearbeiten."

- [ ] Ich bearbeite Auftrag 1722 vom Modul 431: "Ich kann einem Laien an verschiedenen Beispielen erläutern, wie Ergebnisse von Aufträgen sinnvoll dokumentiert werden."2

✍️ Heute habe ich mein Spiel "Errate die Geheimzahl" um zwei kleine Features im Bezug auf die Benutzerfreundlichkeit programmiert. Ausserdem konnte ich mein Spiel mit den Türen um zwei Räume erweitern. Das bedeutet isch habe mein Ziel um einen Raum verfehlt. Das ist warscheinlich passiert, da ich den Code für den ersten Raum umprogrammiert habe, um die Switch Funktion zu vertiefen. Zum Schluss konnte ich leider nur einen Auftrag bearbeiten, da diesere enorm lange war.

## Arbeitspakete für 26.09.2023

- [ ] Ich möchte  mein Spiel "Das Haus der tausend Türen", um eine Verzwigung und zwei weitere Räume erweitern.

- [ ] Ich bearbeite Auftrag 1727 vom Modul 431: "Ich kann einem Laien die Merkmale einer guten Präsentation erklären."

- [ ] Ich bearbeite Auftrag 1728 (MiZ und EwZ) vom Modul 431: "Ich kann mit einer Präsentationssoftware meine Ergebnisse optisch aufbereiten." (MiZ) und "Ich kann meine Ergebnisse dem Auftraggeber in Form einer Präsentation vorstellen." (EwZ)

- [ ] Ich bearbeite Auftrag 1730 vom Modul 431: "Ich kann einem Laien erklären, wie Feedback zur Verbesserung der Arbeitsqualität und des eigenen Verhaltens beitragen kann."
