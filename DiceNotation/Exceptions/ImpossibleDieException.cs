using UnityEngine;

namespace DiceNotation.Exceptions
{
    public class ImpossibleDieException : UnityException
    {
        public ImpossibleDieException(int sides) : base(string.Format("Cannot construct a die with {0} sides", sides))
        { }
    }
}