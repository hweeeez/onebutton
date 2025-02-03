using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword : MonoBehaviour
{

    //public bool inTrigger = false;
    private GameObject[] Enemy;
    GameObject enemyInTrigger = null;
    public Music MusicScript;
    public GameObject Track1;

    // public GameObject Slider;
    //GameObject sliderInTrigger = null;




    // Start is called before the first frame update
    void Start()
    {
        Enemy = GameObject.FindGameObjectsWithTag("Enemy");
        //Slider = GameObject.Find("Slider");
        MusicScript = Track1.GetComponent<Music>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        enemyInTrigger = other.gameObject;
        //sliderInTrigger = Slider.gameObject;
    }
    void OnTriggerExit2D(Collider2D other)
    {
        enemyInTrigger = null;
        //sliderInTrigger = null;

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && enemyInTrigger != null)
        {
            enemyInTrigger.SetActive(false);

            MusicScript.NoteHit();

            //foreach (GameObject Enemies in Enemy)
            //{
            // Enemies.SetActive(false);
            //}


        }
        if (!Input.anyKeyDown && enemyInTrigger != null)
        {
            MusicScript.NotedMissed();
        }
        if (Input.GetKeyDown(KeyCode.A) && enemyInTrigger == null)
        {
            MusicScript.NotedMissed();
        }
        /*if (Input.GetKeyDown(KeyCode.A) && sliderInTrigger != null)
        {

        }*/

    }

}









