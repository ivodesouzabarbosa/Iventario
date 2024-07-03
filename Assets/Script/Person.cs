using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
    public IventarioController _iventarioController;
    // Start is called before the first frame update
    void Start()
    {
        _iventarioController = Camera.main.GetComponent<IventarioController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
      
        if (collision.gameObject.CompareTag("itemTag")) {
     
            ItemControl _itemObj = collision.GetComponent<ItemControl>();
            if (_itemObj._tipo == 0)
            {            
                _iventarioController._gridControl[0].SetItemGrid(_itemObj._itemIventario);

            }

        }
    }

}
