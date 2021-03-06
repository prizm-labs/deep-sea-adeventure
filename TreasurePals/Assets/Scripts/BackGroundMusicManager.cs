﻿using UnityEngine;
using System.Collections;
using System;
public class BackGroundMusicManager : MonoBehaviour {
	public enum BGMType{title =0, setting, game};
	public static BackGroundMusicManager instance;
	public AudioSource s;

	[SerializeField]
	private AudioClip titleBGM;

	[SerializeField]
	private AudioClip GameBGM;

	[SerializeField]
	private AudioClip settingBGM;

	void Awake(){
		if (instance == null) {
			instance = this;
		} else
			Destroy (this);
	}


	public void SetBGM(BGMType type){
		if (type == BGMType.title) {
			s.clip = titleBGM;
		} else if (type == BGMType.game) {
			s.clip = GameBGM;
		} else if(type == BGMType.setting){
			s.clip = settingBGM;
		}

		s.Play ();
	}

	public void SetBGM(string type){
		BGMType parsed_enum = (BGMType)System.Enum.Parse( typeof( BGMType ), type );
		SetBGM (parsed_enum);
	}
}
