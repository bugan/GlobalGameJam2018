using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboLuz : CuboElemental {

	override public void reagir (Elementos tipoEntrada) {
		if (tipoEntrada == Elementos.Eletricidade || tipoEntrada == Elementos.Calor) {
			Debug.Log ("Gerar Luz");
		}else{
			Debug.Log("Neutro");
		}
	}

	override public Elementos tipoResultante (Elementos tipoEntrada) {
		if (tipoEntrada == Elementos.Eletricidade || tipoEntrada == Elementos.Calor) {
			return Elementos.Luz;
		}
		return Elementos.Neutro;
	}
}