using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    float yaxis;

	// Use this for initialization
	void Start () {
        Debug.Log("hello World");

      
	}
	
	// Update is called once per frame
	void Update () {

        yaxis = transform.position.y;

        Debug.Log(yaxis);

        //AudioManager.singleton.PlayEvent(AudioManager.play_example, gameObject);

        //AudioManager.singleton.SetRTPC(AudioManager.rtpc_example, yaxis);


        Debug.Log("noise!");


    }
}
