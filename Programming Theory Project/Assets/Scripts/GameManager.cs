using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour
{
    public Camera gameCamera;
    public GameObject[] boxObject;
    public string playerName { get; private set; } // Encapsulation
    public bool nameIsSet { get; private set; } // Encapsulation

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

        GameObject playerNameText = GameObject.Find("Input Field");
        EventSystem.current.SetSelectedGameObject(playerNameText, null);
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
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }
    public void SetPlayerName(string newPlayerName)
    {
        playerName = newPlayerName;
        nameIsSet = true;
    }
    private void SpawnBox()
    {
        Vector3 position = new Vector3(Random.Range(-xBoundary, xBoundary), Random.Range(1.5f, yBoundary));
        Instantiate(boxObject[Random.Range(0, boxObject.Length)], position, Random.rotation);

        // put text where box was instantiated
        Vector2 textPos = position;
        Vector2 viewportPos = Camera.main.WorldToViewportPoint(textPos);
        descriptionText.GetComponent<RectTransform>().anchorMin = viewportPos;
        descriptionText.GetComponent<RectTransform>().anchorMax = viewportPos;
    }
}
