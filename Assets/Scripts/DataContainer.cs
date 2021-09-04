using UnityEngine;


public interface ICloneable
{
    object Clone();
}
[CreateAssetMenu(menuName = "ScriptableObject/DataContainer")]
public class DataContainer : ScriptableObject
{
    [SerializeField] private GameObject[] objects;

    public GameObject[] Objects { get => objects; private set => objects = value; }
   /* public object Clone()
    { 
        return new GameObject[] {};
    }*/

    // ������� ����� ���� ��������� ������� ����� ���������� � ���� ������� ��� ������� 
    // �������� ��� �������� + � -
    // �������� � �������� SO
    // ��� ����� ������ �������������� ��� ��������� ��� ���������� ��������� �������� �������� �� �� ������ �������� 

    // �������� �������� ������������� �� ����� ���������� � �� ����� 
} 
