using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EventClick : MonoBehaviour
{
    private MaterialApplier materialApplier;

    private void Awake()
    {

        materialApplier = GetComponent<MaterialApplier>();
    }
    public void OnPointerDown(pointerEventData eventData)
    {
        materialApplier.ApplyOther();
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        materialApplier.ApplyOriginal();
    }
    public void OnPointerClick(pointerEventData eventData)
    {
        // Empty
    }
    public void OnPointerEnter(pointerEventData eventData)
    {
        // empty
    }
    public void OnPointerExit(pointerEventData eventData)
    {
        // empty
    }

    public class pointerEventData { }
}

internal class MaterialApplier
{
    internal void ApplyOriginal()
    {
        throw new NotImplementedException();
    }

    internal void ApplyOther()
    {
        throw new NotImplementedException();
    }
}