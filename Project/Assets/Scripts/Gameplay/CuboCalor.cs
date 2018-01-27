using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboCalor : CuboElemental {

	override public void reagir (Elementos tipoEntrada) {
		if (tipoEntrada == Elementos.Eletricidade) {
			Debug.Log ("Gerar Calor");
		}
	}

	override public Elementos tipoResultante (Elementos tipoEntrada) {
		if (tipoEntrada == Elementos.Eletricidade) {
			return Elementos.Calor;
		}
		return Elementos.Neutro;
	}	
}