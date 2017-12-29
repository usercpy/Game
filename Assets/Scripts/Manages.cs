using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manages : MonoBehaviour {

	GameObject cube;
	void Start () {
		cube = create.bulecube;
	}
	
	// Update is called once per frame
	void Update () {
		addScripts ();
	}
	void addScripts(){
		if(cube!=null){
			cube.AddComponent<cubeMove> ();
		}
	}

}
