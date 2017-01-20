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
	public int barriles= 1;
	private bool primera = false;
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
			Invoke("Habitacion",3);
		}
		HungerText.hungerGui = disparadas;

		HungerGUIText = HungerText.GetComponent<GUIText>();
	}
	void Texto(){
		
		guiaGUIText.text = "Presiona F para recoger las armas y clic derecho para apuntar";
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
		guiaGUIText.text = "Dispara 5 veces a la diana";
		Invoke("DesactivarTexto",3);
	}
	public void barril(){
		barriles++;
		Debug.Log(barriles);
		if(barriles == 3){
			if(DestruyeGuiObjInstance != null){
		DestruyeGuiObjInstance.SetActive(true);
			
		puerta2.SetActive(false);
		guiaGUIText.text = "Felicitaciones puedes avanzar";
			Invoke("DesactivarTexto",3);
			Invoke("Listo",3);

			}
		}
	}
	public void Listo(){
		DestruyeGuiObjInstance.SetActive(true);
		guiaGUIText.text = "Felicitaciones estas listo para salir al combate";
		Invoke("DesactivarTexto",3);
		Invoke("Final",3);

	}
	public void Bombas(){
		DestruyeGuiObjInstance.SetActive(true);
		guiaGUIText.text = "Cuidado con las bombas de adelante dispara para destruirlas";
		Invoke("DesactivarTexto",3);

	}
	public void Final(){
		DestruyeGuiObjInstance.SetActive(true);
		guiaGUIText.text = "Ahora explorar hasta encontrar la nave para finalizar el tutorial";
		Invoke("DesactivarTexto",3);
	}
	public void diana(){
		DestruyeGuiObjInstance.SetActive(true);

		guiaGUIText.text = "Felicitaciones puedes avanzar";
		Invoke("DesactivarTexto",3);
		if(primera == false){
			
			Invoke("dianaMov",3);
			primera = true;
		}else{
			Invoke("Granadas",3);
		}


	}
	public void Granadas(){
		DestruyeGuiObjInstance.SetActive(true);

		guiaGUIText.text = "Recoge las granadas de la mesa";
		Invoke("DesactivarTexto",3);
		Invoke("LanzaGranadas",3);
	}
	public void LanzaGranadas(){
		DestruyeGuiObjInstance.SetActive(true);

		guiaGUIText.text = "Presiona G para lanzar Granadas";
		Invoke("DesactivarTexto",3);
	}
	public void dianaMov(){
		DestruyeGuiObjInstance.SetActive(true);

		guiaGUIText.text = "Recoge la francotiradora de la mesa";
		Invoke("DesactivarTexto",3);
		Invoke("dispDiana",3);

	}
	public void dispDiana(){
		DestruyeGuiObjInstance.SetActive(true);

		guiaGUIText.text = "Presiona T para ralentizar y dispara 5 veces al centro de la diana";
		Invoke("DesactivarTexto",3);

	}
}
