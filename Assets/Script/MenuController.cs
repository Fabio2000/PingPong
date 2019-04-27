using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour {

	public Button BtnComeçar;
    public Button BtnProgramador;
	public Button BtnVoltar;

	// Use this for initialization
	void Start () {
		
	}

	public void Jogo(){
		Debug.Log("Jogo");
		Application.LoadLevel("Jogo");
	}

	public void Programador(){
		Debug.Log("Programador");
		Application.LoadLevel("Programador");
	}

		public void Voltar(){
		Debug.Log("MenuInicial");
		Application.LoadLevel("MenuInicial");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
