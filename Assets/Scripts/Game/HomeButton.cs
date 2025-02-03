using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeButton : MonoBehaviour
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
        SceneManager.LoadScene("StartScreen");
    }
    public void LoadSceneSelect()
    {
        SceneManager.LoadScene("LoadTrack");
    }
}
