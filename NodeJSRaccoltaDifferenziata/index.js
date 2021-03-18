const bodyParser = require('body-parser');
const express = require('express');
const mySql = require('mysql');
require('dotenv/config');

const goodQuery = {"Message" : "Query successfull"};
const badQuery = {"Message" : "Bad query"};

const app = express();

app.use(bodyParser.urlencoded({ extended: false }));
app.use(bodyParser.json());

const db = mySql.createConnection({
    host: 'localhost',
    user: process.env.DB_USER,
    password : process.env.DB_PASSWORD,
    database: 'recyclebin'
});

db.connect((err) => {
    if(err) console.log('unable to connect the db');
    else console.log('> Database connected!');
});

// app.get('/',(req,res) => {
//     res.send("hello world");
// });

// //tester post
// app.post('/', (req,res) => {
//     console.log(req.body);
//     //res.json(goodQuery);
//     res.status(200).json(goodQuery);
// });

//post codice fiscale
/*
JSON fields:
    "CF" : "CRMGNN03A21H910M"

RETURN: 
    ritorna tutti i campi dell'utente
*/
app.post('/getCF',(req,res) => {
    //console.log(req.body);
    let sql = `SELECT * FROM utenti WHERE CF = '${req.body.CF}';` //verifica l'esistenza dell'utente con il CF
    db.query(sql,(err,result) => {
        if(err) res.json(badQuery);
        else{
            if(result[0]) res.json(result[0]);
            else res.json(badQuery);
            //console.log(result[0]);
        } 
    });
});

//fa l'update dei sacchi presi dall'utente
/*
JSON fields:
    "CF" : "CRMGNN03A21H910M",
    "plastica" : 5,
    "secco" : 3

RETURN: 
    esegue l'update della tabella e restituisce lo stato dell'operazione
*/
app.post('/fillBidoni', (req,res) => {
    if(req.body.PW = process.env.PW){
        let sql = `UPDATE bidoni SET secco = 100, plastica = 100 WHERE ID = ${req.body.ID} ;`;
        db.query(sql,(err,result) => {
            if(err) res.json(badQuery);
            else res.json(goodQuery);
        })
    }
});

app.post('/prendiSacchi',(req,res) => {
    //console.log(req.body);
    let sql = `SELECT * FROM bidoni WHERE ID = '${req.body.ID}';`;
    db.query(sql, (err,result) => {
        if (err) res.json(badQuery);
        else if (!result) res.json(badQuery);
        else{
            sql = `
                SELECT * FROM utenti WHERE CF = '${req.body.CF}';
                `;
            db.query(sql, (err,result) => {
                if (err) res.json(badQuery);
                else if(!result) res.json(badQuery);
                else{

                    let scontrino = result[0];

                    if(result[0].MAXplastica >= result[0].plastica + parseInt(req.body.plastica) && result[0].MAXsecco >= result[0].secco + parseInt(req.body.secco)){
                        sql = `SELECT * FROM bidoni WHERE ID = '${req.body.ID}';`;

                        db.query(sql, (err,result) => {
                            if (err) res.json(badQuery);
                            else if (result[0].secco < parseInt(req.body.secco) || result[0].plastica < parseInt(req.body.plastica)) res.json({"Message" : "I sacchi sono finiti"});
                            else{
                                
                                sql = `
                                    UPDATE utenti 
                                    SET secco = secco + '${req.body.secco}', plastica = plastica + '${req.body.plastica}' 
                                    WHERE CF = '${req.body.CF}';
                                `;

                                db.query(sql, (err,result) => {
                                    if (err) res.json(badQuery);
                                    else {
                                        res.json(scontrino);
                                        //console.log(scontrino);
                                    }
                                });
                                //console.log("hellooo");
                                

                                sql = `
                                    UPDATE bidoni 
                                    SET secco = secco - '${req.body.secco}' , plastica = plastica - '${req.body.plastica}' 
                                    WHERE ID = '${req.body.ID}';
                                    `;
                                    //console.log(sql);

                                db.query(sql, (err,result) => {if (err) console.log('errore')});
                                //res.json(result[0]);

                            }
                        });
            
                        
                    }
                    else res.json({"Message" : "AHHH furbetto stai cercando di prelevare più sacchi di quelli che ti sono concessi marcioneeeee!"});
                
                }

            });
        }
    });

});

app.post('/registraUtente', (req,res) => {
    if(req.body.CF && req.body.nome && req.body.cognome && req.body.indirizzo && req.body.MAXplastica && req.body.MAXsecco){
        console.log(req.body);
        let sql = `SELECT * FROM utenti WHERE CF = '${req.body.CF}';`;
        db.query(sql,(err,result) => {
            if(err) res.json(badQuery);
            else if(result[0]) res.json({"Message": "utente già esistente"});
            else{
                sql = `
                    INSERT INTO utenti (CF,nome,cognome,indirizzo,MAXplastica,MAXsecco)
                    VALUE ('${req.body.CF}','${req.body.nome}','${req.body.cognome}','${req.body.indirizzo}','${req.body.MAXplastica}','${req.body.MAXsecco}');
                `;
                db.query(sql,(err,result) => {
                    if (err) res.json(badQuery);
                    else res.json(goodQuery);
                });
            }
        });
    }
    else res.json({"Message" : "Missing fields"});
});


app.listen(3000, ()=>{console.log("> listening on port 3000")});