using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateAroundCube : MonoBehaviour
{
    public Transform cubeRotate;
    public float speedMultiplier; //because it rotates very slowly


    // Update is called once per frame
    void Update()
    {
        float rota = Input.GetAxis("Horizontal");
        print("User horizontal input is " + rota);

        cubeRotate.RotateAround(Vector3.zero, Vector3.up, (rota * Time.deltaTime)*speedMultiplier);
        
    }
}
