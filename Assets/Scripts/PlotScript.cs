using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class PlotScript : MonoBehaviour {


	Color[] colorOptions = {
		Color.blue,
		Color.cyan,
		Color.gray,
		Color.green,
		Color.magenta,
		Color.red,
		Color.white,
		Color.yellow,
	};

	string[] validFileExtensions = { "csv", "txt" };

	public WMG_Axis_Graph graph;

	public FileReader fr;

	// Use this for initialization
	void Start () {
		fr = GameObject.FindGameObjectWithTag ("GameController").GetComponent<FileReader> ();
		GameObject graphGo = GameObject.FindGameObjectWithTag ("Graph");
		graph = graphGo.GetComponent<WMG_Axis_Graph> ();
		loadProfile ();
	}

	public void loadProfile(){
		string path = EditorUtility.OpenFilePanelWithFilters("Select a profile", "", validFileExtensions);
		List<Vector2> values = fr.Load(path);
		addSerie (values);
	}

	public void addSerie(List<Vector2> values){
		WMG_Series serie;
		serie = graph.addSeries ();
		serie.pointColor = getRandomColor();
		serie.seriesName = "Circulo2";
		serie.pointValues.SetList (values);
	}

	Color getRandomColor(){
		return colorOptions[Random.Range(0,colorOptions.Length)];
	}
		

}
