using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Botao : MonoBehaviour {

	private string _nomeCena;

	public void configurarCena(string nomeCena, int index){
		this._nomeCena = nomeCena;
		this.GetComponent<Button>().onClick.AddListener(this.carregarCena);
		this.GetComponentInChildren<Text>().text = index.ToString();
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
