using UnityEngine;

namespace DiceNotation.Exceptions
{
    public class InvalidMultiplicityException : UnityException
    {
        public InvalidMultiplicityException(int multiplicity) : base(string.Format("Cannot roll {0} dice; this quantity is less than 0", multiplicity))
        { }
    }
}