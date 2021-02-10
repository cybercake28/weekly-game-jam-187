using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ishere : MonoBehaviour
{
    public Glace glace;

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
   public void Update()
    {
        for(int i = 0; i < glace.parfums.Count; i++)
        {
            if (glace.parfums[i] != "")
            {
                return;
            }
        }
        Destroy(this.gameObject);
    }
}
