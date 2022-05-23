using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HenScript : MonoBehaviour
{
    public GameObject egg;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    GameObject clon;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            clon = Instantiate(egg);
            clon.transform.position = transform.position + Vector3.down;
        }
    }
}
