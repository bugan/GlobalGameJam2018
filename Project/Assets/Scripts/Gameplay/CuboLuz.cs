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
			this.miolo.material = this.materialAceso;
			this._luz.enabled = true;
			this._som.Play();
			this.ativo = true;
		}else{
			this.AoErrar.Invoke();
		}
	}

	override public void desligar () {
		this._luz.enabled = false;
		this.ativo = false;
		this.miolo.material = this.materialApagado;
	}

	override public Elementos tipoResultante (Elementos tipoEntrada) {
		if (tipoEntrada == Elementos.Eletricidade || tipoEntrada == Elementos.Calor) {
			return Elementos.Luz;
		}
		return Elementos.Neutro;
	}
}