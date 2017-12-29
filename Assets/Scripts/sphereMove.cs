using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereMove : MonoBehaviour {

	private Rigidbody sphereRigidbogy;
	// Use this for initialization
	void Start () {
		//transform.gameObject.AddComponent<Rigidbody> ();//为选中的物体添加刚体
		sphereRigidbogy = GetComponent<Rigidbody> ();//获取物体身上的刚体
		//sphereRigidbogy.useGravity = false;//让物体不受重力的影响
	}

	// Update is called once per frame
	void Update () {
		spheremove ();//调用移动的函数
	}
	void spheremove()//物体移动的函数
	{  
		if(Input.GetKey(KeyCode.I)){
			sphereRigidbogy.velocity= new Vector3(0,0,1);
		}else if(Input.GetKey(KeyCode.K)){
			sphereRigidbogy.velocity = new Vector3 (0, 0, -1);
		}else if(Input.GetKey(KeyCode.J)){
			sphereRigidbogy.velocity = new Vector3 (-1, 0, 0);
		}else if(Input.GetKey(KeyCode.L)){
			sphereRigidbogy.velocity = new Vector3 (1, 0,0);
		}else{
			sphereRigidbogy.velocity =new  Vector3 (0, 0, 0);
		}

	}
}
