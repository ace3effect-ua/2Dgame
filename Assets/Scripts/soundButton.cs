using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class soundButton : MonoBehaviour
{
    public AudioMixer mixer;
    // Start is called before the first frame update
    void OnMouseDown(){
        //print( "Clicked the sound button!");
        mixer.SetFloat("Master", -80.0f);
        //mixer.SetFloat("Music", 0.0f);

    }

    //void OnMouseUp(){
        //mixer.SetFloat("Master", 0.0f);
    //}
}
