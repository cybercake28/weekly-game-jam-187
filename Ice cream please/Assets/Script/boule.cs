using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boule : MonoBehaviour
{
    public Glace glace;
    public string parfum;
    public List<GameObject> boules;
    public int x;

    // Start is called before the first frame update
    void Start()
    {
  
    }

    void OnMouseDown()
    {

        for(int i = 0; i< glace.parfums.Count; i++)
        {
            if (glace.position.y >= 5.9f)
            {
                glace.position.y = 4.5f;
            }
            if (glace.parfums[i] == "")
            {
                //Debug.Log(glace.position);
                glace.parfums[i] = parfum;
                Instantiate(boules[x], glace.position, Quaternion.identity);
                glace.position += new Vector3(0, 0.7f, 0);
                break;
            }
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
