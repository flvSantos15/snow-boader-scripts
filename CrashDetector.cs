using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float loadDelay = 1f;
    [SerializeField] ParticleSystem crashDetector;
    [SerializeField] AudioClip crashSFX;
    bool hasCrashed = false;
    
    void OnTriggerEnter2D(Collider2D other) {
         if (other.tag == "Ground" && !hasCrashed)
         {
            hasCrashed = true;
            FindObjectOfType<PlayerControler>().DisableControls();
            crashDetector.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("ReloadScene", loadDelay);
         }
    }

    void ReloadScene()
    {
        // To load a scene we pass the index the the scene we want to load
        SceneManager.LoadScene(0);
    }
}
