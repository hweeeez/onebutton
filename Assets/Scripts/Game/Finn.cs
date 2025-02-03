using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finn : MonoBehaviour
{

    public Rigidbody2D rb;
    public Animator animator;

    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            SpriteRenderer sr;
            sr = GetComponent<SpriteRenderer>();
            animator.SetBool("AttackCont", true);

            //Destroy(collision.gameObject);
        }
        else
        {
            animator.SetBool("AttackCont", false);
        }






    }
}
