
using UnityEngine;
using System;
public class Subject : MonoBehaviour
{
    public event Action OnPlayerDeath;

    public void PlayerDeath()
    {
        if (OnPlayerDeath != null)
        {
            OnPlayerDeath();
        }
    }
}
