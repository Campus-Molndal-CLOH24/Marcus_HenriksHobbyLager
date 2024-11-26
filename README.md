# HenriksHobbyLager

## Medlemmar
- Anton
- Hugo
- Kenny
- Alireza
- Parham

## Kort Beskrivning av Projektet
**Henriks HobbyLager�** �r ett grundl�ggande inventeringshanteringssystem f�r att lagra och hantera produktinformation.  
Programmet st�djer funktioner f�r att l�gga till, uppdatera, ta bort och s�ka efter produkter.  
Det k�rs helt och h�llet i minnet, vilket inneb�r att all data g�r f�rlorad n�r applikationen st�ngs.  
Applikationen �r designad som en konsolapplikation f�r enkelhetens skull.

## Installationsinstruktioner
--Explain--

## Hur man k�r programmet
--Explain--

## Eventuella konfigurationsinst�llningar
--Explain--

## Lista �ver implementerade patterns
- **Repository-m�nster**:  
  Definieras av gr�nssnittet `IRepository`, �ven om det inte �r fullt utnyttjat i denna version.

- **Fasadm�nster (Facade Pattern)**:  
  Representeras av gr�nssnittet `IProductFacade` f�r hantering av produktoperationer.

- **CRUD-operationer**:  
  Funktionalitet f�r att skapa, l�sa, uppdatera och ta bort produkter �r implementerad.

## Kort beskrivning av databasstrukturen
F�r n�rvarande simuleras databasen med en in-memory-struktur: `List<Product>`.  
Varje produkt inneh�ller f�ljande egenskaper:

- **Id**: En unik identifierare f�r produkten.
- **Name**: Produktens namn.
- **Price**: Produktens pris (decimal).
- **Stock**: Tillg�nglig lagerkvantitet (heltal).
- **Category**: Produktens kategori (str�ng).
- **Created**: Tidsst�mpeln n�r produkten skapades.
- **LastUpdated**: Tidsst�mpeln f�r senaste uppdatering (nullable DateTime).

Framtida versioner kan inkludera en persistent databas, exempelvis SQLite.  
Data kan ocks� lagras som ett mer strukturerat format.
