using UnityEngine;

public class Collectable : Collidable
{
    // Logic
    protected bool collected;

    protected override void OnCollide(Collider2D entity)
    {
        if (entity.name == "Player")  
            OnCollect();
    }

    protected virtual void OnCollect()
    {
        collected = true;
    }
}