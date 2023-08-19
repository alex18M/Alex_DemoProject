using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Character", menuName = "Character Data")]
public class Items : ScriptableObject
{
    #region SerializedField
        [Header("Principal Data")]
        [SerializeField] private string _name;
        [SerializeField] private int _id;
        [SerializeField] private int _health;
        [SerializeField] private int _level;
        [Space(5)]
        [Header("Extra data")]
        [SerializeField] private int _usesLeft;
        [SerializeField] private GameObject _prefab;
        
    #endregion

    #region Enums
        public enum WeaknessType
            {
                None,
                Earth,
                Water,
                Fire,
                Air
            }

        public enum StrengthType
            {
                None,
                Earth,
                Water,
                Fire,
                Air
            }

    #endregion
    
    #region Public Variables
    [Space(3)]
    [Header("Sprite Elements of Characters")]
        public WeaknessType weakness;
        public Sprite weaknessImage;

        public StrengthType strength;
        public Sprite strengthImage;
        public bool isSelected;
        public Sprite currentSprite;

    #endregion

    #region Getters

    public int Level { get { return _level; } }

    public int UsesLeft { get { return _usesLeft; } set { _usesLeft = value; } }

    public int Health { get { return _health; } }
    public string Name { get { return _name; } }
    public int Id { get { return _id; } }
    public GameObject Prefab => _prefab;
    // public bool IsSelected { get; set; }

    #endregion

}
