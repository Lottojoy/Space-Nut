using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cow : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public float thrust = 1f;
    public int Xpos;
    public int Ypos;
    bool soisocute = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        if(soisocute)
        {
            StartCoroutine(waitcow());
            soisocute = false;
        }
        rb2D.AddForce(new Vector2(Xpos,Ypos) * thrust, ForceMode2D.Impulse);
        //Debug.Log(Xpos);
        //Debug.Log(Ypos);
        //Debug.Log(Minigame2.dcoww);
        if (Minigame2.dcoww == false)
        {
            Debug.Log("ทำรายเธอ");
            
            StartCoroutine(waitdcow());
            

        }
    }
    IEnumerator waitcow()
    {
        yield return new WaitForSeconds(1);
        soisocute = true;
        Xpos = Random.Range(-5, 5);
        Ypos = Random.Range(-5, 5);
        Debug.Log("โส่ยน่ารักมาก");

    }
    IEnumerator waitdcow()
    {
        Destroy(this.gameObject);
        yield return new WaitForSeconds(2);
       Minigame2.dcoww = true;

    }
}
