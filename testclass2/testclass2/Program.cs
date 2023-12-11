using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace testclass2
{
    internal class Program
    {
        
        static bool contains(List <string> myList, string toFind)
        {       // sac de bille (bille 1, bille2)
                for (int i = 0; i < myList.Count; i++)
                {
                    if (myList[i] == toFind)
                    {
                        return true; // j'ai trouvé ma bille
                    }
                }
            return false;
            // ATTENTION après 1 return la fonction s'arrête donc à 
            // mettre à la fin
        }
        static void Main(string[] args)
        {

            List<string> ball = new List<string>();
            ball.Add("red");
            ball.Add("green");
            ball.Add("blue");
            ball.Add("yellow");
            ball.Add("black");
            string findBall = "blue";

            if (contains(ball, findBall))
            {       // myList changer par ball et toFind changer par findBall
                Console.WriteLine("found");
            }

            else
            {
                Console.WriteLine("not found");
            }


        }
    }
    class Deck
    {
        public Deck(string p_name) 
        {
         deckName = p_name;
        }
        private string deckName;
        private List<card> Listcard = new List<card>();
    }
    class card // création d'une nouvelle variable/fonction
    {
        public card(string p2_name) // constructeur (paramètre de la fonction)
        {
            cardName = p2_name;
        }
        private string cardName;
    }

    internal class program
    {
        static void Main(string[] args) 
        {
            List<card> Listcard = new List<card>();
           
            for (int i =  0; i < 10; i++)
            {
                card newCard = new card("water" +i);
                Listcard.Add(newCard);
            }
            // on aura 9 cartes

            Deck newDeck = new Deck("blue");

            
            


        }
    }




}   

    
