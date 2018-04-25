using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPowerUpSpawner : MonoBehaviour {


    [SerializeField]  GameObject[] powerBubble;

    private float timeUntilSpawn;
    // Use this for initialization
    void Start () {
        timeUntilSpawn = Random.Range(10, 20);
    }
	
	// Update is called once per frame
	void Update () {
        timeUntilSpawn -= Time.deltaTime;
        if (timeUntilSpawn <= 0)
        {
            SpawnPowerup();
         timeUntilSpawn = Random.Range(10, 20); ;
        }
        
        cleanUp();
    }

    private void SpawnPowerup()
    {
        Vector3 newPos = new Vector3(Random.Range(-15, 15), Random.Range(9  , 10), 0);
        GameObject octo = Instantiate(powerBubble[Random.Range(0,powerBubble.Length-1)], newPos, Quaternion.identity) as GameObject;
        Debug.Log("Spawned"+ octo.name);
    }

    private void cleanUp()
    {
        GameObject[] powerups = GameObject.FindGameObjectsWithTag("PowerUp");
        foreach(GameObject powerup in powerups){
            if (powerup.transform.position.y < -9f)
            {
                Destroy(powerup);
            }
        }
    }

    
}
