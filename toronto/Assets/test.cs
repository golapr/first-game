using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    private int speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 10;   
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(speed,0,0);
    }
    private void OnCollisionEnter(Collision collision)
    { if(collision.gameObject.tag=="Player")
        {
            Destroy(gameObject);
        }
        
    }
}
