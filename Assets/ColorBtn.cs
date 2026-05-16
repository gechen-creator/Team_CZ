using UnityEngine;
using TMPro;

public class ColorBtn : MonoBehaviour
{ 
    [SerializeField] private TMP_Text displayTextt;
    [SerializeField] private string correctCode = "GRBY";
    [SerializeField] private int maxCodeLength = 4;
    [SerializeField] private DoorBController door;

    private string currentInput = "";

    void Start()
    {
        UpdateDisplay();
    }


    public void PressColor(string color)
    {
        if (currentInput.Length < maxCodeLength)
        {
            currentInput += color;
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
            displayTextt.text = "ACCESS GRANTED";

            if (door != null)
            {
                door.OpenDoor();
            }

        }
        else
        {
            displayTextt.text = "WRONG CODE";
            Invoke(nameof(ResetKeypad), 1.5f);
        }
    }

    private void UpdateDisplay()
    {
        displayTextt.text = currentInput;
    }

    private void ResetKeypad()
    {
        ClearInput();
    }
}
