using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu (fileName = "Weapons")]
public class Weapons : ScriptableObject
{
    [Header("Основные данные")]
    public string Name;
    public string Description;
    public Sprite WeaponIcon;
    public bool MinRangeWeapon;
    public bool HighRangeWeapon;

    [Header("Характеристики для всего оружия")]
    public int Damage;
    public int Endurance;

    [Header("Характеристики для дальнего оружия")]
    public int Range;
    public int FireRate;
}
