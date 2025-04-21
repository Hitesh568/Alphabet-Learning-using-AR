using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class OrderController : MonoBehaviour
{
    public GameObject starPanel;
    public ChangeLetters changeLetter;
    public List<Slider> sliders = new List<Slider>();
    public int pathCount = 0;
    public bool success = false;
    public string tl;
    public static string selectedObject = ""; // Store object selection

    void Start()
    {
        ShowSlider(pathCount);
    }

    void Update()
    {
        if (success) return;

        if (pathCount < sliders.Count && sliders[pathCount].finish)
        {
            Debug.Log("Show Path");
            pathCount++;
            ShowSlider(pathCount);
        }
        else if (pathCount == sliders.Count)
        {
            Debug.Log("Finish");
            pathCount = 0;
            success = true;
            starPanel.SetActive(true);
            
            //SceneManager.LoadScene(3); // Load AR scene
		if (tl == "A")
		{
			SceneManager.LoadScene(3);
		}
		else if(tl == "B")
		{
			SceneManager.LoadScene(18);
		}
		else if(tl == "C")
		{
			SceneManager.LoadScene(19);
		}
		else if(tl == "D")
		{
			SceneManager.LoadScene(20);
		}
		else if(tl == "E")
		{
			SceneManager.LoadScene(21);
		}
		else if(tl == "F")
		{
			SceneManager.LoadScene(22);
		}
		else if(tl == "G")
		{
			SceneManager.LoadScene(23);
		}
		else if(tl == "H")
		{
			SceneManager.LoadScene(24);
		}
		else if(tl == "I")
		{
			SceneManager.LoadScene(25);
		}
		else if(tl == "J")
		{
			SceneManager.LoadScene(26);
		}
		else if(tl == "K")
		{
			SceneManager.LoadScene(27);
		}
		else if(tl == "L")
		{
			SceneManager.LoadScene(28);
		}
		else if(tl == "M")
		{
			SceneManager.LoadScene(29);
		}
		else if(tl == "N")
		{
			SceneManager.LoadScene(30);
		}
		else if(tl == "O")
		{
			SceneManager.LoadScene(31);
		}
		else if(tl == "P")
		{
			SceneManager.LoadScene(32);
		}
		else if(tl == "Q")
		{
			SceneManager.LoadScene(33);
		}
		else if(tl == "R")
		{
			SceneManager.LoadScene(34);
		}
		else if(tl == "S")
		{
			SceneManager.LoadScene(35);
		}
		else if(tl == "T")
		{
			SceneManager.LoadScene(36);
		}
		else if(tl == "U")
		{
			SceneManager.LoadScene(37);
		}
		else if(tl == "V")
		{
			SceneManager.LoadScene(38);
		}
		else if(tl == "W")
		{
			SceneManager.LoadScene(39);
		}
		else if(tl == "X")
		{
			SceneManager.LoadScene(40);
		}
		else if(tl == "Y")
		{
			SceneManager.LoadScene(41);
		}
        }
    }

    void ShowSlider(int index)
    {
        for (int i = 0; i < sliders.Count; i++)
        {
            sliders[i].gameObject.SetActive(i == index);
        }
    }

    // Call this function when a button is clicked
    public void SelectObject(string objName)
    {
        selectedObject = objName; // Store the selected object name
    }
}