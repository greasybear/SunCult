using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour {

    
    public Button startText;
    

	// Use this for initialization
	void Start () {

        
        startText = startText.GetComponent<Button>();
        
	
	}
	
    public void StartLevel()
    {
        SceneManager.LoadScene("Factory1");
    }



	// Update is called once per frame
	void Update () {


	
	}
}
