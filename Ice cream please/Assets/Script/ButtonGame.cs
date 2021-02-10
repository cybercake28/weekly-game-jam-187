using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonGame : MonoBehaviour
{
    public Glace glace;

    public void DeleteButton()
    { 
        for (int i = 0; i < glace.parfums.Count; i++)
        {
            glace.parfums[i] = "";
        }
    }
}
