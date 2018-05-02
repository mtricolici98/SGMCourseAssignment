using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateMakeSmall : MonoBehaviour {
    private GameObject Gate;

    private Vector2 initScale;
    private Vector2 initPos;
    // Use this for initialization
    void Start()
    {
        Gate = this.gameObject;
        initScale = Gate.transform.localScale;
        initPos = Gate.transform.localPosition;

        Invoke("SmallGate", 0f);
        Invoke("NormalGate", 5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    

    void SmallGate()
    {


        Debug.Log("make Left gate smaller");
        Vector2 initScale = Gate.transform.localScale;
        Vector2 initPos = Gate.transform.localPosition;
        initScale.y = initScale.y - 0.3f;
        initPos.y = initPos.y - 1.2f;
        Gate.transform.localScale = initScale;
        Gate.transform.localPosition = initPos;



    }

    void NormalGate()
    {
        Gate.transform.localScale = initScale;
        Gate.transform.localPosition = initPos;
        Destroy(this);
    }
}
