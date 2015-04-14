using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class SongSelector : MonoBehaviour {

	public void SetSong(AudioClip song){
		GetComponent<AudioSource>().clip = song;
	}
}
