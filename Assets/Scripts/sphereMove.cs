using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereMove : MonoBehaviour {

	private Rigidbody sphereRigidbogy;
    public float speed=1; 
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
			sphereRigidbogy.velocity= new Vector3(0,0,1)*speed;
		}else if(Input.GetKey(KeyCode.K)){
			sphereRigidbogy.velocity = new Vector3 (0, 0, -1)*speed;
		}else if(Input.GetKey(KeyCode.J)){
			sphereRigidbogy.velocity = new Vector3 (-1, 0, 0)*speed;
		}else if(Input.GetKey(KeyCode.L)){
			sphereRigidbogy.velocity = new Vector3 (1, 0,0)*speed;
		}else{
			sphereRigidbogy.velocity =new  Vector3 (0, 0, 0);
		}
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -29, 29), transform.position.y, Mathf.Clamp(transform.position.z, -29, 29));//限制主角移动的范围
    }
}
