using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Stoplicht : MonoBehaviour
{
    public GameObject stoplicht;
    public GameObject Groenlicht;
    public GameObject Oranjelicht;
    public GameObject Roodlicht;

    public GameObject Car;
    public GameObject CarOpponent;

    public GameObject TryAgain;
    public GameObject Ready;
    public GameObject Race;

    public Camera CameraCounter;
    public Camera CameraCar;

    public float minSpeed;
    public float maxSpeed;

    public bool Win;
    private bool Space = false;

    Animator animator;
    Animator animator2;
    Animator animator3;

    float timer;

    // Start is called before the first frame update
    void Start()
    {
        stoplicht.GetComponent<Animator>().speed = Random.Range(minSpeed, maxSpeed);
        animator = GetComponent<Animator>();
        animator2 = Car.GetComponent<Animator>();
        animator3 = CarOpponent.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Return))
        {
            animator.SetBool("Ready", true);
            Ready.SetActive(false);

        }

        if(Groenlicht.activeSelf == true)
        {
            timer += Time.deltaTime;
            Debug.Log(timer);
        }

        if(Space == true)
        {
            if (Input.GetKeyDown(KeyCode.Space) && timer <= 1f)
            {
                Win = true;
                CameraCar.depth = 1;
                CameraCounter.depth = 0;

                animator2.SetBool("Win", true);

                StartCoroutine(WaitToFinish());
            }

            else if (Input.GetKeyDown(KeyCode.Space) && timer > 1f)
            {
                TryAgain.SetActive(true);
                Race.SetActive(false);
            }

        }
    }

    public void EndAnimation()
    {
        Race.SetActive(true);
        
        animator3.SetBool("Drive", true);

        Space = true;
        
    }

    IEnumerator WaitToFinish()
    {
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene("Map-1");
    }
        
    
}
