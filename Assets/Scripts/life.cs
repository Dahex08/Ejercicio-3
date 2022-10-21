using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class life : MonoBehaviour
{
    public float vida=10;
    public Slider vidaV; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        vidaV.GetComponent<Slider>().value = vida;
        if (vida <= 0)
        {
            Debug.Log("dead");
            derrota.show ();
        }
    }
}
