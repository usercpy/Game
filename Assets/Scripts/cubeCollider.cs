using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeCollider : MonoBehaviour {

    float x = 2, y = 2, z = 2;
    public GameObject gameover;
  //  public static string str;//gameover时最终显示的页面
  
    void OnCollisionEnter(Collision Other)
    {
        if (Other.gameObject.tag == "blue")
        {
            this.gameObject.transform.localScale = new Vector3(x += 1, y += 1, z += 1);  //蓝方的碰撞检测
            this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, y / 2, this.gameObject.transform.position.z); //重置中心点，保证在平面上
            Other.gameObject.SetActive(false);
        }
      
    }
}
