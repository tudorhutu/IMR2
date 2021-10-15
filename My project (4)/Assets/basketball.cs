using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basketball : MonoBehaviour
{
    public GameObject gameObject;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {
        gameObject.SetActive(false);
    }
}
