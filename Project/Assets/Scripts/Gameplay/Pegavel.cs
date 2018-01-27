using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pegavel : MonoBehaviour {
	private Rigidbody _corpoRigido;
	public bool ligada;

	private void Awake() {
			this._corpoRigido = this.GetComponent<Rigidbody>();
	}
	public void pegar (Transform novoPai) {
		this.transform.parent = novoPai;
		this.transform.localPosition = Vector3.zero;
		this.transform.rotation = novoPai.rotation;

		this._corpoRigido.freezeRotation = true;
		this._corpoRigido.isKinematic = true;
		this.ligada = true;
	}

	public void soltar()
	{
		this.transform.parent = null;
		this._corpoRigido.freezeRotation = false;
		this._corpoRigido.isKinematic = false;
		this.ligada = false;
	}
}