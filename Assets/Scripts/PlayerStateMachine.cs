
using UnityEngine;
public enum PlayerState
{
    Running,
    Jumping,
    Sliding
}
public class PlayerStateMachine : MonoBehaviour
{
    public PlayerState currentState;

    private void Update()
    {

        switch (currentState)
        {
            case PlayerState.Running:

                break;
            case PlayerState.Jumping:

                break;
            case PlayerState.Sliding:

                break;
            default:
                break;
        }
    }
}
