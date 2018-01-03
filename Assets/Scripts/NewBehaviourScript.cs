using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    Transform a;
	void Start () {
        a = transform.Find("/Game");
       
	}
	
	// Update is called once per frame
	void Update () {
        if (a != null)
        {
            print("a");
        }
    }
}
