using UnityEngine;

/// <summary>
/// Comportement des tirs
/// </summary>
public class ShotScript : MonoBehaviour
{
    // 1 - Designer variables

    /// <summary>
    /// Points de d�g�ts inflig�s
    /// </summary>
    public int damage = 1;

    /// <summary>
    /// Projectile ami ou ennemi ?
    /// </summary>
    public bool isEnemyShot = false;

    void Start()
    {
        // 2 - Destruction programm�e
        Destroy(gameObject, 2); // 20sec
    }
}
