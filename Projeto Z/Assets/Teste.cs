using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teste : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cubo;
    public GameObject inicio;
    public GameObject fim;
    void Start()
    {
        
    }

    // Update is called once per frame
     void OnTriggerEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("inicio"))
        {
            Debug.Log("ok");
            cubo.transform.Translate(new Vector3(0.08f, 0, 0));
        }
        if (collision.gameObject.CompareTag("fim"))
        {
            cubo.transform.Translate(new Vector3(-0.08f, 0, 0));
        }
    }
    void Update()
    {
        cubo.transform.Translate(new Vector3(-0.08f,0,0));
    }
}
