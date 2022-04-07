using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallHelipocter : MonoBehaviour
{
   public AudioClip audioClip;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetButtonDown("CallHelipcoter"))
        {
            Debug.Log("Message to Helipcoter");
            audioSource.Play();
        }
    }
}
