using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeMove : MonoBehaviour {

	private Rigidbody cubeRigidbogy;
    public float speed = 3;
	void Start () {
		cubeRigidbogy = GetComponent<Rigidbody> ();//获取物体身上的刚体
	}
	void Update () {
		cubMove ();//调用移动的函数
	}
	void cubMove()//物体移动的函数
	{  
		if(Input.GetKey(KeyCode.W)){
			cubeRigidbogy.velocity= new Vector3(0,0,1)*speed;
		}else if(Input.GetKey(KeyCode.S)){
			cubeRigidbogy.velocity = new Vector3 (0, 0, -1)*speed;
		}else if(Input.GetKey(KeyCode.A)){
			cubeRigidbogy.velocity = new Vector3 (-1, 0, 0)*speed;
		}else if(Input.GetKey(KeyCode.D)){
			cubeRigidbogy.velocity = new Vector3 (1, 0,0)*speed;
		}else{
			cubeRigidbogy.velocity =new  Vector3 (0, 0, 0);
		}
	}
}
