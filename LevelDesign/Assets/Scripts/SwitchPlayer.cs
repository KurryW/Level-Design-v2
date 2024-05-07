using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;


public class SwitchPlayer : MonoBehaviour
{
    public CinemachineFreeLook playerCamera;
    public CinemachineFreeLook carCamera;

    public GameObject Player;
    public GameObject Car;

    //public Collider ColliderCar;

    public GameObject UICar;

    public Transform RespawnPoint;

    MovementCar MovementCar;
    //SwitchCar SwitchCar;

    public bool InCar;

    private void Start()
    {
        MovementCar = GetComponent<MovementCar>();
    }

    private void Update()
    {

        if(MovementCar.enabled == true)
        {
            CanGetOutCar();
            Debug.Log("ik kan uit de auto");
        }
    }

    void CanGetOutCar()
    {

        if(Input.GetKey(KeyCode.E)) //&& MovementCar.speed <= 1f) 
        {
            playerCamera.Priority = 1;
            carCamera.Priority = 0;
            Player.SetActive(true);
            UICar.SetActive(false);
            Player.transform.position = RespawnPoint.transform.position;
            MovementCar.enabled = false;
            Debug.Log("ik ga de auto uit");
        }

        

    }
}
