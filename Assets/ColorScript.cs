using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class ColorScript : MonoBehaviour
{
    private float red = 1.0f;

    private float green = 1.0f;

    private float blue = 1.0f;

    private int colornumber = 1;

    //private string path = "dot_mario4";

    // Start is called before the first frame update
    void Start()
    {
        //Texture2D texture = Resources.Load(path) as Texture2D;

        //image_component.sprite = Sprite.Create(texture,
        //                                       new Rect(0, 0, texture.width, texture.height),
        //                                       Vector2.zero);
    }

    // Update is called once per frame
    void Update()
    {
        // オブジェクトの取得
        GameObject image_object = GameObject.Find("Image");

        // コンポーネントの取得
        Image image_component = image_object.GetComponent<Image>();

        float alpha = 1.0f;

        Color color = new Color(red, green, blue, alpha);

        //// 色を変えてみる!
        image_component.color = color;

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            //path = "dot_mario2";
            colornumber = 1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            //path = "dot_mario3";
            colornumber = 2;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            //path = "dot_mario4";
            colornumber = 3;
        }

        if (colornumber == 1)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                if (red < 1.0f)
                {
                    red += 0.1f;
                }
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                if (red > 0.0f)
                {
                    red -= 0.1f;
                }
            }
        }

        if (colornumber == 2)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                if (green < 1.0f)
                {
                    green += 0.1f;
                }
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                if (green > 0.0f)
                {
                    green -= 0.1f;
                }
            }
        }

        if (colornumber == 3)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                if (blue < 1.0f)
                {
                    blue += 0.1f;
                }
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                if (blue > 0.0f)
                {
                    blue -= 0.1f;
                }
            }
        }
    }
}

