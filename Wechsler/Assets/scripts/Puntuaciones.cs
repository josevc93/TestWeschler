using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
public class Puntuaciones : MonoBehaviour {
	public Text textPrueba1, textPrueba2, textPrueba3, textPrueba4, textPrueba5, textPrueba6, textPrueba7, textPrueba8, textPrueba9, textPrueba10, textPrueba11, textPrueba12 ;
	public Text TpuntosPrueba1 , TpuntosPrueba2 , TpuntosPrueba3 , TpuntosPrueba4 , TpuntosPrueba5 , TpuntosPrueba6 , TpuntosPrueba7 , TpuntosPrueba8 , TpuntosPrueba9 , TpuntosPrueba10 , TpuntosPrueba11 , TpuntosPrueba12 , TpuntosPruebaTotal ;
	float minutosPrueba1 , segundosPrueba1 , minutosPrueba2 , segundosPrueba2 , minutosPrueba3 , segundosPrueba3 , minutosPrueba4 , segundosPrueba4 , minutosPrueba5 , segundosPrueba5 , minutosPrueba6 , segundosPrueba6 , minutosPrueba7 , segundosPrueba7 , minutosPrueba8 , segundosPrueba8 , minutosPrueba9 , segundosPrueba9 , minutosPrueba10 , segundosPrueba10 , minutosPrueba11 , segundosPrueba11 , minutosPrueba12 , segundosPrueba12 ;
	int puntosPrueba1 , puntosPrueba2 , puntosPrueba3 , puntosPrueba4 , puntosPrueba5 , puntosPrueba6 , puntosPrueba7 , puntosPrueba8 , puntosPrueba9 , puntosPrueba10 , puntosPrueba11 , puntosPrueba12, puntosPruebaTotal ;
	// Use this for initialization
	void Start () {
		Tiempos ();
		Puntos ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Puntos(){
		//Puntos 
		if (segundosPrueba1 < 45)
			puntosPrueba1 = 2;
		else {
			puntosPrueba1 = 0;
		}
		TpuntosPrueba1.text = puntosPrueba1.ToString ();
		//Puntos 
		if (segundosPrueba2 < 45)
			puntosPrueba2 = 4;
		else {
			puntosPrueba2 = 0;
		}
		TpuntosPrueba2.text = puntosPrueba2.ToString ();
		//Puntos 
		if (segundosPrueba3 < 45)
			puntosPrueba3 = 4;
		else {
			puntosPrueba3 = 0;
		}
		TpuntosPrueba3.text = puntosPrueba3.ToString ();
		//Puntos 
		if (segundosPrueba4 < 45)
			puntosPrueba4 = 4;
		else {
			puntosPrueba4 = 0;
		}
		TpuntosPrueba4.text = puntosPrueba4.ToString ();
		//Puntos 
		if (segundosPrueba5 < 45)
			puntosPrueba5 = 4;
		else {
			puntosPrueba5 = 0;
		}
		TpuntosPrueba5.text = puntosPrueba5.ToString ();
		//Puntos 
		if (segundosPrueba6 < 45)
			puntosPrueba6 = 4;
		else {
			puntosPrueba6 = 0;
		}
		TpuntosPrueba6.text = puntosPrueba6.ToString ();
		//Puntos 
		if ((segundosPrueba7 + minutosPrueba7 * 60)>= 75)
			puntosPrueba7 = 0;
		else {	
			if ((segundosPrueba7 + minutosPrueba7 * 60)< 75 && (segundosPrueba7 + minutosPrueba7 * 60)>= 31)
			puntosPrueba7 = 4;
			if ((segundosPrueba7 + minutosPrueba7 * 60)< 31 && (segundosPrueba7 + minutosPrueba7 * 60)>= 21)
				puntosPrueba7 = 5;
			if ((segundosPrueba7 + minutosPrueba7 * 60)< 21 && (segundosPrueba7 + minutosPrueba7 * 60)>= 11)
				puntosPrueba7 = 6;
			if ((segundosPrueba7 + minutosPrueba7 * 60)< 11 && (segundosPrueba7 + minutosPrueba7 * 60)>= 1)
				puntosPrueba7 = 7;
			
		}
		TpuntosPrueba7.text = puntosPrueba7.ToString ();
		//Puntos 
		if ((segundosPrueba8 + minutosPrueba8 * 60)>= 75)
			puntosPrueba8 = 0;
		else {	
			if ((segundosPrueba8 + minutosPrueba8 * 60)< 75 && (segundosPrueba8 + minutosPrueba8 * 60)>= 31)
				puntosPrueba8 = 4;
			if ((segundosPrueba8 + minutosPrueba8 * 60)< 31 && (segundosPrueba8 + minutosPrueba8 * 60)>= 21)
				puntosPrueba8 = 5;
			if ((segundosPrueba8 + minutosPrueba8 * 60)< 21 && (segundosPrueba8 + minutosPrueba8 * 60)>= 11)
				puntosPrueba8 = 6;
			if ((segundosPrueba8 + minutosPrueba8 * 60)< 11 && (segundosPrueba8 + minutosPrueba8 * 60)>= 1)
				puntosPrueba8 = 7;

		}
		TpuntosPrueba8.text = puntosPrueba8.ToString ();
		//Puntos 
		if ((segundosPrueba9 + minutosPrueba9 * 60)>= 120)
			puntosPrueba9 = 0;
		else {	
			if ((segundosPrueba9 + minutosPrueba9 * 60)< 120 && (segundosPrueba9 + minutosPrueba9 * 60)>= 71)
				puntosPrueba9 = 4;
			if ((segundosPrueba9 + minutosPrueba9 * 60)< 71 && (segundosPrueba9 + minutosPrueba9 * 60)>= 51)
				puntosPrueba9 = 5;
			if ((segundosPrueba9 + minutosPrueba9 * 60)< 51 && (segundosPrueba9 + minutosPrueba9 * 60)>= 31)
				puntosPrueba9 = 6;
			if ((segundosPrueba8 + minutosPrueba9 * 60)< 31 && (segundosPrueba8 + minutosPrueba9 * 60)>= 1)
				puntosPrueba9 = 7;

		}
		TpuntosPrueba9.text = puntosPrueba9.ToString ();
		//Puntos 
		if ((segundosPrueba10 + minutosPrueba10 * 60)>= 120)
			puntosPrueba10 = 0;
		else {	
			if ((segundosPrueba10 + minutosPrueba10 * 60)< 120 && (segundosPrueba10 + minutosPrueba10 * 60)>= 71)
				puntosPrueba10 = 4;
			if ((segundosPrueba10 + minutosPrueba10 * 60)< 71 && (segundosPrueba10 + minutosPrueba10 * 60)>= 51)
				puntosPrueba10 = 5;
			if ((segundosPrueba10 + minutosPrueba10 * 60)< 51 && (segundosPrueba10 + minutosPrueba10 * 60)>= 31)
				puntosPrueba10 = 6;
			if ((segundosPrueba10 + minutosPrueba10 * 60)< 31 && (segundosPrueba10 + minutosPrueba10 * 60)>= 1)
				puntosPrueba10 = 7;

		}
		TpuntosPrueba10.text = puntosPrueba10.ToString ();

		//Puntos 
		if ((segundosPrueba11 + minutosPrueba11 * 60)>= 120)
			puntosPrueba11 = 0;
		else {	
			if ((segundosPrueba11 + minutosPrueba11 * 60)< 120 && (segundosPrueba11 + minutosPrueba11 * 60)>= 71)
				puntosPrueba11 = 4;
			if ((segundosPrueba11 + minutosPrueba11 * 60)< 71 && (segundosPrueba11 + minutosPrueba11 * 60)>= 51)
				puntosPrueba11 = 5;
			if ((segundosPrueba11 + minutosPrueba11 * 60)< 51 && (segundosPrueba11 + minutosPrueba11 * 60)>= 31)
				puntosPrueba11 = 6;
			if ((segundosPrueba11 + minutosPrueba11 * 60)< 31 && (segundosPrueba11 + minutosPrueba11 * 60)>= 1)
				puntosPrueba11 = 7;

		}
		TpuntosPrueba11.text = puntosPrueba11.ToString ();

		//Puntos 
		if ((segundosPrueba12 + minutosPrueba12 * 60)>= 120)
			puntosPrueba12 = 0;
		else {	
			if ((segundosPrueba12 + minutosPrueba12 * 60)< 120 && (segundosPrueba12 + minutosPrueba12 * 60)>= 71)
				puntosPrueba12 = 4;
			if ((segundosPrueba12 + minutosPrueba12 * 60)< 71 && (segundosPrueba12 + minutosPrueba12 * 60)>= 51)
				puntosPrueba9 = 5;
			if ((segundosPrueba12 + minutosPrueba12 * 60)< 51 && (segundosPrueba12 + minutosPrueba12 * 60)>= 31)
				puntosPrueba12 = 6;
			if ((segundosPrueba12 + minutosPrueba12 * 60)< 31 && (segundosPrueba12 + minutosPrueba12 * 60)>= 1)
				puntosPrueba12 = 7;

		}
		TpuntosPrueba12.text = puntosPrueba12.ToString ();

		puntosPruebaTotal = puntosPrueba1 + puntosPrueba2 + puntosPrueba3 + puntosPrueba4 + puntosPrueba5 + puntosPrueba6 + puntosPrueba7 + puntosPrueba8 + puntosPrueba9 + puntosPrueba10 + puntosPrueba11 + puntosPrueba12;
		TpuntosPruebaTotal.text = "Total: " + puntosPruebaTotal;
	}

	void Tiempos(){
		//Prueba 1
		segundosPrueba1 = PlayerPrefs.GetFloat ("segundosNivel2");
		minutosPrueba1 = PlayerPrefs.GetFloat ("minutosNivel2");
		textPrueba1.text = minutosPrueba1 + " : " + segundosPrueba1;
		//Prueba 2
		segundosPrueba2 = PlayerPrefs.GetFloat ("segundosNivel3");
		minutosPrueba2 = PlayerPrefs.GetFloat ("minutosNivel3");
		textPrueba2.text = minutosPrueba2 + " : " + segundosPrueba2;
		//Prueba 3
		segundosPrueba3 = PlayerPrefs.GetFloat ("segundosNivel4");
		minutosPrueba3 = PlayerPrefs.GetFloat ("minutosNivel4");
		textPrueba3.text = minutosPrueba3 + " : " + segundosPrueba3;
		//Prueba 4
		segundosPrueba4 = PlayerPrefs.GetFloat ("segundosNivel5");
		minutosPrueba4 = PlayerPrefs.GetFloat ("minutosNivel5");
		textPrueba4.text = minutosPrueba4 + " : " + segundosPrueba4;
		//Prueba 5
		segundosPrueba5 = PlayerPrefs.GetFloat ("segundosNivel6");
		minutosPrueba5 = PlayerPrefs.GetFloat ("minutosNivel6");
		textPrueba5.text = minutosPrueba5 + " : " + segundosPrueba5;
		//Prueba 6
		segundosPrueba6 = PlayerPrefs.GetFloat ("segundosNivel7");
		minutosPrueba6 = PlayerPrefs.GetFloat ("minutosNivel7");
		textPrueba6.text = minutosPrueba6 + " : " + segundosPrueba6;
		//Prueba 7
		segundosPrueba7 = PlayerPrefs.GetFloat ("segundosNivel8");
		minutosPrueba7 = PlayerPrefs.GetFloat ("minutosNivel8");
		textPrueba7.text = minutosPrueba7 + " : " + segundosPrueba7;
		//Prueba 8
		segundosPrueba8 = PlayerPrefs.GetFloat ("segundosNivel9");
		minutosPrueba8 = PlayerPrefs.GetFloat ("minutosNivel9");
		textPrueba8.text = minutosPrueba8 + " : " + segundosPrueba8;
		//Prueba 9
		segundosPrueba9 = PlayerPrefs.GetFloat ("segundosNivel10");
		minutosPrueba9 = PlayerPrefs.GetFloat ("minutosNivel10");
		textPrueba9.text = minutosPrueba9 + " : " + segundosPrueba9;
		//Prueba 10
		segundosPrueba10 = PlayerPrefs.GetFloat ("segundosNivel11");
		minutosPrueba10 = PlayerPrefs.GetFloat ("minutosNivel11");
		textPrueba10.text = minutosPrueba10 + " : " + segundosPrueba10;
		//Prueba 11
		segundosPrueba11 = PlayerPrefs.GetFloat ("segundosNivel12");
		minutosPrueba11 = PlayerPrefs.GetFloat ("minutosNivel12");
		textPrueba11.text = minutosPrueba11 + " : " + segundosPrueba11;
		//Prueba 12
		segundosPrueba12 = PlayerPrefs.GetFloat ("segundosNivel13");
		minutosPrueba12 = PlayerPrefs.GetFloat ("minutosNivel13");
		textPrueba12.text = minutosPrueba12 + " : " + segundosPrueba12;

	}

	void Salir (){
		SceneManager.LoadScene (0);
	}
}
