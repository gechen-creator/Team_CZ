using UnityEngine;
using TMPro;

public class KeypadController : MonoBehaviour
{
    [SerializeField] private TMP_Text displayText;
    [SerializeField] private string correctCode = "3410";
    [SerializeField] private int maxCodeLength = 4;
    [SerializeField] private DoorController door; 

    private string currentInput = "";

    void Start()
    {
        UpdateDisplay();
    }

    
    public void PressNumber(string number)
    {
        if (currentInput.Length < maxCodeLength)
        {
            currentInput += number;
            UpdateDisplay();
        }
    }

    
    public void ClearInput()
    {
        currentInput = "";
        UpdateDisplay();
    }

    
    public void CheckCode()
    {
        if (currentInput == correctCode)
        {
            displayText.text = "ACCESS GRANTED";

            if (door != null)
            {
                door.OpenDoor();
            }

        }
        else
        {
            displayText.text = "WRONG CODE";
            Invoke(nameof(ResetKeypad), 1.5f);
        }
    }

    private void UpdateDisplay()
    {
        displayText.text = currentInput;
    }

    private void ResetKeypad()
    {
        ClearInput();
    }
}

