using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    #region private
    private Items selectedItems;
    

    #region SerializeField
    [Header("Stats")]
        [SerializeField] private TextMeshProUGUI _nameText;
        [SerializeField] private TextMeshProUGUI _idText;
        [SerializeField] private TextMeshProUGUI _healthText;
        [SerializeField] private TextMeshProUGUI _levelText;
        [SerializeField] private Image _characterImage;
    [Space(5)]
    [Header("More information")]
        [SerializeField] private Image _weakness;
        [SerializeField] private Image _strength;
        [SerializeField] private List<Items> _items;
    #endregion
    
    #endregion

    private static UIManager instance;

    /// <summary>
    /// Instancia única de UIManager.
    /// </summary>
    public static UIManager Instance
    {
        get
        {
            // Si no existe una instancia, buscarla en la escena y asignarla a "instance"
            if (instance == null)
            {
                instance = FindObjectOfType<UIManager>();
            }

            return instance;
        }
    }

    private void Start()
    {
        foreach (Items item in _items)
        {
            item.isSelected = false;
        }

    }

    public void UpdateUI(Items items)
    {
        // Desactivar la selección del objeto previamente seleccionado
        if (selectedItems != null)
        {
            selectedItems.isSelected = false;
        }

        // Actualizar la interfaz de usuario con el objeto seleccionado
        _nameText.text = items.Name;
        _levelText.text = items.Level.ToString();
        _healthText.text = items.Health.ToString();
        _idText.text = items.Id.ToString();
        _weakness.GetComponent<Image>().sprite = items.weaknessImage;
        _strength.GetComponent<Image>().sprite = items.strengthImage;
        _characterImage.GetComponent<Image>().sprite = items.currentSprite;

        // Establecer el objeto seleccionado y marcarlo como seleccionado
        selectedItems = items;
        selectedItems.isSelected = true;
    }
    
 

}
