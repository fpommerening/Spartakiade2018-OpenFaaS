# Spartakiade 2018 OpenFaaS

<p align="center"><img src="images/logo_spartakiade.png" width=100/></p>

Web: http://spartakiade.org/  
Twitter: http://twitter.com/spartakiade_org

Datum: 17. bis 18. März 2018

# Workshop: Serverless Computing mit OpenFaaS
mit Frank Pommerening <a href="https://twitter.com/fpommerening"><img src="images/TwitterLogo.png" alt="Follow @fpommerening" width=30/></a> 

## Inhalt
1. [Zielgruppe](#zielgruppe)
2. [Inhalt](#inhalt)
3. [Teilnehmer-Voraussetzung / Vorbereitung](#voraussetzungen)

<a name="zielgruppe"></a>
## 1. Zielgruppe
Die Entwicklung von den Micro-Services zu den Functions (Nano-Services) ist in vollem Gange. Mit Amazon AWS Lambdas bzw. Microsoft Azure Functions habe die beiden großen Cloudanbieter diesen Trend erkannt und adressiert. Diese Workshop richtet sich an Entwickler die mit Docker und OpenFaaS eine Functions erstellen wollen, ohne die Kontrolle zu verlieren.

<br />

Hinweis: Es werden Grundkenntnisse zu Containern und dem Docker-Ökosystem (z.B. Docker-Files, Docker-Compose) benötigt.

## 2. Inhalt
Die folgende Liste gibt einen Überblick über mögliche Themen.
- Basistechologien
  - Docker Swarm
  - Docker Services
  - Docker Stack
  - Docker Config / Stack
  
- Einführung OpenFaaS
  - Architektur
  - Watchdog
  - Vergleich zu WebAPI bzw. WebApps
 
- OpenFaaS CLI
  - Erstellung
  - Build
  - Deployment

- Funktionentwicklung
  - Manuell vs. CLI
  - Asynchrone Funktionen
  - Funktionsketten
  - Auswertung Query / POST-Daten

- Erweiterungen
  - eigene Funktionsvorlagen
  - Verknüpfung mit externen Containern / Services
  - Funktionsüberwachung
  - Integration verteilter Datenspeicher

- OpenFaaS in Produktion / WAN
  - SSL
  - Authentifizierung

- Beispiele
  - Hallo World :-)
  - zeitgesteuerte Funktionen
  - CQRS  
      
Hinweis: Die Beispiele sind mit .NET Core 2 erstellt. Andere Programmiersprachen z.B. node.js, python, ruby oder go sind möglich. 

<a name="voraussetzungen"></a>
3. Teilnehmer-Voraussetzungen / Vorbereitung<br />
[x] Notebook mit <a href="https://code.visualstudio.com/" target="_blank">Visual Studio Code</a><br />
[x] Dockerumgebung z.B. <a href="https://docs.docker.com/docker-for-windows/" target="_blank"> Docker for Windows</a> <br/>
[x] HTTP-Testtool z.B. <a href="https://www.getpostman.com/" target="_blank">Postman</a><br />
[x] <a href="https://www.microsoft.com/net/core#windowscmd" target="_blank">.NET Core 2.0 SDK </a><br />

<b>Die Präsentation könnt ihr, nach der Veranstaltung, auf der <a href="https://fpommerening.github.io/Spartakiade2018-OpenFaaS/#/" target="_blank">GitHub-Page</a> einsehen.</b>
