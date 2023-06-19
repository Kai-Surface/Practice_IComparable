using Practice_IComparable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Practice_IComparable.PlayingCards;

namespace Practice__IComparable
{
    internal class CardsSortByMaterial : IComparable<PlayingCards>
    {
        public int CompareTo(PlayingCards other)
        {
             return material.CompareTo(other.material) * -1;
        }
    }
}
