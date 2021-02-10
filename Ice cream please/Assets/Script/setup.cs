using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setup : MonoBehaviour
{
    public Glace glace;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i< glace.parfums.Count; i++)
        {
            glace.parfums[i] = "";
        }
        glace.position = new Vector3(-8.5f, 4.5f, 0f);
    }


}
