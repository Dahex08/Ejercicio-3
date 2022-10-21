using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class derrota : MonoBehaviour
{
    public GameObject perder;
    public static GameObject perdiste;

    void Start()
    {
        derrota.perdiste = perder;
        derrota.perdiste.gameObject.SetActive(false);
    }

    public static void show()
    {
        derrota.perdiste.gameObject.SetActive(true);
    }
   
}
