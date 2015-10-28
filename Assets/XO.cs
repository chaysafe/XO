using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class XO : MonoBehaviour {
	private bool Player;
	public Text Pa1,Pa2,Pa3,Pa4,Pa5,Pa6,Pa7,Pa8,Pa9;

	public Button Stop;
	public GameObject xWin;
	public GameObject oWin;
	public GameObject Draw;
	public Button B1,B2,B3,B4,B5,B6,B7,B8,B9;
	private int Draws;






	// Use this for initialization
	public void Start () {

		Player = true;


	
	}
	//Cube.SetActive(true);
	// Update is called once per frame
	void Update () {
		Xwin ();
		Owin ();
		DrawScore ();


	
	}


	public void x1 ()
	{
		if (Player) 
		{
			Pa1.text = "X";
			Player = false;

		
			
		} 
		else 
		{
			Pa1.text = "O";
			Player = true;
		
		}
		B1.enabled = false;
		Draws = Draws+1;

	}
	public void x2 ()
	{
		if (Player) 
		{
			Pa2.text = "X";
			Player = false;
		
			
		} 
		else 
		{
			Pa2.text = "O";
			Player = true;

		}
		B2.enabled = false;
		Draws = Draws+1;
	}
	public void x3 ()
	{
		if (Player) 
		{
			Pa3.text = "X";
			Player = false;
		
		} 
		else 
		{
			Pa3.text = "O";
			Player = true;
		
		}
		B3.enabled = false;
		Draws = Draws+1;
	}
	public void x4 ()
	{
		if (Player) 
		{
			Pa4.text = "X";
			Player = false;
	
		} 
		else 
		{
			Pa4.text = "O";
			Player = true;
	
		}
		B4.enabled = false;
		Draws = Draws+1;
	}
	public void x5 ()
	{
		if (Player) 
		{
			Pa5.text = "X";
			Player = false;
	
		} 
		else 
		{
			Pa5.text = "O";
			Player = true;
		
		}
		B5.enabled = false;
		Draws = Draws+1;
	}
	public void x6 ()
	{
		if (Player) 
		{
			Pa6.text = "X";
			Player = false;
		
		} 
		else 
		{
			Pa6.text = "O";
			Player = true;
		
		}
		B6.enabled = false;
		Draws = Draws+1;
	}
	public void x7 ()
	{
		if (Player) 
		{
			Pa7.text = "X";
			Player = false;
	
		} 
		else 
		{
			Pa7.text = "O";
			Player = true;

		}
		B7.enabled = false;
		Draws = Draws+1;
	}
	public void x8 ()
	{
		if (Player) 
		{
			Pa8.text = "X";
			Player = false;
	
		} 
		else 
		{
			Pa8.text = "O";
			Player = true;
		
		}
		B8.enabled = false;
		Draws = Draws+1;
	}
	public void x9 ()
	{
		if (Player) 
		{
			Pa9.text = "X";
			Player = false;

		} 
		else 
		{
			Pa9.text = "O";
			Player = true;
		
		}
		B9.enabled = false;
		Draws = Draws+1;
	}
	public void Load()
	{
		Application.LoadLevel("XOScene");
	}

	public void Xwin()
	{
		if(Pa1.text == "X"&&Pa2.text=="X"&&Pa3.text=="X")
		{
			xWin.SetActive(true);
			Invoke("Load",2);

		}
		else if (Pa1.text == "X"&&Pa5.text=="X"&&Pa7.text=="X")
		{
			xWin.SetActive(true);
			Invoke("Load",2);
		}
		else if (Pa1.text == "X"&&Pa4.text=="X"&&Pa7.text=="X")
		{
			xWin.SetActive(true);
			Invoke("Load",2);
		}
		else if (Pa2.text == "X"&&Pa5.text=="X"&&Pa8.text=="X")
		{
			xWin.SetActive(true);
			Invoke("Load",2);
		}
		else if (Pa3.text == "X"&&Pa6.text=="X"&&Pa9.text=="X")
		{
			xWin.SetActive(true);
			Invoke("Load",2);
		}
		else if (Pa3.text == "X"&&Pa5.text=="X"&&Pa7.text=="X")
		{
			xWin.SetActive(true);
			Invoke("Load",2);
		}
		else if (Pa4.text == "X"&&Pa5.text=="X"&&Pa6.text=="X")
		{
			xWin.SetActive(true);
			Invoke("Load",2);
		}
		else if (Pa7.text == "X"&&Pa8.text=="X"&&Pa9.text=="X")
		{
			xWin.SetActive(true);
			Invoke("Load",2);
		}
	
	}
	public void Owin()
	{
		if(Pa1.text == "O"&&Pa2.text=="O"&&Pa3.text=="O")
		{
			oWin.SetActive(true);
			Invoke("Load",2);
		}
		else if (Pa1.text == "O"&&Pa5.text=="O"&&Pa7.text=="O")
		{
			oWin.SetActive(true);
			Invoke("Load",2);
		}
		else if (Pa1.text == "O"&&Pa4.text=="O"&&Pa7.text=="O")
		{
			oWin.SetActive(true);
			Invoke("Load",2);
		}
		else if (Pa2.text == "O"&&Pa5.text=="O"&&Pa8.text=="O")
		{
			oWin.SetActive(true);
			Invoke("Load",2);
		}
		else if (Pa3.text == "O"&&Pa6.text=="O"&&Pa9.text=="O")
		{
			oWin.SetActive(true);
			Invoke("Load",2);
		}
		else if (Pa3.text == "O"&&Pa5.text=="O"&&Pa7.text=="O")
		{
			oWin.SetActive(true);
			Invoke("Load",2);
		}
		else if (Pa4.text == "O"&&Pa5.text=="O"&&Pa6.text=="O")
		{
			oWin.SetActive(true);
			Invoke("Load",2);
		}
		else if (Pa7.text == "O"&&Pa8.text=="O"&&Pa9.text=="O")
		{
			oWin.SetActive(true);
			Invoke("Load",2);
		}
	
	}

	public void DrawScore()
	{
		if (Draws == 9) 
		{
			Draw.SetActive(true);
			Invoke("Load",2);
		}
	}



}
