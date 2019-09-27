using Laboratorio_5_OOP_201902.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_5_OOP_201902
{
    public static class Visualization
    {
        public static void ShowHand(Hand hand)
        {
            Console.WriteLine(hand);
            foreach (Card card in hand.Cards)
            {
                if (card.GetType().Name == nameof(CombatCard))
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    
                    Console.WriteLine(card.Name);
                    Console.WriteLine(card.Type);
                    Console.WriteLine(card.Effect);

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                  
                    Console.WriteLine(card.Name);
                    Console.WriteLine(card.Type);
                    Console.WriteLine(card.Effect);


                }
                


            }

        }
        public static void ShowDecks(List<Deck> decks)
        {
            
            foreach (Deck deck in decks)
            {
               

                Console.WriteLine(deck);

            }
        }
        public static void ShowCaptains(List<SpecialCard> captains)
        {
            foreach (SpecialCard cap in captains)
            {
                if (cap.Type ==Enums.EnumType.captain)
                {
                    Console.WriteLine(cap);
                }
            }
        }
        public static void GetUserInput(int MaxInput,bool stoper = false)
        {
            int numero = Console.Read();
            if ( stoper == false)
            {
                if (numero<=MaxInput && numero >= 0)
                {
                    Console.WriteLine(  "verificado Correctamente");
                }
            }
        }
        public static void ShowProgramMesage(string mesage)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(mesage);
            
        }
    }
}
