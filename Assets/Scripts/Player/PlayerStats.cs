﻿using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour {
	public float health;
	public int rhythm;
	public GameObject spark;
	public MoveTest pMove;
	public float inv;
	Animator anim;
	int HitHash = Animator.StringToHash("Hit");
	// Use this for initialization
	void Start () {
		health = 5;
		inv = 0;
		pMove = GetComponent<MoveTest> ();
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (health > 5)
			health = 5;
		if (health < 0)
			health = 0;
	}

	public void GetHit(float dmg){
		if (inv < Time.time){
			health -= dmg;
			Instantiate(spark, transform.position, transform.rotation);
			inv = Time.time + 1f;
			anim.SetTrigger (HitHash);
		}
	}
}