##### RecycleBinInBergamo
## Project for school started on March 2021

This project was developed between #11-2-2021 | 18-3-2021 by Carminati Giovanni e Belotti Davide

This program simulate a Bin in Bergamo where after a registration you can take a certain ammount of bags for plastic and for the waste.

### front-end

The front-end is written in C# for windows using the editor VS. (Developed for the most by Davide)
It contains post requests to the server for the registration, menaging the access and for take the bags.
It also contains the possibility to write on file the receipt. 

## C# dependencies: 
 - Newtonsoft.Json
 - System.IO
 - System.Net.Http

### The back-end is made using NodeJS:
Back-end is based on NodeJS using the library Express.
It is Developed first by Giovanni, and also use a SQL database to menage the requests

## The SQL contains 2 tables with the following fields:

# utenti:
 - CF (fiscal code)
 - nome (name)
 - cognome (surname)
 - indirizzo (address)
 - plastica (quantity of bags for plastic taken)
 - secco (quantity of bags for waste taken)
 - MAXplastica (max of bags for plastic)
 - MAXsecco (max of bags for waste)

# bidoni
 - ID (progressive int)
 - plastica (bags for plastic)
 - secco (bags for waste)
    
    
    
## NodeJS dependencies:
 - express (to menage requests)
 - nodemon  (to autoreload application after saving changes)
 - mysql  (to talk with the SQL database)
 - dotenv (to menage the .env file)
 - body-parser (to convert request in json)
   
