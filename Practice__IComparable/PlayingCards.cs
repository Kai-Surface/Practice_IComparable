using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_IComparable
{
    public class PlayingCards : IComparable<PlayingCards>
    {
        int _numOfCardsInDeck;

        public enum Material
        {
            cardStock, paper, cardboard, cottonPaper
        , plastic
        }
        public Material material;



        public enum Use
        {
            game, magic, cardistry, cardThrowing,
            cardHouses, tarot, trade, collecting
        }
        public Use use;

        public enum Packaging { deck, pack }
        Packaging packaging;

        public bool Coated; //Do the cards have a plastic finish or not

        public PlayingCards(int numOfCardsInDeck, Material material, Use use, Packaging packaging, bool coated)
        {
            _numOfCardsInDeck = numOfCardsInDeck;
            this.material = material;
            this.use = use;
            this.packaging = packaging;
            Coated = coated;
        }

        public int NumOfCardsInDeck { get => _numOfCardsInDeck; set => _numOfCardsInDeck = value; }
        private Material Material1 { get => material; set => material = value; }
        public Use Use1 { get => use; set => use = value; }
        private Packaging Packaging1 { get => packaging; set => packaging = value; }
        public bool Coated1 { get => Coated; set => Coated = value; }

        public int CompareTo(PlayingCards? other)
        {
            if (_numOfCardsInDeck > other._numOfCardsInDeck)
            {
                return 1;
            }
            else if (_numOfCardsInDeck < other._numOfCardsInDeck)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"{GetType()} - Number of cards in deck: {NumOfCardsInDeck}, - Material: {material}, - Use: {use}, Packaging: {packaging}, Is coated: {Coated}";
        }
    }
}
