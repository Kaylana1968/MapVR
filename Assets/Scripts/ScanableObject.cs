using System;
using UnityEngine;

[Serializable]
public class Item
{
    public string Name;
    public float Price;
}

public class ScanableObject : MonoBehaviour
{
    [SerializeField]
    Item item;

    public void OnInteract()
    {
        CartManager.Instance.ToggleItem(item);
    }
}
