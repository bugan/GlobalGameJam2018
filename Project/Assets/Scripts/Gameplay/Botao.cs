using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Botao : MonoBehaviour {

	private string _nomeCena;

	public void configurarCena(string nomeCena){
		this._nomeCena = nomeCena;
		this.GetComponent<Button>().onClick.AddListener(this.carregarCena);
	}

	public void carregarCena()
	{
		SceneManager.LoadScene(this._nomeCena);
	}

	public void bloquear()
	{
		this.GetComponent<Button>().interactable = false;
	}
}
