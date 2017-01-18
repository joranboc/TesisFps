using UnityEngine;
using System.Collections;

public class LataManager : MonoBehaviour {
	public int disparadas = 10;
	public GameObject puerta;
	public GameObject puerta2;
	[HideInInspector]
	public GameObject hungerGuiObjInstance;
	public GameObject LatasRestantesGuiObj;
	[HideInInspector]
	public GameObject DestruyeGuiObjInstance;
	public GameObject DestruyeGuiObj;
	private HungerText HungerText ;
	private GUIText HungerGUIText;	
	private GUIText guiaGUIText;	
	// Use this for initialization
	void Start () {
		hungerGuiObjInstance = Instantiate(LatasRestantesGuiObj,Vector3.zero,transform.rotation) as GameObject;
		DestruyeGuiObjInstance = Instantiate(DestruyeGuiObj,new Vector3(-0.57f,-0.48f,0f),transform.rotation) as GameObject;
		//set reference for main color element of hunger GUIText
		HungerText = hungerGuiObjInstance.GetComponent<HungerText>();
		//set reference for shadow background color element of hunger GUIText
		//this object is a child of the main hunger GUIText object, so access it as an array
		guiaGUIText = DestruyeGuiObjInstance.GetComponent<GUIText>();
		Invoke("Texto",4);
		//initialize hunger amounts on GUIText objects
		HungerText.hungerGui = disparadas;

		HungerGUIText = HungerText.GetComponent<GUIText>();
	}
	
	// Update is called once per frame
	void Update () {

	}
	public void disparada(){
		disparadas--;
		Debug.Log(""+disparadas);
		if(disparadas == 0){
			puerta.SetActive(false);
			hungerGuiObjInstance.SetActive(false);
			DestruyeGuiObjInstance.SetActive(true);
			guiaGUIText.text = "Felicitaciones puedes avanzar";
			Invoke("DesactivarTexto",3);
			Invoke("Habitacion",5);
		}
		HungerText.hungerGui = disparadas;

		HungerGUIText = HungerText.GetComponent<GUIText>();
	}
	void Texto(){
		
		guiaGUIText.text = "Presiona F para recoger las armas";
		Invoke("Numeros",3);
	}
	void Numeros(){
		
		guiaGUIText.text = "Presiona los numeros para cambiar de arma";
		Invoke("DesactivarTexto",3);
	}

	void DesactivarTexto(){
		DestruyeGuiObjInstance.SetActive(false);
	}
	public void Habitacion(){
		DestruyeGuiObjInstance.SetActive(true);
		guiaGUIText.text = "Recoge una granada y destruye el barril";
		Invoke("DesactivarTexto",3);
	}
	public void barril(){
		DestruyeGuiObjInstance.SetActive(true);

		guiaGUIText.text = "Felicitaciones puedes avanzar";
		Invoke("DesactivarTexto",3);
	}
	public void diana(){
		DestruyeGuiObjInstance.SetActive(true);

		guiaGUIText.text = "Felicitaciones puedes avanzar";
		Invoke("DesactivarTexto",3);
		puerta2.SetActive(false);
	}
}
