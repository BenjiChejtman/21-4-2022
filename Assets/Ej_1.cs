using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej_1 : MonoBehaviour
{

    int counter = 1;
    int counterMax = 100;

    // Start is called before the first frame update
    void Start()
    {
        while (counter <= counterMax)
        {
            Debug.Log(counter);
            counter++;
        }
        Debug.Log("Termino el while.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
