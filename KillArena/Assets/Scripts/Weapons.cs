using UnityEngine;

[CreateAssetMenu (fileName = "Weapons")]
public class Weapons : ScriptableObject
{
    [Header("Данные")]
    public string Name;
    public string Description;
    public Sprite WeaponIcon;

    [Header("Характеристики")]
    public int Damage;
    public int Endurance;
}
