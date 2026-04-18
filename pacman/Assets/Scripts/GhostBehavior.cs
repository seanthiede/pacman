using UnityEngine;

[RequireComponent(typeof(Ghost))]

public abstract class GhostBehavior : MonoBehaviour
{
    public Ghost ghost { get; private set; }
    public float duration;

    private void Awake()
    {
        this.ghost = GetComponent<Ghost>();
        this.enabled = false;
    }

    public void Enable()
    {
        Enable(this.duration);

        // for example if we eat power pellet before effect of previous one is over, we want to reset the timer and start it again
        CancelInvoke();
        Invoke(nameof(Disable), this.duration);
    }

    public virtual void Enable(float duration)
    {
        this.enabled = true;
    }

    public virtual void Disable()
    {
        this.enabled = false;

        CancelInvoke();
    }
}
