using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboCalor : CuboElemental {

	public Material materialAceso;
	public Material materialApagado;
	public MeshRenderer miolo;

	override public void reagir (Elementos tipoEntrada) {
		if (tipoEntrada == Elementos.Eletricidade || tipoEntrada == Elementos.Calor) {
			Debug.Log ("Gerar Calor");
			this.miolo.material = materialAceso;
			this.ativo = true;
			
		} else {
			Debug.Log ("Neutro");
		}
	}
	override public void desligar () {
			this.miolo.material = materialApagado;
			this.ativo = false;
	}

	override public Elementos tipoResultante (Elementos tipoEntrada) {
		if (tipoEntrada == Elementos.Eletricidade) {
			return Elementos.Calor;
		}
		if (tipoEntrada == Elementos.Calor) {
			return Elementos.Calor;
		}

		return Elementos.Neutro;
	}
}