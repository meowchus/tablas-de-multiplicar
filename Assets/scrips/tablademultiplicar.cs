using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tablademultiplicar : MonoBehaviour {

	public Slider SlA;
	public Text resultados;
	int A,prov;
	
	public void multiplicar(){
		A= (int)SlA.value;
			resultados.text= "Resultados:";
			for (int indice=0;indice<=10;indice++){
				prov=A*indice;
				resultados.text+=""+"\n"+""+A+"*"+indice+"="+prov;
			}
	}




	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
