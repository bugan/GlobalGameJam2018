using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboEstavel : CuboElemental {

	override public void reagir (Elementos tipoEntrada) {
		if (tipoEntrada == Elementos.Eletricidade) {
			this.miolo.material = this.materialAceso;
			this.ativo = true;
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