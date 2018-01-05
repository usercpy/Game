using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereMove : MonoBehaviour {

	private Rigidbody sphereRigidbogy;
    public float speed=4;
    void Start()
    {
        sphereRigidbogy = GetComponent<Rigidbody>();//获取物体身上的刚体
    }
	void Update () {
        spheremove ();//调用移动的函数
	}
	void spheremove()//物体移动的函数
	{
        
        if (Input.GetKey(KeyCode.UpArrow)){
           
            sphereRigidbogy.velocity= new Vector3(0,0,1)*speed;
		}else if(Input.GetKey(KeyCode.DownArrow)){
			sphereRigidbogy.velocity = new Vector3 (0, 0, -1)*speed;
		}else if(Input.GetKey(KeyCode.LeftArrow)){
			sphereRigidbogy.velocity = new Vector3 (-1, 0, 0)*speed;
		}else if(Input.GetKey(KeyCode.RightArrow)){
			sphereRigidbogy.velocity = new Vector3 (1, 0,0)*speed;
		}else{
			sphereRigidbogy.velocity =new  Vector3 (0, 0, 0);
		}
    }
}
