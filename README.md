# SWEN_Organisationsformen
 SWEN_Organisationsformen_fuers_Hallenbad

 Um das Projekt zu starten, 
 - öffnet man Visual Studio Code,
 - öffnet man den Ordner WebApp,
 - öffnet ein NEW TERMINAL,
 - Eingabe: "cd .\WebApplication1\"
 - Eingabe: "dotnet run" 
 
# Webanwendungsprojekt für Organisationsformen

Dieses Projekt ist eine Webanwendung für die Darstellung von verschiedenen Organisationsformen im Hallenbad. Die WebApp soll Schwimmlehrpersonen helfen sich über die Organisation und die Positionierung im Hallenbad Gedanken zu machen und diese zu visualisieren.  Hier ist eine kurze Übersicht über die verschiedenen Teile des Projekts:

## Inhaltsverzeichnis

1. [Ordnerstruktur](#ordnerstruktur)
2. [CSS-Dateien](#css-dateien)
3. [JavaScript-Dateien](#javascript-dateien)
4. [HTML/CSS-Dateien](#htmlcss-dateien)
5. [ASP.NET Core Code](#aspnet-core-code)
6. [Konfiguration und Ausführung](#konfiguration-und-ausführung)
7. [Hinweise](#hinweise)

## Ordnerstruktur
- **wwwroot**: Enthält statische Dateien wie CSS, JavaScript und Bilder.
- **Pages**: Enthält Razor Pages für die Webanwendung.

## CSS-Dateien
- **WebApplication1.styles.css**: Stile für die gesamte Anwendung, einschließlich der Organisation von Elementen.
- **_content/WebApplication1/Pages/Shared/_Layout.cshtml.rz.scp.css**: CSS-Stile spezifisch für das Layout.

## JavaScript-Dateien
- **main.js**: Lokales JavaScript für die Anwendung, einschließlich einer Funktion zum Aktivieren des Drag-and-Drop für Overlay-Bilder.

## HTML/CSS-Dateien
- **Privacy.cshtml**: Razor Page für Informationen zu den Organisationsformen.
- **Index.cshtml**: Razor Page für die Hauptseite mit verschiedenen Organisationsformen.

## ASP.NET Core Code
- **Startup.cs**: Konfiguration der ASP.NET Core-Anwendung, einschließlich Routen, Dienste und Middleware.
- **Program.cs**: Initialisierung und Ausführung der ASP.NET Core-Anwendung.

## Versionierung
Die Git-Versionierung wurde am 27.10.2023 für das Projekt eingerichtet. 
Da es bei der Umstellung auf den .net-Ansatz zu einem explorativen Projekt wurde, wurde bis zur ausführbaren Webapp auf den Ansatz des lokalen Speicherns umgestiegen. Der Dozent kann die Versionen im one-drive Ordner finden https://1drv.ms/f/s!Atx8abvljqrmiQq-DUmboov6XEm5?e=AkKRaY . 
Das Projekt wurde dann wieder mit einer ausführbaren .net App commited und anschliessend nochmals mit den vereinheitlichten Kommentaren. 

## Hinweise
Der Code enthält Kommentare Deutsch, um die Verständlichkeit zu verbessern. Die Bereiche des json sind nicht kommentiert, da json keine Kommentare unterstützt. Auch Lizenzen und mit dem Projekt geladene Dateien enthalten, wenn nur die ursprünglich enthaltenen Kommentare. 
