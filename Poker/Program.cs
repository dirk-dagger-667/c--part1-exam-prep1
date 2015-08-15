using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] inputCards = new string[5]{ "2", "7", "A", "K", "J"};
            string[] deckOfCards = new string[13] {"A" ,"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"};
            int[] cardsToInt = new int[5];
            int numberOfPairs = 0;
            int counter = 1;
            bool isThreeOfKind = false;
            bool isFourOfKind = false;

            for (int i = 0; i < cardsToInt.Length; i++)
            {
                for (int j = 0; j < deckOfCards.Length; j++)
                {
                    if (inputCards[i] == deckOfCards[j])
                    {
                        cardsToInt[i] = j;
                        break;
                    }
                }
            }

            Array.Sort(cardsToInt);

            if (inputCards[0] == inputCards[1] && inputCards[0] == inputCards[2] && inputCards[3] == inputCards[1] &&
                inputCards[4] == inputCards[1])
            {
                Console.WriteLine("Impossible");
                return;
            }
            else if (((cardsToInt[1] == cardsToInt[0] + 1) && (cardsToInt[2] == cardsToInt[0] + 2) && (cardsToInt[3] == cardsToInt[0] + 3) &&
                (cardsToInt[4] == cardsToInt[0] + 4)) || (cardsToInt[0] == 0 && cardsToInt[1] == 9 && cardsToInt[2] == 10 &&
                cardsToInt[3] == 11 && cardsToInt[4] == 12))
            {
                Console.WriteLine("Straigth");
                return;
            }

            for (int i = 1; i < cardsToInt.Length; i++)
            {
                if (cardsToInt[i] == cardsToInt[i - 1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }

                if (counter == 3)
                {
                    isThreeOfKind = true;
                    numberOfPairs--;
                }
                else if(counter == 4)
                {
                    isFourOfKind = true;
                    isThreeOfKind = false;
                }
                else if (counter == 2)
                {
                    numberOfPairs++;
                }
            }

            if (numberOfPairs == 1 && isFourOfKind == false && isThreeOfKind == false)
            {
                Console.WriteLine("One Pair");
            }
            else if (numberOfPairs == 2 && isFourOfKind == false && isThreeOfKind == false)
            {
                Console.WriteLine("Two Pairs");
            }
            else if (isThreeOfKind == true && numberOfPairs == 0 && isFourOfKind == false)
            {
                Console.WriteLine("Three of a Kind");
            }
            else if (isThreeOfKind == true && numberOfPairs == 1 && isFourOfKind == false)
            {
                Console.WriteLine("Full House");
            }
            else if (isThreeOfKind == false && numberOfPairs == 0 && isFourOfKind == true)
            {
                Console.WriteLine("Four of a Kind");
            }
            else
            {
                Console.WriteLine("Nothing");
            }

        }
    }
}
