﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private SceneIndexes current_scene_index;
    private LevelIndexes current_level_index;
    private static GameManager instance; 
    // Start is called before the first frame update
    private void Start()
    {
        instance = this;
        DontDestroyOnLoad(this.gameObject);
        current_scene_index = SceneIndexes.MAINMENU;
        current_level_index = LevelIndexes.LVONE;
        instance.setScene(current_scene_index);
        LoadGame();
    }
    public static GameManager getManager()
    {
        //singleton pattern
        return instance;
    }
    public void setScene (SceneIndexes level)
    {
        current_scene_index = level;
    }
    public int getScene()
    {
        return (int)current_scene_index;
    }

    public void setLevel (LevelIndexes lvl)
    {
        current_level_index = lvl;
    }
    public int getLevel()
    {
        return (int)current_level_index;
    }

    public void LoadGame()
    {
        SceneManager.LoadScene((int)current_scene_index);
    }
}
