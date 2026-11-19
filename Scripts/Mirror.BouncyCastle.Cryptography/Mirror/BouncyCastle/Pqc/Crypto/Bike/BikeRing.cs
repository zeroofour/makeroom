using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Mirror.BouncyCastle.Pqc.Crypto.Bike;

internal sealed class BikeRing
{
	[CompilerGenerated]
	private sealed class _003CEnumerateSquarePowersInv_003Ed__27 : IEnumerable<int>, IEnumerable, IEnumerator<int>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private int _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private int r;

		public int _003C_003E3__r;

		private int _003CrSub2_003E5__2;

		private int _003Cbits_003E5__3;

		private int _003Ci_003E5__4;

		int IEnumerator<int>.Current
		{
			[DebuggerHidden]
			get
			{
				return 0;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CEnumerateSquarePowersInv_003Ed__27(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[DebuggerHidden]
		IEnumerator<int> IEnumerable<int>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	private const int PermutationCutoff = 64;

	private readonly int m_bits;

	private readonly int m_size;

	private readonly int m_sizeExt;

	private readonly Dictionary<int, int> m_halfPowers;

	internal int Size => 0;

	internal int SizeExt => 0;

	internal BikeRing(int r)
	{
	}

	internal void Add(ulong[] x, ulong[] y, ulong[] z)
	{
	}

	internal void AddTo(ulong[] x, ulong[] z)
	{
	}

	internal void Copy(ulong[] x, ulong[] z)
	{
	}

	internal ulong[] Create()
	{
		return null;
	}

	internal ulong[] CreateExt()
	{
		return null;
	}

	internal void DecodeBytes(byte[] bs, ulong[] z)
	{
	}

	internal byte[] EncodeBitsTransposed(ulong[] x)
	{
		return null;
	}

	internal void EncodeBytes(ulong[] x, byte[] bs)
	{
	}

	internal void Inv(ulong[] a, ulong[] z)
	{
	}

	internal void Multiply(ulong[] x, ulong[] y, ulong[] z)
	{
	}

	internal void Multiply(ulong[] x, int xOff, ulong[] y, int yOff, ulong[] z)
	{
	}

	internal void Reduce(ulong[] tt, ulong[] z)
	{
	}

	internal void Square(ulong[] x, ulong[] z)
	{
	}

	internal void SquareN(ulong[] x, int n, ulong[] z)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static int ImplModAdd(int m, int x, int y)
	{
		return 0;
	}

	private void ImplMultiplyAcc(ulong[] x, int xOff, ulong[] y, int yOff, ulong[] zz)
	{
	}

	private void ImplPermute(ulong[] x, int n, ulong[] z)
	{
	}

	[IteratorStateMachine(typeof(_003CEnumerateSquarePowersInv_003Ed__27))]
	private static IEnumerable<int> EnumerateSquarePowersInv(int r)
	{
		return null;
	}

	private static int GenerateHalfPower(uint r, uint r32, int n)
	{
		return 0;
	}

	private static void ImplMulwAcc(ulong[] u, ulong x, ulong y, ulong[] z, int zOff)
	{
	}

	private void ImplSquare(ulong[] x, ulong[] zz)
	{
	}
}
