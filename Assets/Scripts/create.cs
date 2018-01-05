using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class create : MonoBehaviour {
	GameObject cubecopy;//复制出的蓝方物体  
	GameObject spherecopy;//复制出的红方物体  
	static public  GameObject [] cubecopyArray;//存储蓝方复制的物体的数组
	static public  GameObject [] spherecopyArray;//存储红方复制的物体的数组
	GameObject cube;////定义复制的物体cube
	GameObject sphere;////定义复制的物体sphere
	public static int cubecopynum=0;//复制的cube的个数
	public static int spherecopynum=0;//复制的shpere的个数
	float x,y;//存储随机生成的地理坐标 x，y
	float x1,y1;
	bool temp=true;//定义一个标记，用来控制  只进行一次整体的复制
	Text blue;//用来存储  cube身上显示的数字
	Text red;
	static public GameObject bulecube;
	//string aaa="peay";
	void Start () {
		cube = Resources.Load <GameObject>("prefabs/Cube");//动态加载预制体
		sphere = Resources.Load <GameObject>("prefabs/Sphere");//动态加载预制体
		cubecopynum = Random.Range (2, 10);//控制cube随机生成的个数
		spherecopynum = Random.Range (2, 10);//控制shpere随机生成的个数
		cubecopyArray=new GameObject[cubecopynum];//设置cube数组的个数
		spherecopyArray=new GameObject[spherecopynum];//设置sphere数组的个数
        copyCube();//调用cube复制的方法
    }
	void Update () {
	
		findcube();
		findshpere ();
	}
	void copyCube()//进行cube的复制还有存储
	{

		if(cube!=null&&temp!=false){
			
			for(int i=0;i<cubecopynum;i++){
				x = Random.Range (-28,28);//随机坐标
				y= Random.Range (-28,28);
			    cubecopy =Instantiate (cube,new Vector3(Mathf.Clamp(x,-28,28),1,Mathf.Clamp(y,-28,28)),this.transform.rotation) as GameObject;//随机生成物体的坐标
				cubecopyArray[i]=cubecopy;//生成的游戏对象存储到对象数组里面
				blue=cubecopyArray [i].transform.Find ("Canvas").Find("Text").GetComponent<Text>();//进行text数字添加
				blue.text = "" + i;


			}
			for (int j = 0; j < spherecopynum; j++) {
				x1 = Random.Range (-28,28);//随机坐标
				y1= Random.Range (-28,28);
				spherecopy =Instantiate (sphere,new Vector3(Mathf.Clamp(x1,-28,28),1,Mathf.Clamp(y1,-28,28)),this.transform.rotation) as GameObject;//随机生成物体的坐标
				spherecopyArray[j]=spherecopy;
				red = spherecopyArray [j].transform.Find ("Canvas").Find ("Text").GetComponent<Text> ();
					
				
				red.text = "" + j;
			}
			temp=false;
		}
	}
	void findcube(){
		if (select_manage.temp1 == true) {
		for(int i=0;i<cubecopynum;i++){
				if(i==select_manage.bluenum&&select_manage.temp1==true&&cubecopyArray [i].GetComponent<cubeMove> ()==null){
				cubecopyArray [i].AddComponent<cubeMove> ();
                    cubecopyArray[i].AddComponent<cubeCollider>();
                    cubecopyArray [i].tag = "blueplayer";// 被选择的蓝色主要人物
                  

			    }
                if (select_manage.rednum!=-1)
                    //Destroy ( cubecopyArray[i].transform.Find ("Canvas").gameObject);
                    cubecopyArray[i].transform.Find("Canvas").Find("Text").GetComponent<Text>().text = "";
               // select_manage.temp1 = false;
            }
	   }
	}
	void findshpere(){
		if (select_manage.temp1 == true) {
         
			for(int i=0;i<spherecopynum;i++){
				if(i==select_manage.rednum&&select_manage.temp1==true&&spherecopyArray [i].GetComponent<sphereMove> ()==null){
					spherecopyArray [i].AddComponent<sphereMove> ();
					spherecopyArray [i].AddComponent<sphereCollider> ();
					spherecopyArray [i].tag = "redplayer";//被选择的红色主要人物
				}
				spherecopyArray[i].transform.Find ("Canvas").Find("Text").GetComponent<Text>().text="";
              //  select_manage.temp1 = false;

            }

		}
	}
}
