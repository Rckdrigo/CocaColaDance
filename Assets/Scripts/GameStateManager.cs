using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameStateManager : Singleton<GameStateManager> {

	Animator anim;
	public bool isFinished;
	[System.Serializable()]
	public delegate void GameStates();
	public event GameStates MusicFinished;
	
	public event GameStates Restarting;

	public Sprite win, lose;
	public Image result;

	void Start(){
		anim = GetComponent<Animator>();
	}

	public void StartGame(){
		anim.SetTrigger("NextStep");
		isFinished = false;
	}


	void Update(){
		if(GetComponent<AudioSource>().time >= GetComponent<AudioSource>().clip.length-0.1f && !isFinished){
			MusicFinished();
			isFinished = true;
		}

		if(anim.GetCurrentAnimatorStateInfo(0).IsName("GameHUD")){
			if(Input.GetKeyDown(KeyCode.Space) && !GetComponent<AudioSource>().isPlaying){
				StartCoroutine(GetComponent<SphereGenerator>().GenerateSphere());
				GetComponent<AudioSource>().Play();
				SodaFiller.Instance.StartGame();
			}

		}

		if(Input.GetKeyDown(KeyCode.Escape))
			Application.Quit();
	}

	public void Win(){
		result.sprite = win;
		anim.SetTrigger("NextStep");
	}

	public void Lose(){
		result.sprite = lose;
		anim.SetTrigger("NextStep");
	}

	public void Return(){
		anim.SetTrigger("NextStep");
		Restarting();
	}

	public void GoToSelector(){
		anim.SetTrigger("NextStep");
	}
}
