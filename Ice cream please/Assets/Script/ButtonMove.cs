using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMove : MonoBehaviour
{
    public InfosCharact infoCharact;
    public Glace glace;
    private bool isCorrect = true;
    public Score score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Give()
    {
        if (!infoCharact.leave)
        {
            if (!verif())
            {
                isCorrect = false;
            }
            for (int i = 0; i < 3; i++)
            {
                if (glace.parfums[i] != infoCharact.liste[i])
                {
                    isCorrect = false;
                }
            }

            if (!isCorrect)
            {
                score.life -= 1;
                Debug.Log("NotCorrect");
            }
            else
            {
                score.score += 1;
                Debug.Log("IsCorrect");
            }
            infoCharact.leave = true;
            isCorrect = true;
        }
    }

    public bool verif()
    {
        if ((infoCharact.sexeinfos == true && infoCharact.sexe == "Male") || (infoCharact.sexeinfos == false && infoCharact.sexe == "Female"))
        {
            return false;
        }
        if (!infoCharact.isbirthright) 
        {
            return false;
        }
        return true;
    }

    public void Reject()
    {
        if (!infoCharact.leave)
        {
            if (verif())
            {
                score.life -= 1;
                Debug.Log("NotCorrect");
            }
            else
            {
                score.score += 1;
                Debug.Log("IsCorrect");
            }
            infoCharact.leave = true;
        }
    }
}
