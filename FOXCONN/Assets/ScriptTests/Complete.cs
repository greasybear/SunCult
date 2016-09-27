using UnityEngine;
using System.Collections;

public class Complete : MonoBehaviour {
    public GameObject CompletePhone;
	// Use this for initialization
	void Start () {
        for (int i = 0; i < 2; i++)
            Instantiate(CompletePhone, new Vector3(i * 2.0f, 0, 0), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
