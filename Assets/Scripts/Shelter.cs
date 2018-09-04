using UnityEngine;

public class Shelter : MonoBehaviour
{
    [SerializeField]
    private int maxResistance = 5;
    private int damage = -1;
    public int MaxResistance
    {
        get
        {
            return maxResistance;
        }
        protected set
        {
            maxResistance = value;
        }
    }

    public void Damage(int damage)
    {
        maxResistance += damage;
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Enemy")
        {
            maxResistance += damage;
        }

        }
    private void Update()
    {
        if(maxResistance == 0)
        {
            Destroy(this);
        }
    }
}