using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager Manager;
    private void OnTriggerEnter()
    {
        Manager.CompleateLevel();
    }
}
