using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemScriptBindings.h")]
[UsedByNativeCode]
[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemModulesScriptBindings.h")]
[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemScriptBindings.h")]
[NativeHeader("Modules/ParticleSystem/ParticleSystem.h")]
[NativeHeader("ParticleSystemScriptingClasses.h")]
[RequireComponent(typeof(Transform))]
[NativeHeader("Modules/ParticleSystem/ParticleSystemGeometryJob.h")]
[NativeHeader("ParticleSystemScriptingClasses.h")]
[NativeHeader("Modules/ParticleSystem/ParticleSystem.h")]
public sealed class ParticleSystem : Component
{
	public struct MainModule
	{
		internal ParticleSystem m_ParticleSystem = null;

		public MinMaxGradient startColor
		{
			get
			{
				return default;
			}
			[NativeThrows]
			set
			{
			}
		}

		public ParticleSystemSimulationSpace simulationSpace => ParticleSystemSimulationSpace.Local;

		public int maxParticles => 0;

		internal MainModule(ParticleSystem particleSystem)
		{
		}

		[SpecialName]
		private static void get_startColor_Injected(ref MainModule _unity_self, out MinMaxGradient ret)
		{
			ret = default;
		}

		[SpecialName]
		private static void set_startColor_Injected(ref MainModule _unity_self, ref MinMaxGradient value)
		{
		}

		[SpecialName]
		private static ParticleSystemSimulationSpace get_simulationSpace_Injected(ref MainModule _unity_self)
		{
			return ParticleSystemSimulationSpace.Local;
		}

		[SpecialName]
		private static int get_maxParticles_Injected(ref MainModule _unity_self)
		{
			return 0;
		}
	}

	public struct EmissionModule
	{
		internal ParticleSystem m_ParticleSystem = null;

		public bool enabled
		{
			[NativeThrows]
			set
			{
			}
		}

		internal EmissionModule(ParticleSystem particleSystem)
		{
		}

		[SpecialName]
		private static void set_enabled_Injected(ref EmissionModule _unity_self, bool value)
		{
		}
	}

	public struct ShapeModule
	{
		internal ParticleSystem m_ParticleSystem = null;

		public ParticleSystemShapeType shapeType
		{
			[NativeThrows]
			set
			{
			}
		}

		public Vector3 scale
		{
			[NativeThrows]
			set
			{
			}
		}

		internal ShapeModule(ParticleSystem particleSystem)
		{
		}

		[SpecialName]
		private static void set_shapeType_Injected(ref ShapeModule _unity_self, ParticleSystemShapeType value)
		{
		}

		[SpecialName]
		private static void set_scale_Injected(ref ShapeModule _unity_self, ref Vector3 value)
		{
		}
	}

	[RequiredByNativeCode("particleSystemParticle", Optional = true)]
	public struct Particle
	{
		private Vector3 m_Position;

		private Vector3 m_Velocity;

		private Vector3 m_AnimatedVelocity;

		private Vector3 m_InitialVelocity;

		private Vector3 m_AxisOfRotation;

		private Vector3 m_Rotation;

		private Vector3 m_AngularVelocity;

		private Vector3 m_StartSize;

		private Color32 m_StartColor;

		private uint m_RandomSeed;

		private uint m_ParentRandomSeed;

		private float m_Lifetime;

		private float m_StartLifetime;

		private int m_MeshIndex;

		private float m_EmitAccumulator0;

		private float m_EmitAccumulator1;

		private uint m_Flags;

		[Obsolete("Please use Particle.remainingLifetime instead. (UnityUpgradable) -> UnityEngine.ParticleSystem/Particle.remainingLifetime", false)]
		public float lifetime
		{
			set
			{
			}
		}

		public Vector3 position
		{
			set
			{
			}
		}

		public Vector3 velocity
		{
			set
			{
			}
		}

		public float remainingLifetime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float startLifetime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Color32 startColor
		{
			set
			{
			}
		}

		public uint randomSeed
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public float startSize
		{
			set
			{
			}
		}

		public Vector3 rotation3D
		{
			set
			{
			}
		}

		public Vector3 angularVelocity3D
		{
			set
			{
			}
		}
	}

	[Serializable]
	[NativeType(CodegenOptions.Custom, "MonoMinMaxGradient", Header = "Runtime/Scripting/ScriptingCommonStructDefinitions.h")]
	public struct MinMaxGradient(Color color)
	{
		[SerializeField]
		private ParticleSystemGradientMode m_Mode = ParticleSystemGradientMode.Color;

		[SerializeField]
		private Gradient m_GradientMin = null;

		[SerializeField]
		private Gradient m_GradientMax = null;

		[SerializeField]
		private Color m_ColorMin = default;

		[SerializeField]
		private Color m_ColorMax = default;

		public Color color => default;

		public static implicit operator MinMaxGradient(Color color)
		{
			return default;
		}
	}

	public struct EmitParams
	{
		[NativeName("particle")]
		private Particle m_Particle;

		[NativeName("positionSet")]
		private bool m_PositionSet;

		[NativeName("velocitySet")]
		private bool m_VelocitySet;

		[NativeName("axisOfRotationSet")]
		private bool m_AxisOfRotationSet;

		[NativeName("rotationSet")]
		private bool m_RotationSet;

		[NativeName("rotationalSpeedSet")]
		private bool m_AngularVelocitySet;

		[NativeName("startSizeSet")]
		private bool m_StartSizeSet;

		[NativeName("startColorSet")]
		private bool m_StartColorSet;

		[NativeName("randomSeedSet")]
		private bool m_RandomSeedSet;

		[NativeName("startLifetimeSet")]
		private bool m_StartLifetimeSet;

		[NativeName("meshIndexSet")]
		private bool m_MeshIndexSet;

		[NativeName("applyShapeToPosition")]
		private bool m_ApplyShapeToPosition;
	}

	public MainModule main => default;

	public EmissionModule emission => default;

	public ShapeModule shape => default;

	[Obsolete("Emit with specific parameters is deprecated. Pass a ParticleSystem.EmitParams parameter instead, which allows you to override some/all of the emission properties", false)]
	public void Emit(Vector3 position, Vector3 velocity, float size, float lifetime, Color32 color)
	{
	}

	[Obsolete("Emit with a single particle structure is deprecated. Pass a ParticleSystem.EmitParams parameter instead, which allows you to override some/all of the emission properties", false)]
	public void Emit(Particle particle)
	{
	}

	[FreeFunction(Name = "ParticleSystemScriptBindings::SetParticles", HasExplicitThis = true, ThrowsException = true)]
	public void SetParticles([Out] Particle[] particles, int size, int offset)
	{
	}

	public void SetParticles([Out] Particle[] particles, int size)
	{
	}

	[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticles", HasExplicitThis = true, ThrowsException = true)]
	public int GetParticles([Out][NotNull("ArgumentNullException")] Particle[] particles, int size, int offset)
	{
		return 0;
	}

	public int GetParticles([Out] Particle[] particles, int size)
	{
		return 0;
	}

	public int GetParticles([Out] Particle[] particles)
	{
		return 0;
	}

	[RequiredByNativeCode]
	public void Emit(int count)
	{
	}

	[NativeName("SyncJobs()->Emit")]
	private void Emit_Internal(int count)
	{
	}

	[NativeName("SyncJobs()->EmitParticlesExternal")]
	public void Emit(EmitParams emitParams, int count)
	{
	}

	[NativeName("SyncJobs()->EmitParticleExternal")]
	private void EmitOld_Internal(ref Particle particle)
	{
	}

	private void Emit_Injected(ref EmitParams emitParams, int count)
	{
	}
}
