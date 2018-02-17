﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubInimigoScript : MonoBehaviour {

	public GameObject alvo;
	public float velocidade;

	void Start () {
		// Atribui o alvoa ser perseguido	
		alvo = GameObject.FindGameObjectWithTag ("Player");

	}
	
	void Update () {
		// Persegue alvo
		transform.position = Vector2.Lerp (transform.position, 
			alvo.transform.position, 
			velocidade * Time.deltaTime);
	}


}
