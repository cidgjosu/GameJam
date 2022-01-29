using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov_floor : MonoBehaviour
{
    public float movement = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector2(gameObject.transform.position.x + movement * Time.deltaTime , gameObject.transform.position.y);
        
        if (gameObject.transform.position.x >= 30 || gameObject.transform.position.x  <= -30)
            movement = movement * -1;
    }
}
