using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontrol : MonoBehaviour
{
    public GameObject personaje;
   // private Vector2 posicion;

    // Start is called before the first frame update
    void Start()
    {
         //
    }

    // Update is called once per frame
    void Update()
    {
        if (personaje.transform.position.y >= 22)
        {
            //posicion = (posicion.x, posicion.y + 22);
            //transform.position = posicion;
            gameObject.transform.position = new Vector3(0, 41, -20);
        }
    }
}
