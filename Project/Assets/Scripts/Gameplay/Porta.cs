using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porta : MonoBehaviour {
	public Trilho entrada;
	public Elementos tipo;

	private bool _estaAberta;

	private void Start () {
		this._estaAberta = false;
	}

	void Update () {

		if (this.entrada.tipo == this.tipo) {

			if (this.entrada.ativo) {
				this._abrir ();
			} else {
				this._fechar ();
			}
		} else {
			this._fechar ();
		}
	}

	private void _abrir () {
		if (this._estaAberta)
			return;
		this._estaAberta = true;
		Debug.Log ("abrir");
	}

	private void _fechar () {
		if (!this._estaAberta)
			return;
		this._estaAberta = false;
		Debug.Log ("Fechar");
	}
}