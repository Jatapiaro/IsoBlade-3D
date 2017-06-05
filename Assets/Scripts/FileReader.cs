using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.IO;
using System;
using System.Text.RegularExpressions;  

public class FileReader : MonoBehaviour {


	public List<Vector2> Load(string fileName){
		List<Vector2> points = new List<Vector2>();
		StreamReader reader = new StreamReader(fileName);
		while(!reader.EndOfStream){
			string line = reader.ReadLine();
			line = Regex.Replace(line, @"\s+", ",");
			string[] values = line.Split (',');
			float x = float.Parse (values[0]);
			float y = float.Parse (values[1]);
			points.Add (new Vector2 (x, y));
		}
		reader.Close();
		return (points.Count > 0) ? points : null;
	}

}
