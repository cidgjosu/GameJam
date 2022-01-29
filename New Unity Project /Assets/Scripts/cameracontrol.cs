using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontrol : MonoBehaviour
{
    public GameObject personaje;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
         if (personaje.transform.position.y < 22)
            gameObject.transform.position = new Vector3(0, 1, -20);
        else if (personaje.transform.position.y >= 22 && personaje.transform.position.y < 62)
            gameObject.transform.position = new Vector3(0, 41, -20);
        else if (personaje.transform.position.y >= 62 && personaje.transform.position.y < 102)
            gameObject.transform.position = new Vector3(0, 81, -20);
        else if (personaje.transform.position.y >= 102 && personaje.transform.position.y < 142)
            gameObject.transform.position = new Vector3(0, 101, -20);
    }
}
