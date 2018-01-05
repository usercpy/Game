using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour {

    public GameObject gameOverBlue;
    public GameObject gameOverRed;
    public GameObject reset;
    float time = 0.9f;
    void Awark() {
        gameOverBlue.SetActive(false);
        gameOverRed.SetActive(false);

    }
	void Update () {
        judge();

    }
    void judge() {
        if (sphereCollider.str == "红方胜利") {
            gameOverRed.SetActive(true);
            time -= Time.deltaTime;
            if (time<0) {
                reset.SetActive(true);
                Time.timeScale = 0;
            }
           
        } else if (sphereCollider.str=="蓝方胜利") {
            gameOverBlue.SetActive(true);
            time -= Time.deltaTime;
            if (time < 0)
            {
                reset.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
    public void again() {
       
        select_manage.rednum = -1;
        select_manage.bluenum = -1;
        select_manage.temp1 = false;
        sphereCollider.str = null;
        create.cubecopynum = 0;
        create.spherecopynum = 0;
        SceneManager.LoadScene(0);
        gameOverRed.SetActive(false);
        gameOverBlue.SetActive(false);
        Time.timeScale = 1;
    }
}
