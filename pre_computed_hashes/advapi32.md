The following is table of pre-computed ROR-13 hashes for all advapi32.dll Win32 APIs. The Win32 APIs list was generated using the below command.

```
dumpbin.exe /exports c:\windows\system32\advapi32.dll
```

| hashes     | ordinal | hint | name
|------------|:-------:|:----:|---------------------------------------------------------------        
| 0xB52E8E6D |    1002 |    0 | A_SHAFinal (forwarded to NTDLL.A_SHAFinal)
| 0xD79837F8 |    1003 |    1 | A_SHAInit (forwarded to NTDLL.A_SHAInit)
| 0xDFAE19E0 |    1004 |    2 | A_SHAUpdate (forwarded to NTDLL.A_SHAUpdate)
| 0x4CA9AC0C |    1005 |    3 | AbortSystemShutdownA
| 0x4CA9AC22 |    1006 |    4 | AbortSystemShutdownW
| 0xF7EB6E95 |    1007 |    5 | AccessCheck
| 0xBA44F0D2 |    1008 |    6 | AccessCheckAndAuditAlarmA
| 0xBA44F0E8 |    1009 |    7 | AccessCheckAndAuditAlarmW
| 0x65DF8E74 |    1010 |    8 | AccessCheckByType
| 0x8AC46A8A |    1011 |    9 | AccessCheckByTypeAndAuditAlarmA
| 0x8AC46AA0 |    1012 |    A | AccessCheckByTypeAndAuditAlarmW
| 0x1BEDDCE8 |    1013 |    B | AccessCheckByTypeResultList
| 0xC3FE3962 |    1014 |    C | AccessCheckByTypeResultListAndAuditAlarmA
| 0xB01308CB |    1015 |    D | AccessCheckByTypeResultListAndAuditAlarmByHandleA
| 0xB01308E1 |    1016 |    E | AccessCheckByTypeResultListAndAuditAlarmByHandleW
| 0xC3FE3978 |    1017 |    F | AccessCheckByTypeResultListAndAuditAlarmW
| 0xDBE80BF6 |    1018 |   10 | AddAccessAllowedAce
| 0xFC2AFE2E |    1019 |   11 | AddAccessAllowedAceEx
| 0xA90DB058 |    1020 |   12 | AddAccessAllowedObjectAce
| 0x38911DC  |    1021 |   13 | AddAccessDeniedAce
| 0xE46C7778 |    1022 |   14 | AddAccessDeniedAceEx
| 0xC0A24EDC |    1023 |   15 | AddAccessDeniedObjectAce
| 0x4B1E50C6 |    1024 |   16 | AddAce
| 0x8D3984AF |    1025 |   17 | AddAuditAccessAce
| 0x50892C5B |    1026 |   18 | AddAuditAccessAceEx
| 0x8BF0759E |    1027 |   19 | AddAuditAccessObjectAce
| 0xF37C0D12 |    1028 |   1A | AddConditionalAce
| 0x4D8DB756 |    1029 |   1B | AddMandatoryAce (forwarded to KERNELBASE.AddMandatoryAce)
| 0x3FFBFB82 |    1030 |   1C | AddUsersToEncryptedFile
| 0x126E108  |    1031 |   1D | AddUsersToEncryptedFileEx
| 0x89ED71C9 |    1032 |   1E | AdjustTokenGroups
| 0x24488A0F |    1033 |   1F | AdjustTokenPrivileges
| 0x5BDCE983 |    1034 |   20 | AllocateAndInitializeSid
| 0x98B8ACE4 |    1035 |   21 | AllocateLocallyUniqueId
| 0xE145C464 |    1036 |   22 | AreAllAccessesGranted
| 0x8147C466 |    1037 |   23 | AreAnyAccessesGranted
| 0x42F0A0FA |    1038 |   24 | AuditComputeEffectivePolicyBySid
| 0xCB5050BE |    1039 |   25 | AuditComputeEffectivePolicyByToken
| 0x8DB6B8E9 |    1040 |   26 | AuditEnumerateCategories
| 0xD43BA7AD |    1041 |   27 | AuditEnumeratePerUserPolicy
| 0x4E3719BF |    1042 |   28 | AuditEnumerateSubCategories
| 0x51BF6BBA |    1043 |   29 | AuditFree
| 0x32507757 |    1044 |   2A | AuditLookupCategoryGuidFromCategoryId
| 0x1591D475 |    1045 |   2B | AuditLookupCategoryIdFromCategoryGuid
| 0xF27DF74B |    1046 |   2C | AuditLookupCategoryNameA
| 0xF27DF761 |    1047 |   2D | AuditLookupCategoryNameW
| 0x439179   |    1048 |   2E | AuditLookupSubCategoryNameA
| 0x43918F   |    1049 |   2F | AuditLookupSubCategoryNameW
| 0x72D57E00 |    1050 |   30 | AuditQueryGlobalSaclA
| 0x72D57E16 |    1051 |   31 | AuditQueryGlobalSaclW
| 0xAE5E23E  |    1052 |   32 | AuditQueryPerUserPolicy
| 0xDD9FB089 |    1053 |   33 | AuditQuerySecurity
| 0xD53096E6 |    1054 |   34 | AuditQuerySystemPolicy
| 0x50FA8F8F |    1055 |   35 | AuditSetGlobalSaclA
| 0x50FA8FA5 |    1056 |   36 | AuditSetGlobalSaclW
| 0x942A45F5 |    1057 |   37 | AuditSetPerUserPolicy
| 0xF02877F8 |    1058 |   38 | AuditSetSecurity
| 0x61A7880F |    1059 |   39 | AuditSetSystemPolicy
| 0x532DF946 |    1060 |   3A | BackupEventLogA
| 0x532DF95C |    1061 |   3B | BackupEventLogW
| 0x672D8316 |    1062 |   3C | BaseRegCloseKey
| 0x4BEC241C |    1063 |   3D | BaseRegCreateKey
| 0x4430A00B |    1064 |   3E | BaseRegDeleteKeyEx
| 0x3DB14CB8 |    1065 |   3F | BaseRegDeleteValue
| 0x6D2D8379 |    1066 |   40 | BaseRegFlushKey
| 0xE36752A7 |    1067 |   41 | BaseRegGetVersion
| 0x1346C67B |    1068 |   42 | BaseRegLoadKey
| 0xA753067B |    1069 |   43 | BaseRegOpenKey
| 0xC78FA317 |    1070 |   44 | BaseRegRestoreKey
| 0x5B2D9D7D |    1071 |   45 | BaseRegSaveKeyEx
| 0xA9BB04E7 |    1072 |   46 | BaseRegSetKeySecurity
| 0xDF8FBD44 |    1073 |   47 | BaseRegSetValue
| 0x5B86F3A3 |    1074 |   48 | BaseRegUnLoadKey
| 0xFFCF33EB |    1075 |   49 | BuildExplicitAccessWithNameA
| 0xFFCF3401 |    1076 |   4A | BuildExplicitAccessWithNameW
| 0xB6825EEF |    1077 |   4B | BuildImpersonateExplicitAccessWithNameA
| 0xB6825F05 |    1078 |   4C | BuildImpersonateExplicitAccessWithNameW
| 0xC77E1094 |    1079 |   4D | BuildImpersonateTrusteeA
| 0xC77E10AA |    1080 |   4E | BuildImpersonateTrusteeW
| 0x936E6CF9 |    1081 |   4F | BuildSecurityDescriptorA
| 0x936E6D0F |    1082 |   50 | BuildSecurityDescriptorW
| 0x540EED8E |    1083 |   51 | BuildTrusteeWithNameA
| 0x540EEDA4 |    1084 |   52 | BuildTrusteeWithNameW
| 0x4F6C6310 |    1085 |   53 | BuildTrusteeWithObjectsAndNameA
| 0x4F6C6326 |    1086 |   54 | BuildTrusteeWithObjectsAndNameW
| 0x9611EBC9 |    1087 |   55 | BuildTrusteeWithObjectsAndSidA
| 0x9611EBDF |    1088 |   56 | BuildTrusteeWithObjectsAndSidW
| 0xE761AC5D |    1089 |   57 | BuildTrusteeWithSidA
| 0xE761AC73 |    1090 |   58 | BuildTrusteeWithSidW
| 0x37DA14E5 |    1091 |   59 | CancelOverlappedAccess
| 0x966AC154 |    1092 |   5A | ChangeServiceConfig2A
| 0x966AC16A |    1093 |   5B | ChangeServiceConfig2W
| 0x582272DC |    1094 |   5C | ChangeServiceConfigA
| 0x582272F2 |    1095 |   5D | ChangeServiceConfigW
| 0x835B7460 |    1096 |   5E | CheckForHiberboot
| 0x2889045  |    1097 |   5F | CheckTokenMembership
| 0x442101D1 |    1098 |   60 | ClearEventLogA
| 0x442101E7 |    1099 |   61 | ClearEventLogW
| 0x17479322 |    1100 |   62 | CloseCodeAuthzLevel
| 0xD1C41C8D |    1101 |   63 | CloseEncryptedFileRaw
| 0x93329886 |    1102 |   64 | CloseEventLog
| 0xDDB5B95C |    1103 |   65 | CloseServiceHandle
| 0xF11603AC |    1104 |   66 | CloseThreadWaitChainSession
| 0xD4EB7EB8 |    1105 |   67 | CloseTrace
| 0x51A9A173 |    1106 |   68 | CommandLineFromMsiDescriptor
| 0xE6431FC3 |    1107 |   69 | ComputeAccessTokenFromCodeAuthzLevel
| 0x1CADF66  |    1108 |   6A | ControlService
| 0xCFC3A73F |    1109 |   6B | ControlServiceExA
| 0xCFC3A755 |    1110 |   6C | ControlServiceExW
| 0xB9C0EB57 |    1111 |   6D | ControlTraceA
| 0xB9C0EB6D |    1112 |   6E | ControlTraceW
| 0x112A19CC |    1113 |   6F | ConvertAccessToSecurityDescriptorA
| 0x112A19E2 |    1114 |   70 | ConvertAccessToSecurityDescriptorW
| 0x8F65599A |    1115 |   71 | ConvertSDToStringSDDomainW
| 0x1C7725DC |    1116 |   72 | ConvertSDToStringSDRootDomainA
| 0x1C7725F2 |    1117 |   73 | ConvertSDToStringSDRootDomainW
| 0x61B3480F |    1118 |   74 | ConvertSecurityDescriptorToAccessA
| 0xDFFCD90  |    1119 |   75 | ConvertSecurityDescriptorToAccessNamedA
| 0xDFFCDA6  |    1120 |   76 | ConvertSecurityDescriptorToAccessNamedW
| 0x61B34825 |    1121 |   77 | ConvertSecurityDescriptorToAccessW
| 0x70B38A2C |    1122 |   78 | ConvertSecurityDescriptorToStringSecurityDescriptorA
| 0x70B38A42 |    1123 |   79 | ConvertSecurityDescriptorToStringSecurityDescriptorW
| 0xA20AE292 |    1124 |   7A | ConvertSidToStringSidA
| 0xA20AE2A8 |    1125 |   7B | ConvertSidToStringSidW
| 0x48BA050D |    1126 |   7C | ConvertStringSDToSDDomainA
| 0x48BA0523 |    1127 |   7D | ConvertStringSDToSDDomainW
| 0x672FB171 |    1128 |   7E | ConvertStringSDToSDRootDomainA
| 0x672FB187 |    1129 |   7F | ConvertStringSDToSDRootDomainW
| 0xCCCD3EFB |    1130 |   80 | ConvertStringSecurityDescriptorToSecurityDescriptorA
| 0xCCCD3F11 |    1131 |   81 | ConvertStringSecurityDescriptorToSecurityDescriptorW
| 0x46A20245 |    1132 |   82 | ConvertStringSidToSidA
| 0x46A2025B |    1133 |   83 | ConvertStringSidToSidW
| 0x3522CC0F |    1134 |   84 | ConvertToAutoInheritPrivateObjectSecurity
| 0x765B155C |    1135 |   85 | CopySid
| 0x42FA18EA |    1136 |   86 | CreateCodeAuthzLevel
| 0x7C99B61C |    1137 |   87 | CreatePrivateObjectSecurity
| 0x28958797 |    1138 |   88 | CreatePrivateObjectSecurityEx
| 0xBF276BDD |    1139 |   89 | CreatePrivateObjectSecurityWithMultipleInheritance
| 0x635DC48B |    1140 |   8A | CreateProcessAsUserA
| 0x635DC4A1 |    1141 |   8B | CreateProcessAsUserW
| 0xDC0B5B73 |    1142 |   8C | CreateProcessWithLogonW
| 0xE40B58F7 |    1143 |   8D | CreateProcessWithTokenW
| 0xE2E2E846 |    1144 |   8E | CreateRestrictedToken
| 0x9E112AD3 |    1145 |   8F | CreateServiceA
| 0x56BCF101 |    1146 |   90 | CreateServiceEx
| 0x9E112AE9 |    1147 |   91 | CreateServiceW
| 0x1B9D8D78 |    1148 |   92 | CreateTraceInstanceId (forwarded to ntdll.EtwCreateTraceInstanceId)
| 0xE82C7B4A |    1149 |   93 | CreateWellKnownSid
| 0x9BE36FFC |    1150 |   94 | CredBackupCredentials
| 0x73427A05 |    1151 |   95 | CredDeleteA
| 0x73427A1B |    1152 |   96 | CredDeleteW
| 0x38F0FBDB |    1153 |   97 | CredEncryptAndMarshalBinaryBlob
| 0xD72F7B4D |    1154 |   98 | CredEnumerateA
| 0xD72F7B63 |    1155 |   99 | CredEnumerateW
| 0x118FD0E1 |    1156 |   9A | CredFindBestCredentialA
| 0x118FD0F7 |    1157 |   9B | CredFindBestCredentialW
| 0x10F66578 |    1158 |   9C | CredFree
| 0x6E3928C1 |    1159 |   9D | CredGetSessionTypes
| 0x17EF5766 |    1160 |   9E | CredGetTargetInfoA
| 0x17EF577C |    1161 |   9F | CredGetTargetInfoW
| 0xA04110D0 |    1162 |   A0 | CredIsMarshaledCredentialA
| 0xA04110E6 |    1163 |   A1 | CredIsMarshaledCredentialW
| 0x320CA5FA |    1164 |   A2 | CredIsProtectedA
| 0x320CA610 |    1165 |   A3 | CredIsProtectedW
| 0xAA5C13D7 |    1166 |   A4 | CredMarshalCredentialA
| 0xAA5C13ED |    1167 |   A5 | CredMarshalCredentialW
| 0x62EEE035 |    1168 |   A6 | CredProfileLoaded
| 0xBDE00DD0 |    1169 |   A7 | CredProfileLoadedEx
| 0x36DCBEE2 |    1170 |   A8 | CredProfileUnloaded
| 0x33F88B56 |    1171 |   A9 | CredProtectA
| 0x33F88B6C |    1172 |   AA | CredProtectW
| 0x11B946F4 |    1173 |   AB | CredReadA
| 0x68A81D90 |    1174 |   AC | CredReadByTokenHandle
| 0xE9AA2DF  |    1175 |   AD | CredReadDomainCredentialsA
| 0xE9AA2F5  |    1176 |   AE | CredReadDomainCredentialsW
| 0x11B9470A |    1177 |   AF | CredReadW
| 0x6B7A9845 |    1178 |   B0 | CredRenameA
| 0x6B7A985B |    1179 |   B1 | CredRenameW
| 0xCDD21941 |    1180 |   B2 | CredRestoreCredentials
| 0xD54CF69E |    1181 |   B3 | CredUnmarshalCredentialA
| 0xD54CF6B4 |    1182 |   B4 | CredUnmarshalCredentialW
| 0xDFBC1672 |    1183 |   B5 | CredUnprotectA
| 0xDFBC1688 |    1184 |   B6 | CredUnprotectW
| 0xC8C1620D |    1185 |   B7 | CredWriteA
| 0xC6DB7BAC |    1186 |   B8 | CredWriteDomainCredentialsA
| 0xC6DB7BC2 |    1187 |   B9 | CredWriteDomainCredentialsW
| 0xC8C16223 |    1188 |   BA | CredWriteW
| 0x33EC2B82 |    1189 |   BB | CredpConvertCredential
| 0x257A2CE8 |    1190 |   BC | CredpConvertOneCredentialSize
| 0xCD211664 |    1191 |   BD | CredpConvertTargetInfo
| 0x1A9BA1B6 |    1192 |   BE | CredpDecodeCredential
| 0x3A9BC5B6 |    1193 |   BF | CredpEncodeCredential
| 0xAC942CC8 |    1194 |   C0 | CredpEncodeSecret
| 0x43C28BDA |    1195 |   C1 | CryptAcquireContextA
| 0x43C28BF0 |    1196 |   C2 | CryptAcquireContextW
| 0x8D53CA7A |    1197 |   C3 | CryptContextAddRef
| 0x4105A130 |    1198 |   C4 | CryptCreateHash
| 0x59202584 |    1199 |   C5 | CryptDecrypt
| 0xB56D274A |    1200 |   C6 | CryptDeriveKey
| 0x25D4AE7A |    1201 |   C7 | CryptDestroyHash
| 0x95E24580 |    1202 |   C8 | CryptDestroyKey
| 0x59839BC6 |    1203 |   C9 | CryptDuplicateHash
| 0x738BCBF6 |    1204 |   CA | CryptDuplicateKey
| 0xD9242588 |    1205 |   CB | CryptEncrypt
| 0x3FF29CD4 |    1206 |   CC | CryptEnumProviderTypesA
| 0x3FF29CEA |    1207 |   CD | CryptEnumProviderTypesW
| 0x361DC570 |    1208 |   CE | CryptEnumProvidersA
| 0x361DC586 |    1209 |   CF | CryptEnumProvidersW
| 0xD464E9AD |    1210 |   D0 | CryptExportKey
| 0x9A02016E |    1211 |   D1 | CryptGenKey
| 0x4AABDD73 |    1212 |   D2 | CryptGenRandom
| 0xEC135F27 |    1213 |   D3 | CryptGetDefaultProviderA
| 0xEC135F3D |    1214 |   D4 | CryptGetDefaultProviderW
| 0xC7AFB4A9 |    1215 |   D5 | CryptGetHashParam
| 0x180E1DA5 |    1216 |   D6 | CryptGetKeyParam
| 0xCF9FB6D0 |    1217 |   D7 | CryptGetProvParam
| 0x765BDA1  |    1218 |   D8 | CryptGetUserKey
| 0xC2122629 |    1219 |   D9 | CryptHashData
| 0xFC1E8396 |    1220 |   DA | CryptHashSessionKey
| 0xD864E84D |    1221 |   DB | CryptImportKey
| 0x5AE8E894 |    1222 |   DC | CryptReleaseContext
| 0xC7C7B4A9 |    1223 |   DD | CryptSetHashParam
| 0x180E1DA8 |    1224 |   DE | CryptSetKeyParam
| 0xCFB7B6D0 |    1225 |   DF | CryptSetProvParam
| 0xD6414364 |    1226 |   E0 | CryptSetProviderA
| 0x9410DA76 |    1227 |   E1 | CryptSetProviderExA
| 0x9410DA8C |    1228 |   E2 | CryptSetProviderExW
| 0xD641437A |    1229 |   E3 | CryptSetProviderW
| 0x3C565195 |    1230 |   E4 | CryptSignHashA
| 0x3C5651AB |    1231 |   E5 | CryptSignHashW
| 0x606C8410 |    1232 |   E6 | CryptVerifySignatureA
| 0x606C8426 |    1233 |   E7 | CryptVerifySignatureW
| 0xA04BC3C9 |    1234 |   E8 | CveEventWrite (forwarded to KERNELBASE.CveEventWrite)
| 0x8977A2B5 |    1235 |   E9 | DecryptFileA
| 0x8977A2CB |    1236 |   EA | DecryptFileW
| 0x92CF5D78 |    1237 |   EB | DeleteAce
| 0xE53873D3 |    1238 |   EC | DeleteService
| 0xCBC06A6A |    1239 |   ED | DeregisterEventSource
| 0x86CC4590 |    1240 |   EE | DestroyPrivateObjectSecurity
| 0xBBFE36F5 |    1241 |   EF | DuplicateEncryptionInfoFile
| 0xE8E0B6EC |    1242 |   F0 | DuplicateToken
| 0x3A55BBB2 |    1243 |   F1 | DuplicateTokenEx
| 0x74E01C7B |    1244 |   F2 | ElfBackupEventLogFileA
| 0x74E01C91 |    1245 |   F3 | ElfBackupEventLogFileW
| 0x91553A3B |    1246 |   F4 | ElfChangeNotify
| 0x4EC65788 |    1247 |   F5 | ElfClearEventLogFileA
| 0x4EC6579E |    1248 |   F6 | ElfClearEventLogFileW
| 0x6634488F |    1249 |   F7 | ElfCloseEventLog
| 0xD4936C1A |    1250 |   F8 | ElfDeregisterEventSource
| 0xE93448C0 |    1251 |   F9 | ElfFlushEventLog
| 0xED232B04 |    1252 |   FA | ElfNumberOfRecords
| 0x6708B529 |    1253 |   FB | ElfOldestRecord
| 0xE77648DA |    1254 |   FC | ElfOpenBackupEventLogA
| 0xE77648F0 |    1255 |   FD | ElfOpenBackupEventLogW
| 0xF5B8900A |    1256 |   FE | ElfOpenEventLogA
| 0xF5B89020 |    1257 |   FF | ElfOpenEventLogW
| 0xF5A24039 |    1258 |  100 | ElfReadEventLogA
| 0xF5A2404F |    1259 |  101 | ElfReadEventLogW
| 0x636A1F58 |    1260 |  102 | ElfRegisterEventSourceA
| 0x636A1F6E |    1261 |  103 | ElfRegisterEventSourceW
| 0x3520249E |    1262 |  104 | ElfReportEventA
| 0xD7A06778 |    1263 |  105 | ElfReportEventAndSourceW
| 0x352024B4 |    1264 |  106 | ElfReportEventW
| 0x9D0D52A  |    1265 |  107 | EnableTrace
| 0x765D4AFA |    1266 |  108 | EnableTraceEx
| 0x57D3B31C |    1267 |  109 | EnableTraceEx2
| 0xC979A2B7 |    1268 |  10A | EncryptFileA
| 0xC979A2CD |    1269 |  10B | EncryptFileW
| 0x7923544B |    1270 |  10C | EncryptedFileKeyInfo
| 0xAFA13295 |    1271 |  10D | EncryptionDisable
| 0xD1FE5CED |    1272 |  10E | EnumDependentServicesA
| 0xD1FE5D03 |    1273 |  10F | EnumDependentServicesW
| 0xC5F53F03 |    1274 |  110 | EnumDynamicTimeZoneInformation
| 0x43AFD376 |    1275 |  111 | EnumServiceGroupW
| 0x770FAAD4 |    1276 |  112 | EnumServicesStatusA
| 0xC7AAB65E |    1277 |  113 | EnumServicesStatusExA
| 0xC7AAB674 |    1278 |  114 | EnumServicesStatusExW
| 0x770FAAEA |    1279 |  115 | EnumServicesStatusW
| 0xC51D4AE  |    1280 |  116 | EnumerateTraceGuids
| 0x169D2BFB |    1281 |  117 | EnumerateTraceGuidsEx
| 0x8701A5E  |    1282 |  118 | EqualDomainSid
| 0xA8501AC0 |    1283 |  119 | EqualPrefixSid
| 0x5D122DFF |    1284 |  11A | EqualSid
| 0x7ACBF1E2 |    1285 |  11B | EventAccessControl
| 0xE5CE2D8C |    1286 |  11C | EventAccessQuery
| 0xFC4E2E16 |    1287 |  11D | EventAccessRemove
| 0xC6C6F6D5 |    1288 |  11E | EventActivityIdControl (forwarded to ntdll.EtwEventActivityIdControl)
| 0xB6CF6239 |    1289 |  11F | EventEnabled (forwarded to ntdll.EtwEventEnabled)
| 0x45212E1D |    1290 |  120 | EventProviderEnabled (forwarded to ntdll.EtwEventProviderEnabled)
| 0x1FB22C50 |    1291 |  121 | EventRegister (forwarded to ntdll.EtwEventRegister)
| 0xF5882E6  |    1292 |  122 | EventSetInformation (forwarded to ntdll.EtwEventSetInformation)
| 0x14A27E54 |    1293 |  123 | EventUnregister (forwarded to ntdll.EtwEventUnregister)
| 0x5F5FBF80 |    1294 |  124 | EventWrite (forwarded to ntdll.EtwEventWrite)
| 0x69DF3653 |    1295 |  125 | EventWriteEndScenario (forwarded to ntdll.EtwEventWriteEndScenario)
| 0xDA17E08F |    1296 |  126 | EventWriteEx (forwarded to ntdll.EtwEventWriteEx)
| 0xBBF64CAA |    1297 |  127 | EventWriteStartScenario (forwarded to ntdll.EtwEventWriteStartScenario)
| 0x6578D850 |    1298 |  128 | EventWriteString (forwarded to ntdll.EtwEventWriteString)
| 0xEB566462 |    1299 |  129 | EventWriteTransfer (forwarded to ntdll.EtwEventWriteTransfer)
| 0xD114EC63 |    1300 |  12A | FileEncryptionStatusA
| 0xD114EC79 |    1301 |  12B | FileEncryptionStatusW
| 0x78C7A9C2 |    1302 |  12C | FindFirstFreeAce
| 0xEFB7EE7C |    1303 |  12D | FlushEfsCache
| 0xBBD2A79D |    1304 |  12E | FlushTraceA
| 0xBBD2A7B3 |    1305 |  12F | FlushTraceW
| 0xD215D619 |    1306 |  130 | FreeEncryptedFileKeyInfo
| 0x1CF8100D |    1307 |  131 | FreeEncryptedFileMetadata
| 0xADCCFC4B |    1308 |  132 | FreeEncryptionCertificateHashList
| 0x6286C276 |    1309 |  133 | FreeInheritedFromArray
| 0xCE66655D |    1310 |  134 | FreeSid
| 0xDB66E132 |    1311 |  135 | GetAccessPermissionsForObjectA
| 0xDB66E148 |    1312 |  136 | GetAccessPermissionsForObjectW
| 0x6B1E60C9 |    1313 |  137 | GetAce
| 0xD4EA7F14 |    1314 |  138 | GetAclInformation
| 0x92404FF1 |    1315 |  139 | GetAuditedPermissionsFromAclA
| 0x92405007 |    1316 |  13A | GetAuditedPermissionsFromAclW
| 0xC15A2595 |    1317 |  13B | GetCurrentHwProfileA
| 0xC15A25AB |    1318 |  13C | GetCurrentHwProfileW
| 0x422E638E |    1319 |  13D | GetDynamicTimeZoneInformationEffectiveYears
| 0x23DF606F |    1320 |  13E | GetEffectiveRightsFromAclA
| 0x23DF6085 |    1321 |  13F | GetEffectiveRightsFromAclW
| 0x179F4A0D |    1322 |  140 | GetEncryptedFileMetadata
| 0x5BE2EB8C |    1323 |  141 | GetEventLogInformation
| 0xD37D7697 |    1324 |  142 | GetExplicitEntriesFromAclA
| 0xD37D76AD |    1325 |  143 | GetExplicitEntriesFromAclW
| 0xC5320AA0 |    1326 |  144 | GetFileSecurityA
| 0xC5320AB6 |    1327 |  145 | GetFileSecurityW
| 0xE49366F3 |    1328 |  146 | GetInformationCodeAuthzLevelW
| 0x40BE82B7 |    1329 |  147 | GetInformationCodeAuthzPolicyW
| 0xD2D74CDB |    1330 |  148 | GetInheritanceSourceA
| 0xD2D74CF1 |    1331 |  149 | GetInheritanceSourceW
| 0x3F755E45 |    1332 |  14A | GetKernelObjectSecurity
| 0xE1990211 |    1333 |  14B | GetLengthSid
| 0x1A7712DA |    1334 |  14C | GetLocalManagedApplicationData
| 0x6B7D1CBA |    1335 |  14D | GetLocalManagedApplications
| 0xB1797536 |    1336 |  14E | GetManagedApplicationCategories
| 0x79DCF6FB |    1337 |  14F | GetManagedApplications
| 0xBB0292CA |    1338 |  150 | GetMultipleTrusteeA
| 0xDBD62EAA |    1339 |  151 | GetMultipleTrusteeOperationA
| 0xDBD62EC0 |    1340 |  152 | GetMultipleTrusteeOperationW
| 0xBB0292E0 |    1341 |  153 | GetMultipleTrusteeW
| 0xF37DC4E9 |    1342 |  154 | GetNamedSecurityInfoA
| 0xE3313BBD |    1343 |  155 | GetNamedSecurityInfoExA
| 0xE3313BD3 |    1344 |  156 | GetNamedSecurityInfoExW
| 0xF37DC4FF |    1345 |  157 | GetNamedSecurityInfoW
| 0xFD988251 |    1346 |  158 | GetNumberOfEventLogRecords
| 0x761A13FB |    1347 |  159 | GetOldestEventLogRecord
| 0x86E6678A |    1348 |  15A | GetOverlappedAccessResults
| 0xE95010DC |    1349 |  15B | GetPrivateObjectSecurity
| 0x981B699A |    1350 |  15C | GetSecurityDescriptorControl
| 0x534E53C2 |    1351 |  15D | GetSecurityDescriptorDacl
| 0xC05ACDE2 |    1352 |  15E | GetSecurityDescriptorGroup
| 0xED352FC0 |    1353 |  15F | GetSecurityDescriptorLength
| 0xC9DB4DA4 |    1354 |  160 | GetSecurityDescriptorOwner
| 0xA2A6244F |    1355 |  161 | GetSecurityDescriptorRMControl
| 0x714E53C2 |    1356 |  162 | GetSecurityDescriptorSacl
| 0x7F05F5C3 |    1357 |  163 | GetSecurityInfo
| 0x8ABE1D6C |    1358 |  164 | GetSecurityInfoExA
| 0x8ABE1D82 |    1359 |  165 | GetSecurityInfoExW
| 0x4E14B6E6 |    1360 |  166 | GetServiceDisplayNameA
| 0x4E14B6FC |    1361 |  167 | GetServiceDisplayNameW
| 0x9F96729F |    1362 |  168 | GetServiceKeyNameA
| 0x9F9672B5 |    1363 |  169 | GetServiceKeyNameW
| 0xF3E140C  |    1364 |  16A | GetSidIdentifierAuthority
| 0xDF383F74 |    1365 |  16B | GetSidLengthRequired
| 0x20067E32 |    1366 |  16C | GetSidSubAuthority
| 0xF1778CCD |    1367 |  16D | GetSidSubAuthorityCount
| 0x2E29784C |    1368 |  16E | GetStringConditionFromBinary
| 0x2123CE88 |    1369 |  16F | GetThreadWaitChain
| 0xDBDB6E5A |    1370 |  170 | GetTokenInformation
| 0xC16FC69A |    1371 |  171 | GetTraceEnableFlags (forwarded to ntdll.EtwGetTraceEnableFlags)
| 0xB3602BD3 |    1372 |  172 | GetTraceEnableLevel (forwarded to ntdll.EtwGetTraceEnableLevel)
| 0x93DF8A44 |    1373 |  173 | GetTraceLoggerHandle (forwarded to ntdll.EtwGetTraceLoggerHandle)
| 0x892D56D1 |    1374 |  174 | GetTrusteeFormA
| 0x892D56E7 |    1375 |  175 | GetTrusteeFormW
| 0x6CEDD591 |    1376 |  176 | GetTrusteeNameA
| 0x6CEDD5A7 |    1377 |  177 | GetTrusteeNameW
| 0x9CEE3651 |    1378 |  178 | GetTrusteeTypeA
| 0x9CEE3667 |    1379 |  179 | GetTrusteeTypeW
| 0x5C52AA34 |    1380 |  17A | GetUserNameA
| 0x5C52AA4A |    1381 |  17B | GetUserNameW
| 0xBA5A9866 |    1382 |  17C | GetWindowsAccountDomainSid
| 0x22BF54A3 |    1383 |  17D | I_QueryTagInformation (forwarded to api-ms-win-service-private-l1-1-0.I_QueryTagInformation)
| 0x82E4618A |    1001 |  17E | I_ScGetCurrentGroupStateW
| 0xF7577484 |    1384 |  17F | I_ScIsSecurityProcess (forwarded to api-ms-win-service-private-l1-1-0.I_ScIsSecurityProcess)
| 0xDC8FA726 |    1385 |  180 | I_ScPnPGetServiceName (forwarded to api-ms-win-service-private-l1-1-0.I_ScPnPGetServiceName)
| 0x308CBC51 |    1386 |  181 | I_ScQueryServiceConfig (forwarded to api-ms-win-service-private-l1-1-0.I_ScQueryServiceConfig)
| 0xB8E23A71 |    1387 |  182 | I_ScRegisterPreshutdownRestart (forwarded to api-ms-win-service-private-l1-1-1.I_ScRegisterPreshutdownRestart)
| 0xFCCFE0CB |    1388 |  183 | I_ScReparseServiceDatabase
| 0x63326794 |    1389 |  184 | I_ScSendPnPMessage (forwarded to api-ms-win-service-private-l1-1-0.I_ScSendPnPMessage)
| 0x510AC490 |    1390 |  185 | I_ScSendTSMessage (forwarded to api-ms-win-service-private-l1-1-0.I_ScSendTSMessage)
| 0xB2E630F2 |    1391 |  186 | I_ScSetServiceBitsA
| 0xB2E63108 |    1392 |  187 | I_ScSetServiceBitsW
| 0xDA9D97C5 |    1393 |  188 | I_ScValidatePnPService (forwarded to api-ms-win-service-private-l1-1-0.I_ScValidatePnPService)
| 0x6B361190 |    1394 |  189 | IdentifyCodeAuthzLevelW
| 0x3B59808A |    1395 |  18A | ImpersonateAnonymousToken
| 0x6D821B37 |    1396 |  18B | ImpersonateLoggedOnUser
| 0x3386F672 |    1397 |  18C | ImpersonateNamedPipeClient
| 0xD1393ABD |    1398 |  18D | ImpersonateSelf
| 0xF8AF61AB |    1399 |  18E | InitializeAcl
| 0x230EA37F |    1400 |  18F | InitializeSecurityDescriptor
| 0xF8DF6623 |    1401 |  190 | InitializeSid
| 0x315A3DF7 |    1402 |  191 | InitiateShutdownA
| 0x315A3E0D |    1403 |  192 | InitiateShutdownW
| 0xFEA312C4 |    1404 |  193 | InitiateSystemShutdownA
| 0xAC84B280 |    1405 |  194 | InitiateSystemShutdownExA
| 0xAC84B296 |    1406 |  195 | InitiateSystemShutdownExW
| 0xFEA312DA |    1407 |  196 | InitiateSystemShutdownW
| 0xAEED9187 |    1408 |  197 | InstallApplication
| 0x4363E782 |    1409 |  198 | IsTextUnicode
| 0x4895A2D8 |    1410 |  199 | IsTokenRestricted
| 0xCADABE70 |    1411 |  19A | IsTokenUntrusted
| 0x3FA4F3A3 |    1412 |  19B | IsValidAcl
| 0xCA3E9D88 |    1413 |  19C | IsValidRelativeSecurityDescriptor (forwarded to KERNELBASE.IsValidRelativeSecurityDescriptor)
| 0xBED55BE  |    1414 |  19D | IsValidSecurityDescriptor
| 0x3FD4F81B |    1415 |  19E | IsValidSid
| 0x3238F606 |    1416 |  19F | IsWellKnownSid
| 0x14F5A020 |    1417 |  1A0 | LockServiceDatabase
| 0x5A53D699 |    1418 |  1A1 | LogonUserA
| 0x98B5A797 |    1419 |  1A2 | LogonUserExA
| 0x3129E73D |    1420 |  1A3 | LogonUserExExW
| 0x98B5A7AD |    1421 |  1A4 | LogonUserExW
| 0x5A53D6AF |    1422 |  1A5 | LogonUserW
| 0x115AD7E3 |    1423 |  1A6 | LookupAccountNameA
| 0x115AD7F9 |    1424 |  1A7 | LookupAccountNameW
| 0x64AC4407 |    1425 |  1A8 | LookupAccountSidA
| 0x64AC441D |    1426 |  1A9 | LookupAccountSidW
| 0x4B139443 |    1427 |  1AA | LookupPrivilegeDisplayNameA
| 0x4B139459 |    1428 |  1AB | LookupPrivilegeDisplayNameW
| 0x17CBB319 |    1429 |  1AC | LookupPrivilegeNameA
| 0x17CBB32F |    1430 |  1AD | LookupPrivilegeNameW
| 0x97E8C2A2 |    1431 |  1AE | LookupPrivilegeValueA
| 0x97E8C2B8 |    1432 |  1AF | LookupPrivilegeValueW
| 0x7C2615BA |    1433 |  1B0 | LookupSecurityDescriptorPartsA
| 0x7C2615D0 |    1434 |  1B1 | LookupSecurityDescriptorPartsW
| 0x6EA2C826 |    1435 |  1B2 | LsaAddAccountRights
| 0x50383759 |    1436 |  1B3 | LsaAddPrivilegesToAccount
| 0x50AF840D |    1437 |  1B4 | LsaClearAuditLog
| 0x5D6855D6 |    1438 |  1B5 | LsaClose
| 0xC7E332D9 |    1439 |  1B6 | LsaCreateAccount
| 0x65CCD9CB |    1440 |  1B7 | LsaCreateSecret
| 0x27944872 |    1441 |  1B8 | LsaCreateTrustedDomain
| 0xE73A1D01 |    1442 |  1B9 | LsaCreateTrustedDomainEx
| 0x292A7828 |    1443 |  1BA | LsaDelete
| 0xA7DB480A |    1444 |  1BB | LsaDeleteTrustedDomain
| 0x65F7BF45 |    1445 |  1BC | LsaEnumerateAccountRights
| 0x28A229C4 |    1446 |  1BD | LsaEnumerateAccounts
| 0xEC2DF70  |    1447 |  1BE | LsaEnumerateAccountsWithUserRight
| 0x1CCEC737 |    1448 |  1BF | LsaEnumeratePrivileges
| 0x27B4138D |    1449 |  1C0 | LsaEnumeratePrivilegesOfAccount
| 0xEC6F8464 |    1450 |  1C1 | LsaEnumerateTrustedDomains
| 0x1E0919B3 |    1451 |  1C2 | LsaEnumerateTrustedDomainsEx
| 0x1212ADD9 |    1452 |  1C3 | LsaFreeMemory
| 0xBAFA2B42 |    1453 |  1C4 | LsaGetAppliedCAPIDs
| 0x2C1B2CBD |    1454 |  1C5 | LsaGetQuotasForAccount
| 0x2D2254F9 |    1455 |  1C6 | LsaGetRemoteUserName
| 0xC07CD5D0 |    1456 |  1C7 | LsaGetSystemAccessAccount
| 0x7C0072BA |    1457 |  1C8 | LsaGetUserName
| 0xE70C51F8 |    1458 |  1C9 | LsaICLookupNames
| 0xA2841E40 |    1459 |  1CA | LsaICLookupNamesWithCreds
| 0x93E8BEEF |    1460 |  1CB | LsaICLookupSids
| 0x85EBD3A7 |    1461 |  1CC | LsaICLookupSidsWithCreds
| 0x5CC6888F |    1462 |  1CD | LsaLookupNames
| 0x447AE666 |    1463 |  1CE | LsaLookupNames2
| 0x77588A48 |    1464 |  1CF | LsaLookupPrivilegeDisplayName
| 0xA681C500 |    1465 |  1D0 | LsaLookupPrivilegeName
| 0x2885B433 |    1466 |  1D1 | LsaLookupPrivilegeValue
| 0xDABB8DA6 |    1467 |  1D2 | LsaLookupSids
| 0x6D36D60E |    1468 |  1D3 | LsaLookupSids2
| 0x84D2E8CF |    1469 |  1D4 | LsaManageSidNameMapping
| 0x8243D7E6 |    1470 |  1D5 | LsaNtStatusToWinError
| 0xAE3FE2EA |    1471 |  1D6 | LsaOpenAccount
| 0x8DBF945A |    1472 |  1D7 | LsaOpenPolicy
| 0xB833944D |    1473 |  1D8 | LsaOpenPolicySce
| 0xFBCEF696 |    1474 |  1D9 | LsaOpenSecret
| 0xE7D7E1E4 |    1475 |  1DA | LsaOpenTrustedDomain
| 0x27034826 |    1476 |  1DB | LsaOpenTrustedDomainByName
| 0x9BB6B7A9 |    1477 |  1DC | LsaQueryCAPs
| 0xD6458AB5 |    1478 |  1DD | LsaQueryDomainInformationPolicy
| 0x96102D5B |    1479 |  1DE | LsaQueryForestTrustInformation
| 0x69AE630  |    1480 |  1DF | LsaQueryInfoTrustedDomain
| 0xF988F35B |    1481 |  1E0 | LsaQueryInformationPolicy
| 0x16D82AA3 |    1482 |  1E1 | LsaQuerySecret
| 0xB1198887 |    1483 |  1E2 | LsaQuerySecurityObject
| 0x7B66A07F |    1484 |  1E3 | LsaQueryTrustedDomainInfo
| 0x216D9661 |    1485 |  1E4 | LsaQueryTrustedDomainInfoByName
| 0x60D5D1C3 |    1486 |  1E5 | LsaRemoveAccountRights
| 0x5DE70348 |    1487 |  1E6 | LsaRemovePrivilegesFromAccount
| 0xAE94784D |    1488 |  1E7 | LsaRetrievePrivateData
| 0x7CD5BD06 |    1489 |  1E8 | LsaSetCAPs
| 0x14504478 |    1490 |  1E9 | LsaSetDomainInformationPolicy
| 0xED48751C |    1491 |  1EA | LsaSetForestTrustInformation
| 0xA7F982DE |    1492 |  1EB | LsaSetInformationPolicy
| 0x2F15B268 |    1493 |  1EC | LsaSetInformationTrustedDomain
| 0x2F1B2CBD |    1494 |  1ED | LsaSetQuotasForAccount
| 0x5E9981DB |    1495 |  1EE | LsaSetSecret
| 0xE96149DE |    1496 |  1EF | LsaSetSecurityObject
| 0xC082D5D0 |    1497 |  1F0 | LsaSetSystemAccessAccount
| 0x5F785023 |    1498 |  1F1 | LsaSetTrustedDomainInfoByName
| 0xA82C2B2A |    1499 |  1F2 | LsaSetTrustedDomainInformation
| 0xA1DAE272 |    1500 |  1F3 | LsaStorePrivateData
| 0xD61C85A6 |    1501 |  1F4 | MD4Final (forwarded to NTDLL.MD4Final)
| 0x967F5C16 |    1502 |  1F5 | MD4Init (forwarded to NTDLL.MD4Init)
| 0x99772150 |    1503 |  1F6 | MD4Update (forwarded to NTDLL.MD4Update)
| 0x561C85A7 |    1504 |  1F7 | MD5Final (forwarded to NTDLL.MD5Final)
| 0x967F6C16 |    1505 |  1F8 | MD5Init (forwarded to NTDLL.MD5Init)
| 0x997B2150 |    1506 |  1F9 | MD5Update (forwarded to NTDLL.MD5Update)
| 0x93423881 |    1507 |  1FA | MIDL_user_free_Ext
| 0x31FC1C1  |    1508 |  1FB | MSChapSrvChangePassword
| 0xE081930  |    1509 |  1FC | MSChapSrvChangePassword2
| 0xB5B38644 |    1510 |  1FD | MakeAbsoluteSD
| 0x3225ADCE |    1511 |  1FE | MakeAbsoluteSD2
| 0x5FDFE41E |    1512 |  1FF | MakeSelfRelativeSD
| 0x74C983A2 |    1513 |  200 | MapGenericMask
| 0xF0378958 |    1514 |  201 | NotifyBootConfigStatus
| 0x50C7BE83 |    1515 |  202 | NotifyChangeEventLog
| 0x307D2222 |    1516 |  203 | NotifyServiceStatusChange
| 0x1111842A |    1517 |  204 | NotifyServiceStatusChangeA
| 0x11118440 |    1518 |  205 | NotifyServiceStatusChangeW
| 0x561E706A |    1519 |  206 | NpGetUserName
| 0xBD6AA069 |    1520 |  207 | ObjectCloseAuditAlarmA
| 0xBD6AA07F |    1521 |  208 | ObjectCloseAuditAlarmW
| 0x77C41842 |    1522 |  209 | ObjectDeleteAuditAlarmA
| 0x77C41858 |    1523 |  20A | ObjectDeleteAuditAlarmW
| 0xAF039B9E |    1524 |  20B | ObjectOpenAuditAlarmA
| 0xAF039BB4 |    1525 |  20C | ObjectOpenAuditAlarmW
| 0x20F6CF76 |    1526 |  20D | ObjectPrivilegeAuditAlarmA
| 0x20F6CF8C |    1527 |  20E | ObjectPrivilegeAuditAlarmW
| 0x2752FCD4 |    1528 |  20F | OpenBackupEventLogA
| 0x2752FCEA |    1529 |  210 | OpenBackupEventLogW
| 0x10CD10A8 |    1530 |  211 | OpenEncryptedFileRawA
| 0x10CD10BE |    1531 |  212 | OpenEncryptedFileRawW
| 0x22B6E002 |    1532 |  213 | OpenEventLogA
| 0x22B6E018 |    1533 |  214 | OpenEventLogW
| 0x591EA70F |    1534 |  215 | OpenProcessToken
| 0xBE66D274 |    1535 |  216 | OpenSCManagerA
| 0xBE66D28A |    1536 |  217 | OpenSCManagerW
| 0x4564ABB7 |    1537 |  218 | OpenServiceA
| 0x4564ABCD |    1538 |  219 | OpenServiceW
| 0x8D91EA66 |    1539 |  21A | OpenThreadToken
| 0x74544D0  |    1540 |  21B | OpenThreadWaitChainSession
| 0x36E9BDCC |    1541 |  21C | OpenTraceA
| 0x36E9BDE2 |    1542 |  21D | OpenTraceW
| 0xD3E83615 |    1543 |  21E | OperationEnd
| 0x99E6529  |    1544 |  21F | OperationStart
| 0x44A3697F |    1545 |  220 | PerfAddCounters
| 0x38403AA7 |    1546 |  221 | PerfCloseQueryHandle
| 0x4E8BA706 |    1547 |  222 | PerfCreateInstance (forwarded to api-ms-win-core-perfcounters-l1-1-0.PerfCreateInstance)
| 0xCB9F5209 |    1548 |  223 | PerfDecrementULongCounterValue (forwarded to api-ms-win-core-perfcounters-l1-1-0.PerfDecrementULongCounterValue)
| 0xEEC9E211 |    1549 |  224 | PerfDecrementULongLongCounterValue (forwarded to api-ms-win-core-perfcounters-l1-1-0.PerfDecrementULongLongCounterValue)
| 0x75954346 |    1550 |  225 | PerfDeleteCounters
| 0x4F19A637 |    1551 |  226 | PerfDeleteInstance (forwarded to api-ms-win-core-perfcounters-l1-1-0.PerfDeleteInstance)
| 0xA3BA76FD |    1552 |  227 | PerfEnumerateCounterSet
| 0xFDB2244B |    1553 |  228 | PerfEnumerateCounterSetInstances
| 0xF39F5B09 |    1554 |  229 | PerfIncrementULongCounterValue (forwarded to api-ms-win-core-perfcounters-l1-1-0.PerfIncrementULongCounterValue)
| 0xEF59E491 |    1555 |  22A | PerfIncrementULongLongCounterValue (forwarded to api-ms-win-core-perfcounters-l1-1-0.PerfIncrementULongLongCounterValue)
| 0x939D2563 |    1556 |  22B | PerfOpenQueryHandle
| 0xAF953D5F |    1557 |  22C | PerfQueryCounterData
| 0xB92540AD |    1558 |  22D | PerfQueryCounterInfo
| 0xC5F8DD1E |    1559 |  22E | PerfQueryCounterSetRegistrationInfo
| 0xD416C275 |    1560 |  22F | PerfQueryInstance (forwarded to api-ms-win-core-perfcounters-l1-1-0.PerfQueryInstance)
| 0x692FBB06 |    1561 |  230 | PerfRegCloseKey
| 0xEC2A06BA |    1562 |  231 | PerfRegEnumKey
| 0x62A5BE0  |    1563 |  232 | PerfRegEnumValue
| 0x9BEAFC53 |    1564 |  233 | PerfRegQueryInfoKey
| 0x5093DD89 |    1565 |  234 | PerfRegQueryValue
| 0xE191F534 |    1566 |  235 | PerfRegSetValue
| 0x5BAFA7F3 |    1567 |  236 | PerfSetCounterRefValue (forwarded to api-ms-win-core-perfcounters-l1-1-0.PerfSetCounterRefValue)
| 0xDAC6AEAF |    1568 |  237 | PerfSetCounterSetInfo (forwarded to api-ms-win-core-perfcounters-l1-1-0.PerfSetCounterSetInfo)
| 0x309B9FEF |    1569 |  238 | PerfSetULongCounterValue (forwarded to api-ms-win-core-perfcounters-l1-1-0.PerfSetULongCounterValue)
| 0xB3A83861 |    1570 |  239 | PerfSetULongLongCounterValue (forwarded to api-ms-win-core-perfcounters-l1-1-0.PerfSetULongLongCounterValue)
| 0xDF34E0FF |    1571 |  23A | PerfStartProvider (forwarded to api-ms-win-core-perfcounters-l1-1-0.PerfStartProvider)
| 0xCF60406F |    1572 |  23B | PerfStartProviderEx (forwarded to api-ms-win-core-perfcounters-l1-1-0.PerfStartProviderEx)
| 0xA29632   |    1573 |  23C | PerfStopProvider (forwarded to api-ms-win-core-perfcounters-l1-1-0.PerfStopProvider)
| 0x698DA5BC |    1574 |  23D | PrivilegeCheck
| 0x3F63B543 |    1575 |  23E | PrivilegedServiceAuditAlarmA
| 0x3F63B559 |    1576 |  23F | PrivilegedServiceAuditAlarmW
| 0x885CD03D |    1577 |  240 | ProcessIdleTasks
| 0x81EC433D |    1578 |  241 | ProcessIdleTasksW
| 0x4C8CDD9C |    1579 |  242 | ProcessTrace
| 0xB25589A9 |    1580 |  243 | QueryAllTracesA
| 0xB25589BF |    1581 |  244 | QueryAllTracesW
| 0xC875E7BD |    1582 |  245 | QueryLocalUserServiceName
| 0x6076A050 |    1583 |  246 | QueryRecoveryAgentsOnEncryptedFile
| 0xCAFF9FE2 |    1584 |  247 | QuerySecurityAccessMask
| 0xEB75930A |    1585 |  248 | QueryServiceConfig2A
| 0xEB759320 |    1586 |  249 | QueryServiceConfig2W
| 0xB2593D7D |    1587 |  24A | QueryServiceConfigA
| 0xB2593D93 |    1588 |  24B | QueryServiceConfigW
| 0x9092F9B2 |    1589 |  24C | QueryServiceDynamicInformation
| 0x3419F950 |    1590 |  24D | QueryServiceLockStatusA
| 0x3419F966 |    1591 |  24E | QueryServiceLockStatusW
| 0x875AEC11 |    1592 |  24F | QueryServiceObjectSecurity
| 0xE07E9DF  |    1593 |  250 | QueryServiceStatus
| 0x8422783B |    1594 |  251 | QueryServiceStatusEx
| 0x6C16EF80 |    1595 |  252 | QueryTraceA
| 0x2FD47B89 |    1596 |  253 | QueryTraceProcessingHandle
| 0x6C16EF96 |    1597 |  254 | QueryTraceW
| 0xCB2D9F33 |    1598 |  255 | QueryUserServiceName
| 0xCEA09FF9 |    1599 |  256 | QueryUserServiceNameForContext
| 0x9E233913 |    1600 |  257 | QueryUsersOnEncryptedFile
| 0x9F42E7F9 |    1601 |  258 | ReadEncryptedFileRaw
| 0x22A09031 |    1602 |  259 | ReadEventLogA
| 0x22A09047 |    1603 |  25A | ReadEventLogW
| 0x35E273E6 |    1604 |  25B | RegCloseKey
| 0x2C21BFC0 |    1605 |  25C | RegConnectRegistryA
| 0xC2FF14C  |    1606 |  25D | RegConnectRegistryExA
| 0xC2FF162  |    1607 |  25E | RegConnectRegistryExW
| 0x2C21BFD6 |    1608 |  25F | RegConnectRegistryW
| 0xEC949FB7 |    1609 |  260 | RegCopyTreeA
| 0xEC949FCD |    1610 |  261 | RegCopyTreeW
| 0xCE1E9395 |    1611 |  262 | RegCreateKeyA
| 0x8B64E6B4 |    1612 |  263 | RegCreateKeyExA
| 0x8B64E6CA |    1613 |  264 | RegCreateKeyExW
| 0x17D8C5D  |    1614 |  265 | RegCreateKeyTransactedA
| 0x17D8C73  |    1615 |  266 | RegCreateKeyTransactedW
| 0xCE1E93AB |    1616 |  267 | RegCreateKeyW
| 0xC12E9C75 |    1617 |  268 | RegDeleteKeyA
| 0x4F671EB1 |    1618 |  269 | RegDeleteKeyExA
| 0x4F671EC7 |    1619 |  26A | RegDeleteKeyExW
| 0xFE418E94 |    1620 |  26B | RegDeleteKeyTransactedA
| 0xFE418EAA |    1621 |  26C | RegDeleteKeyTransactedW
| 0x3BC57BC7 |    1622 |  26D | RegDeleteKeyValueA
| 0x3BC57BDD |    1623 |  26E | RegDeleteKeyValueW
| 0xC12E9C8B |    1624 |  26F | RegDeleteKeyW
| 0xFECE94B5 |    1625 |  270 | RegDeleteTreeA
| 0xFECE94CB |    1626 |  271 | RegDeleteTreeW
| 0xB4CEEAB6 |    1627 |  272 | RegDeleteValueA
| 0xB4CEEACC |    1628 |  273 | RegDeleteValueW
| 0xFF140A40 |    1629 |  274 | RegDisablePredefinedCache
| 0xC72A90B7 |    1630 |  275 | RegDisablePredefinedCacheEx
| 0x442231FB |    1631 |  276 | RegDisableReflectionKey
| 0x1B18F68B |    1632 |  277 | RegEnableReflectionKey
| 0x28A1A71  |    1633 |  278 | RegEnumKeyA
| 0xA6469D81 |    1634 |  279 | RegEnumKeyExA
| 0xA6469D97 |    1635 |  27A | RegEnumKeyExW
| 0x28A1A87  |    1636 |  27B | RegEnumKeyW
| 0xBAE6987  |    1637 |  27C | RegEnumValueA
| 0xBAE699D  |    1638 |  27D | RegEnumValueW
| 0x3BE27449 |    1639 |  27E | RegFlushKey
| 0x66FA3FBB |    1640 |  27F | RegGetKeySecurity
| 0x64A57266 |    1641 |  280 | RegGetValueA
| 0x64A5727C |    1642 |  281 | RegGetValueW
| 0x25A4A49D |    1643 |  282 | RegLoadAppKeyA
| 0x25A4A4B3 |    1644 |  283 | RegLoadAppKeyW
| 0x28D8B47  |    1645 |  284 | RegLoadKeyA
| 0x28D8B5D  |    1646 |  285 | RegLoadKeyW
| 0xF2A35031 |    1647 |  286 | RegLoadMUIStringA
| 0xF2A35047 |    1648 |  287 | RegLoadMUIStringW
| 0x9AE4C899 |    1649 |  288 | RegNotifyChangeKeyValue
| 0xFA0958A7 |    1650 |  289 | RegOpenCurrentUser
| 0x2922BA9  |    1651 |  28A | RegOpenKeyA
| 0xA84AEB81 |    1652 |  28B | RegOpenKeyExA
| 0xA84AEB97 |    1653 |  28C | RegOpenKeyExW
| 0xCE9A7261 |    1654 |  28D | RegOpenKeyTransactedA
| 0xCE9A7277 |    1655 |  28E | RegOpenKeyTransactedW
| 0x2922BBF  |    1656 |  28F | RegOpenKeyW
| 0xA902E6BC |    1657 |  290 | RegOpenUserClassesRoot
| 0x3428DC2C |    1658 |  291 | RegOverridePredefKey
| 0xC8F63C08 |    1659 |  292 | RegQueryInfoKeyA
| 0xC8F63C1E |    1660 |  293 | RegQueryInfoKeyW
| 0x448C7B3  |    1661 |  294 | RegQueryMultipleValuesA
| 0x448C7C9  |    1662 |  295 | RegQueryMultipleValuesW
| 0x5D8409A2 |    1663 |  296 | RegQueryReflectionKey
| 0xABE3EA51 |    1664 |  297 | RegQueryValueA
| 0xFCBA95AB |    1665 |  298 | RegQueryValueExA
| 0xFCBA95C1 |    1666 |  299 | RegQueryValueExW
| 0xABE3EA67 |    1667 |  29A | RegQueryValueW
| 0xE18E2823 |    1668 |  29B | RegRenameKey
| 0x3523A598 |    1669 |  29C | RegReplaceKeyA
| 0x3523A5AE |    1670 |  29D | RegReplaceKeyW
| 0xB85BA69F |    1671 |  29E | RegRestoreKeyA
| 0xB85BA6B5 |    1672 |  29F | RegRestoreKeyW
| 0x82559C31 |    1673 |  2A0 | RegSaveKeyA
| 0x99270DA1 |    1674 |  2A1 | RegSaveKeyExA
| 0x99270DB7 |    1675 |  2A2 | RegSaveKeyExW
| 0x82559C47 |    1676 |  2A3 | RegSaveKeyW
| 0x6CFA3FBB |    1677 |  2A4 | RegSetKeySecurity
| 0x9B3D28D6 |    1678 |  2A5 | RegSetKeyValueA
| 0x9B3D28EC |    1679 |  2A6 | RegSetKeyValueW
| 0x70A57266 |    1680 |  2A7 | RegSetValueA
| 0x2D1C9ADD |    1681 |  2A8 | RegSetValueExA
| 0x2D1C9AF3 |    1682 |  2A9 | RegSetValueExW
| 0x70A5727C |    1683 |  2AA | RegSetValueW
| 0x4A57106C |    1684 |  2AB | RegUnLoadKeyA
| 0x4A571082 |    1685 |  2AC | RegUnLoadKeyW
| 0x3341E3E  |    1686 |  2AD | RegisterEventSourceA
| 0x3341E54  |    1687 |  2AE | RegisterEventSourceW
| 0x939934B9 |    1688 |  2AF | RegisterIdleTask
| 0xD5C76D32 |    1689 |  2B0 | RegisterServiceCtrlHandlerA
| 0x759B4DF6 |    1690 |  2B1 | RegisterServiceCtrlHandlerExA
| 0x759B4E0C |    1691 |  2B2 | RegisterServiceCtrlHandlerExW
| 0xD5C76D48 |    1692 |  2B3 | RegisterServiceCtrlHandlerW
| 0x2803DB60 |    1693 |  2B4 | RegisterTraceGuidsA (forwarded to ntdll.EtwRegisterTraceGuidsA)
| 0x2803DB76 |    1694 |  2B5 | RegisterTraceGuidsW (forwarded to ntdll.EtwRegisterTraceGuidsW)
| 0xE663DCB1 |    1695 |  2B6 | RegisterWaitChainCOMCallback
| 0x3A7D994B |    1696 |  2B7 | RemoteRegEnumKeyWrapper
| 0xD67AF920 |    1697 |  2B8 | RemoteRegEnumValueWrapper
| 0x4A4301C0 |    1698 |  2B9 | RemoteRegQueryInfoKeyWrapper
| 0xA919BADD |    1699 |  2BA | RemoteRegQueryMultipleValues2Wrapper
| 0xD588653D |    1700 |  2BB | RemoteRegQueryMultipleValuesWrapper
| 0x7AA74300 |    1701 |  2BC | RemoteRegQueryValueWrapper
| 0x95F8D9D0 |    1702 |  2BD | RemoveTraceCallback (forwarded to sechost.RemoveTraceCallback)
| 0x8562B82A |    1703 |  2BE | RemoveUsersFromEncryptedFile
| 0xFF1F0A3D |    1704 |  2BF | ReportEventA
| 0xFF1F0A53 |    1705 |  2C0 | ReportEventW
| 0x50DEC82A |    1706 |  2C1 | RevertToSelf
| 0xB00DD97F |    1707 |  2C2 | SafeBaseRegGetKeySecurity
| 0x6C46567C |    1708 |  2C3 | SaferCloseLevel
| 0x70733B96 |    1709 |  2C4 | SaferComputeTokenFromLevel
| 0x7E604AB  |    1710 |  2C5 | SaferCreateLevel
| 0x3BEB2BE4 |    1711 |  2C6 | SaferGetLevelInformation
| 0x6EA0C555 |    1712 |  2C7 | SaferGetPolicyInformation
| 0xFCF2F697 |    1713 |  2C8 | SaferIdentifyLevel
| 0x97B89C57 |    1714 |  2C9 | SaferRecordEventLogEntry
| 0x3EEB2BE4 |    1715 |  2CA | SaferSetLevelInformation
| 0x6EA0DD55 |    1716 |  2CB | SaferSetPolicyInformation
| 0xAF10EE09 |    1717 |  2CC | SaferiChangeRegistryScope
| 0xA2B09D5F |    1718 |  2CD | SaferiCompareTokenLevels
| 0x829A92D  |    1719 |  2CE | SaferiIsDllAllowed
| 0xBFA361C6 |    1720 |  2CF | SaferiIsExecutableFileType
| 0xD6E7B9B9 |    1721 |  2D0 | SaferiPopulateDefaultsInRegistry
| 0x69785D6C |    1722 |  2D1 | SaferiRecordEventLogEntry
| 0x6CFAB1C7 |    1723 |  2D2 | SaferiSearchMatchingHashRules
| 0xD4F67F14 |    1724 |  2D3 | SetAclInformation
| 0x191F4A0D |    1725 |  2D4 | SetEncryptedFileMetadata
| 0xB0F6A97C |    1726 |  2D5 | SetEntriesInAccessListA
| 0xB0F6A992 |    1727 |  2D6 | SetEntriesInAccessListW
| 0xB142E3E  |    1728 |  2D7 | SetEntriesInAclA
| 0xB142E54  |    1729 |  2D8 | SetEntriesInAclW
| 0xA13D088C |    1730 |  2D9 | SetEntriesInAuditListA
| 0xA13D08A2 |    1731 |  2DA | SetEntriesInAuditListW
| 0x45320AA2 |    1732 |  2DB | SetFileSecurityA
| 0x45320AB8 |    1733 |  2DC | SetFileSecurityW
| 0xE55366F3 |    1734 |  2DD | SetInformationCodeAuthzLevelW
| 0x40BE88B7 |    1735 |  2DE | SetInformationCodeAuthzPolicyW
| 0x3F755E75 |    1736 |  2DF | SetKernelObjectSecurity
| 0xB37DC4EA |    1737 |  2E0 | SetNamedSecurityInfoA
| 0xE3313BED |    1738 |  2E1 | SetNamedSecurityInfoExA
| 0xE3313C03 |    1739 |  2E2 | SetNamedSecurityInfoExW
| 0xB37DC500 |    1740 |  2E3 | SetNamedSecurityInfoW
| 0xEAD010DC |    1741 |  2E4 | SetPrivateObjectSecurity
| 0xB62C37B2 |    1742 |  2E5 | SetPrivateObjectSecurityEx
| 0xA985049D |    1743 |  2E6 | SetSecurityAccessMask
| 0x981B69B2 |    1744 |  2E7 | SetSecurityDescriptorControl
| 0x534E5FC2 |    1745 |  2E8 | SetSecurityDescriptorDacl
| 0x205ACDE3 |    1746 |  2E9 | SetSecurityDescriptorGroup
| 0x29DB4DA5 |    1747 |  2EA | SetSecurityDescriptorOwner
| 0xA2A62A4F |    1748 |  2EB | SetSecurityDescriptorRMControl
| 0x714E5FC2 |    1749 |  2EC | SetSecurityDescriptorSacl
| 0x7F0625C3 |    1750 |  2ED | SetSecurityInfo
| 0x8ABE1DCC |    1751 |  2EE | SetSecurityInfoExA
| 0x8ABE1DE2 |    1752 |  2EF | SetSecurityInfoExW
| 0x65B5A80A |    1753 |  2F0 | SetServiceBits
| 0xFD17F6DA |    1754 |  2F1 | SetServiceObjectSecurity
| 0xCB12B354 |    1755 |  2F2 | SetServiceStatus
| 0x7F1CAE66 |    1756 |  2F3 | SetThreadToken
| 0xDEDB6E5A |    1757 |  2F4 | SetTokenInformation
| 0x88B92A5  |    1758 |  2F5 | SetTraceCallback (forwarded to sechost.SetTraceCallback)
| 0x6181410E |    1759 |  2F6 | SetUserFileEncryptionKey
| 0x62784410 |    1760 |  2F7 | SetUserFileEncryptionKeyEx
| 0x8BAF18E3 |    1761 |  2F8 | StartServiceA
| 0x3F593D1C |    1762 |  2F9 | StartServiceCtrlDispatcherA
| 0x3F593D32 |    1763 |  2FA | StartServiceCtrlDispatcherW
| 0x8BAF18F9 |    1764 |  2FB | StartServiceW
| 0xE802E780 |    1765 |  2FC | StartTraceA
| 0xE802E796 |    1766 |  2FD | StartTraceW
| 0x3AF1DF0C |    1767 |  2FE | StopTraceA
| 0x3AF1DF22 |    1768 |  2FF | StopTraceW
| 0xA8898337 |    1769 |  300 | SystemFunction001 (forwarded to CRYPTBASE.SystemFunction001)
| 0xA8898338 |    1770 |  301 | SystemFunction002 (forwarded to CRYPTBASE.SystemFunction002)
| 0xA8898339 |    1771 |  302 | SystemFunction003 (forwarded to CRYPTBASE.SystemFunction003)
| 0xA889833A |    1772 |  303 | SystemFunction004 (forwarded to CRYPTBASE.SystemFunction004)
| 0xA889833B |    1773 |  304 | SystemFunction005 (forwarded to CRYPTBASE.SystemFunction005)
| 0xA889833C |    1774 |  305 | SystemFunction006 (forwarded to CRYPTSP.SystemFunction006)
| 0xA889833D |    1775 |  306 | SystemFunction007 (forwarded to CRYPTSP.SystemFunction007)
| 0xA889833E |    1776 |  307 | SystemFunction008 (forwarded to CRYPTSP.SystemFunction008)
| 0xA889833F |    1777 |  308 | SystemFunction009 (forwarded to CRYPTSP.SystemFunction009)
| 0xA8918336 |    1778 |  309 | SystemFunction010 (forwarded to CRYPTSP.SystemFunction010)
| 0xA8918337 |    1779 |  30A | SystemFunction011 (forwarded to CRYPTSP.SystemFunction011)
| 0xA8918338 |    1780 |  30B | SystemFunction012 (forwarded to CRYPTSP.SystemFunction012)
| 0xA8918339 |    1781 |  30C | SystemFunction013 (forwarded to CRYPTSP.SystemFunction013)
| 0xA891833A |    1782 |  30D | SystemFunction014 (forwarded to CRYPTSP.SystemFunction014)
| 0xA891833B |    1783 |  30E | SystemFunction015 (forwarded to CRYPTSP.SystemFunction015)
| 0xA891833C |    1784 |  30F | SystemFunction016 (forwarded to CRYPTSP.SystemFunction016)
| 0xA891833D |    1785 |  310 | SystemFunction017
| 0xA891833E |    1786 |  311 | SystemFunction018 (forwarded to CRYPTSP.SystemFunction018)
| 0xA891833F |    1787 |  312 | SystemFunction019
| 0xA8998336 |    1788 |  313 | SystemFunction020 (forwarded to CRYPTSP.SystemFunction020)
| 0xA8998337 |    1789 |  314 | SystemFunction021 (forwarded to CRYPTSP.SystemFunction021)
| 0xA8998338 |    1790 |  315 | SystemFunction022 (forwarded to CRYPTSP.SystemFunction022)
| 0xA8998339 |    1791 |  316 | SystemFunction023 (forwarded to CRYPTSP.SystemFunction023)
| 0xA899833A |    1792 |  317 | SystemFunction024 (forwarded to CRYPTSP.SystemFunction024)
| 0xA899833B |    1793 |  318 | SystemFunction025 (forwarded to CRYPTSP.SystemFunction025)
| 0xA899833C |    1794 |  319 | SystemFunction026 (forwarded to CRYPTSP.SystemFunction026)
| 0xA899833D |    1795 |  31A | SystemFunction027 (forwarded to CRYPTSP.SystemFunction027)
| 0xA899833E |    1796 |  31B | SystemFunction028 (forwarded to CRYPTBASE.SystemFunction028)
| 0xA899833F |    1797 |  31C | SystemFunction029 (forwarded to CRYPTBASE.SystemFunction029)
| 0xA8A18336 |    1798 |  31D | SystemFunction030 (forwarded to CRYPTSP.SystemFunction030)
| 0xA8A18337 |    1799 |  31E | SystemFunction031 (forwarded to CRYPTSP.SystemFunction031)
| 0xA8A18338 |    1800 |  31F | SystemFunction032 (forwarded to CRYPTSP.SystemFunction032)
| 0xA8A18339 |    1801 |  320 | SystemFunction033 (forwarded to CRYPTSP.SystemFunction033)
| 0xA8A1833A |    1802 |  321 | SystemFunction034 (forwarded to CRYPTBASE.SystemFunction034)
| 0xA8A1833B |    1803 |  322 | SystemFunction035 (forwarded to CRYPTSP.CheckSignatureInFile)
| 0xA8A1833C |    1804 |  323 | SystemFunction036 (forwarded to CRYPTBASE.SystemFunction036)
| 0xA8A98336 |    1805 |  324 | SystemFunction040 (forwarded to CRYPTBASE.SystemFunction040)
| 0xA8A98337 |    1806 |  325 | SystemFunction041 (forwarded to CRYPTBASE.SystemFunction041)
| 0xE3031607 |    1807 |  326 | TraceEvent (forwarded to ntdll.EtwLogTraceEvent)
| 0x4EBA6855 |    1808 |  327 | TraceEventInstance (forwarded to ntdll.EtwTraceEventInstance)
| 0x4E1E5D95 |    1809 |  328 | TraceMessage (forwarded to ntdll.EtwTraceMessage)
| 0x8A4765B4 |    1810 |  329 | TraceMessageVa (forwarded to ntdll.EtwTraceMessageVa)
| 0xBF636B1F |    1811 |  32A | TraceQueryInformation (forwarded to api-ms-win-eventing-controller-l1-1-0.TraceQueryInformation)
| 0xB31446C4 |    1812 |  32B | TraceSetInformation
| 0x5065AB38 |    1813 |  32C | TreeResetNamedSecurityInfoA
| 0x5065AB4E |    1814 |  32D | TreeResetNamedSecurityInfoW
| 0xC1F09A7E |    1815 |  32E | TreeSetNamedSecurityInfoA
| 0xC1F09A94 |    1816 |  32F | TreeSetNamedSecurityInfoW
| 0xF2815713 |    1817 |  330 | TrusteeAccessToObjectA
| 0xF2815729 |    1818 |  331 | TrusteeAccessToObjectW
| 0xCA6E3C87 |    1819 |  332 | UninstallApplication
| 0x6CF67C25 |    1820 |  333 | UnlockServiceDatabase
| 0x94073765 |    1821 |  334 | UnregisterIdleTask
| 0x96E49000 |    1822 |  335 | UnregisterTraceGuids (forwarded to ntdll.EtwUnregisterTraceGuids)
| 0x287067C8 |    1823 |  336 | UpdateTraceA
| 0x287067DE |    1824 |  337 | UpdateTraceW
| 0x2FD9A6A3 |    1825 |  338 | UsePinForEncryptedFilesA
| 0x2FD9A6B9 |    1826 |  339 | UsePinForEncryptedFilesW
| 0x385C715D |    1827 |  33A | WaitServiceState
| 0x9C467C9  |    1828 |  33B | WmiCloseBlock
| 0x9090464A |    1829 |  33C | WmiDevInstToInstanceNameA
| 0x90904660 |    1830 |  33D | WmiDevInstToInstanceNameW
| 0xE4BA6A0F |    1831 |  33E | WmiEnumerateGuids
| 0x4C01BC7B |    1832 |  33F | WmiExecuteMethodA
| 0x4C01BC91 |    1833 |  340 | WmiExecuteMethodW
| 0x3174CBB4 |    1834 |  341 | WmiFileHandleToInstanceNameA
| 0x3174CBCA |    1835 |  342 | WmiFileHandleToInstanceNameW
| 0x839FAC3E |    1836 |  343 | WmiFreeBuffer
| 0xD9C41A6E |    1837 |  344 | WmiMofEnumerateResourcesA
| 0xD9C41A84 |    1838 |  345 | WmiMofEnumerateResourcesW
| 0xB1735989 |    1839 |  346 | WmiNotificationRegistrationA
| 0xB173599F |    1840 |  347 | WmiNotificationRegistrationW
| 0x6C61927E |    1841 |  348 | WmiOpenBlock
| 0x952BAECC |    1842 |  349 | WmiQueryAllDataA
| 0xBD73E5CA |    1843 |  34A | WmiQueryAllDataMultipleA
| 0xBD73E5E0 |    1844 |  34B | WmiQueryAllDataMultipleW
| 0x952BAEE2 |    1845 |  34C | WmiQueryAllDataW
| 0x1C7BF202 |    1846 |  34D | WmiQueryGuidInformation
| 0x2D35D891 |    1847 |  34E | WmiQuerySingleInstanceA
| 0x820BEFF4 |    1848 |  34F | WmiQuerySingleInstanceMultipleA
| 0x820BF00A |    1849 |  350 | WmiQuerySingleInstanceMultipleW
| 0x2D35D8A7 |    1850 |  351 | WmiQuerySingleInstanceW
| 0xB84DD256 |    1851 |  352 | WmiReceiveNotificationsA
| 0xB84DD26C |    1852 |  353 | WmiReceiveNotificationsW
| 0x69F28EA3 |    1853 |  354 | WmiSetSingleInstanceA
| 0x69F28EB9 |    1854 |  355 | WmiSetSingleInstanceW
| 0x65E0A907 |    1855 |  356 | WmiSetSingleItemA
| 0x65E0A91D |    1856 |  357 | WmiSetSingleItemW
| 0x10442897 |    1857 |  358 | WriteEncryptedFileRaw
