using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboLuz : CuboElemental {
	Light _luz;
	AudioSource _som;
	private void Start() {
		this._luz = this.GetComponentInChildren<Light>();
		this._som = this.GetComponentInChildren<AudioSource>();
	}
	override public void reagir (Elementos tipoEntrada) {
		if (tipoEntrada == Elementos.Eletricidade || tipoEntrada == Elementos.Calor) {
			Debug.Log ("Gerar Luz");
			this._luz.enabled = true;
			this._som.Play();
			this.ativo = true;
		}else{
			Debug.Log("Neutro");
		}
	}

	override public void desligar () {
		this._luz.enabled = false;
		this.ativo = false;
	}

	override public Elementos tipoResultante (Elementos tipoEntrada) {
		if (tipoEntrada == Elementos.Eletricidade || tipoEntrada == Elementos.Calor) {
			return Elementos.Luz;
		}
		return Elementos.Neutro;
	}
}