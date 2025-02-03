using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Music : MonoBehaviour
{
    public AudioSource Track1;
    public bool startPlay;
    public bool musicPlay;
    public Blankey theBS;

    public int currentScore;
    public int scorePerNote = 100;
    public float notesTracker = 0;
    public int notesHit;
    public int WaitSeconds;

    public Text scoreText;
    public GameObject Score;
    public GameObject resultsScreen;
    public Text percentHitText, rankText, finalScoreText;
    public float totalNotes = 82;


    //public static sword instance;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PlaySoundAfterDelay());
        resultsScreen = GameObject.Find("Results");
        Track1 = GetComponent<AudioSource>();

        StartCoroutine(PlaySoundStop());
        if (Score != null)
        {
            scoreText.text = "Score: 0";
        }

        //StartCoroutine(NoteCount());

    }
    IEnumerator PlaySoundAfterDelay()
    {
        yield return new WaitForSeconds(2);
        Track1.Play();

    }


    void Update()
    {
        Debug.Log(notesTracker);


        float percentHit = (notesTracker / totalNotes) * 100;

        percentHitText.text = percentHit.ToString("F1") + "%";


        string rankVal = "F";
        if (percentHit > 40)
        {
            rankVal = "C";
            if (percentHit > 60)
            {
                rankVal = "B";
                if (percentHit > 80)
                {
                    rankVal = "A";
                    if (percentHit > 90)
                    {
                        rankVal = "S";
                    }
                }
            }
        }
        if (resultsScreen != null)
        {
            rankText.text = rankVal;
            finalScoreText.text = currentScore.ToString();

        }
    }







    IEnumerator PlaySoundStop()
    {
        resultsScreen.SetActive(false);
        yield return new WaitForSeconds(WaitSeconds);
        resultsScreen.SetActive(true);
    }


    public void NoteHit()
    {
        Debug.Log("Hit On Time");
        notesTracker++;
        currentScore += scorePerNote;
        scoreText.text = "Score: " + currentScore;
    }

    /*public void NoteLong()
    {
        Debug.Log("Long Note");
    }*/

    public void NotedMissed()
    {
        Debug.Log("Missed Note");
    }

}
