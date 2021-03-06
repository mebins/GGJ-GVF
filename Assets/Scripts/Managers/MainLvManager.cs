﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainLvManager : MonoBehaviour{

  private int levelInd;
  private GameManager gm;

  public GameObject player;
  private Vector3 playerPos;

  public GameObject cmera;
  private Vector3 cmeraPos;

  // We only need the starting place at the left
  public GameObject flagLeft1;
  public GameObject flagLeft2;
  public GameObject flagLeft3;
  public GameObject flagLeft4;
  private float flagLeftPos;

  // Start is called before the first frame update
  void Start(){
    gm = GameManager.getManager();
    levelInd = gm.getLevel();

    switch (levelInd){
      case 1:
        playerPos = new Vector3(flagLeft1.transform.position.x + (player.transform.localScale.x * 2), flagLeft1.transform.position.y, player.transform.position.z);
        //Debug.Log("Case 1");
        break;
      case 2:
        // insert code check mechanic here
        //
        //
        //
        playerPos = new Vector3(flagLeft2.transform.position.x + (player.transform.localScale.x * 2), flagLeft2.transform.position.y, player.transform.position.z);
        break;
      case 3:
        // insert code check mechanic here
        //
        //
        //
        playerPos = new Vector3(flagLeft3.transform.position.x + (player.transform.localScale.x * 2), flagLeft3.transform.position.y, player.transform.position.z);
        break;
      case 4:
        // insert code check mechanic here
        //
        //
        //
        playerPos = new Vector3(flagLeft4.transform.position.x + (player.transform.localScale.x * 2), flagLeft4.transform.position.y, player.transform.position.z);
        break;
      default:
        //Debug.Log("Default case");
        break;
      }

    player.transform.position = playerPos;
  }

  // Update is called once per frame
  void Update(){
    if (player.transform.position.y < -10){
      switch (levelInd){
        case 1:
          playerPos = new Vector3(flagLeft1.transform.position.x + (player.transform.localScale.x * 2), flagLeft1.transform.position.y, player.transform.position.z);
          player.transform.position = playerPos;
          break;
        case 2:
          playerPos = new Vector3(flagLeft2.transform.position.x + (player.transform.localScale.x * 2), flagLeft2.transform.position.y, player.transform.position.z);
          player.transform.position = playerPos;
          break;
        case 3:
          playerPos = new Vector3(flagLeft3.transform.position.x + (player.transform.localScale.x * 2), flagLeft3.transform.position.y, player.transform.position.z);
          player.transform.position = playerPos;
          break;
        case 4:
          playerPos = new Vector3(flagLeft4.transform.position.x + (player.transform.localScale.x * 2), flagLeft4.transform.position.y, player.transform.position.z);
          player.transform.position = playerPos;
          break;
        default:
          playerPos = new Vector3(flagLeft1.transform.position.x + (player.transform.localScale.x * 2), flagLeft1.transform.position.y, player.transform.position.z);
          player.transform.position = playerPos;
          break;
        }
      }
  }
}
