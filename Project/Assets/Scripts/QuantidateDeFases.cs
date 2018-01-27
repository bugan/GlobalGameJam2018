using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class QuantidateDeFases : MonoBehaviour {
	public int quantidade;
	public GameObject botaoPrefab;

	void Start () {
		int leveisAbertos = PlayerPrefs.GetInt("ultimoLevel");
		Debug.Log(leveisAbertos);
		for (int i = 0; i < this.quantidade; i++) {
			GameObject instancia = GameObject.Instantiate (this.botaoPrefab, this.transform);
			Botao botao = instancia.GetComponent<Botao>();
			botao.configurarCena("Cena"+ i, i+1);
			if(i>leveisAbertos){
				botao.bloquear();
			}
		}
	}
}