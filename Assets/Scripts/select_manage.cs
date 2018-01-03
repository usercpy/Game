using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class select_manage : MonoBehaviour {

	float time=3;//控制初始的提示时间
	public GameObject tip;//提示的页面
	bool temp=true;//控制提示页面显示一次
	public GameObject red;//红方选择页面提示
	public GameObject blue;//蓝方选择页面提示
	static public  int rednum=-1;//选择的红方的序号
	static public int bluenum=-1;//选择的蓝方的序号
	static public bool temp1=false;  //表示红蓝主角  是否选择好
    bool select_red = false;//用来判断红色页面是否在显示
    bool select_blue = false;//用来判断蓝方页面是否在存在
    float time1=1;//红蓝方选择的时间差
    int num;
    bool time_tip=false;
    //bool preparePhase=false;
    //bool playPhase = false;
    //int input;
    void Start () {
		tip.SetActive (true);
        //初始红色显示，蓝色隐藏
     //   red.SetActive(true);
       // blue.SetActive(false);
        //preparePhase = true;

	}
	void Update () {
        judge();
        vanish_hint();
        print(getKeyDownCode());
        // getKeyDownCode();
        //  getKeyDownCode();
        //input=getKeyDownCode();
        ////游戏准备阶段的两个条件：1,preparePhase为true，2，输入合法
        //if (input!=-1&&preparePhase)
        //{
        //    //开始准备阶段的游戏代码
        //    //如果蓝色隐藏,说明当前是选择红色数字阶段，把值付给rednum
        //    if (blue.!active)
        //    {

        //        rednum = getKeyDownCode();

        //    }
        //    else
        //    {
        //        //否则说明当前是选择蓝色数字阶段，赋值给bluenum
        //        bluenum = getKeyDownCode();
        //        preparePhase = false;
        //    }
        //}


        Select_red();
        if (time_tip)
        {
            time1 -= Time.deltaTime;//红蓝选择间隔的时间倒计时
            if (time1 < 0)
            {
                //   Select_blue();
            }
        }


    }
	void vanish_hint()//控制提示6秒消失
	{
		time -= Time.deltaTime;//倒计时
		if(tip!=null&&time<=0&&temp){
			tip.SetActive(false);//隐藏提示框
            
			red.SetActive(true);
            select_red = true;//红方选择页面显示
			temp =false;  
		}
	}

    void Select_red()
    {
        if (select_red)
        {
            red.SetActive(true);   //红方选择提示页面
                                   //  print(getKeyDownCode());
            if (getKeyDownCode() != -1)
            {
                rednum = getKeyDownCode();  //获取小键盘的按键
                print("rednum" + rednum);   //调试用的  
                red.SetActive(false);
                select_red = false;
                select_blue = true;
                time_tip = true;//控制间隔时间开始倒计时的开关
            }

        }

    }
    void Select_blue()
    {
        if (select_blue)
        {
            blue.SetActive(true);
            num = getKeyDownCode();
            if (num != -1)
            {
                bluenum = num;
                //  print("bluenum" + bluenum);//调试用的
                blue.SetActive(false);
                select_blue = false;
            }
        }
    }
    void judge() {
        if (bluenum!=-1&&rednum!=-1) {    //判断红方与蓝方是否选择好
            temp1 = true;
        }
    }
  int  getKeyDownCode()
    {
		if (Input.anyKeyDown) {

            //将输入范围控制在小键盘0-9
            for (int i = 256; i < 266; i++) {
				KeyCode key = (KeyCode)i;
				if (Input.GetKeyDown (key)) {
                   // print((int)key - 256);
                  
				return (i - 256);
				}
			}

		}
     
          return -1;


    }
}
