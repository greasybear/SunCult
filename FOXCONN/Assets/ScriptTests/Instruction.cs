using UnityEngine;
using System.Collections;

public class Instruction : MonoBehaviour {
    public string text;
    bool display = false;


	
	void OnTriggerEnter (Collider hit) {
        if(hit.transform.name == "Player")
        {
            display = true;
        }     
    }
	
	
	void OnTriggerExit(Collider hit)
    {
       if(hit.transform.name == "Player")
        {
            display = false;
            
        }
	
	}

    void OnGUI ()
    { 
        if(display == true)
        {
            GUI.Box(new Rect(Screen.width / 2 - 75, Screen.height - 100, 150, 30), text);
        }
        }
    
}
