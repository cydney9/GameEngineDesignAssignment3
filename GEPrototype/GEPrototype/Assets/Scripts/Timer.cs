using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//Much of the behavior for this script was used from https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.LoadScene.html
public class Timer : MonoBehaviour
{
    public Text theTimer;
    private float x; //The amount of time
         

    // Start is called before the first frame update
    void Start()
    {
        x = 50;
        theTimer.text = "";
    }
 

    // Update is called once per frame
    void Update()
    {
        if (x > 0)
        {
            x -= Time.deltaTime;
            theTimer.text = "Timer: " + x.ToString();
        }
        else 
        {
            SceneManager.LoadScene("Game"); //restart game
        }
    }
}
