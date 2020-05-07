﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponCamera : MonoBehaviour{
    public GameObject Gan;
    public GameObject Player;
    public GameObject WeaponPlayer;

    void Start(){
        Gan. SetActive (false);
    }

    void Update() {
        if(Input.GetKey(KeyCode.V)){
            Gan. SetActive (true);
            Player.GetComponent <PlayerShot>(). enabled = false;
            WeaponPlayer. SetActive (false);
        }
        if(Input.GetKey(KeyCode.B)){
            Gan. SetActive (false);
            Player.GetComponent <PlayerShot>(). enabled = true;
            WeaponPlayer. SetActive (true);
        }

        
    }

 
}