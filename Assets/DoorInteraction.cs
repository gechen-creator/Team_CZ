using UnityEngine;

public class DoorInteraction : MonoBehaviour
{

    [SerializeField] private KeypadController keypadCanvas;

    [SerializeField] private float reachDistance = 3f;

    private void OnMouseDown()
    {
        if (keypadCanvas != null)
        {
            keypadCanvas.ActivateKeypad();
        }
    }
}

