using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glacemaker : MonoBehaviour
{
    public List<GameObject> boules;
    public Glace glace;
    public Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
        position = new Vector3(0, 0, 0);
    }
        

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i<glace.parfums.Count; i++)
        {
            if (glace.parfums[i] == "Chocolate")
            {
                Instantiate(boules[0], position, Quaternion.identity);
            }
            if (glace.parfums[i] == "Vanilla")
            {
                Instantiate(boules[0], position, Quaternion.identity);
            }
            if (glace.parfums[i] == "Strawberry")
            {
                Instantiate(boules[0], position, Quaternion.identity);
            }
            if (glace.parfums[i] == "Communist")
            {
                Instantiate(boules[0], position, Quaternion.identity);
            }
        }
    }

}
