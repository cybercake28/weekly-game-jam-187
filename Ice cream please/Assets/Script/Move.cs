using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    public Vector3 vector;
    public InfosCharact infoscharact;
    public GameObject Client;
    public GameObject Client2;
    public GameObject Client3;

    // Start is called before the first frame update
    void Start()
    {
          
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x >= -2.05)
        {
            rb.MovePosition(transform.position + vector * moveSpeed * Time.deltaTime);
        }
        if (infoscharact.leave == true)
        {
            rb.MovePosition(transform.position + vector * moveSpeed * Time.deltaTime);

            if(this.transform.position.x <= -14.5)
            {
                NewClient();
                Destroy(this.gameObject);
            }
        }
    }

    private void NewClient()
    {
        int a = Random.Range(1, 4);
        if(a == 1)
            Instantiate(Client, new Vector3(15, -1, 0), Quaternion.identity);
        else if(a == 2)
            Instantiate(Client2, new Vector3(15, -1, 0), Quaternion.identity);
        else if(a == 3)
            Instantiate(Client3, new Vector3(15, -1, 0), Quaternion.identity);

    }
}
