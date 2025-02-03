using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blankey : MonoBehaviour

{

    //public float speed;
    public Animator animator;
    public Rigidbody2D rb;

    public GameObject prefab;
    public float beatTempo;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        beatTempo = beatTempo / 60f;



        //speed = 6;
    }

    void Update()
    {


        //transform.Translate(Vector3.left * speed * Time.deltaTime);
        transform.position -= new Vector3(beatTempo * Time.deltaTime, 0f, 0f);


    }
}
