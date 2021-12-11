using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController: MonoBehaviour{
	float spawnTimer;
	float spawnRate;
	public GameObject tubo;
	public static bool gameover;
	
    void Start(){
    	spawnRate = 3f;
        gameover = false;
    }

    void Update(){
    	if(!gameover){
		    spawnTimer += Time.deltaTime;
		    if(spawnTimer >= spawnRate){
		    	spawnTimer = 0;
		    	Vector2 spawnPos = new Vector2(0.5f, Random.Range(-1f, 2f));
		    	Instantiate(tubo, spawnPos, Quaternion.identity);
		    }
    	}
    }
}
