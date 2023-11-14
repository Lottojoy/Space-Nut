using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dcow : MonoBehaviour
{
    void Update()
    {
        if(Minigame2.Descow)
        {
            Destroy(gameObject);
        }
    }
}
