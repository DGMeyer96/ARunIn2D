using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int Health = 6;
    public int Damage = 1;
    public int PowerModifier = 2;

    Vector3 PlayerLocation;

    List<bool> RedAbilities;
    List<bool> YellowAbilities;
    List<bool> BlueAbilities;

    void SaveGame()
    {

    }

    void LoadGame()
    {

    }
}
