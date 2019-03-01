using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class soundButton : MonoBehaviour
{
    public AudioMixer mixer;
    public SpriteRenderer buttonImage;

    public Sprite muteSprite;
    public Sprite unmuteSprite;
    bool off;
    // Start is called before the first frame update
    void OnMouseDown(){
        //print( "Clicked the sound button!");
        
        off = !off;
        if (off == false){
            buttonImage.sprite=unmuteSprite;
            mixer.SetFloat("Master", 0.0f);  
        }
        else{
            buttonImage.sprite = muteSprite;
            mixer.SetFloat("Master", -80.0f);
        }
        //mixer.SetFloat("Music", 0.0f);

    }

    //void OnMouseUp(){
        //mixer.SetFloat("Master", 0.0f);
    //}
}
