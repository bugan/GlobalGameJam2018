using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour {

	public bool estaLigado;
	public Elementos tipo;

	public Trilho[] entradas;
	public Trilho[] saidas;

	private bool _podeLigar;
	private GameObject _cuboLigado;

	void Start () {

	}

	void Update () {
		this._verificarEntradas ();
	}

	private void OnTriggerEnter (Collider other) {
		CuboElemental cubo = other.transform.GetComponent<CuboElemental> ();
		if (cubo == null)
			return;

		if (cubo.tipo == this.tipo && this._podeLigar) {
			this._cuboLigado = other.gameObject;
			this._ligar ();
		}
	}

	private void OnTriggerExit (Collider other) {
		if (other.gameObject == this._cuboLigado) {
			this._desligar();
			this._cuboLigado = null;
		}
	}
	
	private void _ligar () {

		this.estaLigado = true;
		for(var i=0 ; i<this.saidas.Length ; i++)
		{
			this.saidas[i].ativo = true;
		}
	}

	private void _desligar () {
		this.estaLigado = true;
		for(var i=0 ; i<this.saidas.Length ; i++)
		{
			this.saidas[i].ativo = false;
		}
	}

	private void _verificarEntradas () {
		for (int i = 0; i < this.entradas.Length; i++) {
			if (this.entradas[i].ativo == false)
				return;
		}
		this._podeLigar = true;
	}
}