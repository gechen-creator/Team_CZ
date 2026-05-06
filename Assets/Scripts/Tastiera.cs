using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tastiera : MonoBehaviour
{
    public List<BtnNumeri.TipoBottone> ordine;

    private List<BtnNumeri.TipoBottone> ordinePremuta;

    public GameObject PortaFinale;

    private bool ControllaOrdine() 
    {
        if (ordinePremuta.Count != ordine.Count)
        {
            return false;
        }

        for (int i = 0; i < ordine.Count; i++)
        {
            if (ordinePremuta[i] != ordine[i])
            {
                return false;
            }

        }
        return true;
    }

    public void Premere(BtnNumeri.TipoBottone tipoBottone)
    {
        ordinePremuta.Add(tipoBottone);
        Debug.Log("Aggiunto:  " + tipoBottone);

        if (ordinePremuta.Count == ordine.Count)
        {
            if (ControllaOrdine())
            {
                Debug.Log("Il codice è corretto! La porta è aperta ");
                PortaFinale.transform.Rotate(0, 90, 0);
            }

            else
            {
                Debug.Log("Il codice è incorretta! Riprova!");
                ordinePremuta.Clear();
            }
        }
    }
}
