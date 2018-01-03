using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeCollider : MonoBehaviour {

    float x = 2, y = 2, z = 2;
    public GameObject gameover;
   
    //void OnTriggerEnter(Collider Other)
    //{
    //    if (Other.gameObject.tag == "red")
    //    {
    //        this.gameObject.transform.localScale = new Vector3(x += 1, y += 1, z += 1);
    //        Other.gameObject.SetActive(false);
    //    }
    //    else if (Other.gameObject.tag == "buleplayer")
    //    {
    //        Time.timeScale = 0;
    //        gameover.SetActive(true);
    //    }
    //}
    void OnCollisionEnter(Collision Other)
    {
        if (Other.gameObject.tag == "blue")
        {
            this.gameObject.transform.localScale = new Vector3(x += 1, y += 1, z += 1);
            this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, y / 2, this.gameObject.transform.position.z);
            Other.gameObject.SetActive(false);
        }
        //else if (Other.gameObject.tag == "redplayer")
        //{
        //    Time.timeScale = 0;
        //  //  gameover.SetActive(true);
        //}
    }
}
