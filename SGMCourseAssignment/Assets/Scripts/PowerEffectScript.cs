using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerEffectScript : MonoBehaviour {
    private bool isBig,isFrozen,isBiggerGate,isSmallerGate;
	// Use this for initialization
	void Start () {
        isBig = isFrozen = isBiggerGate = isSmallerGate = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (isBig)
        {
            Invoke("makeBig", 0f);
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
        Destroy(col.gameObject);
    }

    void makeBig()
    {
        gameObject.transform.localScale = new Vector2(1f, 1f);
    }


}
