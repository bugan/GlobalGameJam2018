using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceGraficaPersonagem : MonoBehaviour {

	public GameObject painelAtalho;
	public Text textoComando;
	public  void mostrarAtalhoLevantarCaixa(){
		this.painelAtalho.SetActive(true);
	}
	public  void esconderAtalhoLevantarCaixa(){
		this.painelAtalho.SetActive(false);
	}
	public void alterarComandoParaSoltarCaixa()
	{
		this.textoComando.text = "To Release";
	}
	public void alterarComandoParaPegarCaixa()
	{
		this.textoComando.text = "To Lift";
	}
}
