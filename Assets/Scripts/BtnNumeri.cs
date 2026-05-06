using Unity.VisualScripting;
using UnityEngine;
using static BtnNumeri;

public class BtnNumeri : MonoBehaviour
{

        public enum TipoBottone{
            none,
            uno,
            due,
            tre,
            quattro,
            cinque,
            sei,
            sette,
            otto,
            nove,
            zero,
            OK,
        }

    
    public TipoBottone tipoBottone;
    private Tastiera tastiera;


    private void Start()
    {
        tastiera = GetComponentInParent<Tastiera>();
    }

    public void Interact()
    {
        tastiera.Premere(tipoBottone);

    }

}
