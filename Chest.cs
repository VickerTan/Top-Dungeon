using UnityEngine;

public class Chest : Collectable
{
    public Sprite emptyChest;
    public int coinsAmount = 10;

    protected override void OnCollect()
    {
        if (!collected)
        {
            collected = true;
            GetComponent<SpriteRenderer>().sprite = emptyChest;
            Debug.Log("Grant " + coinsAmount + " coins.");
        }
    }
}