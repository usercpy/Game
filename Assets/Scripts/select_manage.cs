using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class select_manage : MonoBehaviour {

	float time=3;//控制初始的提示时间
	//GameObject tip;
    public GameObject select;
	public GameObject tip;//提示的页面
	bool temp=true;
	public Text red;
	public Text blue;
	static public  int rednum;
	static public int bluenum;
	static public bool temp1=false;
	void Start () {
		//tip = GameObject.Find ("hint");
		tip.SetActive (true);

	}
	
	// Update is called once per frame
	void Update () {
		vanish_hint();
	}
	void vanish_hint()//控制提示6秒消失
	{
		time -= Time.deltaTime;//倒计时
		if(tip!=null&&time<=0&&temp){
			tip.SetActive(false);//隐藏提示框
			if(select!=null){
				select.SetActive (true);
				temp = false;
			}
			time = 3;
		}
	}
	public void StartSelect(){
		rednum = int.Parse (red.text);
		bluenum = int.Parse (blue.text);
		select.SetActive (false);//将选择的页面隐藏
		temp1=true;
	}
}
