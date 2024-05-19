using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcceptMission : MonoBehaviour
{
    public GameObject Marker;
    public GameObject MissionUI;

    public void MissionAccepted()
    {
        MissionUI.SetActive(false);
        Marker.SetActive(true);
    }
}
