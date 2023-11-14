using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playbutton : MonoBehaviour
{
    public string[] sceneNames;
    public Animator anim;
    public Animator anim2;
    public void ChangeScene()
    
    {
        int Loadgame = Random.Range(0, sceneNames.Length);
        string randomSceneName = sceneNames[Loadgame];
        SceneManager.LoadScene(randomSceneName);
    }

    void Start()
    {
        anim.SetTrigger("start");
    }
    void Update()
    {
        if (Input.anyKey)
        {
            
            anim2.SetTrigger("playlobby");
            StartCoroutine(WaitTime());

            



        }
    }

    IEnumerator WaitTime()
    {
  
        anim.SetTrigger("end");
        yield return new WaitForSeconds(2);
        int Loadgame = Random.Range(0, sceneNames.Length);
                string randomSceneName = sceneNames[Loadgame];
                SceneManager.LoadScene(randomSceneName);
    }
}