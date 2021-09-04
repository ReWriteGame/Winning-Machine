using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Edge : MonoBehaviour
{
    [SerializeField] private uint edgeNum;
    private SpriteRenderer spriteRenderer;

    public SpriteRenderer SpriteRenderer { get => spriteRenderer; private set => spriteRenderer = value; }
    public uint EdgeNum { get => edgeNum; set => edgeNum = value; }

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();     
    }
}
