using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Camera gameCamera;
    public GameObject boxObject;
    public TextMeshProUGUI descriptionText;

    private float xBoundary = 12.0f;
    private float yBoundary = 8.0f;

    public void Start()
    {
        InvokeRepeating("SpawnBox", 0, 2);
    }

    public void Update()
    {
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

    private void SpawnBox()
    {
        Vector3 position = new Vector3(Random.Range(-xBoundary, xBoundary), Random.Range(1.5f, yBoundary));
        //Instantiate(boxObject, position, boxObject.transform.rotation);
        Instantiate(boxObject, position, Random.rotation);
    }
}
