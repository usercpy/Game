using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    Transform aa;
	void Start () {
        aa = transform.Find("/select/Game");
        aa.gameObject.SetActive(false);

	}
	
	// Update is called once per frame
	void Update () {
        //print("123");
        if (aa!=null) {
            print("asd");
        }
    }
}
