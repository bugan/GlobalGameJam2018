using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfigurarScore : MonoBehaviour {

	public Text nome;
	public Text pontuacao;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Init(string nome, float recorde){
		this.nome.text = nome;
		this.pontuacao.text = (recorde/60).ToString("N0")+ " : " + (recorde%60).ToString("N0");
	}
}
