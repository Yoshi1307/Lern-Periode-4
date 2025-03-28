# Lern-Periode 4

14.2 bis 4.4

## Grob-Planung

1. Mit meinen Noten stehe ich momentan gut, weil ich eine 5 als Schnitt habe. Mein bestes Modul war 431 mit einer 5.5 und ungenügend war ich noch nicht.
2. Was wäre ein geeignetes Projekt für diese LP4? Können Sie mit diesem Projekt zeigen, wie Sie sich selbständig in eine Problemstellung einarbeiten können und eine überzeugende Lösung programmieren können?
Als Projekt für diese Lernperiode habe ich an einen Cookie-clicker gedacht.

## 14.2: Explorativer Wegwerf-Prototyp

- [x] Zähl mechanik einbauen
- [x] Desing grob überlegen

✍️ Heute habe ich mir vorgenommen den beginn eines Cookie-clickers zu programmieren. Zuerst hatte ich noch ein paar Probleme mit dem Programm, da ich es schon 3 Wochen nicht mehr gebraucht habe. Also musste ich ein neues erstellen. Beim zweiten anlauf hat es dann geklappt und ich konnte ein Prototyp für den Mainscreen und ein bisschen vom Shop machen.

## 21.2: Explorativer Wegwerf-Prototyp

- [X] Layout vom Spiel zeichen (Mainscreen, Shop,...)
- [ ] Autoclicker coden
- [X] Verbindung für den Autoclicker vom Shop zum Mainscreen
- [X] Upgrades ausenken

✍️ Heute habe ich damit begonnen mir das Layout des Spiels zu überlegen. Ich habe damit begonnen den Mainscreen zu zeichnen und anschliessend den Shop. Im selben Auftrag habe ich mir die verschiedenen Upgrades überlegt. Als nächstes habe ich den Autoklicker probiert. Dass er funktioniert, musste ich zuerst eine Verbindung zwischen der Knopfberührung und dem Cookie Zähler machen was herausfordernd war. Anschliessend habe ich einen Autoklicker probiert, bin aber gescheitert. Da ich nicht mehr viel Zeit hatte, habe ich damit begonnen das Shop-Design zu verbessern.

## 28.2: Kern-Funktionalität
- [X] Autoklicker Coden
- [X] Funktionierendes Preissystem Coden
- [X] Cookiecounter im Shop
- [ ] Level-System Coden

Heute habe ich damit begonnen den Cookiecounter im Shop zu machen. Dass er einigermassen funktionert war nicht so schwer, doch er updatet noch nicht bei jedem Cookie. Als nächstes habe ich damit begonnen den Autoclicker machen. Diesesmal hat es funktioniert und der Cookiecounter aktualissiert auf beiden Forms gleichzeitig. Anschliessen habe ich noch gemacht, dass der Preis nach jedem Kauf verdoppelt wird und die ausgegebenen Cookies abgezogen werden. Zum Ende wollte ich den Counter im Shop noch fertig stellen, dass wenn man den Cookie klickt er auch direkt geupdatet wird. Dies habe ich mit dem Befehl "ShopForm.UpdateShopCookieCount();" probiert doch jetzt kommt eine Fehlermeldung.

## 7.3: Kern-Funktionalität
Kernfunktion: Upgrades
- [x] Levelsystem einbauen bei Upgrades
- [x] Cursor Upgrade Coden
- [x] Preis für Cursor
- [x] Fehlermeldung beheben

Heute habe ich damit begonnen die Fehlermeldung zu beheben. Dies war nicht sehr schwer. Danach habe ich angefangen ein Cursor-Upgrade zu Coden. Wenn man es kauft verdoppelt sich die Anzahl Cookies die man pro klick bekommt. Anschliessend habe ich den Preis gemacht, was nicht so schwer war, weil ich es beim Autoclicker schon hatte. Als nächstes habe ich ein Levelsystem gemacht, dass sich nach jedem kauf automatisch hochstuft. Dies habe ich für den Autoclicker und das Cursor-Upgrade gemacht. Ausserdem sind die beiden Cookiecounter jetzt Synchron, das einzige Problem ist, dass der Shop nach dem ersten klick auf den cookie aufgeht und wenn man ihn zumacht er sich nicht mehr updatet.
## 14.3: Architektur ausbauen
- [X] Preis für 2x Upgrade
- [x] Levelsystem für 2x Upgrade 
- [ ] Funktionierendes 2x Upgarde Coden
- [ ] Shop kann sich im Hintegrund aktualisieren

Heute habe ich damit begonnen das Preissystem und die Levelmechanik auch für das 2x Upgrade einzufügen. Dies war wieder nicht so schwer. Danach habe ich probiert ein Funktionierendes 2x Upgrade zu machen, welches nicht geklappt hat. Nach einiger Zeit habe ich mich ans letzte Arbeitspaket gemacht. Dies hat nur Teilweise funktioniert, da wenn er sich bei mir im Hintergrund aktualisiert, sich nicht mehr live auf dem Shop Form updatet. Heute war leider nicht so ein guter Tag, weshalb ich nur die 2 ersten geschafft habe. 
 
## 21.3: Architektur ausbauen
- [X] Funktionierendes 2x Upgarde Coden
- [ ] Shop kann sich im Hintegrund aktualisieren
- [ ] Countdown für 60sec Timer

Heute habe ich das 2. mal damit begonnen, das 2x Upgrade zu Coden. Heute ist es viel besser gelungen und es funktioniert. Als Nächstes habe ich die Preise und Preisupdates der einzelnen Upgrades angepasst. Sie sind noch nicht perfekt, aber besser als vorhin. Zum Schluss habe ich mich noch an den Countdown gemacht, der Anzeigen soll, wie lange das 2x Upgrade noch hält. Ich habe einen Code geschrieben, aber der funktioniert noch nicht und ich weiss nicht wieso.

## 28.3: Auspolieren
- [X] Countdown zum laufen bringen
- [X] Preise und Preisupdates verbessern
- [X] Desing vom ganzen überarbeiten
- [ ] Shop im Hintergrund aktualisieren lassen

Heute habe ich zuerst die Preise vom ganzen angepasst. Ich habe sie so angepasst dass es nicht zu schnell geht und man ein bisschen spielen muss. Die upgrades wurden auch dementsprechend angepasst. Als nächstes habe ich das Design angepasst und ein anderes Hintergrundbild genommen. Ausserdem habe ich einen CookiesPerClick zähler und einen CookiesPerAutoklickerinterval Zähler. Zum Schluss habe ich den Countdown noch zum laufen gebracht.

## 4.4: Auspolieren & Abschluss
- [ ] Shopwerte sollen im Hintergrund gespeichert werden
- [ ] 2x Upgrade Optimieren wenn etwas während dem Timer gekauft wird
