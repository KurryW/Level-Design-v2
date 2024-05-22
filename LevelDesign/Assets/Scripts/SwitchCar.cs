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

    public Collider ColliderCar;

    public GameObject UICar;
    public GameObject UISpeed;

    public Transform RespawnPoint;

    MovementCar MovementCar;

    public bool InCar;
    bool CanGetInTheCar = false;

    private void Start()
    {
        MovementCar = Car.GetComponent<MovementCar>();
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

    private void OnTriggerEnter()
    {
        if (ColliderCar.gameObject.CompareTag("Car"))
        {
            CanGetInTheCar = true;
            Debug.Log("CarReady");
            UICar.SetActive(true);

        }
    }

    private void OnTriggerExit(Collider ColliderCar)
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
