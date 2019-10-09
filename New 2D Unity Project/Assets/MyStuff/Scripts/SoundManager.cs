using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // Start is called before the first frame update
    
   
       public static SoundManager Instance;
        
        public AudioSource audioSource;

        public AudioClip coinCollectedSound;



    // Update is called once per frame
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else {

            Destroy(this.gameObject);

        }
    }
public void PlayCoinCollectSound()
{
    audioSource.clip = coinCollectedSound;
    audioSource.Play();
}

}
