using UnityEngine;

[CreateAssetMenu (fileName = "Weapons")]
public class Weapons : ScriptableObject
{
    [Header("������")]
    public string Name;
    public string Description;
    public Sprite WeaponIcon;

    [Header("��������������")]
    public int Damage;
    public int Endurance;
}
