using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CrashDetection : MonoBehaviour
{
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] float loadDelay = 1f;
    [SerializeField] AudioClip crashSFX;
    bool playedOnce = false;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground")

        {
            FindObjectOfType<PlayerController>().DisableControls();
            crashEffect.Play();
            if(!playedOnce){
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            playedOnce = true;
            }
           Invoke("ReloadScene",loadDelay);
        }
    }

    void ReloadScene(){
         SceneManager.LoadScene(0);
    }
}
