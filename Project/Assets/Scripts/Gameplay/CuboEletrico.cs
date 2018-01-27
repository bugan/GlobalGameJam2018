using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboEletrico : CuboElemental {

	override public void reagir (Elementos tipoEntrada) {
		if (tipoEntrada == Elementos.Luz) {
			Debug.Log ("Gerar Eletricidade");
		}else{
			Debug.Log("Neutro");
		}
	}
	
	override public void desligar () {
		
	}

	override public Elementos tipoResultante (Elementos tipoEntrada) {
		if (tipoEntrada == Elementos.Luz) {
			return Elementos.Eletricidade;
		}
		return Elementos.Neutro;
	}
}