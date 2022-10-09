using UnityEngine;

namespace DiceNotation.Rollers
{
    public class UnityDieRoller : IDieRoller
    {
        public int RollDie(int sides)
        {
            return Random.Range(0, sides) + 1;
        }
    }
}