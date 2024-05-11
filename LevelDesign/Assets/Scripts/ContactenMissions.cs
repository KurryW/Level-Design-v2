using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContactenMissions : MonoBehaviour
{
    public GameObject Missions;
    public GameObject Notification;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void ClickOnContacten()
    {
        Missions.SetActive(true);
        Notification.SetActive(false);

    }

    public void SetOff()
    {
        Missions.SetActive(false);
    }
}
