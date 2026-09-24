using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CartManager : MonoBehaviour
{
    static public CartManager Instance;

    private TMP_Text _textField;
    private List<Item> items;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        items = new List<Item>();
        _textField = GetComponent<TMP_Text>();
        _textField.text = "Total : 0";
    }

    private void WriteReceipt()
    {
        string text = "";
        float totalPrice = 0;

        foreach (Item i in items)
        {
            text += i.Name + " : " + i.Price + "\n";
            totalPrice += i.Price;
        }

        text += "\nTotal : " + Mathf.Round(totalPrice).ToString();

        _textField.text = text;
    }

    public void ToggleItem(Item item)
    {
        if (items.Contains(item))
        {
            items.Remove(item);
        }
        else
        {
            items.Add(item);
        }
        WriteReceipt();
    }

    public void EmptyCart()
    {
        items.Clear();
        WriteReceipt();
    }
}
