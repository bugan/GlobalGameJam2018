using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trilho : MonoBehaviour {

	public bool ativo;
	public Elementos tipo;
	public Material luz;
	public Material calor;
	public Material energia;
	public Material neutro;
	private MeshRenderer[] renderer;

	private void Start () {
		this.renderer = this.GetComponentsInChildren<MeshRenderer> ();
	}
	public void ativar (Elementos tipo) {
		this.ativo = true;
		this.tipo = tipo;
		if (tipo == Elementos.Calor) {
			this.mudarMateriais(this.calor);
		}
		if (tipo == Elementos.Eletricidade) {
			this.mudarMateriais(this.energia);
		}
		if (tipo == Elementos.Luz) {
			this.mudarMateriais(this.luz);
		}
	}

	public void desativar () {
		this.ativo = false;
		this.mudarMateriais(this.neutro);
	}

	private void mudarMateriais (Material material) {
		for (int i = 0; i < this.renderer.Length; i++) {
			this.renderer[i].material = material;
		}
	}

}