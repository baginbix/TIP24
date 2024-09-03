using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed = 1f;

    // Update is called once per frame
    void Update()
    {
        Vector3 velocity = new Vector3();
        if(Input.GetKey(KeyCode.W)){
            velocity.x = 1;
        }
        if(Input.GetKey(KeyCode.S)){
            velocity.x = -1;
        }
        if(Input.GetKey(KeyCode.D)){
            velocity.z = -1;
        }
        if(Input.GetKey(KeyCode.A)){
            velocity.z = 1;
        }
        velocity.Normalize();

        transform.position += velocity * Time.deltaTime * speed;

    }
}
