using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject inventoryChilds;

    // Buttons
    // Consumables
    public Button itemConsumables1;
    public Button itemConsumables2;
    public Button itemConsumables3;

    // Story
    public Button itemStory1;
    public Button itemStory2;
    public Button itemStory3;

    // Weapons
    public Button itemWeapon1;
    public Button itemWeapon2;
    public Button itemWeapon3;

    // Text
    public Text textCurrency;

    // Current Item Selected
    private Item selectedItem;
    public Text textNoItem;
    public GameObject itemSelected;

    // Start is called before the first frame update
    void Start()
    {
        inventoryChilds.SetActive(false);
        itemSelected.SetActive(false);
        Button closeButton = inventoryChilds.transform.Find("Close Button").GetComponent<Button>();
        closeButton.onClick.AddListener(() =>
        {
            CloseInventory();
        });

        itemConsumables1.onClick.AddListener(() =>
        {
            if (itemConsumables1.transform.Find("Image").GetComponent<Image>().enabled)
            {
                textNoItem.enabled = false;
                itemSelected.SetActive(true);
                Item basicPotion = GameManager.instance.itemManagement.GetItemByTitle("Basic Potion");
                itemSelected.transform.Find("Image").GetComponent<Image>().sprite = basicPotion.icon;
                itemSelected.transform.Find("Item Title").GetComponent<Text>().text = basicPotion.title;
                itemSelected.transform.Find("Description").GetComponent<Text>().text = basicPotion.description;
                itemSelected.transform.Find("Quantity").GetComponent<Text>().text = "Quantity: " + GameManager.instance.saveData.playerData.ItemQuantityInInventory(basicPotion.title).ToString();
            }
            else
            {
                textNoItem.enabled = true;
                itemSelected.SetActive(false);
            }
        });

        itemConsumables2.onClick.AddListener(() =>
        {
            if (itemConsumables2.transform.Find("Image").GetComponent<Image>().enabled)
            {
                textNoItem.enabled = false;
                itemSelected.SetActive(true);
                Item basicPotion = GameManager.instance.itemManagement.GetItemByTitle("Basic Potion");
                itemSelected.transform.Find("Image").GetComponent<Image>().sprite = basicPotion.icon;
                itemSelected.transform.Find("Item Title").GetComponent<Text>().text = basicPotion.title;
                itemSelected.transform.Find("Description").GetComponent<Text>().text = basicPotion.description;
                itemSelected.transform.Find("Quantity").GetComponent<Text>().text = "Quantity: " + GameManager.instance.saveData.playerData.ItemQuantityInInventory(basicPotion.title).ToString();
            }
            else
            {
                textNoItem.enabled = true;
                itemSelected.SetActive(false);
            }
        });

        itemConsumables3.onClick.AddListener(() =>
        {
            if (itemConsumables3.transform.Find("Image").GetComponent<Image>().enabled)
            {
                textNoItem.enabled = false;
                itemSelected.SetActive(true);
                Item basicPotion = GameManager.instance.itemManagement.GetItemByTitle("Basic Potion");
                itemSelected.transform.Find("Image").GetComponent<Image>().sprite = basicPotion.icon;
                itemSelected.transform.Find("Item Title").GetComponent<Text>().text = basicPotion.title;
                itemSelected.transform.Find("Description").GetComponent<Text>().text = basicPotion.description;
                itemSelected.transform.Find("Quantity").GetComponent<Text>().text = "Quantity: " + GameManager.instance.saveData.playerData.ItemQuantityInInventory(basicPotion.title).ToString();
            }
            else
            {
                textNoItem.enabled = true;
                itemSelected.SetActive(false);
            }
        });

        itemWeapon1.onClick.AddListener(() =>
        {
            if (itemWeapon1.transform.Find("Image").GetComponent<Image>().enabled)
            {
                textNoItem.enabled = false;
                itemSelected.SetActive(true);
                Item basicSword = GameManager.instance.itemManagement.GetItemByTitle("Basic Sword");
                itemSelected.transform.Find("Image").GetComponent<Image>().sprite = basicSword.icon;
                itemSelected.transform.Find("Item Title").GetComponent<Text>().text = basicSword.title;
                itemSelected.transform.Find("Description").GetComponent<Text>().text = basicSword.description;
                itemSelected.transform.Find("Quantity").GetComponent<Text>().text = "Quantity: " + GameManager.instance.saveData.playerData.ItemQuantityInInventory(basicSword.title).ToString();
            }
            else
            {
                textNoItem.enabled = true;
                itemSelected.SetActive(false);
            }
        });

        itemWeapon2.onClick.AddListener(() =>
        {
            if (itemWeapon2.transform.Find("Image").GetComponent<Image>().enabled)
            {
                textNoItem.enabled = false;
                itemSelected.SetActive(true);
                Item basicBow = GameManager.instance.itemManagement.GetItemByTitle("Basic Bow");
                itemSelected.transform.Find("Image").GetComponent<Image>().sprite = basicBow.icon;
                itemSelected.transform.Find("Item Title").GetComponent<Text>().text = basicBow.title;
                itemSelected.transform.Find("Description").GetComponent<Text>().text = basicBow.description;
                itemSelected.transform.Find("Quantity").GetComponent<Text>().text = "Quantity: " + GameManager.instance.saveData.playerData.ItemQuantityInInventory(basicBow.title).ToString();
            }
            else
            {
                textNoItem.enabled = true;
                itemSelected.SetActive(false);
            }
        });


        itemWeapon3.onClick.AddListener(() =>
        {
            if (itemWeapon3.transform.Find("Image").GetComponent<Image>().enabled)
            {
                textNoItem.enabled = false;
                itemSelected.SetActive(true);
                Item basicBow = GameManager.instance.itemManagement.GetItemByTitle("Basic Bow");
                itemSelected.transform.Find("Image").GetComponent<Image>().sprite = basicBow.icon;
                itemSelected.transform.Find("Item Title").GetComponent<Text>().text = basicBow.title;
                itemSelected.transform.Find("Description").GetComponent<Text>().text = basicBow.description;
                itemSelected.transform.Find("Quantity").GetComponent<Text>().text = "Quantity: " + GameManager.instance.saveData.playerData.ItemQuantityInInventory(basicBow.title).ToString();
            }
            else
            {
                textNoItem.enabled = true;
                itemSelected.SetActive(false);
            }
        });

        itemStory1.onClick.AddListener(() =>
        {
            if (itemStory1.transform.Find("Image").GetComponent<Image>().enabled)
            {
                textNoItem.enabled = false;
                itemSelected.SetActive(true);
                Item tiara = GameManager.instance.itemManagement.GetItemByTitle("Tiara");
                itemSelected.transform.Find("Image").GetComponent<Image>().sprite = tiara.icon;
                itemSelected.transform.Find("Item Title").GetComponent<Text>().text = tiara.title;
                itemSelected.transform.Find("Description").GetComponent<Text>().text = tiara.description;
                itemSelected.transform.Find("Quantity").GetComponent<Text>().text = "Quantity: " + GameManager.instance.saveData.playerData.ItemQuantityInInventory(tiara.title).ToString();
            }
            else
            {
                textNoItem.enabled = true;
                itemSelected.SetActive(false);
            }
        });

        itemStory2.onClick.AddListener(() =>
        {
            if (itemStory2.transform.Find("Image").GetComponent<Image>().enabled)
            {
                textNoItem.enabled = false;
                itemSelected.SetActive(true);
                Item tiara = GameManager.instance.itemManagement.GetItemByTitle("Tiara");
                itemSelected.transform.Find("Image").GetComponent<Image>().sprite = tiara.icon;
                itemSelected.transform.Find("Item Title").GetComponent<Text>().text = tiara.title;
                itemSelected.transform.Find("Description").GetComponent<Text>().text = tiara.description;
                itemSelected.transform.Find("Quantity").GetComponent<Text>().text = "Quantity: " + GameManager.instance.saveData.playerData.ItemQuantityInInventory(tiara.title).ToString();
            }
            else
            {
                textNoItem.enabled = true;
                itemSelected.SetActive(false);
            }
        });

        itemStory3.onClick.AddListener(() =>
        {
            if (itemStory3.transform.Find("Image").GetComponent<Image>().enabled)
            {
                textNoItem.enabled = false;
                itemSelected.SetActive(true);
                Item tiara = GameManager.instance.itemManagement.GetItemByTitle("Tiara");
                itemSelected.transform.Find("Image").GetComponent<Image>().sprite = tiara.icon;
                itemSelected.transform.Find("Item Title").GetComponent<Text>().text = tiara.title;
                itemSelected.transform.Find("Description").GetComponent<Text>().text = tiara.description;
                itemSelected.transform.Find("Quantity").GetComponent<Text>().text = "Quantity: " + GameManager.instance.saveData.playerData.ItemQuantityInInventory(tiara.title).ToString();
            }
            else
            {
                textNoItem.enabled = true;
                itemSelected.SetActive(false);
            }
        });

        GameManager.instance.saveData.playerData.AddItemToInventory(GameManager.instance.itemManagement.GetItemByTitle("Magic Stone"), 100);
        GameManager.instance.saveData.playerData.AddItemToInventory(GameManager.instance.itemManagement.GetItemByTitle("Tiara"), 1);
        GameManager.instance.saveData.playerData.AddItemToInventory(GameManager.instance.itemManagement.GetItemByTitle("Basic Sword"), 1);
        GameManager.instance.saveData.playerData.AddItemToInventory(GameManager.instance.itemManagement.GetItemByTitle("Basic Potion"), 2);

        UpdateSlots();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateSlots()
    {
        if (GameManager.instance.saveData.playerData.ItemQuantityInInventory("Basic Potion") > 0)
        {
            Item basicPotion = GameManager.instance.itemManagement.GetItemByTitle("Basic Potion");
            itemConsumables1.transform.Find("Image").GetComponent<Image>().sprite = basicPotion.icon;
            itemConsumables1.transform.Find("Text").GetComponent<Text>().enabled = false;
        }
        else
        {
            itemConsumables1.transform.Find("Image").GetComponent<Image>().enabled = false;
            itemConsumables1.transform.Find("Text").GetComponent<Text>().enabled = true;
        }
        itemConsumables2.transform.Find("Image").GetComponent<Image>().enabled = false;
        itemConsumables3.transform.Find("Image").GetComponent<Image>().enabled = false;

        if (GameManager.instance.saveData.playerData.ItemQuantityInInventory("Basic Sword") > 0)
        {
            Item basicSword = GameManager.instance.itemManagement.GetItemByTitle("Basic Sword");
            itemWeapon1.transform.Find("Image").GetComponent<Image>().sprite = basicSword.icon;
            itemWeapon1.transform.Find("Text").GetComponent<Text>().enabled = false;

        }
        else
        {
            itemWeapon1.transform.Find("Image").GetComponent<Image>().enabled = false;
            itemWeapon1.transform.Find("Text").GetComponent<Text>().enabled = true;

        }
        if (GameManager.instance.saveData.playerData.ItemQuantityInInventory("Basic Bow") > 0)
        {
            Item basicSword = GameManager.instance.itemManagement.GetItemByTitle("Basic Bow");
            itemWeapon2.transform.Find("Image").GetComponent<Image>().sprite = basicSword.icon;
            itemWeapon2.transform.Find("Text").GetComponent<Text>().enabled = false;

        }
        else
        {
            itemWeapon2.transform.Find("Image").GetComponent<Image>().enabled = false;
            itemWeapon2.transform.Find("Text").GetComponent<Text>().enabled = true;

        }
        itemWeapon3.transform.Find("Image").GetComponent<Image>().enabled = false;

        if(GameManager.instance.saveData.playerData.ItemQuantityInInventory("Tiara") > 0)
        {
            Item tiara = GameManager.instance.itemManagement.GetItemByTitle("Tiara");
            itemStory1.transform.Find("Image").GetComponent<Image>().sprite = tiara.icon;
            itemStory1.transform.Find("Text").GetComponent<Text>().enabled = false;
        }
        else
        {
            itemStory1.transform.Find("Image").GetComponent<Image>().enabled = false;
            itemStory1.transform.Find("Text").GetComponent<Text>().enabled = true;
        }
        itemStory2.transform.Find("Image").GetComponent<Image>().enabled = false;
        itemStory3.transform.Find("Image").GetComponent<Image>().enabled = false;

        textCurrency.text = "Magic Stones: " + GameManager.instance.saveData.playerData.ItemQuantityInInventory("Magic Stone").ToString();
    }

    public void ViewInventory()
    {
        if (inventoryChilds.activeSelf)
        {
            CloseInventory();
        }
        else
        {
            OpenInventory();
        }
        UpdateSlots();
    }

    public void CloseInventory()
    {
        inventoryChilds.SetActive(false);
        Time.timeScale = 1f;
        PauseMenu.gameIsPaused = false;
    }

    public void OpenInventory()
    {
        inventoryChilds.SetActive(true);
        Time.timeScale = 0f;
        PauseMenu.gameIsPaused = true;
    }
}
