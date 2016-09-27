using UnityEngine;
using System.Collections;

public class PipeSoundT : MonoBehaviour {
    private AudioSource tubesuck;
    public AudioClip vacuum;
    
    

    void Awake()
    {
        tubesuck = GetComponent<AudioSource>();

    }

    void OnTriggerEnter(Collider other)
    {
        tubesuck.clip = vacuum;
        tubesuck.Play();



    }



    void OnTriggerExit(Collider other)
    {
        tubesuck.clip = vacuum;
        tubesuck.Stop();
    }


  

}