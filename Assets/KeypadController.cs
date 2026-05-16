using UnityEngine;
using TMPro;

public class KeypadController : MonoBehaviour
{
    [Header("UI Elements")]
    [SerializeField] private TMP_Text displayText;

    [Header("Settings")]
    [SerializeField] private string correctCode = "1234";
    [SerializeField] private int maxCodeLength = 4;

    [Header("References")]
    [SerializeField] private DoorController door; 

    private string currentInput = "";

    void Start()
    {
        CloseKeypad();
    }

    public void ActivateKeypad()
    {
        gameObject.SetActive(true);

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        ClearInput();
    }

    public void CloseKeypad()
    {
        gameObject.SetActive(false);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
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
            displayText.color = Color.green;

            if (door != null)
            {
                door.OpenDoor();
            }

            Invoke(nameof(CloseKeypad), 1.0f);
        }
        else
        {
            displayText.text = "WRONG CODE";
            displayText.color = Color.red;
            Invoke(nameof(ResetKeypad), 1.5f);
        }
    }

    private void UpdateDisplay()
    {
        displayText.color = Color.white;
        displayText.text = currentInput;
    }

    private void ResetKeypad()
    {
        ClearInput();
    }
}

