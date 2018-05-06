using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerEffectScript : MonoBehaviour {
    private bool isBig,isFrozen,isBiggerGate,isSmallerGate;
    private Vector2 originalScale;
    private Rigidbody2D rb;
    public GameObject leftGate;
    public GameObject rightGate;
    private Animator animator;
    

    void Start () {
       
        isBig = isFrozen = isBiggerGate = isSmallerGate = false;
        originalScale = gameObject.transform.localScale;
        rb = GetComponent<Rigidbody2D>();
        animator=GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (isBig)
        {
            Invoke("makeBig", 0f);
            Invoke("makeNormal", 5f);

        }else
        if (isFrozen)
        {
            Invoke("freeze", 0f);
            Invoke("unFreeze", 5f);
        }
        if (isBiggerGate)
        {
            Invoke("BigGate", 0f);
          
        }
        if (isSmallerGate)
        {
            Invoke("SmallGate", 0f);
          
        }

    }


    void OnTriggerEnter2D(Collider2D col)
    {
       
        Debug.Log("COLIDED:  "  +col.gameObject.name);
        if(col.gameObject.name == "Grow(Clone)")
        {
            Destroy(col.gameObject);
            isBig = true;
          
        }
        if (col.gameObject.name == "Freeze(Clone)")
        {
            Destroy(col.gameObject);
            isFrozen = true;

        }
        if (col.gameObject.name == "BiggerGate(Clone)")
        {
            Destroy(col.gameObject);
            isBiggerGate = true;

        }
        if (col.gameObject.name == "SmallerGate(Clone)")
        {
            Destroy(col.gameObject);
            isSmallerGate = true;

        }
        
    }

    void makeBig()
    {
        gameObject.transform.localScale = new Vector2(1f, 1f);
    }

    void makeNormal()
    {
        gameObject.transform.localScale = originalScale;
        isBig = false;
    }

    void freeze()
    {
        rb.mass = 10000000000f;
        animator.Play("dizzy");
    }
    void unFreeze()
    {
        rb.mass = 1f;
        isFrozen = false;
    }

    void BigGate()
    {
        if (gameObject.tag == "Player1")
        {
            leftGate.AddComponent<GateMakeBig>();
            isBiggerGate = false;
        }
        if (gameObject.tag == "Player2")
        {
            rightGate.AddComponent<GateMakeBig>();
            isBiggerGate = false;
        
        }
    }

    void SmallGate()
    {
        if (gameObject.tag == "Player1")
        {
            leftGate.AddComponent<GateMakeSmall>();
            isSmallerGate = false;
        }
        if (gameObject.tag == "Player2")
        {
            rightGate.AddComponent<GateMakeSmall>();

            isSmallerGate = false;

        }
    }

  
}
