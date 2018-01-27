using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Slot : MonoBehaviour {

	public UnityEvent AoLigar;
	public UnityEvent AoDesligar;
	public bool estaLigado;
	public Elementos tipoEntrada;
	public Trilho[] entradas;
	public Trilho[] saidas;

	private bool _podeLigar;
	public CuboElemental _cuboConectado;

	void Start () {

	}

	void Update () {
		this._verificarEntradas ();

		if (this._cuboConectado != null && this._podeLigar && ! this.estaLigado) {
			this._ligar ();
		}

		if ((this._cuboConectado == null || !this._podeLigar) && !this.estaLigado) {
			this._desligar ();
		}

	}

	private void OnTriggerEnter (Collider other) {
		CuboElemental cubo = other.transform.GetComponent<CuboElemental> ();
		if (cubo == null)
			return;
		this._cuboConectado = cubo;
	}

	private void OnTriggerExit (Collider other) {
		if (this._cuboConectado == null)
			return;
		if (other.gameObject == this._cuboConectado.gameObject) {
			this._cuboConectado.desligar ();
			this._cuboConectado = null;
		}
	}

	private void _ligar () {
		this.AoLigar.Invoke();
		Elementos tipo = this._cuboConectado.tipoResultante (this.tipoEntrada);
		this.estaLigado = true;
		for (var i = 0; i < this.saidas.Length; i++) {
			this.saidas[i].ativo = true;
			this.saidas[i].tipo = tipo;
		}
		this._cuboConectado.reagir (this.tipoEntrada);
	}

	private void _desligar () {
		this.AoDesligar.Invoke();
		this.estaLigado = false;
		if (this._cuboConectado != null) {
			this._cuboConectado.desligar ();
		}
		for (var i = 0; i < this.saidas.Length; i++) {
			this.saidas[i].ativo = false;
		}
	}

	private void _verificarEntradas () {
		this._podeLigar = false;
		if (this.entradas.Length > 0) {
			Elementos _tipo = this.entradas[0].tipo;
			for (int i = 0; i < this.entradas.Length; i++) {
				if (_tipo != this.entradas[i].tipo) {
					return;
				}
				if (this.entradas[i].ativo == false)
					return;
			}
			this.tipoEntrada = _tipo;
		}
		this._podeLigar = true;
	}
}