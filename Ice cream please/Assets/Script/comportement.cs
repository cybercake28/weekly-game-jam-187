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
        nbboules = Random.Range(1, 4);
        setParfums();
        if(Random.Range(0, 2) == 1)
        {
            sexeinfos = !sexe;
        }
        setDate();

        infosCharact.parfums = "Number of scoops of ice cream asked : " + nbboules + " Flavors : " + parfums[0] + " " + parfums[1] + " " + parfums[2];
        infosCharact.id = "" + Random.Range(10000000, 99999999);
        if (sexe == true)
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
    }


    private void setDate()
    {
        dateNaissanceinfos = Random.Range(1850, 1970);

        if(dateNaissanceinfos < 1880 || dateNaissanceinfos > 1932)
        {
            isbirthright = false;
            return;
        }
        isbirthright = true;
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
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
