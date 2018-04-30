using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerEffectScript : MonoBehaviour {
    private bool isBig,isFrozen,isBiggerGate,isSmallerGate;
    private float cooldownBig, cooldownFrozen, cooldownBGate, cooldownSGate;
    private Vector2 originalScale;
    private Rigidbody2D rb;
    public GameObject leftGate;
    public GameObject rightGate;
    private  Vector2 orgScale;
    private   Vector2 endScale;
    private Vector2 LinitScale;
    private Vector2 LinitPos;
    private Vector2 RinitScale;
    private Vector2 RinitPos;
    // Use this for initialization
    void Start () {
        LinitScale = leftGate.transform.localScale;
         LinitPos = leftGate.transform.localPosition;
        RinitScale = rightGate.transform.localScale;
        RinitPos = rightGate.transform.localPosition;
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
        if (isBiggerGate)
        {
            Invoke("BigGate", 0f);
            Invoke("NormalGate", 5f);
        }
        if (isSmallerGate)
        {
            Invoke("SmallGate", 0f);
            Invoke("NormalGate", 5f);
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
        if (col.gameObject.name == "BiggerGate(Clone)")
        {
            Debug.Log("Freezing");
            isBiggerGate = true;

        }
        if (col.gameObject.name == "SmallerGate(Clone)")
        {
            Debug.Log("Freezing");
            isSmallerGate = true;

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

    void BigGate()
    {
        if (gameObject.tag == "Player1")
        {
            Debug.Log("make Left gate bigger");
            Vector2 initScale = leftGate.transform.localScale;
            Vector2 initPos = leftGate.transform.localPosition;
            initScale.y = initScale.y + 0.3f;
            initPos.y = initPos.y + 1.2f;
            leftGate.transform.localScale = initScale;
            leftGate.transform.localPosition = initPos;
            isBiggerGate = false;
        }
        if (gameObject.tag == "Player2")
        {
            Debug.Log("make Right gate bigger");
            Vector2 initScale = rightGate.transform.localScale;
            Vector2 initPos = rightGate.transform.localPosition;
            initScale.y = initScale.y + 0.3f;
            initPos.y = initPos.y + 1.2f;
            rightGate.transform.localScale = initScale;
            rightGate.transform.localPosition = initPos;
            isBiggerGate = false;
        
        }
    }

    void SmallGate()
    {
        if (gameObject.tag == "Player1")
        {
            Debug.Log("make Left gate smaller");
            Vector2 initScale = leftGate.transform.localScale;
            Vector2 initPos = leftGate.transform.localPosition;
            initScale.y = initScale.y - 0.3f;
            initPos.y = initPos.y - 1.2f;
            leftGate.transform.localScale = initScale;
            leftGate.transform.localPosition = initPos;
            isSmallerGate = false;
        }
        if (gameObject.tag == "Player2")
        {
            Debug.Log("make Right gate smaller");
            Vector2 initScale = rightGate.transform.localScale;
            Vector2 initPos = rightGate.transform.localPosition;
            initScale.y = initScale.y - 0.3f;
            initPos.y = initPos.y - 1.2f;
            rightGate.transform.localScale = initScale;
            rightGate.transform.localPosition = initPos;
            isSmallerGate = false;

        }
    }

    void NormalGate()
    {
        leftGate.transform.localScale = LinitScale;
        leftGate.transform.localPosition = LinitPos;
        rightGate.transform.localScale = RinitScale;
        rightGate.transform.localPosition = RinitPos;
    }
}
