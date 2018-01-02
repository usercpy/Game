using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereCollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision Other){
		if(Other.gameObject.tag=="red"){
			print ("asda");
			this.gameObject.transform.localScale = new Vector3 (4,4,4);
			//Destroy (Other.gameObject);
		}
	}
}
