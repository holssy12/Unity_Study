using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameObject[] myObjectArr;

    [SerializeField]
    Sprite[] spriteArr;

    [SerializeField]
    GameObject spriteChangerObject;
    SpriteChanger spriteChanger;

    [SerializeField]
    GameObject textObject;
    Text myText;

    // Start is called before the first frame update
    void Start()
    {
        spriteChanger = spriteChangerObject.GetComponent<SpriteChanger>();

        myText = textObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        // GetKeyDown : 누르고 딱 한 번만 발동.
        if (Input.GetKeyDown(KeyCode.W))
        {
            spriteChanger.ChangeSprite(myObjectArr[0], spriteArr[0]);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            spriteChanger.ChangeSprite(myObjectArr[1], spriteArr[1]);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            spriteChanger.ChangeSprite(myObjectArr[2], spriteArr[2]);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            spriteChanger.ChangeSprite(myObjectArr[3], spriteArr[3]);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            myText.text = "반갑습니다";
            myText.fontSize = 150;
            myText.fontStyle = FontStyle.Italic;
        }
    }
}
