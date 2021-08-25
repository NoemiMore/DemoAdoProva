using System;

namespace Magazzino
{
    class Program
    {
        /*
     Sviluppare una console app che permetta ad un utente di acquistare prodotti su un e-commerce.
        I prodotti disponibili sono:
                    * classe astratta prodotto
            - prodotti alimentari: 
                    codice prodotto * 
                    prezzo          * 
                    descrizione     *
                    data di scadenza
            - prodotti di abbigliamento
                    codice prodotto
                    prezzo
                    descrizione
                    taglia
                    brand
            - prodotti elettronica
                    codice prodotto
                    prezzo
                    descrizione
                    marca
                    modello
Un utente può:
vedere tutti i prodotti per categoria
vedere tutti i prodotti per categoria con prezzo <= al prezzo inserito
vedere gli alimenti con una data di scadenta >= alla data inserita
vedere l'abbigliamento con taglia uguale alla taglia inserita
vedere gli elettrodomestici della marca inserita.
Facoltativo. -> ogni volta che l'utente visualizza una lista di prodotti,
gli viene chiesto se e quale prodotto vuole aggiungere al carrello
Se sceglie un prodotto viene aggiunto al carrello.
Quindi tra le opzioni ci sarà: Procedi agli acquisti.
Verrà stampato a video il totale dei prodotti nel carrello
     
     */
        static void Main(string[] args)
        {
            Menu.Start();
        }
    }
}
