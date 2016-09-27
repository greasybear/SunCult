using UnityEngine;
using System.Collections;

public class OpenWindow : MonoBehaviour



{


    private DistanceWin distance;
    Animator anim;
    public AudioClip SlideO;
    public AudioClip SlideC;
    public AudioSource windowopen;
    public AudioSource windowclose;

    void Start()
    {
        distance = GetComponent<DistanceWin>();
        anim = GetComponent<Animator>();
        AudioSource audio = GetComponent<AudioSource>();
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E) && distance.inRange)
        {
            anim.SetBool("Opening", true);
            windowopen.clip = SlideO;
            windowopen.Play();

        }
        if (Input.GetKeyUp(KeyCode.E) || !distance.inRange)

        {
            anim.SetBool("Opening", false);
         
        }
        if (Input.GetKeyDown(KeyCode.E) && distance.inRange)
        {
            anim.SetBool("ClosingTime", true);
            windowclose.clip = SlideC;
            windowclose.Play();
        }
        if (Input.GetKeyUp(KeyCode.E) || !distance.inRange)

        {
            anim.SetBool("ClosingTime", false);
            
        }

    }
}