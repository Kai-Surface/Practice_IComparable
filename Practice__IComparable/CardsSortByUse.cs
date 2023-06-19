using Practice_IComparable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice__IComparable
{
    internal class CardsSortByUse : IComparable<PlayingCards>
    {
        public int CompareTo(PlayingCards other)
        {
            return use.CompareTo(other.use);
            
        }
    }
}
