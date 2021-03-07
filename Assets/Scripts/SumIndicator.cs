using UnityEngine;
using UnityEngine.UI;

public class SumIndicator : MonoBehaviour
{
    public Text bombSumText;
    public Text multiplierSumText;

    public void SetTexts(int bombSum, int multiplierSum) 
    {
        bombSumText.text = bombSum.ToString();
        multiplierSumText.text = multiplierSum.ToString();
    }
}

// separate class for row/col?