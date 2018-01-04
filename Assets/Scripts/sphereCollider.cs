using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class sphereCollider : MonoBehaviour {
    float x = 2, y = 2, z = 2;
    public static string str=null;
   
    void OnCollisionEnter(Collision Other)
    {
        if (Other.gameObject.tag == "red")
        {
            this.gameObject.transform.localScale = new Vector3(x += 1, y += 1, z += 1);//半径增加1
            this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x,y/2,this.gameObject.transform.position.z);
            Other.gameObject.SetActive(false);
        }
        else if (Other.gameObject.tag == "blueplayer")
        {
           
            if (Other.gameObject.transform.localScale.x > this.gameObject.transform.localScale.x) {  //比较红方与蓝方的半径
                str = "蓝方胜利";
           
            } else if (Other.gameObject.transform.localScale.x < this.gameObject.transform.localScale.x) {
                str = "红方胜利";
          
            }
         

        }
    }
}
