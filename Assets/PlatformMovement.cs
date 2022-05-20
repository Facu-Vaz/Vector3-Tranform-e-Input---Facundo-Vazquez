using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public float xSpeed;
    public bool toRigth;
    public GameObject prefabRight;
    public GameObject prefabLeft;


    // Start is called before the first frame update
    void Start()
    {
        toRigth = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(toRigth)
        {
            transform.position += new Vector3(xSpeed, 0, 0);
        }
        else 
        {
            transform.position -= new Vector3(xSpeed, 0, 0);
        }

        if (transform.position.x > 2)
        {
            toRigth = false;
            Instantiate(prefabRight);
        }
        else if (transform.position.x < -2)
        {
            toRigth = true;
            Instantiate(prefabLeft);
        }

    }
}
