using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void LoadScene()
    {
        SceneManager.LoadScene("Track 1");
    }
    public void LoadScene2()
    {
        SceneManager.LoadScene("Track 2");
    }
    public void LoadScene3()
    {
        SceneManager.LoadScene("Track 3");
    }
}
