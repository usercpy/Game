using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class  select_manage : MonoBehaviour
{
   
    public GameObject red;//红方选择页面提示
    public GameObject blue;//蓝方选择页面提示
    static public int rednum = -1;//选择的红方的序号
    static public int bluenum = -1;//选择的蓝方的序号
    static public bool temp1 = false;  //表示红蓝主角  是否选择好
    bool preparePhase = false;
    bool playPhase = false;
    int input;
    void Start()
    {
        //初始红色显示，蓝色隐藏
        red.SetActive(true);
        blue.SetActive(false);
        preparePhase = true;

    }
    void Update()
    {
        judge();
        getKeyDownCode();
       
        input = getKeyDownCode();
        //游戏准备阶段的两个条件：1,preparePhase为true，2，输入合法
        if (input != -1 && preparePhase)
        {
            //开始准备阶段的游戏代码
            //如果蓝色隐藏,说明当前是选择红色数字阶段，把值付给rednum
            if (!blue.activeInHierarchy&&input<create.spherecopynum)//如果红方提示出现
            {
                rednum = input;
                red.SetActive(false);
                blue.SetActive(true);
            }
            else if(input < create.cubecopynum)
            {
                //否则说明当前是选择蓝色数字阶段，赋值给bluenum
                bluenum = input;
                blue.SetActive(false);
                playPhase = true;
                preparePhase = false;    
            }
        }
        judge();
    }
    void judge()
    {
        if (bluenum != -1 && rednum != -1&&playPhase)
        {    //判断红方与蓝方是否选择好   
            temp1 = true;
            playPhase = false;   
        }
    }
    int getKeyDownCode()
    {
        if (Input.anyKeyDown)
        {
            //将输入范围控制在小键盘0-9
            for (int i = 256; i < 266; i++)
            {
                KeyCode key = (KeyCode)i;
                if (Input.GetKeyDown(key))
                {
                    return (i - 256);
                }
            }

        }
        return -1;
    }
}
