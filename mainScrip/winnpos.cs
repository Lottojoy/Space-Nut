using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class winnpos : MonoBehaviour
{
    public Animator anim;
    public string[] sceneNames;
    void Start()
    {
        anim.SetTrigger("start");
    }
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.gameObject.tag == "Win")
        {
            anim.SetTrigger("end");
            StartCoroutine(ChangeScene());
        }
    }

    IEnumerator ChangeScene()
    {
        Scroegame.score++;
       
        yield return new WaitForSeconds(2);
        int Loadgame = Random.Range(0, sceneNames.Length);
        string randomSceneName = sceneNames[Loadgame];
        SceneManager.LoadScene(randomSceneName);
    }
}
