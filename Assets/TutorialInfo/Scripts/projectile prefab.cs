using System;

public GameObject projectilePrefab;

void Update()
{
	if (Input.GetKeyDown(KeyCode.Space))
	{
		Instantiate(projectilePrefab, transform.position, Quaternion.identity);
	}
}

public Class1()
	{
	}
}
