using UnityEngine;
using System.Collections;

public class nivelManager : MonoBehaviour {
	public int disparadas = 10;
	public GameObject puerta;
	public GameObject mision2;
	public GameObject mision3;
	public GameObject mision4;
	public GameObject mision5;

	public int zombiesDown;
	public int aliensDown;
	public int soldiersDown;

	[HideInInspector]
	public GameObject DestruyeGuiObjInstance;
	public GameObject DestruyeGuiObj;


	private GUIText guiaGUIText;	
	public int barriles= 1;
	private bool primera = false;
	// Use this for initialization
	void Start () {

		DestruyeGuiObjInstance = Instantiate(DestruyeGuiObj,new Vector3(-0.35f,-0.40f,0f),transform.rotation) as GameObject;
		//set reference for main color element of hunger GUIText

		//set reference for shadow background color element of hunger GUIText
		//this object is a child of the main hunger GUIText object, so access it as an array
		guiaGUIText = DestruyeGuiObjInstance.GetComponent<GUIText>();
		Invoke("Texto",4);
		//initialize hunger amounts on GUIText objects


	
	}

	// Update is called once per frame
	void Update () {

	}
	public void disparada(){
		disparadas--;
		Debug.Log(""+disparadas);
		if(disparadas == 0){
			puerta.SetActive(false);
		
			DestruyeGuiObjInstance.SetActive(true);
			guiaGUIText.text = "Felicitaciones puedes avanzar";
			Invoke("DesactivarTexto",3);
			Invoke("Habitacion",3);
		}



	}
	void Texto(){

		Invoke("DesactivarTexto",3);
	}
	public void Robot(){
		DestruyeGuiObjInstance.SetActive(true);
		guiaGUIText.text = "Tu mision es interceptar tecnologia alienigena";
		Invoke("Acabar",4);
	}
	public void Acabar(){

		guiaGUIText.text = "que ha sido manipulada por el gobierno de E.E.U.U";
		Invoke("Aldea",4);
	}
	public void Aldea(){

		guiaGUIText.text = "Ve a la aldea en linea recta desde aca, hacia la luz roja";
		Invoke("casa",4);
	}

	void casa(){
		guiaGUIText.text = "Entra a la casa mas larga donde habrán armas.";
		Invoke("DesactivarTexto",4);
	}

	public void DesZombies(){
		DestruyeGuiObjInstance.SetActive(true);
		puerta.SetActive (false);
		guiaGUIText.text = "Destruye a todos los zombies del pueblo";
		Invoke("DesactivarTexto",4);
	}

	public void DesZombiesF(){
		DestruyeGuiObjInstance.SetActive(true);
		guiaGUIText.text = "Has acabado con ellos, fueron resultado de un experimento de la milicia de Norte America";
		Invoke("DesZombiesFI",4);
	}

	public void DesZombiesFI(){
		guiaGUIText.text = "Vivían en paz, hasta que aterrizo una nave alienigena por error";
		Invoke("DesZombiesFIN",4);
	}

	public void DesZombiesFIN(){
		guiaGUIText.text = "Ahora vé a eliminar a los demas militantes que quedan en una base cercana";
		Invoke("DesZombiesFINf",4);
	}

	public void DesZombiesFINf(){
		guiaGUIText.text = "recupera el artefacto alienigena de la base, sigue la luz amarilla";
		mision2.SetActive(true);
		Invoke("DesactivarTexto",4);
	}



	public void DesSoldiersF(){
		DestruyeGuiObjInstance.SetActive(true);
		guiaGUIText.text = "Recoge el artefacto y llevalo a la nave, ten ciudado con los aliens";
		Invoke("DesSoldiersFI",4);
	}

	public void DesSoldiersFI(){
		guiaGUIText.text = "en la nave el artefacto se neutralizará, es una gran responsabilidad usarlo.";
		mision2.SetActive(false);
		mision3.SetActive(true);
		Invoke("DesAliensFo",4);
	}
	public void DesAliensFo(){
		DestruyeGuiObjInstance.SetActive(true);
		guiaGUIText.text = "Sigue las luces verdes";
		Invoke("DesactivarTexto",4);
	}

	public void DesAliensF(){
		DestruyeGuiObjInstance.SetActive(true);
		guiaGUIText.text = "Has derrotado a los aliens, una raza guerrera la cual pudo crear una desgracia";
		Invoke("DesAliensFI",4);
	}

	public void DesAliensFI(){
		guiaGUIText.text = "has salvado al mundo de una catastrofe";
		Invoke("DesactivarTexto",4);
	}


	void DesactivarTexto(){
		DestruyeGuiObjInstance.SetActive(false);
	}
	public void Soldier(){
		soldiersDown--;
	}
	public void Alien(){
		aliensDown--;
		if(aliensDown == 0){
			DesAliensF();
		}
	}
	public void Zombie(){
		zombiesDown--;
		Debug.Log ("muerto"+zombiesDown);
		if(zombiesDown == 0){
			DesZombiesF ();
		}
	}
	public void desactivar1(){
		mision3.SetActive(false);
		mision4.SetActive(true);
	}
	public void desactivar2(){
		mision4.SetActive(false);
		mision5.SetActive(true);
	}
		

}
