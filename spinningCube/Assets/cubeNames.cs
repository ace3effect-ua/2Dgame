using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeNames : MonoBehaviour
{
    public string [] names;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < names.Length; i++){
            names[i] = Input.inputString;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
