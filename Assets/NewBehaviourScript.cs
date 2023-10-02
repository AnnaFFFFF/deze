using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public int a;
    public int b;
    public int c;
    public int d;

    public GameObject sphere;
    public GameObject cylinder;
    public GameObject cam;
    public Text x;

    void Start()
    {

    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space)) {
            a = Random.Range(0, 255);
            b = Random.Range(0, 255);
            c = Random.Range(0, 255);
            this.gameObject.GetComponent<Renderer>().material.color = new Color32 ((byte)a, (byte)b, (byte)c, 1);
        }

     
    }

   

    private void OnMouseDown()
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.cyan;
    }
    private void OnMouseUp()
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.white;
    }
    private void OnMouseEnter()
    {
        cylinder.gameObject.GetComponent<Renderer>().material.color = Color.red;
    }
    private void OnMouseExit()
    {
        cylinder.gameObject.GetComponent<Renderer>().material.color = Color.green;
    }
}


