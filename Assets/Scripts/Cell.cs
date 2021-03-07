using UnityEngine;

public class Cell : MonoBehaviour
{
    public GameObject cellPrefab;
    public (int x, int y) coords; // are indices enough to remove this member?
    public MultiplierCard multiplier;
    public Bomb bomb;
    public bool isFlipped;

    public void Init((int x, int y) coords)
    {
        this.coords = coords;
        isFlipped = false;
    }

    public void Populate(MultiplierCard multiplier, Bomb bomb)
    {
        this.multiplier = multiplier;
        this.bomb = bomb;
    }
}
