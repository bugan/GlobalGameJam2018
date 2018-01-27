using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerificarCaixaPerto : MonoBehaviour {

	public float distanciaMiminaParaPegar;
	public Transform controleCamera;
	public Transform pontoDeApoioCaixa;
	private Pegavel _segurando;
	void Start () {

	}

	void Update () {
		RaycastHit hit;
		if (this._segurando == null) {

			if (Physics.Raycast (this.transform.position, this.transform.forward, out hit, this.distanciaMiminaParaPegar, 1 << 8)) {
				this.SendMessageUpwards ("mostrarAtalhoLevantarCaixa");
				if (Input.GetKeyDown (KeyCode.E)) {
					Pegavel pegavel = hit.transform.GetComponent<Pegavel> ();
					if (pegavel != null) {
						this.pegarCaixa(pegavel);
					}
				}
			} else {
				this.SendMessageUpwards ("esconderAtalhoLevantarCaixa");
			}
		} else {
			if (Input.GetKeyDown (KeyCode.E)) {
				this.soltarCaixa ();
			}

		}

		this.transform.rotation = this.controleCamera.rotation;
	}
	public void soltarCaixa () {
		this._segurando.soltar ();
		this._segurando = null;
		this.SendMessageUpwards ("alterarComandoParaPegarCaixa");
	}

	public void pegarCaixa (Pegavel pegavel) {
		this._segurando = pegavel;
		this._segurando.pegar (this.pontoDeApoioCaixa);
		this.SendMessageUpwards ("alterarComandoParaSoltarCaixa");
	}
	private void OnDrawGizmos () {
		Gizmos.color = Color.red;
		Gizmos.DrawLine (this.transform.position, this.transform.position + this.transform.forward * this.distanciaMiminaParaPegar);
	}
}