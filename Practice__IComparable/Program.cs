using Practice__IComparable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_IComparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<PlayingCards> _cards = new List<PlayingCards>();

            _cards.Add(new PlayingCards(12, PlayingCards.Material.paper, PlayingCards.Use.tarot, PlayingCards.Packaging.pack, true));
            _cards.Add(new PlayingCards(50, PlayingCards.Material.cardboard, PlayingCards.Use.collecting, PlayingCards.Packaging.pack, false));
            _cards.Add(new PlayingCards(20, PlayingCards.Material.cardStock, PlayingCards.Use.cardThrowing, PlayingCards.Packaging.deck, true));
            _cards.Add(new PlayingCards(150, PlayingCards.Material.cottonPaper, PlayingCards.Use.magic, PlayingCards.Packaging.deck, false));
            _cards.Add(new PlayingCards(100, PlayingCards.Material.cottonPaper, PlayingCards.Use.collecting, PlayingCards.Packaging.deck, false));

            DisplayCards(_cards, "Unsorted");

            _cards.Sort();

            DisplayCards(_cards, "By material, descending");

            CardsSortByMaterial sortByMaterial = new CardsSortByMaterial();
            _cards.Sort((IComparer<PlayingCards>)sortByMaterial);

            DisplayCards(_cards, "By use, acsending");

            CardsSortByUse sortByUse = new CardsSortByUse();
            _cards.Sort((IComparer<PlayingCards>)sortByUse);

            DisplayCards(_cards, "By number of cards in the deck, ascending");


        } //Main

        public static void DisplayCards(List<PlayingCards> cards, string typeOfSort)
        {
            Console.WriteLine(typeOfSort);
            foreach (PlayingCards card in cards)
            {
                Console.WriteLine(cards);

            }
            Console.WriteLine("\n-----------------------------------\n");
        }
    }
}
