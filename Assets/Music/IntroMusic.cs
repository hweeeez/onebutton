using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroMusic : MonoBehaviour
{
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
        if (objs.Length > 2)
            Destroy(this.gameObject);

        DontDestroyOnLoad(this.gameObject);

    }

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Track 1")
        {
            Destroy(this.gameObject);
        }
        if (SceneManager.GetActiveScene().name == "Track 2")
        {
            Destroy(this.gameObject);
        }
        if (SceneManager.GetActiveScene().name == "Track 3")
        {
            Destroy(this.gameObject);
        }
    }
}
