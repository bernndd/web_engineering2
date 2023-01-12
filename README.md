
# backend-personal für Web-Enginneering Projekt
## Inhalt

[ Allgemein ](#allg)  
[ Docker-Image ](#dock)  
[ Umgebungsvariablen ](#umg)  
[ Compose ](#comp)  

<a name="allg"></a>
## Allgemein
Team: Stefan Graßold, Simon Stenzel, Bernd Dorer  
Lizenz: MIT  
Sprache: [C#](https://learn.microsoft.com/de-de/dotnet/csharp/language-reference/) (Version 10.0)  
Framework: [.NET](https://dotnet.microsoft.com/en-us/) 6.0  
ORM: [Npgsql](https://www.npgsql.org/) (Version 7.0.1)


<a name="dock"></a>
## Docker-Image
Das Docker-Image ist in der Github-Registry hinterlegt und kann mit folgendem Befehl gepullt werden:

    docker pull ghcr.io/bernndd/web_engineering2:latest

Der Container wird nach einer Änderung in dem Repository direkt mit Github Actions gebaut und auf die github-Registry gepusht. Hierzu wird die Datei `deploy_personal.yaml` verwendet diese liegt im Ordner `.github/workflows`

<a name="umg"></a>
## Umgebungsvariablen
Standardwerte der Umgebungsvariablen

      KEYCLOAK_HOST: "traefik"
      KEYCLOAK_REALM: "biletado"
      JAEGER_TRACECONTEXTHEADERNAME: ${JAEGER_TRACECONTEXTHEADERNAME}
      POSTGRES_PERSONAL_USER: ${POSTGRES_USER}
      POSTGRES_PERSONAL_PASSWORD: ${POSTGRES_PASSWORD}
      POSTGRES_PERSONAL_DBNAME: "personal"
      POSTGRES_PERSONAL_HOST: "postgres"
      POSTGRES_PERSONAL_PORT: "5432"
      PERSONAL_EMPLOYEE_URI: "http://traefik/api/personal/employees/"
      PERSONAL_RESERVATIONS_URI: "http://traefik/api/reservations/"

Die Variablen `POSTGRES_USER` , `POSTGRES_PASSWORD` und `JAEGER_TRACECONTEXTHEADERNAME` werden mit der .env in dem `compose` Ordern an die `compose` Datei übergeben.


<a name="comp"></a>
## Compose
Gestartet werden kann die Docker-Compose Anwendung in dem `compose` Ordner mit: `docker compose up -d` .

