using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    public float threshold = -10f;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= threshold)
        {
            transform.position = new Vector3(-18.7999992f, 0.688472986f, 235.800003f);
        }
    }

    
}
