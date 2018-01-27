using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboLuz : CuboElemental {

	override public void reagir (Elementos tipoEntrada) {
		if (tipoEntrada == Elementos.Eletricidade) {
			Debug.Log ("Gerar Luz");
		}
	}

	override public Elementos tipoResultante (Elementos tipoEntrada) {
		if (tipoEntrada == Elementos.Eletricidade) {
			return Elementos.Luz;
		}
		return Elementos.Neutro;
	}
}