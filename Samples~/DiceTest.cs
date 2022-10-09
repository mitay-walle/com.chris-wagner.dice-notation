using DiceNotation;
using UnityEngine;

namespace mitaywalle.DiceNotation.Examples
{
    [ExecuteAlways]
    public class DiceTest : MonoBehaviour
    {
        private string _diceText = "3d6+4";
        private string _result;

        void OnGUI()
        {
            GUILayout.BeginArea(new Rect(50,50,400,1000));
            GUILayout.Label("Expression:");
            _diceText = GUILayout.TextArea(_diceText);

            if (GUILayout.Button("Roll"))
            {
                DiceResult diceResult = Dice.Parse(_diceText).Roll();
                _result = diceResult.Value.ToString();
            }

            GUILayout.Label($"Result: {_result}");
            GUILayout.EndArea();
        }
    }
}