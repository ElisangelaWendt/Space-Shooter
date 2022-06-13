using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {

public Transform Point;
public GameObject bulletPrefab;

	void Update () {
		if( Input.GetButtonDown("Fire1")){
            Shoot();
        }
    }

    void Shoot(){
        if(PauseMenu.isGamePaused == true){
        Time.timeScale = 0f;
        }
        if(PauseMenu.isGamePaused == false){
        Instantiate(bulletPrefab, Point.position, Point.rotation);
        }
    }
}