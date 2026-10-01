using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Aide de https://stackoverflow.com/questions/39854745/how-to-hide-a-image-on-app-start-in-unity
/// </summary>
public class Indicateurs : MonoBehaviour
{

    [SerializeField, Tooltip("Permière image acéérateur")]
    private Image boost1;
    [SerializeField, Tooltip("Deuxième image acéérateur")]
    private Image boost2;
    [SerializeField, Tooltip("Troisième image acéérateur")]
    private Image boost3;


    // Update is called once per frame
    void Update()
    {
        if ()
        {
            //aucun boos
            boost1.enabled = false;
            boost2.enabled = false;
            boost3.enabled = false;
        }
        else if () {
            // un boost
            boost1.enabled = true;
            boost2.enabled = false;
            boost3.enabled = false;
        }
        else if () {
            // deux boost
            boost1.enabled = true;
            boost2.enabled = true;
            boost3.enabled = false;
        }
        else
        {
            // trois boost
            boost1.enabled = true;
            boost2.enabled = true;
            boost3.enabled = true;

        }
    }
}
