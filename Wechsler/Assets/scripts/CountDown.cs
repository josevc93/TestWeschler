using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
public class CountDown : MonoBehaviour
{
	//float timeLeft = 300.0f;
	public float	segundos = 0;
	public float minutos = 0;
	bool parado = false;
	public Text text;
	void Start(){
			}


	void Update()
	{
		if (!parado) {
			segundos += Time.deltaTime;
			if (Mathf.Round (segundos) >= 60) {
				sigMinuto ();
			}
			text.text = minutos + " : " + Mathf.Round (segundos);
		}
	}
	void sigMinuto(){
		minutos++;
		segundos = 0;
	}

	public void pararTiempo(){
		parado = !parado;
	}

	public void cambioEscena(){
		PlayerPrefs.SetFloat("segundos", segundos);
		PlayerPrefs.SetFloat("minutos", minutos);
		SceneManager.LoadScene (2);
	}

	public void guardar(){
		PlayerPrefs.SetFloat("segundos", segundos);
		PlayerPrefs.SetFloat("minutos", minutos);
	}
}
