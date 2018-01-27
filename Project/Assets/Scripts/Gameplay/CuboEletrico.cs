using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboEletrico : CuboElemental {
	
	override public void reagir (Elementos tipoEntrada) {
		if (tipoEntrada == Elementos.Luz) {
			Debug.Log ("Gerar Eletricidade");
		}
	}
}