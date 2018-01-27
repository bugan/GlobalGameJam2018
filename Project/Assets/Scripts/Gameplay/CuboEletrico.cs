using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboEletrico : CuboElemental {
	
	override public void reagir (Elementos tipoEntrada) {
		Debug.Log(tipoEntrada);
		if (tipoEntrada == Elementos.Calor) {
			Debug.Log ("Gerar Eletricidade");
		}
	}
}