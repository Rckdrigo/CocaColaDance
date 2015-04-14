using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SodaFiller : Singleton<SodaFiller> {

	Image image;
	public EllipsoidParticleEmitter prin, sec;

	// Use this for initialization
	void Start () {
		image = GetComponent<Image>();
		GameStateManager.Instance.MusicFinished += StopGenerating;
	}

	void OnEnable(){
		image = GetComponent<Image>();
		image.fillAmount = 0;
	}

	// Update is called once per frame
	public void AddPoint () {
		image.fillAmount+= 0.005f;
	}

	public void StartGame(){
		StartCoroutine(ReducePoints());
	}

	IEnumerator ReducePoints(){
		yield return new WaitForSeconds(0.075f);
		
		image.fillAmount-= 0.00125f;
		StartCoroutine(ReducePoints());
	}	

	void StopGenerating(){
		if(image.fillAmount >0.8f){
			GameStateManager.Instance.Win();
		}
		else{
			GameStateManager.Instance.Lose();
		}
		StopAllCoroutines();
	}

	void Update(){
		if(image.fillAmount >0.8f){
			prin.emit = true;
			sec.emit = true;
		}
		else{
			prin.emit = false;
			sec.emit = false;
		}
	}

}
