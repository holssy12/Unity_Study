using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    public void ChangeSprite(GameObject changingObject, Sprite spr)
    {
        SpriteRenderer rend = changingObject.GetComponent<SpriteRenderer>();
        rend.sprite = spr;
    }

}
