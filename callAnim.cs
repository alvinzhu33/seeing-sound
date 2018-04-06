using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class callAnim : MonoBehaviour {
    public Animator anim;
    public string animName;
    // Use this for initialization
    void Start () {
        anim.enabled = false;
	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("collision");
        anim.enabled = true;
        Debug.Log(anim.enabled);
        anim.Play(animName);
    }
}
