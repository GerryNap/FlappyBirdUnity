using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points: MonoBehaviour{
	public static int points;
	
    void Start(){
        points = 0;
    }

    void Update(){
        GetComponent<Text>().text = points.ToString();
    }
}
