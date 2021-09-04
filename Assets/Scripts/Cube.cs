using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Cube : MonoBehaviour
{
    [SerializeField] private List<GameObject> edges;
    [SerializeField] private GameObject currentEdge;

    public GameObject CurrentEdge { get => currentEdge; set => currentEdge = value; }

    private void Start()
    {
        setRandomEdge();
    }
    public void setRandomEdge()
    {
        turnOffAll();

        currentEdge = edges[Random.Range(0, edges.Capacity)];
            currentEdge.gameObject.SetActive(true);  
    }

    public void setEdge(int index)
    {
        turnOffAll();
        currentEdge = edges[(int)index];
        currentEdge.gameObject.SetActive(true);

    }

    public void turnOffAll()
    {
        foreach (GameObject obj in edges)
            obj.gameObject.SetActive(false);
    }


}
