using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridControl : MonoBehaviour
{
    public List<ItemIventario> _item = new List<ItemIventario>();
    public List<Image> _btItem;
    void Start()
    {
        
    }

    public void SetItemGrid(ItemIventario itemIventario) {
        _item.Add(itemIventario);
        for (int i = 0; i < _btItem.Count; i++)
        {
            if (_btItem[i].sprite == null)
            {
                _btItem[i].sprite = itemIventario._img;
                break;
            }
           
        }
    
    }

}
