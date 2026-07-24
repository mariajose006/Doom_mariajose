using UnityEngine;
using UnityEngine.Events;

public class LevelManager : MonoBehaviour
{
   [SerializeField]
   private UnityEvent onLevelStart;
   [SerializeField]
   private UnityEvent onLevelLose;
   [SerializeField]
   private UnityEvent onLevelCompleted;
   private void Start()
    {
        onLevelStart?.Invoke();
    }
    public void LoseLevel()
    {
        onLevelLose?.Invoke();
    }
    public void CompleteLevel()
    {
        onLevelCompleted?.Invoke();
    }
}
