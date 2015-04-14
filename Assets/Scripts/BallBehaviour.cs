using UnityEngine;
using System.Collections;

public class BallBehaviour : MonoBehaviour {

	public Texture white,red;

	void OnDisable(){
		GetComponent<Rigidbody>().velocity = Vector3.zero;
		GetComponent<Renderer>().material.mainTexture = white;
	}

	void OnEnable(){
		float random = Random.Range(0.75f,1.5f);
		transform.localScale = new Vector3(random,random,random);
	}

	void Start(){
		GameStateManager.Instance.Restarting += Pool;
	}

	void Pool(){
		ObjectPool.instance.PoolGameObject(gameObject);
	}

	void OnBecameInvisible() {
		if(gameObject.activeSelf)
			ObjectPool.instance.PoolGameObject(gameObject);
	}

	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.CompareTag("Player")){
			GetComponent<Renderer>().material.mainTexture = red;
			SodaFiller.Instance.AddPoint();
		}
	}

}
