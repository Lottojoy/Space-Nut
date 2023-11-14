using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigame1 : MonoBehaviour
{
    public int numtowin = 6;
    //public int play = Random.Range(1,6);
    public bool waitgame = true;

    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(3);

    }

    public async void Playgame1()
    {


        //switch (play)
        //{
        //    case 1 && :
        //        StartCoroutine(WaitTime());
        //        break;
        //    case 2:
        //        break;
        //    case 3:
        //        break;
        //    case 4:
        //        break;
        //    case 5:
        //        break;
        //    case 6:
        //        break;
        //}

    }

    // Update is called once per frame
    void start()
    {
        Playgame1();
    }
    
    void Update()
    {
        if (waitgame == false)
        {
            numtowin = 6;
        }
    }
}
