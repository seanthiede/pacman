using UnityEngine;

public class Pellet : MonoBehaviour
{
    public int points = 10;

    // protected so we can override func in Subclass
    // virtual so we can call base.Eat() in Subclass -> override func
    protected virtual void Eat()
    {
        FindAnyObjectByType<GameManager>().PelletEaten(this);
    }

    private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.layer == LayerMask.NameToLayer("Pacman"))
            {
                Eat();
        }
    }
}
