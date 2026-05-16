using UnityEngine;

public class DoorBController : MonoBehaviour
{
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
