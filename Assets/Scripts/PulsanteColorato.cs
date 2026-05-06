using Unity.VisualScripting;
using UnityEngine;

public class PulsanteColorato : MonoBehaviour
{
    public enum TipoPulsante{
        None,
        Giallo,
        Blue,
        Rosso,
        Verde,
    }
    public TipoPulsante tipoPulsante;
    private Serratura serratura;
   

    private void Start()
    {
        serratura = GetComponentInParent<Serratura>();

        if (serratura == null )
        {
            Debug.LogError("Serratura no trovata");
        }
    }

    public void Interact()
    {
        if (serratura != null)
        {
            serratura.Premuto(tipoPulsante);
        }
    }
}
