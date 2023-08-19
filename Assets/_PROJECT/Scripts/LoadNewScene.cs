using System;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewScene : MonoBehaviour
{
    
    [SerializeField] private string _nameScene;
    [SerializeField] private List<Items> _items;

    public void ChangeScene()
    {
        // Cambiar a la escena especificada si se ha seleccionado algún item
        if (_items.Any(item => item.isSelected))
        {
            SceneManager.LoadScene(_nameScene);
        }
        else
        {
            Debug.Log("No has seleccionado un Item");
        }
    }

}