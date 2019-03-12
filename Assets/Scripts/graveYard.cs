using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class graveYard : MonoBehaviour
{
     public GameObject explosionParticle;
    void OnTriggerEnter(Collider other){
        if(other.tag == "Coin"){
            Instantiate(explosionParticle, other.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
