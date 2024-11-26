# HenriksHobbyLager

## Medlemmar
- Anton
- Hugo
- Kenny
- Alireza
- Parham

## Kort Beskrivning av Projektet
**Henriks HobbyLager™** är ett grundläggande inventeringshanteringssystem för att lagra och hantera produktinformation.  
Programmet stödjer funktioner för att lägga till, uppdatera, ta bort och söka efter produkter.  
Det körs helt och hållet i minnet, vilket innebär att all data går förlorad när applikationen stängs.  
Applikationen är designad som en konsolapplikation för enkelhetens skull.

## Installationsinstruktioner
--Explain--

## Hur man kör programmet
--Explain--

## Eventuella konfigurationsinställningar
--Explain--

## Lista över implementerade patterns
- **Repository-mönster**:  
  Definieras av gränssnittet `IRepository`, även om det inte är fullt utnyttjat i denna version.

- **Fasadmönster (Facade Pattern)**:  
  Representeras av gränssnittet `IProductFacade` för hantering av produktoperationer.

- **CRUD-operationer**:  
  Funktionalitet för att skapa, läsa, uppdatera och ta bort produkter är implementerad.

## Kort beskrivning av databasstrukturen
För närvarande simuleras databasen med en in-memory-struktur: `List<Product>`.  
Varje produkt innehåller följande egenskaper:

- **Id**: En unik identifierare för produkten.
- **Name**: Produktens namn.
- **Price**: Produktens pris (decimal).
- **Stock**: Tillgänglig lagerkvantitet (heltal).
- **Category**: Produktens kategori (sträng).
- **Created**: Tidsstämpeln när produkten skapades.
- **LastUpdated**: Tidsstämpeln för senaste uppdatering (nullable DateTime).

Framtida versioner kan inkludera en persistent databas, exempelvis SQLite.  
Data kan också lagras som ett mer strukturerat format.
