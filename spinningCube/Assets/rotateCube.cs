using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateCube : MonoBehaviour
{
    public Transform cubeRotate;
    public float speedMultiplier; //because it rotates very slowly

    // Update is called once per frame
    void Update()
    {
        float rota = Input.GetAxis("Horizontal");
        print("User horizontal input is " + rota);
        

        cubeRotate.Rotate((rota * Time.deltaTime) * speedMultiplier, 0f, 0f);

        //rotateAroundd(rota);
    }
    /*
    void rotateAroundd(float rotaInput){

        Dampen towards the target rotation
        cubeRotate.RotateAround(Vector3.zero, Vector3.up, (rotaInput * Time.deltaTime)*speedMultiplier);
        Use rotate around for part 3 and possiblly part 4
        Create multiple cubes in unity to and assign them as pairs
        to have them rotate around each other.


    }
    */
}
