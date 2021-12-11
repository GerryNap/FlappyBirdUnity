using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor: MonoBehaviour{
    Vector2 startPosition;
    void Start(){
        startPosition = transform.position;
    }

    void Update(){
    	if(!GameController.gameover){
			if(transform.position.x >= -0.15f)
		        transform.position = new Vector2(transform.position.x - 1.5f * Time.deltaTime, transform.position.y);
		    else
		    	transform.position = startPosition;
    	}
    }
}
