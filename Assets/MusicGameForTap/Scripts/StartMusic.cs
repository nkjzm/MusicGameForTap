﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartMusic : MonoBehaviour {

    //流したい曲を入れる
    AudioSource targetMusic;
    //押した後に非表示にしたいためButtonUIをいれる。
    public GameObject MusicStaratButton;
    //押した後に曲名を更新するUI
    public Text nowPlayMusicName;
    //MusicNameScriptからMusicNameを取ってくる。
     MusicNameData musicName;
    //スタートしているかどうか
    public bool isStarted;
    // Use this for initialization
    void Start ()
    { 
        targetMusic = GetComponent<AudioSource>();
        musicName = GameObject.Find("MusicNameData").GetComponent<MusicNameData>();
        
    }

    // Update is called once per frame
    void Update () {
		
	}
    public void OnPushedBottun()
    {
        //曲を流す
        targetMusic.Play();
        //StartButtonが邪魔になるので非表示に。
        MusicStaratButton.SetActive(false);

        //現在の曲名を更新
        nowPlayMusicName.text = "Now Play Music\n:" + musicName.GetMusicName(0);
        isStarted = true;
    }
}
