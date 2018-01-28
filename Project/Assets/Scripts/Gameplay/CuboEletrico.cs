using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboEletrico : CuboElemental {

	override public void reagir (Elementos tipoEntrada) {
		if (tipoEntrada == Elementos.Luz || tipoEntrada == Elementos.Calor) {
			this.miolo.material = this.materialAceso;
			this.ativo = true;
		}
	}

	override public void desligar () {
		this.miolo.material = this.materialApagado;
		this.ativo = false;
	}

	override public Elementos tipoResultante (Elementos tipoEntrada) {
		if (tipoEntrada == Elementos.Luz || tipoEntrada == Elementos.Calor) {
			return Elementos.Eletricidade;
		}
		return Elementos.Neutro;
	}
}