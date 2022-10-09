using DiceNotation;
using UnityEngine;

namespace mitaywalle.DiceNotation.Examples
{
    public class DiceTest : MonoBehaviour
    {
        private string _diceText = "3d6+4";
        private string _result;
        
        void OnGUI()
        {
            GUILayout.Label("Expression:");
            _diceText = GUILayout.TextArea(_diceText);
            if (GUILayout.Button("Roll parsed expression"))
            {
                _result = Dice.Parse(_diceText).Roll().Value.ToString();
            }
            
            GUILayout.Label($"Result: {_result}");
        }

    }
}
