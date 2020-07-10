using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class level_selector : MonoBehaviour {
	public string load_level;
	public GameObject paneldesc;
	public Text textdesc;
	public string flag;
	public int coin, heart;
	bool isloadmap;
	public void load_minigame2(Button button)
	{
		if (button.name == "lvl1") 
		{
			loadscene("minigame2");

		}
		else if (button.name == "lvl2") 
		{
			loadscene("minigame2_level2");
		}
		else if (button.name == "lvl3") 
		{
			loadscene("minigame2_level3");
		}
		else if (button.name == "lvl4") 
		{
			loadscene("minigame2_level4");
		}
		else if (button.name == "lvl5") 
		{
			loadscene("minigame2_level5");
		}
		else if (button.name == "lvl6") 
		{
			loadscene("minigame2_level2");
		}
		else if (button.name == "lvl7") 
		{
			loadscene("minigame2_level2");
		}
		
	}

	public void load_minigame1(Button button)
	{
		if (button.name == "lvl1") 
		{
			loadscene("minigame1");

		}
		else if (button.name == "lvl2") 
		{
			loadscene("minigame1");
		}
		else if (button.name == "lvl3") 
		{
			loadscene("minigame1");
		}
		else if (button.name == "lvl4") 
		{
			loadscene("minigame1");
		}
		else if (button.name == "lvl5") 
		{
			loadscene("minigame1");
		}
		else if (button.name == "lvl6") 
		{
			loadscene("minigame1");
		}
		else if (button.name == "lvl7") 
		{
			loadscene("minigame1");
		}

	}


	public void loadmap(Button button)
	{
		if (button.name == "town1") 
		{
			setpanel ();
			flag = "town1";
			textdesc.text = "Pada kota ini pemain akan mengetahui informasi dasar mengenai periode pada tabel periodik unsur modern (TPU)";
			isloadmap = PlayerPrefs.HasKey ("stage");

			if (!isloadmap) 
			{
				PlayerPrefs.SetInt ("heart", 3);
				PlayerPrefs.SetInt ("coin", 0);
			}
			else
			{
				coin=PlayerPrefs.GetInt ("coin");
				heart = PlayerPrefs.GetInt ("heart");
				PlayerPrefs.SetInt ("coin", coin);
				PlayerPrefs.SetInt ("heart", heart);
			}

		
		}
		 if (button.name == "town2") 
		{
			setpanel ();
			flag="town2";
			textdesc.text = "Pada kota ini pemain akan mengetahui informasi dasar mengenai golongan pada tabel periodik unsur modern (TPU)";
			PlayerPrefs.SetString ("stage", "map");
			isloadmap = PlayerPrefs.HasKey ("stage");

			if (!isloadmap) 
			{
				PlayerPrefs.SetInt ("heart", 3);
				PlayerPrefs.SetInt ("coin", 0);
			}
			else
			{
				coin=PlayerPrefs.GetInt ("coin");
				heart = PlayerPrefs.GetInt ("heart");
				PlayerPrefs.SetInt ("coin", coin);
				PlayerPrefs.SetInt ("heart", heart);
			}


		}
		 if (button.name == "town3") 
		{
			setpanel ();
			flag = "town3";
			textdesc.text = "Pada kota ini pemain akan mengetahui informasi dasar mengenai jenis elemen pada tabel periodik unsur modern (TPU)";
			PlayerPrefs.SetString ("stage", "map");
			isloadmap = PlayerPrefs.HasKey ("stage");

			if (!isloadmap) 
			{
				PlayerPrefs.SetInt ("heart", 3);
				PlayerPrefs.SetInt ("coin", 0);
			}
			else
			{
				coin=PlayerPrefs.GetInt ("coin");
				heart = PlayerPrefs.GetInt ("heart");
				PlayerPrefs.SetInt ("coin", coin);
				PlayerPrefs.SetInt ("heart", heart);
			}

	
		}
		 if (button.name == "town4") 
		{
			setpanel ();
			flag = "town4";
			textdesc.text = "Pada kota ini pemain akan mengetahui informasi dasar mengenai konfigurasi elekron 1 pada tabel periodik unsur modern (TPU)";
			PlayerPrefs.SetString ("stage", "map");
			isloadmap = PlayerPrefs.HasKey ("stage");

			if (!isloadmap) 
			{
				PlayerPrefs.SetInt ("heart", 3);
				PlayerPrefs.SetInt ("coin", 0);
			}
			else
			{
				coin=PlayerPrefs.GetInt ("coin");
				heart = PlayerPrefs.GetInt ("heart");
				PlayerPrefs.SetInt ("coin", coin);
				PlayerPrefs.SetInt ("heart", heart);
			}


		}
		 if (button.name == "town5") 
		{
			setpanel ();
			flag = "town5";
			textdesc.text = "Pada kota ini pemain akan mengetahui informasi dasar mengenai konfigurasi elekron 2 pada tabel periodik unsur modern (TPU)";
			PlayerPrefs.SetString ("stage", "map");
			isloadmap = PlayerPrefs.HasKey ("stage");

			if (!isloadmap) 
			{
				PlayerPrefs.SetInt ("heart", 3);
				PlayerPrefs.SetInt ("coin", 0);
			}
			else
			{
				coin=PlayerPrefs.GetInt ("coin");
				heart = PlayerPrefs.GetInt ("heart");
				PlayerPrefs.SetInt ("coin", coin);
				PlayerPrefs.SetInt ("heart", heart);
			}


		}
		 if (button.name == "return") 
		{
			setpanel ();
			flag = "town5";
			PlayerPrefs.SetString ("stage", "map");
			isloadmap = PlayerPrefs.HasKey ("stage");

			if (!isloadmap) 
			{
				PlayerPrefs.SetInt ("heart", 3);
				PlayerPrefs.SetInt ("coin", 0);
			}
			else
			{
				coin=PlayerPrefs.GetInt ("coin");
				heart = PlayerPrefs.GetInt ("heart");
				PlayerPrefs.SetInt ("coin", coin);
				PlayerPrefs.SetInt ("heart", heart);
			}


//			textdesc.text = "Pada kota ini pemain akan mengetahui informasi dasar mengenai periode pada tabel periodik unsur modern (TPU)"+""
//				+"\n"+"Pada kota ini pemain bisa menyelesaikan quest yang tersedia besrta pemain bisa mengunjungi rumah yang tersedia dikota tersebut.";
		}
		loadmap_start ();

		
	}

	public void setpanel()
	{
		paneldesc.SetActive (true);
	
	
	}
	public void loadscene(string level_name)
	{
		SceneManager.LoadScene (level_name);
	}


	public void loadmap_exit()
	{
		paneldesc.SetActive (false);
		flag = "";
	}

	public void loadmap_start()
	{
		if (flag == "town1") 
		{
			loadscene ("map_1");
		}
		else if (flag == "town2") 
		{
			loadscene ("sm_map2");
			
		}
		else if (flag == "town3") 
		{
			loadscene ("sm_map3");
		}
		else if (flag == "town4") 
		{
			loadscene ("sm_map4");
		}
		else if (flag == "town5") 
		{
			loadscene ("map_5");
		}
		else if (flag == "return") 
		{
			
		}

	}




}
