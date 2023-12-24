using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ForCube : MonoBehaviour
{
    public int count;
    public Text x;
    public GameObject cam;
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward*speed*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if (count >= 0)
        {
            x.text = count.ToString();
        }
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("CEN");
        this.gameObject.GetComponent<Renderer>().material.color = Color.red;
        count++;
    }
    private void OnCollisionEx(Collision collision)
    {
        Debug.Log("CET");
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("CS");
        this.gameObject.GetComponent<Renderer>().material.color = Color.white;
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TE");
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("TS");
    }
    private void OnTriggerEx(Collider other)
    {
        Debug.Log("TX");
    }

}