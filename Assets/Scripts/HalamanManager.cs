using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HalamanManager : MonoBehaviour
{
	public bool isEscapeToExit;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
   	if (Input.GetKeyUp(KeyCode.Escape)){
			SceneManager.LoadScene("Quit");
		}  
    }
	
	public void MulaiPermainan(){
		SceneManager.LoadScene("GamePlay");
	}
	
	public void KembaliKeMenu(){
		SceneManager.LoadScene("Home");
	}
	
	public void KeluarScene() {
      Application.Quit();
   }
   
   public void konfirmasi() {
     SceneManager.LoadScene("Quit");
   }
}
