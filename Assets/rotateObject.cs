using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateObject : MonoBehaviour
{
	public GameObject Poci;
	public GameObject Saron;
	public GameObject Singkal;
	public GameObject Tarawangsa;
	public GameObject Badik;
	public GameObject Bonang;
	public GameObject Botol;
	public GameObject Gong;
	public GameObject Pangarih;
	public GameObject Mangkuk;
	public GameObject Lulumpang;
	public GameObject Kolotok;
	public GameObject Keris;
	public GameObject Helm;
	public GameObject Bubu;
	public GameObject Bokor;
	public GameObject Tombak;
	public GameObject Tas;
	public GameObject Setrika;
	public GameObject Etem;
	public GameObject Topi;
	public GameObject Lesung;
	public GameObject LampuKereta;

	public float rotateSpeed = 50f;
	bool rotateStatus = false;

	//rotate object function
	public void RotateObject()
	{

		if (rotateStatus == false)
		{
			rotateStatus = true;
		}
		else
		{
			rotateStatus = false;
		}
	}

	void Update()
	{
		if (rotateStatus == true)
		{
			//rotate object with speed
			Poci.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
			Saron.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
			Singkal.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
			Tarawangsa.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
			Badik.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
			Bonang.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
			Botol.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
			Gong.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
			Pangarih.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
			Mangkuk.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
			Lulumpang.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
			Kolotok.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
			Keris.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
			Helm.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
			Bubu.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
			Bokor.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
			Tombak.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
			Tas.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
			Setrika.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
			Etem.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
			Topi.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
			Lesung.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
			LampuKereta.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
		}
	}
}
