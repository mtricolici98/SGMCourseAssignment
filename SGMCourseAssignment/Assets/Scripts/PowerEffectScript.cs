using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerEffectScript : MonoBehaviour {
    private bool isBig,isFrozen,isBiggerGate,isSmallerGate;
    private float cooldownBig, cooldownFrozen, cooldownBGate, cooldownSGate;
    private Vector2 originalScale;
    private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        isBig = isFrozen = isBiggerGate = isSmallerGate = false;
        originalScale = gameObject.transform.localScale;
        rb = GetComponent<Rigidbody2D>();
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
    }


    void OnTriggerEnter2D(Collider2D col)
    {
      
        Debug.Log("COLIDED:  "  +col.gameObject.name);
        if(col.gameObject.name == "Grow(Clone)")
        {
            Debug.Log("GROWING");
            isBig = true;
          
        }
        if (col.gameObject.name == "Freeze(Clone)")
        {
            Debug.Log("Freezing");
            isFrozen = true;

        }
        Destroy(col.gameObject);
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
        
    }
    void unFreeze()
    {
        rb.mass = 1f;
        isFrozen = false;
    }


}
