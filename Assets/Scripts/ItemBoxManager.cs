using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public enum ITEM
{
    NONE,
    ROOM_KEY
} 

public class ItemBoxManager : MonoBehaviour
{
    [SerializeField] Sprite roomKeySprite; //鍵の画像
    [SerializeField] Image[] itemBoxImages;

    ITEM[] itemList = new ITEM[4]; //取得したアイテムの配列

    // アイテムを取得
    public void SetItem(ITEM item)
    {
    }
    {
    }
}
