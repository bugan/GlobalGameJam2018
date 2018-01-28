using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CuboElemental : MonoBehaviour {

	public Elementos tipo;
	public bool ativo;
	public Material materialAceso;
	public Material materialApagado;
	public MeshRenderer miolo;

	public abstract void reagir (Elementos tipoEntrada);
	public abstract void desligar ();
	public abstract Elementos tipoResultante (Elementos tipoEntrada);
}