using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class PlayingWithAI : MonoBehaviour
{
    [SerializeField] private Button addOne;
    [SerializeField] private Button addTwo;
    [SerializeField] private Button addThree;
    private WhoPlays _plays;
    private int result = 0;
    private void Start()
    {
        EventBus.Register<NumbersOfButtons>(ButtonClick.ACTION, GetButtonNumber);
        
        _plays = WhoPlays.ME;
        if (_plays == WhoPlays.ME)
        {
            
        }
        else
        {
            
        }
    }

    private void GetButtonNumber(NumbersOfButtons numbersOfButtons)
    {
        switch (numbersOfButtons)
        {
           case NumbersOfButtons.ONE:
               result = 1;
               break;
           case NumbersOfButtons.TWO:
               result = 2;
               break;
           case NumbersOfButtons.THREE:
               result = 3;
               break;
        }
    }
}

public enum WhoPlays
{
    ME, AI
}

public enum NumbersOfButtons
{
    ONE, TWO, THREE
}