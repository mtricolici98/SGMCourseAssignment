using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freeze : MonoBehaviour {
    private Rigidbody2D rb;
    private bool isFrozen;
    // Use this for initialization
    void Start() {
        isFrozen = false;
    }

    // Update is called once per frame
    void Update() {
        if (isFrozen)
        {
            Debug.Log("Maeby probem here");
            Invoke("freeze", 0f);
            Invoke("unFreeze", 5f);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.tag);
        if (col.tag == "Player1" || col.tag == "Player2")
        {
            rb = col.GetComponent<Rigidbody2D>();
            isFrozen = true;
            Debug.Log("Should Freeze Now");
        }
    }

    void freeze()
    {
        
        rb.mass = 10000000000f;
        
    }
    void unFreeze()
    {
        rb.mass = 1f;
        isFrozen = false;
    }
}
