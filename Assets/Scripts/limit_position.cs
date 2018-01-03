using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class limit_position : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        limit();

    }
    void limit() {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -29, 29), transform.position.y, Mathf.Clamp(transform.position.z, -29, 29));//限制主角移动的范围
    }
}
