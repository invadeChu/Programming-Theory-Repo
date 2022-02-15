using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Camera gameCamera;
    public GameObject boxObject;
    public string playerName;
    public bool nameIsSet;

    private GameObject titleScreen;
    private GameObject descriptionText;
    private bool startSpawn;
    private float xBoundary = 12.0f;
    private float yBoundary = 8.0f;

    public void Start()
    {
        titleScreen = GameObject.Find("Title Screen");
        descriptionText = GameObject.Find("Description Text");
        titleScreen.SetActive(true);
        descriptionText.SetActive(false);
    }

    public void Update()
    {
        if (nameIsSet)
        {
            if (!startSpawn)
            {
                titleScreen.SetActive(false);
                descriptionText.SetActive(true);
                InvokeRepeating("SpawnBox", 0, 2);
                startSpawn = true;
            }
            if (Input.GetMouseButtonDown(0))
            {
                var ray = gameCamera.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    //hit.collider.gameObject.SetActive(false);
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }

    private void SpawnBox()
    {
        Vector3 position = new Vector3(Random.Range(-xBoundary, xBoundary), Random.Range(1.5f, yBoundary));
        //Instantiate(boxObject, position, boxObject.transform.rotation);
        Instantiate(boxObject, position, Random.rotation);
    }
}
