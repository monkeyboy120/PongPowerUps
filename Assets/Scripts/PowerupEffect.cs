using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupEffect : MonoBehaviour
{
    public enum PowerupType
    {
        Big,
        Small,
        Fast
    }

    public PowerupType powerupType;
    public float sizeMultiplier;
    public float speedMultiplier;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Hit");
        if (other.CompareTag("Player1") || other.CompareTag("Player2"))
        {
            PaddleScript paddleScript = other.GetComponent<PaddleScript>();

            if (paddleScript != null)
            {
                ApplyPowerupEffect(paddleScript);
            }
            Destroy(gameObject);
        }
    }

    private void ApplyPowerupEffect(PaddleScript paddleScript)
    {
        switch (powerupType)
        {
            case PowerupType.Big:
                paddleScript.ChangeSize(sizeMultiplier);
                break;
            case PowerupType.Small:
                paddleScript.ChangeSize(sizeMultiplier);
                break;
            case PowerupType.Fast:
                paddleScript.ChangeSpeed(speedMultiplier);
                break;
        }
    }
}