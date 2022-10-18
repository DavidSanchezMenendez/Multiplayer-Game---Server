using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonido : MonoBehaviour
{
    PlayerManager player;
    AudioSource Audio;
    public AudioClip N;
    public GameObject Instanciar;
    // Start is called before the first frame update
    void Start()
    {
        Audio = GetComponent<AudioSource>();

       
        
        
    }
    
    public void NWord()
    {
        Audio.PlayOneShot(N);
    }
    public void InstanciarObjeto(Vector3 posicion)
    {
      
            Instantiate(Instanciar, posicion, Quaternion.identity);
        
        
    }



}
