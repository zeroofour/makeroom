using Mirror.BouncyCastle.Security;

namespace Mirror.BouncyCastle.Pqc.Crypto.Sike;

internal sealed class SidhCompressed
{
	private readonly SikeEngine engine;

	private static uint t_points;

	internal SidhCompressed(SikeEngine engine)
	{
	}

	internal void init_basis(ulong[] gen, ulong[][] XP, ulong[][] XQ, ulong[][] XR)
	{
	}

	internal void FormatPrivKey_B(byte[] skB)
	{
	}

	internal void random_mod_order_A(byte[] random_digits, SecureRandom random)
	{
	}

	internal void random_mod_order_B(byte[] random_digits, SecureRandom random)
	{
	}

	internal void Ladder3pt_dual(PointProj[] Rs, ulong[] m, uint AliceOrBob, PointProj R, ulong[][] A24)
	{
	}

	internal void Elligator2(ulong[][] a24, uint[] r, uint rIndex, ulong[][] x, byte[] bit, uint bitOffset, uint COMPorDEC)
	{
	}

	internal void make_positive(ulong[][] x)
	{
	}

	internal void BiQuad_affine(ulong[][] a24, ulong[][] x0, ulong[][] x1, PointProj R)
	{
	}

	internal void get_4_isog_dual(PointProj P, ulong[][] A24, ulong[][] C24, ulong[][][] coeff)
	{
	}

	internal void eval_dual_2_isog(ulong[][] X2, ulong[][] Z2, PointProj P)
	{
	}

	internal void eval_final_dual_2_isog(PointProj P)
	{
	}

	internal void eval_dual_4_isog_shared(ulong[][] X4pZ4, ulong[][] X42, ulong[][] Z42, ulong[][][] coeff, uint coeffOffset)
	{
	}

	internal void eval_dual_4_isog(ulong[][] A24, ulong[][] C24, ulong[][][] coeff, uint coeffOffset, PointProj P)
	{
	}

	internal void eval_full_dual_4_isog(ulong[][][][] As, PointProj P)
	{
	}

	internal void TripleAndParabola_proj(PointProjFull R, ulong[][] l1x, ulong[][] l1z)
	{
	}

	internal void Tate3_proj(PointProjFull P, PointProjFull Q, ulong[][] gX, ulong[][] gZ)
	{
	}

	internal void FinalExpo3(ulong[][] gX, ulong[][] gZ)
	{
	}

	internal void FinalExpo3_2way(ulong[][][] gX, ulong[][][] gZ)
	{
	}

	private bool FirstPoint_dual(PointProj P, PointProjFull R, byte[] ind)
	{
		return false;
	}

	private bool SecondPoint_dual(PointProj P, PointProjFull R, byte[] ind)
	{
		return false;
	}

	internal void FirstPoint3n(ulong[][] a24, ulong[][][][] As, ulong[][] x, PointProjFull R, uint[] r, byte[] ind, byte[] bitEll)
	{
	}

	internal void SecondPoint3n(ulong[][] a24, ulong[][][][] As, ulong[][] x, PointProjFull R, uint[] r, byte[] ind, byte[] bitEll)
	{
	}

	internal void makeDiff(PointProjFull R, PointProjFull S, PointProj D)
	{
	}

	internal void BuildOrdinary3nBasis_dual(ulong[][] a24, ulong[][][][] As, PointProjFull[] R, uint[] r, uint[] bitsEll, uint bitsEllOffset)
	{
	}

	internal void FullIsogeny_A_dual(byte[] PrivateKeyA, ulong[][][][] As, ulong[][] a24, uint sike)
	{
	}

	internal void Dlogs3_dual(ulong[][][] f, int[] D, ulong[] d0, ulong[] c0, ulong[] d1, ulong[] c1)
	{
	}

	internal void BuildOrdinary3nBasis_Decomp_dual(ulong[][] A24, PointProj[] Rs, uint[] r, uint[] bitsEll, uint bitsEllIndex)
	{
	}

	internal void PKADecompression_dual(byte[] SecretKeyB, byte[] CompressedPKA, PointProj R, ulong[][] A)
	{
	}

	internal void Compress_PKA_dual(ulong[] d0, ulong[] c0, ulong[] d1, ulong[] c1, ulong[][] a24, uint[] rs, byte[] CompressedPKA)
	{
	}

	internal uint EphemeralKeyGeneration_A_extended(byte[] PrivateKeyA, byte[] CompressedPKA)
	{
		return 0u;
	}

	private uint EphemeralKeyGeneration_A(byte[] PrivateKeyA, byte[] CompressedPKA)
	{
		return 0u;
	}

	internal uint EphemeralSecretAgreement_B(byte[] PrivateKeyB, byte[] PKA, byte[] SharedSecretB)
	{
		return 0u;
	}

	internal void BuildEntangledXonly(ulong[][] A, PointProj[] R, byte[] qnr, byte[] ind)
	{
	}

	internal void RecoverY(ulong[][] A, PointProj[] xs, PointProjFull[] Rs)
	{
	}

	internal void BuildOrdinary2nBasis_dual(ulong[][] A, ulong[][][][] Ds, PointProjFull[] Rs, byte[] qnr, byte[] ind)
	{
	}

	internal void FullIsogeny_B_dual(byte[] PrivateKeyB, ulong[][][][] Ds, ulong[][] A)
	{
	}

	internal void Dlogs2_dual(ulong[][][] f, int[] D, ulong[] d0, ulong[] c0, ulong[] d1, ulong[] c1)
	{
	}

	internal void BuildEntangledXonly_Decomp(ulong[][] A, PointProj[] R, uint qnr, uint ind)
	{
	}

	internal void PKBDecompression_extended(byte[] SecretKeyA, uint SecretKeyAOffset, byte[] CompressedPKB, PointProj R, ulong[][] A, byte[] tphiBKA_t, uint tphiBKA_tOffset)
	{
	}

	internal void Compress_PKB_dual_extended(ulong[] d0, ulong[] c0, ulong[] d1, ulong[] c1, ulong[][] A, byte[] qnr, byte[] ind, byte[] CompressedPKB)
	{
	}

	internal void PKBDecompression(byte[] SecretKeyA, uint SecretKeyAOffset, byte[] CompressedPKB, PointProj R, ulong[][] A)
	{
	}

	internal void Compress_PKB_dual(ulong[] d0, ulong[] c0, ulong[] d1, ulong[] c1, ulong[][] A, byte[] qnr, byte[] ind, byte[] CompressedPKB)
	{
	}

	internal uint EphemeralKeyGeneration_B_extended(byte[] PrivateKeyB, byte[] CompressedPKB, uint sike)
	{
		return 0u;
	}

	internal uint EphemeralKeyGeneration_B(byte[] PrivateKeyB, byte[] CompressedPKB)
	{
		return 0u;
	}

	internal uint EphemeralSecretAgreement_A_extended(byte[] PrivateKeyA, uint PrivateKeyAOffset, byte[] PKB, byte[] SharedSecretA, uint sike)
	{
		return 0u;
	}

	private uint EphemeralSecretAgreement_A(byte[] PrivateKeyA, uint PrivateKeyAOffset, byte[] PKB, byte[] SharedSecretA)
	{
		return 0u;
	}

	internal byte validate_ciphertext(byte[] ephemeralsk_, byte[] CompressedPKB, byte[] xKA, uint xKAOffset, byte[] tphiBKA_t, uint tphiBKA_tOffset)
	{
		return 0;
	}

	internal void solve_dlog(ulong[][] r, int[] D, ulong[] d, uint ell)
	{
	}

	private void from_base(int[] D, ulong[] r, uint Dlen, uint baseNum)
	{
	}

	internal void Traverse_w_notdiv_e_fullsigned(ulong[][] r, uint j, uint k, uint z, uint[] P, ulong[] CT1, ulong[] CT2, int[] D, uint Dlen, uint ell, uint ellw, uint ell_emodw, uint w, uint e)
	{
	}

	internal void Traverse_w_div_e_fullsigned(ulong[][] r, uint j, uint k, uint z, uint[] P, ulong[] CT, int[] D, uint Dlen, uint ellw, uint w)
	{
	}

	private void Tate3_pairings(PointProjFull[] Qj, ulong[][][] f)
	{
	}

	private void final_exponentiation_3_torsion(ulong[][] f, ulong[][] finv, ulong[][] fout)
	{
	}

	private void Tate2_pairings(PointProj P, PointProj Q, PointProjFull[] Qj, ulong[][][] f)
	{
	}

	private void final_exponentiation_2_torsion(ulong[][] f, ulong[][] finv, ulong[][] fout)
	{
	}
}
