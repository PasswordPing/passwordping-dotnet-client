﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnzoicClient.Enums
{
    /**
     * Specifies a hash algorithm for a password 
     */
    public enum PasswordType
    {
        Plaintext = 0,
        MD5 = 1,
        SHA1 = 2,
        SHA256 = 3,
        TripleDES = 4,
        IPBoard_MyBB = 5,
        vBulletinPre3_8_5 = 6,
        vBulletinPost3_8_5 = 7,
        BCrypt = 8,
        CRC32 = 9,
        PHPBB3 = 10,
        CustomAlgorithm1 = 11,  
        SCrypt = 12,
        CustomAlgorithm2 = 13, 
        SHA512 = 14,
        CustomAlgorithm3 = 15,
        MD5Crypt = 16,
        CustomAlgorithm4 = 17,
        CustomAlgorithm5 = 18,
        osCommerce_AEF = 19,
        DESCrypt = 20,
        MySQLPre4_1 = 21,
        MySQLPost4_1 = 22,
        PeopleSoft = 23,
        PunBB = 24,
        CustomAlgorithm6 = 25,
        PartialMD5_20 = 26,
        AVE_DataLife_Diferior = 27,
        DjangoMD5 = 28,
        DjangoSHA1 = 29,
        PartialMD5_29 = 30,
        PliggCMS = 31,
        RunCMS_SMF1_1 = 32,
        NTLM = 33,
        SHA1Dash = 34, 
        SHA384 = 35,
        CustomAlgorithm7 = 36, 
        CustomAlgorithm8 = 37, 
        CustomAlgorithm9 = 38, 
        Unknown = 97,
        UnusablePassword = 98,
        None = 99
    }
}
