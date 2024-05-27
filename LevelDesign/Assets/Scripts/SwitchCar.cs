using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;


public class SwitchCar : MonoBehaviour
{
    public CinemachineFreeLook playerCamera;
    public CinemachineFreeLook carCamera;

    public GameObject Player;
    public GameObject Car;
    public GameObject CarCollider;

    public Collider ColliderCar;

    public GameObject UICar;
    public GameObject UISpeed;
    public GameObject UILights;
    public GameObject UIGetOutCar;

    public Transform RespawnPoint;

    MovementCar MovementCar;

    public bool InCar;
    bool CanGetInTheCar = false;

    private void Start()
    {
        MovementCar = Car.GetComponent<MovementCar>();
        ColliderCar = CarCollider.GetComponent<BoxCollider>();
    }

    private void Update()
    {
        CanGetInCar();

        //if (InCar == true)
        //{
        //    CanGetOutCar();
        //    Debug.Log("ik kan uit de auto");
        //}
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Collider")
        {
            CanGetInTheCar = true;
            Debug.Log("CarReady");
            UICar.SetActive(true);

        }
    }

    private void OnTriggerExit()
    {
        UICar.SetActive(false);
        CanGetInTheCar = false;
    }

    void CanGetInCar()
    {
        if(CanGetInTheCar == true)
        {
            if(Input.GetKey(KeyCode.Q))
            {
                carCamera.Priority = 1;
                InCar = true;
                Player.SetActive(false);
                UICar.SetActive(false);
                UISpeed.SetActive(true);
                UILights.SetActive(true);
                UIGetOutCar.SetActive(true);
                MovementCar.enabled = true;
                Debug.Log("ik zit in de auto");
            }

        }

    }

    //void CanGetOutCar()
    //{

    //    if(Input.GetKey(KeyCode.A)) //&& MovementCar.speed <= 1f) 
    //    {
    //        playerCamera.Priority = 1;
    //        carCamera.Priority = 0;
    //        Player.SetActive(true);
    //        UICar.SetActive(false);
    //        //Player.transform.position = RespawnPoint.transform.position;
    //        Debug.Log("ik ga de auto uit");
    //    }

        

    //}
}
