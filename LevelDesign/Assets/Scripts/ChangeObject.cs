using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeObject : MonoBehaviour
{
    public Camera CameraPart;
    public CinemachineFreeLook playerCamera;

    public GameObject UIChangePart;
    public GameObject UIChangeDone;
    public GameObject UIGetInCar;
    public GameObject UIInfo;

    //public Collider ColliderWheel;

    public GameObject Player;

    Movement Movement;
    //SwitchCar SwitchCar;

    // Start is called before the first frame update
    void Start()
    {
        Movement = Player.GetComponent<Movement>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Player.activeInHierarchy == false)
        {
            UIChangePart.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Change Wheel");
        UIChangePart.SetActive(true);

    }

    private void OnTriggerExit(Collider other)
    {
        UIChangePart.SetActive(false);
       
    }

    public void TaskOnClick()
    {
        UIChangePart.SetActive(false);
        CameraPart.depth = 1;
        playerCamera.Priority = 0;
        Movement.enabled = false;
        UIGetInCar.SetActive(false);
        UIInfo.SetActive(true);
        UIChangeDone.SetActive(true);
    }

    public void TaskDone()
    {
        CameraPart.depth = -1;
        playerCamera.Priority = 1;
        Movement.enabled = true;
        UIInfo.SetActive(false);
        UIChangeDone.SetActive(false); 
    }
}
