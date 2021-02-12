using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UpdateInfos : MonoBehaviour
{

    public InfosCharact infoCharact;
    public Text ID, sex, date, parfums;
    public Text tscore, tlife;
    public Score score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ID.text = "ID : " + infoCharact.id;
        sex.text = infoCharact.sexe;
        date.text = infoCharact.date;
        parfums.text = infoCharact.parfums;
        tscore.text = "Score : " + score.score;
        tlife.text = " Error max : " + score.life;
        if(score.life <= 0)
            SceneManager.LoadScene("GameOver");
    }
}
