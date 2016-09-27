using UnityEngine;
using System.Collections;

public class PlayerReset : MonoBehaviour



{
    
    Vector3 startPos;
    // Use this for initialization
    void Start()
    {
        
        startPos = transform.position;
   
}

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
       
        if (other.tag == "Renet")
        {
            StartCoroutine(MovePlayer());
        
    }
    }
    IEnumerator MovePlayer() {
            yield return new WaitForSeconds(4f);
        transform.position = startPos;
        
        
}
            
        

    }
