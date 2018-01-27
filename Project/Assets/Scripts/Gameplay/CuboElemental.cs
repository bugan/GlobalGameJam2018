using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CuboElemental : MonoBehaviour {

	public Elementos tipo;

	

	public abstract void reagir (Elementos tipoEntrada);
	public abstract Elementos tipoResultante(Elementos tipoEntrada);
}