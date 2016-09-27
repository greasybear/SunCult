using UnityEngine;
using System.Collections;

public class PlayTimer : MonoBehaviour {

    public int playtime = 0;   // this is to manipulate and can be used to store later in playerprefs
    private int seconds = 0;
    private int minutes = 0;
    private int hours = 0;
    private int days = 0;


	
	void Start () {
        StartCoroutine("playtimer");
            }
	private IEnumerator playtimer()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            playtime += 80;
            seconds = (playtime);
            
        }
                
                
    }
    void OnGUI()

    {
        GUI.Label(new Rect(20, 20, 400, 50), "Taxes Apple won't pay anyway who cares = " + seconds.ToString() + " Dollars");
    }
	
        
        
        
}

