using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSelection : MonoBehaviour
{
    [SerializeField] private Items _items;

    #region private Methods
    
    private void Update()
    {
        // Actualizar la interfaz de usuario con el item seleccionado
        UIManager.Instance.UpdateUI(_items);

        // Actualizar el estado de selección del item
        UpdateSelectedStatus();
    }

    private void UpdateSelectedStatus()
    {
        // Actualizar el estado de selección del item para permitir solo seleccionar uno
        if (_items != null)
        {
            _items.isSelected = false;
        }
    }
    #endregion

}