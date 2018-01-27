using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboEletrico : CuboElemental {

	override public void reagir (Elementos tipoEntrada) {
		if (tipoEntrada == Elementos.Luz || tipoEntrada == Elementos.Calor ) {
			Debug.Log ("Gerar Eletricidade");
			this.ativo = true;
		}else{
			Debug.Log("Neutro");
		}
	}

	override public void desligar () {
			this.ativo = false;
	}

	override public Elementos tipoResultante (Elementos tipoEntrada) {
		if (tipoEntrada == Elementos.Luz || tipoEntrada == Elementos.Calor) {
			return Elementos.Eletricidade;
		}
		return Elementos.Neutro;
	}
}