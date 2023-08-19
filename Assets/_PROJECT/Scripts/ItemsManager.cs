using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemsManager : MonoBehaviour
{
    [SerializeField] private List<Items> _items;
    [SerializeField] private Transform _spawnPosition;
    [SerializeField] private TextMeshProUGUI _usesLeftText;

    private int selectedIndex; // Índice del item seleccionado
    private List<GameObject> instantiatedPrefabs = new List<GameObject>(); // Lista de prefabs instanciados

    #region public Methods
    public void InstantiatPrefab()
    {
        // Instanciar un nuevo prefab del item seleccionado
        if (selectedIndex != -1 && _items[selectedIndex].UsesLeft > 0)
        {
            Items selectedItems = _items[selectedIndex];
            GameObject prefab = selectedItems.Prefab;
            GameObject instantiatedPrefab = Instantiate(prefab, _spawnPosition.position, _spawnPosition.rotation);
            instantiatedPrefabs.Add(instantiatedPrefab);
            _items[selectedIndex].UsesLeft--;
        }
        else
        {
            StartCoroutine(WaitForDestroy());
        }
    }
    
    #endregion

    #region private Methods

    private void Start()
    {
        // Inicialización al inicio del juego
        selectedIndex = _items.FindIndex(item => item.isSelected);

        if (selectedIndex != -1)
        {
            // Instanciar el prefab del item seleccionado
            Items selectedItems = _items[selectedIndex];
            GameObject prefab = selectedItems.Prefab;
            GameObject instantiatedPrefab = Instantiate(prefab, _spawnPosition.position, _spawnPosition.rotation);
            instantiatedPrefabs.Add(instantiatedPrefab);
            _items[selectedIndex].UsesLeft = 2; // Reiniciamos las veces de instanciar para que sean 2
        }
    }

    private void Update()
    {
        // Actualizar la interfaz de usuario
        LoadUsesLeft();
    }
    
    private void DestroyPrefabs()
    {
        // Destruir los prefabs instanciados cuando se agoten los usos
        if (selectedIndex != -1 && _items[selectedIndex].UsesLeft == 0)
        {
            foreach (var prefab in instantiatedPrefabs)
            {
                Destroy(prefab);
            }
            instantiatedPrefabs.Clear();
        }
    }

    private void LoadUsesLeft()
    {
        // Cargar el número de usos restantes en la interfaz de usuario
        foreach (var item in _items)
        {
            if (item.isSelected)
            {
                _usesLeftText.text = item.UsesLeft.ToString();
                break; // Detener el bucle una vez que se encuentre el item seleccionado
            }
        }
    }

    #endregion

    #region private IEnumerator
    private IEnumerator WaitForDestroy()
    {
        // Esperar antes de destruir los prefabs
        yield return new WaitForSeconds(4f);
        DestroyPrefabs();
    }

    #endregion
    
}
