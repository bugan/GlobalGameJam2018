using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboCalor : CuboElemental {

	override public void reagir (Elementos tipoEntrada) {
		if (tipoEntrada == Elementos.Eletricidade || tipoEntrada == Elementos.Calor) {
			Debug.Log ("Gerar Calor");
		}else{
			Debug.Log("Neutro");
		}
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