using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Movement : MonoBehaviour
{
    GameObject Ball;
    Rigidbody myRigidBody;
    int Life =- 3;
    

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
        myRigidBody.AddForce(0, -200, 0);
    }

    // Update is called once per frame
    void Update()
    {

        float speed = 4;
        myRigidBody.velocity = myRigidBody.velocity.normalized * speed;
        if (transform.position.y < 1)
        {
            transform.position = new Vector3(0, 5, 0);
            Life -= 1;
            
        }
        if(Life == 0)
        {
            Destroy(gameObject);
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
       
    }
}
