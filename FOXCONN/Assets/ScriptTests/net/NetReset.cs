using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NetReset : MonoBehaviour {
    public AudioSource audioSource;
    public AudioSource audioSource2;
    public Camera FirstPersonCharacter;
    public Camera BlackCamera;
    Vector3 startPos;
    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource = GetComponent<AudioSource>();

    }
    void Start()
    {
        startPos = transform.position;
        FirstPersonCharacter.enabled = true;
        BlackCamera.enabled = false;
       
    }


    void OnTriggerEnter(Collider other)
    {
        
        FirstPersonCharacter.enabled = false;
        BlackCamera.enabled = true;

        StartCoroutine(MovePlayer());



    }

    IEnumerator MovePlayer()
    {

        yield return new WaitForSeconds(4f);

        transform.position = startPos;
        
        BlackCamera.enabled = false;
        FirstPersonCharacter.enabled = true;
        
        audioSource.Play();
        
        audioSource2.Play();




    }


    

}