using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body : MonoBehaviour
{
    public GameObject head;
    public GameObject body;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "manzana" || head != body)
        {
            Instantiate(body);
           //transform.position = Vector3.MoveTowards(transform.position);
        }
    }
}