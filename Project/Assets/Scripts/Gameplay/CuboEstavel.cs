using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboEstavel : CuboElemental {

	public Material materialAceso;
	public Material materialApagado;
	public MeshRenderer miolo;

	override public void reagir (Elementos tipoEntrada) {
		if (tipoEntrada == Elementos.Eletricidade) {
			Debug.Log ("Gerar Eletricidade");
			this.miolo.material = materialAceso;
			this.ativo = true;
		} else {
			Debug.Log ("Neutro");
		}
	}
	override public void desligar () {

	}

	override public Elementos tipoResultante (Elementos tipoEntrada) {
		if (tipoEntrada == Elementos.Eletricidade) {
			return Elementos.Luz;
		}
		return Elementos.Neutro;
	}
}