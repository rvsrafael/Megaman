using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoScript : MonoBehaviour {

	public int vidas;
	public GameObject peixePrefab;
	public Transform gerarPeixes;
	public float intervalo;

	IEnumerator Start () {

		// Gera peixe que sairam da boca do inimigo
		Instantiate (peixePrefab, 
								gerarPeixes.position, 
								gerarPeixes.rotation);
		
		yield return new WaitForSeconds (intervalo);
		StartCoroutine (Start());

	}

	void OnCollisionEnter2D(Collision2D c){

		// Subtrai vidas qndo for atingido pelo projetil (peixe)
		if(c.gameObject.tag == "Projetil") {
			vidas--;
			if (vidas <= 0) {
				Destroy (gameObject);
			}

		}
	
	}
	
	void Update () {
		
	}
}
