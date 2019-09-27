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
                if (numero>MaxInput || numero < 0)
                {
                    Console.WriteLine(  "Error, ingrese un numero dentro del rango");
                    numero = Console.Read();
                }
                else
                {
                    Console.WriteLine("Verificado correctamente");
                }
                
            }
            else
            {
                if (numero > MaxInput || numero < -1)
                {
                    Console.WriteLine("Error, ingrese un numero dentro del rango");
                    numero = Console.Read();
                }
                else
                {
                    Console.WriteLine("Verificado correctamente");
                }
            }
        }
        public static void ShowProgramMesage(string mesage)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(mesage);
            
        }
        public static void ConsoleError(string mesage)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(mesage);
        }
        public static void ClearConsole()
        {
            Console.Clear();
        }
        public static void ShowListOptions(List<string> options,string message=null)
        {
            if ( message != null)
            {
                Console.WriteLine(message);
            }
            foreach(string opt in options)
            {
                Console.WriteLine(opt);
            }
        }
    }
}
