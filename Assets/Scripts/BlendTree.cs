using UnityEngine;

/// <summary>
/// Control Puppy 2 by setting parameter values on the animator and using a blend tree to control the motion.
/// This is the type of animation seen in the Lab 1 project folder: "3. Blend Trees".
/// </summary>

public class BlendTree : MonoBehaviour
{
	[SerializeField] private Animator puppy2Animator;
	private float speed;

	private void Update()
	{
		speed = Input.GetAxisRaw("Vertical");
		if (Input.GetAxisRaw("Vertical") > 0f) //Walk
		{
			puppy2Animator.SetFloat("Move", speed);
		}
		else //Idle
		{
			puppy2Animator.SetFloat("Move", 0);
		}

		transform.position += new Vector3(Time.deltaTime * 0.32f * speed, 0f);
	}
}
