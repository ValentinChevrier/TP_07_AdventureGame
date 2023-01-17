using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DOORS_Play_LONG : MonoBehaviour
{
    public AK.Wwise.Event MyEvent;
    public GameObject otherGameObject;
    public void OnTriggerEnter(Collider Player)
    {
        MyEvent.Post(otherGameObject);
    }
}