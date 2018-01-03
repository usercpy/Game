using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class sphereCollider : MonoBehaviour {
    float x = 2, y = 2, z = 2;
    public GameObject gameover;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //void OnTriggerEnter(Collider Other){
    //       if (Other.gameObject.tag == "red") {
    //           this.gameObject.transform.localScale = new Vector3(x += 1, y += 1, z += 1);
    //           Other.gameObject.SetActive(false);
    //       } else if (Other.gameObject.tag=="buleplayer") {
    //           Time.timeScale = 0;
    //           gameover.SetActive(true);
    //       }
    //}
    void OnCollisionEnter(Collision Other)
    {
        if (Other.gameObject.tag == "red")
        {
            this.gameObject.transform.localScale = new Vector3(x += 1, y += 1, z += 1);
            Other.gameObject.SetActive(false);
        }
        else if (Other.gameObject.tag == "buleplayer")
        {
            Time.timeScale = 0;
            gameover.SetActive(true);
        }
    }
}
