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

    Serratura serratura;
    private void Start()
    {
        serratura = GetComponentInParent<Serratura>();
    }

    public void Interact()
    {
        serratura.Premuto(tipoPulsante);
    }
}
