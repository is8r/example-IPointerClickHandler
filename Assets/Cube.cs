using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Cube : MonoBehaviour, IPointerClickHandler
{
    private void Update()
    {
        transform.Rotate(Vector3.right * 10f + Vector3.up * 10f);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        print(eventData);
    }
}

