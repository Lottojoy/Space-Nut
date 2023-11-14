using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Endbutton : MonoBehaviour
{
    public string[] sceneNames;
    public Animator anim;
    
    public void ChangeScene()

    {
        int Loadgame = Random.Range(0, sceneNames.Length);
        string randomSceneName = sceneNames[Loadgame];
        SceneManager.LoadScene(randomSceneName);
    }

    void Start()
    {
        anim.SetTrigger("start");
        GameObject StartBG = GameObject.Find("BG sound");
        Destroy(StartBG);
    }
    void Update()
    {
        if (Input.anyKey)
        {
            StartCoroutine(WaitTime());

            Timer.timeValue = 180;



        }
    }

    IEnumerator WaitTime()
    {

        anim.SetTrigger("end");
        Scroegame.score = 0;
        yield return new WaitForSeconds(2);
        int Loadgame = Random.Range(0, sceneNames.Length);
        string randomSceneName = sceneNames[Loadgame];
        SceneManager.LoadScene(randomSceneName);
    }
}
