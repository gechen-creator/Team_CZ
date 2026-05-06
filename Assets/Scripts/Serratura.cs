using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Serratura : MonoBehaviour
{
    public List<PulsanteColorato.TipoPulsante> sequenza;

    private List<PulsanteColorato.TipoPulsante> sequenzaPremuta;

    public GameObject PortaCamera;

    /// <summary>
    /// Controlla che la sequenzaPremuta sia uguale alla sequenza memorizzata
    /// </summary>
    /// <returns>True se è uguale, False altrimenti</returns>



    private bool ControllaSequenza()
    {
        if (sequenzaPremuta.Count != sequenza.Count)
        {
            return false;
        }

        for (int i = 0; i < sequenza.Count; i++)
        {
            if (sequenzaPremuta[i] != sequenza[i])
            {
                return false;
            }

        }
        return true;

    }

    public void Premuto(PulsanteColorato.TipoPulsante tipoPulsante)
    {
        sequenzaPremuta.Add(tipoPulsante);
        Debug.Log("Aggiunto:  " + tipoPulsante);

        if (sequenzaPremuta.Count == sequenza.Count)
        {
            if (ControllaSequenza())
            {
                Debug.Log ("La sequenza è corretta! La serratura è aperta ");

                PortaCamera.transform.Rotate(0, 180, 0);

            }

            else
            {
                Debug.Log("La sequenza è incorretta! Riprova!");
                sequenzaPremuta.Clear ();
            }
        }
    }
}

    
