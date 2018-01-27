using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboCalor : CuboElemental {

	override public void reagir(Elementos tipoEntrada){
		if(tipoEntrada == Elementos.Eletricidade){
			Debug.Log("Gerar Calor");
		}
	}
}
