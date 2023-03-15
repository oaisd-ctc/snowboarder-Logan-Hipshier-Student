using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetection : MonoBehaviour
{
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] float loadDelay = 1f;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground")

        {
            crashEffect.Play();
           Invoke("ReloadScene",loadDelay);
        }
    }

    void ReloadScene(){
         SceneManager.LoadScene(0);
    }
}
