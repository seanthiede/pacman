using UnityEngine;

[RequireComponent(typeof(Ghost))]

public class GhostBehavior : MonoBehaviour
{
    public Ghost ghost { get; private set; }

    private void Awake()
    {
        this.ghost = GetComponent<Ghost>();
        this.enabled = false;
    }

    public void Enable()
    {
        
    }

    public void Enable(float duration)
    {
        
    }

    public void Disable()
    {
        
    }
}
