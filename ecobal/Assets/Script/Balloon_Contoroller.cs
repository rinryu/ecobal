﻿using UnityEngine;
using System.Collections;

public class Balloon_Contoroller : MonoBehaviour {

    public GameObject deathEffect;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void DestroyObject()
    {
        Instantiate(deathEffect, transform.position, transform.rotation);
        Destroy(gameObject);
        

    }
}
