﻿using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	public AudioClip[] levelMusicChangeArray;
	
	private AudioSource audioSource;
	
	void Awake(){
		DontDestroyOnLoad(gameObject);
		Debug.Log("Don't destroy on load: " + name);
	}
	
	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
	}
	
	void OnLevelWasLoaded(int level){
		AudioClip thisLevelMusic = levelMusicChangeArray[level];
		Debug.Log("Playing clip: " + thisLevelMusic);
		
		if(thisLevelMusic){
			audioSource.clip = thisLevelMusic;
			audioSource.loop = true;
			audioSource.Play();
		}
	}
	
	public void ChangeVolume(float value){
		audioSource.volume = value;
	}
}
