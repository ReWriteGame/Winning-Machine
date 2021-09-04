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

    // создать класс дата контейнер который будет содеражать в себе префабы дл€ объекта 
    // обдумать его нужность + и -
    // дописать в нахвании SO
    // эта штука должна использоватьс€ дл€ первичной ини циилизации локальных массивов объектов ее не должны измен€ть 

    // возможно дописать заполн€емость на этапе компил€ции а не потом 
} 
