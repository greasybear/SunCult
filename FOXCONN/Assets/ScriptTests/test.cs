using UnityEngine;
using System.Collections;

public class test : MonoBehaviour
{
    private Distance distance;
    Animator anim;
    public GameObject CompletePhone;
    private float timestamp = 0F;
    public float SpawnRate = 1f;
    public Vector3 ObjectSpawnPosition;
    public AudioClip PhoneMake;
    public AudioSource Phone;




    void Start()
    {
        distance = GetComponent<Distance>();
        anim = GetComponent<Animator>();
        AudioSource audio = GetComponent<AudioSource>();
       
    }

    void Update()
    {   

        if (Input.GetKeyDown(KeyCode.E) && distance.inRange)
        {
            anim.SetBool("Production", true);
            Phone.clip = PhoneMake;
            Phone.Play();







        }
        if (Input.GetKeyUp(KeyCode.E) || !distance.inRange)

        {
            anim.SetBool("Production", false);
            Phone.clip = PhoneMake;
            Phone.Stop();
        }

        if (Input.GetKey(KeyCode.E) && distance.inRange && Time.time>= timestamp)
        {
            Instantiate(CompletePhone, ObjectSpawnPosition, Quaternion.identity);
            timestamp = Time.time + SpawnRate;
        }

    }
}
