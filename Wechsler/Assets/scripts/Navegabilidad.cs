using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Navegabilidad : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void irMenuInicial(){
		SceneManager.LoadScene (0);
	}

	public void irMenuNiveles(){
		SceneManager.LoadScene (0);
	}
		
	public void irNivel1(){
		SceneManager.LoadScene (2);
	}

	public void irNivel2(){
		SceneManager.LoadScene (3);
	}

	public void irNivel3(){
		SceneManager.LoadScene (4);
	}

	public void irNivel4(){
		SceneManager.LoadScene (5);
	}

	public void irNivel5(){
		SceneManager.LoadScene (6);
	}

	public void irNivel6(){
		SceneManager.LoadScene (7);
	}

	public void irNivel7(){
		SceneManager.LoadScene (8);
	}

	public void irNivel8(){
		SceneManager.LoadScene (9);
	}

	public void irNivel9(){
		SceneManager.LoadScene (10);
	}
	public void irCreditos(){
		SceneManager.LoadScene (15);
	}
	public void irInstrucciones(){
		SceneManager.LoadScene (16);
	}
	public void irPuntuacion(){
		SceneManager.LoadScene (17);
	}
}