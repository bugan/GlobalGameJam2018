﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour {

	public bool estaLigado;
	public Elementos tipoEntrada;
	public Elementos tipoCubo;
	public Trilho[] entradas;
	public Trilho[] saidas;

	private bool _podeLigar;
	private CuboElemental _cuboLigado;

	void Start () {

	}

	void Update () {
		this._verificarEntradas ();
		if (!this.estaLigado) {
			if (this._cuboLigado != null && this._podeLigar) {
				this._ligar (this._cuboLigado.tipo);
			}
		} else {
			if (this._cuboLigado == null || !this._podeLigar) {
				this._desligar ();
			}
		}
	}

	private void OnTriggerEnter (Collider other) {
		CuboElemental cubo = other.transform.GetComponent<CuboElemental> ();
		if (cubo == null)
			return;
		this._cuboLigado = cubo;
	}

	private void OnTriggerExit (Collider other) {
		if (this._cuboLigado == null)
			return;
		if (other.gameObject == this._cuboLigado.gameObject) {
			this._desligar ();

			this._cuboLigado = null;
		}
	}

	private void _ligar (Elementos tipo) {

		this.estaLigado = true;
		this._cuboLigado.reagir (this.tipoEntrada);
		for (var i = 0; i < this.saidas.Length; i++) {
			this.saidas[i].ativo = true;
			this.saidas[i].tipo = tipo;
		}
	}

	private void _desligar () {
		this.estaLigado = false;
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