using System;

namespace Mirror.BouncyCastle.Asn1.BC;

public abstract class BCObjectIdentifiers
{
	public static readonly DerObjectIdentifier bc;

	public static readonly DerObjectIdentifier bc_pbe;

	public static readonly DerObjectIdentifier bc_pbe_sha1;

	public static readonly DerObjectIdentifier bc_pbe_sha256;

	public static readonly DerObjectIdentifier bc_pbe_sha384;

	public static readonly DerObjectIdentifier bc_pbe_sha512;

	public static readonly DerObjectIdentifier bc_pbe_sha224;

	public static readonly DerObjectIdentifier bc_pbe_sha1_pkcs5;

	public static readonly DerObjectIdentifier bc_pbe_sha1_pkcs12;

	public static readonly DerObjectIdentifier bc_pbe_sha256_pkcs5;

	public static readonly DerObjectIdentifier bc_pbe_sha256_pkcs12;

	public static readonly DerObjectIdentifier bc_pbe_sha1_pkcs12_aes128_cbc;

	public static readonly DerObjectIdentifier bc_pbe_sha1_pkcs12_aes192_cbc;

	public static readonly DerObjectIdentifier bc_pbe_sha1_pkcs12_aes256_cbc;

	public static readonly DerObjectIdentifier bc_pbe_sha256_pkcs12_aes128_cbc;

	public static readonly DerObjectIdentifier bc_pbe_sha256_pkcs12_aes192_cbc;

	public static readonly DerObjectIdentifier bc_pbe_sha256_pkcs12_aes256_cbc;

	public static readonly DerObjectIdentifier bc_sig;

	public static readonly DerObjectIdentifier sphincs256;

	public static readonly DerObjectIdentifier sphincs256_with_BLAKE512;

	public static readonly DerObjectIdentifier sphincs256_with_SHA512;

	public static readonly DerObjectIdentifier sphincs256_with_SHA3_512;

	public static readonly DerObjectIdentifier xmss;

	public static readonly DerObjectIdentifier xmss_SHA256ph;

	public static readonly DerObjectIdentifier xmss_SHA512ph;

	public static readonly DerObjectIdentifier xmss_SHAKE128ph;

	public static readonly DerObjectIdentifier xmss_SHAKE256ph;

	public static readonly DerObjectIdentifier xmss_SHA256;

	public static readonly DerObjectIdentifier xmss_SHA512;

	public static readonly DerObjectIdentifier xmss_SHAKE128;

	public static readonly DerObjectIdentifier xmss_SHAKE256;

	public static readonly DerObjectIdentifier xmss_mt;

	public static readonly DerObjectIdentifier xmss_mt_SHA256ph;

	public static readonly DerObjectIdentifier xmss_mt_SHA512ph;

	public static readonly DerObjectIdentifier xmss_mt_SHAKE128ph;

	public static readonly DerObjectIdentifier xmss_mt_SHAKE256ph;

	public static readonly DerObjectIdentifier xmss_mt_SHA256;

	public static readonly DerObjectIdentifier xmss_mt_SHA512;

	public static readonly DerObjectIdentifier xmss_mt_SHAKE128;

	public static readonly DerObjectIdentifier xmss_mt_SHAKE256;

	[Obsolete("Use 'xmss_SHA256ph' instead")]
	public static readonly DerObjectIdentifier xmss_with_SHA256;

	[Obsolete("Use 'xmss_SHA512ph' instead")]
	public static readonly DerObjectIdentifier xmss_with_SHA512;

	[Obsolete("Use 'xmss_SHAKE128ph' instead")]
	public static readonly DerObjectIdentifier xmss_with_SHAKE128;

	[Obsolete("Use 'xmss_SHAKE256ph' instead")]
	public static readonly DerObjectIdentifier xmss_with_SHAKE256;

	[Obsolete("Use 'xmss_mt_SHA256ph' instead")]
	public static readonly DerObjectIdentifier xmss_mt_with_SHA256;

	[Obsolete("Use 'xmss_mt_SHA512ph' instead")]
	public static readonly DerObjectIdentifier xmss_mt_with_SHA512;

	[Obsolete("Use 'xmss_mt_SHAKE128ph' instead")]
	public static readonly DerObjectIdentifier xmss_mt_with_SHAKE128;

	[Obsolete("Use 'xmss_mt_SHAKE256ph' instead")]
	public static readonly DerObjectIdentifier xmss_mt_with_SHAKE256;

	public static readonly DerObjectIdentifier qTESLA;

	public static readonly DerObjectIdentifier qTESLA_Rnd1_I;

	public static readonly DerObjectIdentifier qTESLA_Rnd1_III_size;

	public static readonly DerObjectIdentifier qTESLA_Rnd1_III_speed;

	public static readonly DerObjectIdentifier qTESLA_Rnd1_p_I;

	public static readonly DerObjectIdentifier qTESLA_Rnd1_p_III;

	public static readonly DerObjectIdentifier qTESLA_p_I;

	public static readonly DerObjectIdentifier qTESLA_p_III;

	public static readonly DerObjectIdentifier sphincsPlus;

	public static readonly DerObjectIdentifier sphincsPlus_sha2_128s_r3;

	public static readonly DerObjectIdentifier sphincsPlus_sha2_128f_r3;

	public static readonly DerObjectIdentifier sphincsPlus_shake_128s_r3;

	public static readonly DerObjectIdentifier sphincsPlus_shake_128f_r3;

	public static readonly DerObjectIdentifier sphincsPlus_haraka_128s_r3;

	public static readonly DerObjectIdentifier sphincsPlus_haraka_128f_r3;

	public static readonly DerObjectIdentifier sphincsPlus_sha2_192s_r3;

	public static readonly DerObjectIdentifier sphincsPlus_sha2_192f_r3;

	public static readonly DerObjectIdentifier sphincsPlus_shake_192s_r3;

	public static readonly DerObjectIdentifier sphincsPlus_shake_192f_r3;

	public static readonly DerObjectIdentifier sphincsPlus_haraka_192s_r3;

	public static readonly DerObjectIdentifier sphincsPlus_haraka_192f_r3;

	public static readonly DerObjectIdentifier sphincsPlus_sha2_256s_r3;

	public static readonly DerObjectIdentifier sphincsPlus_sha2_256f_r3;

	public static readonly DerObjectIdentifier sphincsPlus_shake_256s_r3;

	public static readonly DerObjectIdentifier sphincsPlus_shake_256f_r3;

	public static readonly DerObjectIdentifier sphincsPlus_haraka_256s_r3;

	public static readonly DerObjectIdentifier sphincsPlus_haraka_256f_r3;

	public static readonly DerObjectIdentifier sphincsPlus_sha2_128s_r3_simple;

	public static readonly DerObjectIdentifier sphincsPlus_sha2_128f_r3_simple;

	public static readonly DerObjectIdentifier sphincsPlus_shake_128s_r3_simple;

	public static readonly DerObjectIdentifier sphincsPlus_shake_128f_r3_simple;

	public static readonly DerObjectIdentifier sphincsPlus_haraka_128s_r3_simple;

	public static readonly DerObjectIdentifier sphincsPlus_haraka_128f_r3_simple;

	public static readonly DerObjectIdentifier sphincsPlus_sha2_192s_r3_simple;

	public static readonly DerObjectIdentifier sphincsPlus_sha2_192f_r3_simple;

	public static readonly DerObjectIdentifier sphincsPlus_shake_192s_r3_simple;

	public static readonly DerObjectIdentifier sphincsPlus_shake_192f_r3_simple;

	public static readonly DerObjectIdentifier sphincsPlus_haraka_192s_r3_simple;

	public static readonly DerObjectIdentifier sphincsPlus_haraka_192f_r3_simple;

	public static readonly DerObjectIdentifier sphincsPlus_sha2_256s_r3_simple;

	public static readonly DerObjectIdentifier sphincsPlus_sha2_256f_r3_simple;

	public static readonly DerObjectIdentifier sphincsPlus_shake_256s_r3_simple;

	public static readonly DerObjectIdentifier sphincsPlus_shake_256f_r3_simple;

	public static readonly DerObjectIdentifier sphincsPlus_haraka_256s_r3_simple;

	public static readonly DerObjectIdentifier sphincsPlus_haraka_256f_r3_simple;

	public static readonly DerObjectIdentifier sphincsPlus_interop;

	public static readonly DerObjectIdentifier sphincsPlus_sha2_128f;

	public static readonly DerObjectIdentifier sphincsPlus_sha2_128s;

	public static readonly DerObjectIdentifier sphincsPlus_sha2_192f;

	public static readonly DerObjectIdentifier sphincsPlus_sha2_192s;

	public static readonly DerObjectIdentifier sphincsPlus_sha2_256f;

	public static readonly DerObjectIdentifier sphincsPlus_sha2_256s;

	public static readonly DerObjectIdentifier sphincsPlus_shake_128f;

	public static readonly DerObjectIdentifier sphincsPlus_shake_128s;

	public static readonly DerObjectIdentifier sphincsPlus_shake_192f;

	public static readonly DerObjectIdentifier sphincsPlus_shake_192s;

	public static readonly DerObjectIdentifier sphincsPlus_shake_256f;

	public static readonly DerObjectIdentifier sphincsPlus_shake_256s;

	[Obsolete("Will be removed - name is erroneous")]
	public static readonly DerObjectIdentifier sphincsPlus_shake_256;

	[Obsolete("Will be removed - name is erroneous")]
	public static readonly DerObjectIdentifier sphincsPlus_sha_256;

	[Obsolete("Will be removed - name is erroneous")]
	public static readonly DerObjectIdentifier sphincsPlus_sha_512;

	public static readonly DerObjectIdentifier picnic;

	public static readonly DerObjectIdentifier picnicl1fs;

	public static readonly DerObjectIdentifier picnicl1ur;

	public static readonly DerObjectIdentifier picnicl3fs;

	public static readonly DerObjectIdentifier picnicl3ur;

	public static readonly DerObjectIdentifier picnicl5fs;

	public static readonly DerObjectIdentifier picnicl5ur;

	public static readonly DerObjectIdentifier picnic3l1;

	public static readonly DerObjectIdentifier picnic3l3;

	public static readonly DerObjectIdentifier picnic3l5;

	public static readonly DerObjectIdentifier picnicl1full;

	public static readonly DerObjectIdentifier picnicl3full;

	public static readonly DerObjectIdentifier picnicl5full;

	public static readonly DerObjectIdentifier picnic_signature;

	public static readonly DerObjectIdentifier picnic_with_sha512;

	public static readonly DerObjectIdentifier picnic_with_shake256;

	public static readonly DerObjectIdentifier picnic_with_sha3_512;

	public static readonly DerObjectIdentifier falcon;

	public static readonly DerObjectIdentifier falcon_512;

	public static readonly DerObjectIdentifier falcon_1024;

	public static readonly DerObjectIdentifier dilithium;

	public static readonly DerObjectIdentifier dilithium2;

	public static readonly DerObjectIdentifier dilithium3;

	public static readonly DerObjectIdentifier dilithium5;

	public static readonly DerObjectIdentifier dilithium2_aes;

	public static readonly DerObjectIdentifier dilithium3_aes;

	public static readonly DerObjectIdentifier dilithium5_aes;

	public static readonly DerObjectIdentifier rainbow;

	public static readonly DerObjectIdentifier rainbow_III_classic;

	public static readonly DerObjectIdentifier rainbow_III_circumzenithal;

	public static readonly DerObjectIdentifier rainbow_III_compressed;

	public static readonly DerObjectIdentifier rainbow_V_classic;

	public static readonly DerObjectIdentifier rainbow_V_circumzenithal;

	public static readonly DerObjectIdentifier rainbow_V_compressed;

	public static readonly DerObjectIdentifier bc_exch;

	public static readonly DerObjectIdentifier newHope;

	public static readonly DerObjectIdentifier bc_ext;

	public static readonly DerObjectIdentifier linkedCertificate;

	public static readonly DerObjectIdentifier external_value;

	public static readonly DerObjectIdentifier bc_kem;

	public static readonly DerObjectIdentifier pqc_kem_mceliece;

	public static readonly DerObjectIdentifier mceliece348864_r3;

	public static readonly DerObjectIdentifier mceliece348864f_r3;

	public static readonly DerObjectIdentifier mceliece460896_r3;

	public static readonly DerObjectIdentifier mceliece460896f_r3;

	public static readonly DerObjectIdentifier mceliece6688128_r3;

	public static readonly DerObjectIdentifier mceliece6688128f_r3;

	public static readonly DerObjectIdentifier mceliece6960119_r3;

	public static readonly DerObjectIdentifier mceliece6960119f_r3;

	public static readonly DerObjectIdentifier mceliece8192128_r3;

	public static readonly DerObjectIdentifier mceliece8192128f_r3;

	public static readonly DerObjectIdentifier pqc_kem_frodo;

	public static readonly DerObjectIdentifier frodokem640aes;

	public static readonly DerObjectIdentifier frodokem640shake;

	public static readonly DerObjectIdentifier frodokem976aes;

	public static readonly DerObjectIdentifier frodokem976shake;

	public static readonly DerObjectIdentifier frodokem1344aes;

	public static readonly DerObjectIdentifier frodokem1344shake;

	public static readonly DerObjectIdentifier pqc_kem_saber;

	public static readonly DerObjectIdentifier lightsaberkem128r3;

	public static readonly DerObjectIdentifier saberkem128r3;

	public static readonly DerObjectIdentifier firesaberkem128r3;

	public static readonly DerObjectIdentifier lightsaberkem192r3;

	public static readonly DerObjectIdentifier saberkem192r3;

	public static readonly DerObjectIdentifier firesaberkem192r3;

	public static readonly DerObjectIdentifier lightsaberkem256r3;

	public static readonly DerObjectIdentifier saberkem256r3;

	public static readonly DerObjectIdentifier firesaberkem256r3;

	public static readonly DerObjectIdentifier ulightsaberkemr3;

	public static readonly DerObjectIdentifier usaberkemr3;

	public static readonly DerObjectIdentifier ufiresaberkemr3;

	public static readonly DerObjectIdentifier lightsaberkem90sr3;

	public static readonly DerObjectIdentifier saberkem90sr3;

	public static readonly DerObjectIdentifier firesaberkem90sr3;

	public static readonly DerObjectIdentifier ulightsaberkem90sr3;

	public static readonly DerObjectIdentifier usaberkem90sr3;

	public static readonly DerObjectIdentifier ufiresaberkem90sr3;

	public static readonly DerObjectIdentifier pqc_kem_sike;

	public static readonly DerObjectIdentifier sikep434;

	public static readonly DerObjectIdentifier sikep503;

	public static readonly DerObjectIdentifier sikep610;

	public static readonly DerObjectIdentifier sikep751;

	public static readonly DerObjectIdentifier sikep434_compressed;

	public static readonly DerObjectIdentifier sikep503_compressed;

	public static readonly DerObjectIdentifier sikep610_compressed;

	public static readonly DerObjectIdentifier sikep751_compressed;

	public static readonly DerObjectIdentifier pqc_kem_ntru;

	public static readonly DerObjectIdentifier ntruhps2048509;

	public static readonly DerObjectIdentifier ntruhps2048677;

	public static readonly DerObjectIdentifier ntruhps4096821;

	public static readonly DerObjectIdentifier ntruhrss701;

	public static readonly DerObjectIdentifier pqc_kem_kyber;

	public static readonly DerObjectIdentifier kyber512;

	public static readonly DerObjectIdentifier kyber768;

	public static readonly DerObjectIdentifier kyber1024;

	public static readonly DerObjectIdentifier kyber512_aes;

	public static readonly DerObjectIdentifier kyber768_aes;

	public static readonly DerObjectIdentifier kyber1024_aes;

	public static readonly DerObjectIdentifier pqc_kem_ntruprime;

	public static readonly DerObjectIdentifier pqc_kem_ntrulprime;

	public static readonly DerObjectIdentifier ntrulpr653;

	public static readonly DerObjectIdentifier ntrulpr761;

	public static readonly DerObjectIdentifier ntrulpr857;

	public static readonly DerObjectIdentifier ntrulpr953;

	public static readonly DerObjectIdentifier ntrulpr1013;

	public static readonly DerObjectIdentifier ntrulpr1277;

	public static readonly DerObjectIdentifier pqc_kem_sntruprime;

	public static readonly DerObjectIdentifier sntrup653;

	public static readonly DerObjectIdentifier sntrup761;

	public static readonly DerObjectIdentifier sntrup857;

	public static readonly DerObjectIdentifier sntrup953;

	public static readonly DerObjectIdentifier sntrup1013;

	public static readonly DerObjectIdentifier sntrup1277;

	public static readonly DerObjectIdentifier pqc_kem_bike;

	public static readonly DerObjectIdentifier bike128;

	public static readonly DerObjectIdentifier bike192;

	public static readonly DerObjectIdentifier bike256;

	public static readonly DerObjectIdentifier pqc_kem_hqc;

	public static readonly DerObjectIdentifier hqc128;

	public static readonly DerObjectIdentifier hqc192;

	public static readonly DerObjectIdentifier hqc256;
}
