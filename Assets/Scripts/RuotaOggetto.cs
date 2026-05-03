using UnityEngine;

public class RuotaOggetto : MonoBehaviour
{
    public Vector3 rotazioneTarget = new Vector3(0, 0, 180);
    public float velocita = 5f;

    private Quaternion targetRotation;
    private bool cliccato = false;

    void Start()
    {
        targetRotation = transform.rotation;
    }

    void OnMouseDown()
    {
        targetRotation *= Quaternion.Euler(rotazioneTarget);
        cliccato = true;
    }

    void Update()
    {
        if (cliccato)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * velocita);

            if (Quaternion.Angle(transform.rotation, targetRotation) < 0.1f)
            {
                transform.rotation = targetRotation;
                cliccato = false;
            }
        }
    }
}