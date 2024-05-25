using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheelchange : MonoBehaviour
{

    public GameObject wheelNew;
    public GameObject wheelOld;

    public GameObject UINewWheel;
    public GameObject UIWheelOld;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextWheel()
    {
        wheelNew.SetActive(true);
        wheelOld.SetActive(false);
        UINewWheel.SetActive(true);
        UIWheelOld.SetActive(false);
    }

    public void PrevWheel()
    {
        wheelNew.SetActive(false);
        wheelOld.SetActive(true);
        UINewWheel.SetActive(false);
        UIWheelOld.SetActive(true);
    }
}
