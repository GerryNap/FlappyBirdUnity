using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes: MonoBehaviour{
	bool alreadyCount;
	AudioSource audioSource;

    void Start(){
        alreadyCount = false;
        audioSource = GetComponent<AudioSource>();
    }

    void Update(){
    	if(!GameController.gameover)
    		transform.position = new Vector2(transform.position.x - 1.5f * Time.deltaTime, transform.position.y);
    		
    	if(transform.position.x < -7)
    		Destroy(gameObject);
    		
    	if(!alreadyCount && transform.position.x < -5.2){
    		audioSource.Play();
    		alreadyCount = true;
    		Points.points += 1;
    	}
    }
}
