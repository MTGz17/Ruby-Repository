using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KillCounter : MonoBehaviour
{
    public Text counterText;
    public GameObject winPanel;
    public GameObject ruby;
    private bool isDead;
    public int kills;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ShowKills();

    }

    private void ShowKills()
    {
        counterText.text = kills.ToString();
    }

    public void AddKill()
    {
        kills++;
        if(kills == 2 && !isDead)
        {
            winPanel.SetActive(true);
            ruby.SetActive(false);
        }
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void quit()
    {
        Application.Quit();
    }
}