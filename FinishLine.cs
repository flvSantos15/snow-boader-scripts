using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float loadDelay = 1f;
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player")
        {
            Invoke("ReloadScene", loadDelay);
        }
    }

    void ReloadScene()
    {
        // To load a scene we pass the index the the scene we want to load
        SceneManager.LoadScene(0);
    }
}
