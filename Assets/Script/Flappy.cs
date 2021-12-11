using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flappy: MonoBehaviour{
	Rigidbody2D rb;
	public GameObject gameover;
	public GameObject restart;
	public GameObject points;
	public AudioClip[] audioClips;
	public AudioSource audioSource;
	
    void Start(){
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update(){
        if(Input.GetMouseButtonDown(0) && !GameController.gameover){
        	audioSource.PlayOneShot(audioClips[0]);
        	rb.velocity = new Vector2(0f, 6f);
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision){
    	audioSource.PlayOneShot(audioClips[1]);
    	GameController.gameover = true;
    	gameover.SetActive(true);
    	restart.SetActive(true);
    	points.SetActive(false);
    }
}
