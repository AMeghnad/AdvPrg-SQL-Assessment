using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    #region Variables
    public string[] itemList;
    public bool loaded;
    private Vector2 scr;
    public List<Item> item;
    public Dictionary<int, Weapon> weapons = new Dictionary<int, Weapon>();
    public Dictionary<int, Clue> clues = new Dictionary<int, Clue>();

    #endregion
    // Use this for initialization
    void Start()
    {
        StartCoroutine(LoadItemData());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator LoadItemData()
    {
        WWW itemDataURL = new WWW("localhost/loginsystem/Inventory.php");
        yield return itemDataURL;
        string textDataString = itemDataURL.text;
        string[] items = textDataString.Split('#');
        itemList = new string[items.Length - 1];
        for (int i = 0; i < items.Length - 1; i++)
        {
            itemList[i] = items[i];
        }
        SetItems();
    }
    void SetItems()
    {
        for (int i = 0; i < itemList.Length; i++)
        {
            string[] current = itemList[i].Split('|');
            Weapon weapon = new Weapon(int.Parse(current[0]), current[1], int.Parse(current[2]), current[3], int.Parse(current[4]), float.Parse(current[5]), current[6], current[7]);
            Clue clue = new Clue(int.Parse(current[0]), current[1], current[8], current[6], current[7]);
        }
    }
}
