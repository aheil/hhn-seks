---
marp: true
theme: defalut
paginate: true
footer: 

---
<style> img[alt~="center"] { display: block; margin: 0 auto; } </style>

<style> img[alt~="rt_float"] { position:absolute; top: 50px; right: 50px; } </style>

<style> img[alt~="float_right"] { float: right } </style>

<style> img[alt~="left"] { float: left } </style>
<style> img[alt~="right"] { float: right } </style>

# Software Engineering komplexer Systeme
## Komplexität

Prof. Dr.-Ing. Andreas Heil

![h:32 CC 4.0](../img/cc.svg)![h:32 CC 4.0](../img/by.svg) Dieses Werk ist lizensiert unter einer Creative Commons Namensnennung 4.0 International Lizenz.

v.1.0.0

---

# SEKS

Die Veranstaltung im Curriculum, Voraussetzung und Ziele bzw.
Kompetenzen

* Vorlesungsorganisation, Arbeitsform und Online
* Personen und Ressourcen
* Fragen

---

# Die Veranstaltung im Curriculum

## SEB SPO4

### Modul H2 262050 Algorithmen, Theorie und Verteilung

* H2.1 262052 Algorithmen und Datenstrukturen
* H2.2 262053 Theoretische Informatik
* H2.3 262055 Grundlagen verteilter Systeme 
* **H2.4 262062 DevOps – Pflichtveranstaltung**

--- 

# Voraussetzungen (SEB)

* G5.1 262005 Grundlagen des Software Engineering 1✔
* G5.2 262006 Grundlagen des Software Engineering 2✔

---

# Ziele und Kompetenzen 

* Ausgewählte und weiterführende Themen aus dem Software Engineering **kennen lernen** 
* Methoden bei größeren und komplexen Software-Projekten **kennen und anwenden lernen**
* **Erarbeiten und Vorstellen** eines komplexen Themas aus dem Gebiet der Software-Entwicklung

---

# Personen und Ressourcen 

## Prof. Dr.-Ing. Andreas Heil 
Haben Sie Fragen? 
Über mich?  Werdegang, Hintergrund? XBOX Gamertag, LoL?
Quicklink: [https://prof.aheil.de](https://prof.aheil.de)

![rt_float](../img/seks.00.aheil.de.png) 

## Vorlesung SEKS
Lernmaterial: [https://aheil.github.io/hhn-seks/](https://aheil.github.io/hhn-seks/)
Kursseite: [https://www.hs-heilbronn.de/seks](https://www.hs-heilbronn.de/seks)
ILIAS für Abgaben und Forum: [https://ilias.hs-heilbronn.de/goto.php?target=crs_360741](https://ilias.hs-heilbronn.de/goto.php?target=crs_360741) 

---

# Prüfung 

* LKBK = lehrveranstaltungsbegleitend durch Kombinierte Prüfung mit Klausur als abschließender Prüfung
* 90 = 90-minütige schriftliche Prüfung (EvaExam)
* Klausur zählt 50% der Endnote
* Für das Bestehen des Kurses sind 40% der Klausurpunkte notwendig
* 25% Multiple-Choice, 75% offene Fragen
* **Zugelassene Hilfsmittel: doppelseitig beschriftetes DINA A 4 Blatt (handschriftlich oder gedruckt)** 
* Ja, man kann sich durch die Klausur in der Note verschlechtern

---

# Übungsaufgaben 

* Es gibt 3 Übungsaufgaben, die Sie individuell bearbeiten
* Jede Aufgabe zählt 1/3 
* Abgabe via ILIAS
* Zu späte Abgaben werden mit 0 Punkten bewertet 

---

# Kurzreferat 

* Sie erarbeiten in Ihrer Gruppe (2-3 Student*innen) ein Thema 
* Sie stellen das Thema vor (im SoSe 2021 als Video, Upload via ILIAS)
* Abgabe: In den letzten Vorlesungsversuchen, genauer Termin wird nach der Klausurphase im Mai bekannt gegeben

---

# FAQ

* Ich habe im Referat und den Hausaufgaben je eine 1,0, bin in der Klausur durchgefallen. Rechnerisch komme ich auf eine 3,1. habe ich den Kurs bestanden.
    * Nein, zum Bestehen ist in der Klausur mind. eine 4,0 erforderlich. 
* Ich habe die Klausur bestanden, bestehe ich den Kurs auf jeden Fall, auch wenn ich die anderen Aufgaben nicht bearbeite?
    * Nope, Angenommen Sie haben in der Klausur eine 4,0 und erhalten für die Hausaufgaben eine 4,0 und halten kein Kurzreferat, was mit einer 4,7 bewertet würde. Damit erhalten Sie die Endnote 4,1 und sind durchgefallen. 

---

# Veranstaltung SoSe 2021

* Veranstaltung 
    * Montags 14:00 bis 15:30 (SEB/AIB)
        * BBB: https://bbb.it.hs-heilbronn.de/b/and-pxc-zoq-mxc
    * Montags 15:45 bis 17:15 (AIB)
        * BBB: https://bbb.it.hs-heilbronn.de/b/and-iwc-3oo-jvy  
* Sprechstunde SoSe 2021
        * Dienstags 10:00 bis 11:00 Uhr 
        * Online via BBB, https://prof.aheil.de/bbb 
        * Bitte nutzen Sie die Buchungsfunktion in ILIAS 


---
<style> img[alt~="left"] { float: left } </style>
<style> img[alt~="right"] { float: right } </style>

<!-- footer: By Unknown author - http://www.unipublic.unizh.ch/magazin/gesellschaft/2005/1440/ebbinghaus2.jpg, Public Domain, https://commons.wikimedia.org/w/index.php?curid=4039544 -->

# Vergessenskurve nach Ebbinghaus

![left h:400](../img/seks.00.ebbing_graph01.de.png)  
![left h:310](../img/seks.00.ebbinghaus.de.png)  

---
<style> img[alt~="r"] { position: absolute; right: 100px; bottom: 130px } </style>
<style scoped>
ul {
  width:60%  
}
</style>

![r h:350](../img/seks.00.ebbing_graph02.de.png)  

# Vergessenskurve nach Ebbinghaus

* Innerhalb einer Woche die Notizen für mind. 30 Minuten täglich wiederholen 
* Danach jede Woche die Notizen für 30 Minuten wöchentlich wiederholen
Es macht einen merkbaren Unterschied, wie Sie sich erinnern (auch beim Lernen auf die Klausur)

<!--![bg right:33% h:350](../img/seks.00.ebbing_graph02.de.png) -->

---