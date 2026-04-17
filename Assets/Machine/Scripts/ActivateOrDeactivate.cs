using UnityEngine;

public class ActivateOrDeactivate : MonoBehaviour
{
    [SerializeField] GameObject[] gameObjectsToActivate;
    [SerializeField] GameObject[] gameObjectsToDeactivate;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        foreach (var currentGameObject in gameObjectsToActivate) currentGameObject.SetActive(true);

        foreach (var currentGameObject in gameObjectsToDeactivate) currentGameObject.SetActive(false);
    }
}
