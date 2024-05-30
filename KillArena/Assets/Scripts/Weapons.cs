using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu (fileName = "Weapons")]
public class Weapons : ScriptableObject
{
    [Header("�������� ������")]
    public string Name;
    public string Description;
    public Sprite WeaponIcon;
    public bool MinRangeWeapon;
    public bool HighRangeWeapon;

    [Header("�������������� ��� ����� ������")]
    public int Damage;
    public int Endurance;

    [Header("�������������� ��� �������� ������")]
    public int Range;
    public int FireRate;
}
