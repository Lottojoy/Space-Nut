using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGsound : MonoBehaviour
{
    private AudioSource _audioSource;
    private static BGsound instance = null;
    
    public static BGsound Instance
    {
        get { return instance; }
    }
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }


}

//    private void Start()
//    {
//        GameObject StartBG = GameObject.Find("BG sound");
        
//        if (StartBG)
//        {
//         DontDestroyOnLoad(transform.gameObject);
//            _audioSource = GetComponent<AudioSource>();
            
//        }
        
//    }

//    public void PlayMusic()
//    {
//        //if (_audioSource.isPlaying) return;
//        _audioSource.Play();
//    }

//    public void StopMusic()
//    {
//        _audioSource.Stop();
//    }
//}
