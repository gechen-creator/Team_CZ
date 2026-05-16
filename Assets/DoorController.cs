using UnityEngine;

public class DoorController : MonoBehaviour
{
    private Animator doorAnimator;
    private bool isOpen = false;

    

    public void OpenDoor()
    {
        if (!isOpen)
        {

                Debug.Log("Door opens!");
                transform.Rotate(0, 90, 0);

        }
    }
}