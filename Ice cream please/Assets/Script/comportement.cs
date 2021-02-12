using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class comportement : MonoBehaviour
{
    public int nbboules;
    public List<string> parfums;
    public bool sexe;
    public bool sexeinfos;
    public int dateNaissanceinfos;
    public bool isbirthright;
    public InfosCharact infosCharact;
    public GameObject bonnet;

    // Start is called before the first frame update
    void Start()
    {
        infosCharact.leave = false;
        nbboules = Random.Range(1, 4);
        setParfums();

        if(Random.Range(0, 10) == 1)
        {
            sexeinfos = !sexe;
        }
        else
        {
            sexeinfos = sexe;
        }

        setDate();
        infosCharact.sexeinfos = sexeinfos;
        infosCharact.liste = parfums;
        infosCharact.parfums = "Number of scoops of ice cream asked : " + nbboules + " Flavors : " + parfums[0] + " " + parfums[1] + " " + parfums[2];
        infosCharact.id = "" + Random.Range(10000000, 99999999);
        
        if (sexeinfos == true)
        {
            infosCharact.sexe = "Female";
        }
        else
        {
            infosCharact.sexe = "Male";
        }
        
        infosCharact.date = "" + Random.Range(1, 32) + "/" + Random.Range(1, 13) +"/"+ dateNaissanceinfos;
        
        if (Random.Range(0, 3) == 1)
        {
            bonnet.SetActive(true);
        }
        else
        {
            bonnet.SetActive(false);
        }
    }


    private void setDate()
    {
        dateNaissanceinfos = Random.Range(1850, 1970);

        if (dateNaissanceinfos < 1877 || dateNaissanceinfos > 1935)
        {
            isbirthright = false;

        }
        else
        {
            isbirthright = true;
        }
        infosCharact.isbirthright = isbirthright;
    }

    private void setParfums() 
    {
        for (int i = 0; i < nbboules; i++)
        {
            int a = Random.Range(1, 5);
            if (a == 1)
            {
                parfums[i] = "Chocolate";
            }
            else if (a == 2)
            {
                parfums[i] = "Vanilla";
            }
            else if (a == 3)
            {
                parfums[i] = "Strawberry";
            }
            else
            {
                parfums[i] = "Communist";
            }
        }

        for(int j = 1; j < 3; j++)
        {
            if(parfums[j] == null)
            {
                parfums[j] = "";
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
