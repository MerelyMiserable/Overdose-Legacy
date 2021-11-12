using System;
using UnityEngine;

// Token: 0x0200002D RID: 45
public class dumb : MonoBehaviour
{
	// Token: 0x060000D7 RID: 215 RVA: 0x00005982 File Offset: 0x00003B82
	private void Start()
	{
		this.UpdateActivation();
	}

	// Token: 0x060000D8 RID: 216 RVA: 0x0000598A File Offset: 0x00003B8A
	private void Use()
	{
		if (!base.enabled)
		{
			return;
		}
		this.Activated = !this.Activated;
		this.UpdateActivation();
	}

	// Token: 0x060000D9 RID: 217 RVA: 0x000059AA File Offset: 0x00003BAA
	private void FixedUpdate()
	{
		if (this.PhysicalBehaviour.charge > -1f)
		{
			UnityEngine.Object.Instantiate<GameObject>(this.BlackHole, base.transform.position, Quaternion.identity);
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x060000DA RID: 218 RVA: 0x000059E5 File Offset: 0x00003BE5
	private void OnDisable()
	{
		this.ParticleSystem.Stop();
		this.AudioSource.Stop();
	}

	// Token: 0x060000DB RID: 219 RVA: 0x00005A00 File Offset: 0x00003C00
	private void UpdateActivation()
	{
		this.DecimateTrigger.enabled = this.Activated;
		if (this.Activated)
		{
			this.ParticleSystem.Play();
			this.AudioSource.Play();
			return;
		}
		this.ParticleSystem.Stop();
		this.AudioSource.Stop();
	}

	// Token: 0x060000DC RID: 220 RVA: 0x00005A54 File Offset: 0x00003C54
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (!base.enabled)
		{
			return;
		}
		if (!this.Activated)
		{
			return;
		}
		if (collision.isTrigger)
		{
			return;
		}
		PhysicalBehaviour physicalBehaviour;
		if (!Global.main.PhysicalObjectsInWorldByTransform.TryGetValue(collision.transform, out physicalBehaviour))
		{
			return;
		}
		if (!physicalBehaviour.Deletable)
		{
			return;
		}
		UnityEngine.Object.Destroy(physicalBehaviour.transform.root.gameObject);
		UnityEngine.Object.Instantiate<GameObject>(this.DeleteEffect, physicalBehaviour.transform.position, Quaternion.identity);
	}

	// Token: 0x040000D9 RID: 217
	[SkipSerialisation]
	public BoxCollider2D DecimateTrigger;

	// Token: 0x040000DA RID: 218
	[SkipSerialisation]
	public PhysicalBehaviour PhysicalBehaviour;

	// Token: 0x040000DB RID: 219
	[SkipSerialisation]
	public AudioSource AudioSource;

	// Token: 0x040000DC RID: 220
	[SkipSerialisation]
	public ParticleSystem ParticleSystem;

	// Token: 0x040000DD RID: 221
	[SkipSerialisation]
	public GameObject DeleteEffect;

	// Token: 0x040000DE RID: 222
	[SkipSerialisation]
	public GameObject BlackHole;

	// Token: 0x040000DF RID: 223
	[HideInInspector]
	public bool Activated;
}
