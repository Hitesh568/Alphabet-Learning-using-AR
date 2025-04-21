using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeNumber : MonoBehaviour 
{
    public List<Sample> letters;
    public Button btnNextLevel;
    public Button btnRight_Next;
    public Button btnLeft_Prev;
    public Text txtCurrentLetter;
    public Text txtCurrentLevel;
    public Text txtCharCount;
    public int m_index;
    public GameObject animObj;
    private enum E_Direction
    {
        Left, Right
    }
    public static ChangeNumber m_ChangeLetter;
    private string[] chars = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
    void Awake()
    {
        m_ChangeLetter = this;
        animObj.SetActive(false);
        onClickChangeSelectedIndex(E_Direction.Right);
        
        // StartCoroutine(On_OffStarPanel());
    }
    void Update()
    {
        ChangeUIValues(m_index);
    }
    private void onClickChangeSelectedIndex(E_Direction direction)
    {
        switch (direction)
        {
            case E_Direction.Left:
                m_index--;
                break;
            case E_Direction.Right:
                m_index++;
                break;
            default:
                m_index--;
                break;
        }
        if (m_index >= 9)
        {
            m_index = 9;
        }
        else if (m_index <= 0)
        {
            m_index = 1;
        }
        ChangeUIValues(m_index);
    }
    public void ChangeUIValues(int index)
    {
        txtCurrentLevel.text = "Level " + index.ToString();
        txtCharCount.text = index.ToString() + "/9";
        string str = "\"" + chars[index - 1] + "\"";
        txtCurrentLetter.text = "Select Letter " + str;
    }
    public void IncreaeIndex()
    {
        onClickChangeSelectedIndex(E_Direction.Right);
        ShowStars();
    }
    public void DecreaseIndex()
    {
        onClickChangeSelectedIndex(E_Direction.Left);
        ShowStars();
    }

    public void ShowStars() {
      // Show stars for finish letters 
      
      if(m_index <= letters.Count && letters[m_index-1].success) {
        animObj.SetActive(true);           
        StartCoroutine(On_OffStarPanel());
      } else {
        animObj.SetActive(false);
      }
    }

    public IEnumerator On_OffStarPanel()
    {
        animObj.SetActive(false);
        yield return new WaitForSeconds(0.1f);
        animObj.SetActive(true);
    }
}
