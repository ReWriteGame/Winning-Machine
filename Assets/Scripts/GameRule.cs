using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameRule : MonoBehaviour
{
    [SerializeField] private Cube enemy;
    [SerializeField] private Cube hero;
    [SerializeField] private Cube game;

    public UnityEvent heroWinEvent;
    public UnityEvent enemyWinEvent;
    public UnityEvent drawEvent;

    public void checkResult()
    {
        if (Mathf.Abs((int)game.CurrentEdge.GetComponent<Edge>().EdgeNum - (int)enemy.CurrentEdge.GetComponent<Edge>().EdgeNum) >
            Mathf.Abs((int)game.CurrentEdge.GetComponent<Edge>().EdgeNum - (int)hero.CurrentEdge.GetComponent<Edge>().EdgeNum))
            heroWinEvent?.Invoke();
        else if (Mathf.Abs((int)game.CurrentEdge.GetComponent<Edge>().EdgeNum - (int)enemy.CurrentEdge.GetComponent<Edge>().EdgeNum) ==
            Mathf.Abs((int)game.CurrentEdge.GetComponent<Edge>().EdgeNum - (int)hero.CurrentEdge.GetComponent<Edge>().EdgeNum))
            drawEvent?.Invoke();
        else enemyWinEvent?.Invoke();
    }

}
