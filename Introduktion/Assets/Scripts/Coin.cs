using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Coin : MonoBehaviour
{
    
    void OnTriggerEnter(Collider other){
        if(other.tag == "Player"){
            Destroy(gameObject);
        }
    }
}
