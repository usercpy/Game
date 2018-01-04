using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameOver : MonoBehaviour {

    public Text gameOver;  //获得最终结束页面
	void Update () {
        judge();

    }
    void judge() {
        if (sphereCollider.str!=null) {
            gameOver.text = sphereCollider.str;  //红方或者蓝方的胜利
            Time.timeScale = 0;
            gameOver.gameObject.SetActive(true);  //结果页面进行激活
        }
    }
}
