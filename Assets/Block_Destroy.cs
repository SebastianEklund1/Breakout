using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block_Destroy : MonoBehaviour
{
   GameObject Block;
    Rigidbody myRigidBody;
    public int score =+ 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
