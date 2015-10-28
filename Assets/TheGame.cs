﻿using UnityEngine;
using System.Collections;

public class TheGame : MonoBehaviour {
	static readonly int[] triangle_indices = { 0, 1, 2};
	static readonly int[] line_indices = { 0, 1, 1, 2, 2, 0 };
	static readonly Vector3[] vertices = {
		new Vector3 (-5, -5, 0),
		new Vector3 (-5, 5, 0),
		new Vector3 (5, -5, 0),
		new Vector3 (5, 5, 0),
		new Vector3 (-10, 8,0),
		new Vector3 (-5,0,0)
	};

	void make_square() {
		GameObject go = new GameObject ();
		go.name = "square";
		go.transform.localPosition = new Vector3 (-10, 0, 20);

		MeshFilter mf = go.AddComponent<MeshFilter> ();
		go.AddComponent<MeshRenderer> ();

		Mesh mesh = new Mesh ();
		mesh.vertices = vertices;
		mesh.triangles = new int[]{0,1,2,2,1,3};
		//mesh.triangles = new int[]{2,4,1};
		mf.mesh = mesh;
	}

	void make_flower(){
		GameObject go = new GameObject ();
		go.name = "flower";
		go.transform.localPosition = new Vector3 (10, 0, 20);
		
		MeshFilter mf = go.AddComponent<MeshFilter> ();
		go.AddComponent<MeshRenderer> ();
		
		Mesh mesh = new Mesh ();
		mesh.vertices = vertices;
		mesh.triangles = new int[]{1,5,4};
		//mesh.triangles = new int[]{2,4,1};
		mf.mesh = mesh;
	}

//	void make_triangle() {
//		GameObject go = new GameObject ();
//		go.name = "triangle";
//		go.transform.localPosition = new Vector3 (-10, 0, 20);
//		
//		MeshFilter mf = go.AddComponent<MeshFilter> ();
//		go.AddComponent<MeshRenderer> ();
//		
//		Mesh mesh = new Mesh ();
//		mesh.vertices = vertices;
//		mesh.triangles = triangle_indices;
//		mf.mesh = mesh;
//	}
	
//	void make_wireframe() {
//		GameObject go = new GameObject ();
//		go.name = "wireframe";
//		go.transform.localPosition = new Vector3 (10, 0, 20);
//
//		MeshFilter mf = go.AddComponent<MeshFilter> ();
//		go.AddComponent<MeshRenderer> ();
//
//		Mesh mesh = new Mesh ();
//		mesh.vertices = vertices;
//		mesh.SetIndices (line_indices, MeshTopology.Lines, 0);
//		mf.mesh = mesh;
//	}
	
	// Use this for initialization
	void Start () {
		make_square ();
		make_flower ();
		//make_wireframe ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
