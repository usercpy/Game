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
	void OnColliderEnter(Collider Other){
		if(Other.gameObject.tag=="red"){
			print ("sad");
			this.transform.localScale += new Vector3 (1,1,1);

		}
	}
}
