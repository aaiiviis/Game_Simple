﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Weapon : MonoBehaviour {

	public Transform bullet;
	public int BulletForce = 5000;
	public int Magaz = 7;
	public AudioClip Fire;
	public AudioClip Reload;
	public GameObject Pistol;	
	public GameObject FireBall;
	public Text Ammo;
	public int Arsenal = 21;
	public Text UIArsenal;

	void Start(){
		FireBall. SetActive (false);
	}

	void Update () {
		if (Input.GetMouseButtonDown (0) & Magaz > 0) {
			FireBall. SetActive (true);
			Pistol.GetComponent<Animator>(). SetTrigger("Shot");
			Transform BulletInstance = (Transform)Instantiate (bullet, GameObject.Find ("Spawn").transform.position, Quaternion.identity);
			BulletInstance.GetComponent<Rigidbody> ().AddForce (transform.forward * BulletForce);
			Magaz = Magaz - 1;
			GetComponent<AudioSource> ().PlayOneShot (Fire);
			

		}
		if (Input.GetKeyDown (KeyCode.R)&Arsenal>0&Magaz<7) {
			Arsenal = Arsenal - (7-Magaz);
			Magaz = 7;
			GetComponent<AudioSource> ().PlayOneShot (Reload);
			Pistol.GetComponent<Animator>(). SetTrigger("Reload");
		
		}
		if (Input.GetMouseButtonUp(0)){
			FireBall.SetActive (false);
		}
		Ammo.text="Ammo   : "+Magaz;
		UIArsenal.text="/ "+Arsenal;
	}
}