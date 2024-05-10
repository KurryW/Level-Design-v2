using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emission : MonoBehaviour
{
    [SerializeField] Material mat;
    Color colorW;
    Color colorB;

    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<Renderer>().material;

    }

    // Update is called once per frame
    void Update()
    {
        colorW = Color.white;
        colorB = Color.black;
    }

    private void OnTriggerEnter(Collider other)
    {
        mat.SetColor("_EmissionColor", colorW);

    }

    private void OnTriggerExit(Collider other)
    {
        mat.SetColor("_EmissionColor", colorB);
    }
}
