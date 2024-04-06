
using UnityEngine;

public class Observer : MonoBehaviour
{
    private void OnEnable()
    {
        FindObjectOfType<Subject>().OnPlayerDeath += HandlePlayerDeath;
    }

    private void OnDisable()
    {
        FindObjectOfType<Subject>().OnPlayerDeath -= HandlePlayerDeath;
    }

    private void HandlePlayerDeath()
    {
        Debug.Log("Player has died!");
    }
}
