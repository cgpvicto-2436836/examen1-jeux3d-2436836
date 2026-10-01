using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// Contrôleur de jeu qui gère l'état global du jeu et fournit un accès centralisé aux contrôles et aux autres systèmes.
/// </summary>
public class ControleurJeu : MonoBehaviour
{
    /// <summary>
    /// Instance singleton du contrôleur de jeu.
    /// </summary>
    public static ControleurJeu Instance { get; private set; }

    [field:SerializeField, Tooltip("Référence aux contrôles du joueur.")]
    public PlayerInput Controles { get; private set; }

   

 [field: SerializeField, Tooltip("Boost Maximum")]

    private float boostMax = 3;
    [field: SerializeField, Tooltip("Boost Actuellement")]

    private float boostActuelle = 0;
    //Faudrait que Je mettre les boost ici pour lier avec l'objet de acelerateur *
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }  
}
