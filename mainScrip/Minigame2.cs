using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Minigame2 : MonoBehaviour
{
    public static int Cownum;
    public static int Count;
    public static bool dcoww = true;
    public TMP_Text ValueCount;
    public Animator anim;
    public GameObject prefab;
    public Transform possoinarak;
    public static bool Descow = false;
    GameObject soi;
    public bool chackpass = true;
    // Start is called before the first frame update

    public AudioSource SoundA;
    public AudioSource SoundB;
    public AudioSource SoundC;

    public string[] sceneNames;

    IEnumerator ChangeScene()
    {
        Scroegame.score++;
        yield return new WaitForSeconds(2);
        int Loadgame = Random.Range(0, sceneNames.Length);
        string randomSceneName = sceneNames[Loadgame];
        SceneManager.LoadScene(randomSceneName);
    }

    void Awake()
    {
        anim.SetTrigger("start");
        Cownum = Random.Range(4,10);
        Debug.Log(Cownum);
        
        for (var i = 0; i < Cownum; i++)
        {
            soi = Instantiate(prefab, possoinarak.position, Quaternion.identity);
            soi.transform.parent = possoinarak.transform;
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H) && chackpass)
        {
            
            Count = Count + 1;
            Debug.Log("นายคือ" + Count);
            ValueCount.text = Count.ToString();
            SoundA.Play();
        }

        if (Input.GetKeyDown(KeyCode.J) && chackpass)
        {
            
            wingame();
        }

        if (Count >= 11)
        {
            Count = 0;
            ValueCount.text = Count.ToString();
        }
    }

    

    void wingame()
    {
        if ( Count == Cownum)
        {
            Count = 0;
            Debug.Log("good");
            anim.SetTrigger("end");
            StartCoroutine(ChangeScene());
            SoundB.Play();
        }
        else
        {
            chackpass = false;
              Descow = true;
            Cownum = Random.Range(4,10);
            Count = 0;
            ValueCount.text = Count.ToString();
            SoundC.Play();
            StartCoroutine(DesCOW());

        }
    }

    IEnumerator DesCOW()
    {
        yield return new WaitForSeconds(1.5f);
        Descow = false;
        chackpass = true;
        for (var i = 0; i < Cownum; i++)
        {
            soi = Instantiate(prefab, possoinarak.position, Quaternion.identity);
            soi.transform.parent = possoinarak.transform;
        }

    }


}
