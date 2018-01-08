using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour {

    public Animation anim;
	// Use this for initialization
	void Start () {
        anim.Play("Armature|Fly_New");
    }
	
	// Update is called once per frame
	void Update () {
        
	}
}
