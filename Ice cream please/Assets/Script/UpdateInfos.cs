using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateInfos : MonoBehaviour
{

    public InfosCharact infoCharact;
    public Text ID, sex, date, parfums;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ID.text = infoCharact.id;
        sex.text = infoCharact.sexe;
        date.text = infoCharact.date;
        parfums.text = infoCharact.parfums;
    }
}
