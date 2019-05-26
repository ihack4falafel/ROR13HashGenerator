The following is table of pre-computed ROR-13 hashes for all netapi32.dll Win32 APIs. The Win32 APIs list was generated using the below command.

```
dumpbin.exe /exports c:\windows\system32\netapi32.dll
```

| hashes     | ordinal | hint | name
|------------|:-------:|:----:|-----------------------------------------------------------------------------------------------        
| 0x9801F8D3 |       1 |    0 | DavAddConnection (forwarded to ext-ms-win-rdr-davhlpr-l1-1-0.DavAddConnection)
| 0xE4980E1B |       2 |    1 | DavDeleteConnection (forwarded to ext-ms-win-rdr-davhlpr-l1-1-0.DavDeleteConnection)
| 0x97C65877 |       3 |    2 | DavFlushFile (forwarded to ext-ms-win-rdr-davhlpr-l1-1-0.DavFlushFile)
| 0x837B3D23 |       4 |    3 | DavGetExtendedError (forwarded to ext-ms-win-rdr-davhlpr-l1-1-0.DavGetExtendedError)
| 0x9C82D00C |       5 |    4 | DavGetHTTPFromUNCPath (forwarded to ext-ms-win-rdr-davhlpr-l1-1-0.DavGetHTTPFromUNCPath)
| 0x976BB66A |       6 |    5 | DavGetUNCFromHTTPPath (forwarded to ext-ms-win-rdr-davhlpr-l1-1-0.DavGetUNCFromHTTPPath)
| 0xD30354A7 |       7 |    6 | DsAddressToSiteNamesA (forwarded to LOGONCLI.DsAddressToSiteNamesA)
| 0xC4952B35 |       8 |    7 | DsAddressToSiteNamesExA (forwarded to LOGONCLI.DsAddressToSiteNamesExA)
| 0xC4952B4B |       9 |    8 | DsAddressToSiteNamesExW (forwarded to LOGONCLI.DsAddressToSiteNamesExW)
| 0xD30354BD |      10 |    9 | DsAddressToSiteNamesW (forwarded to LOGONCLI.DsAddressToSiteNamesW)
| 0x46D15E80 |      11 |    A | DsDeregisterDnsHostRecordsA (forwarded to LOGONCLI.DsDeregisterDnsHostRecordsA)
| 0x46D15E96 |      12 |    B | DsDeregisterDnsHostRecordsW (forwarded to LOGONCLI.DsDeregisterDnsHostRecordsW)
| 0xEBA7C69D |      13 |    C | DsEnumerateDomainTrustsA (forwarded to LOGONCLI.DsEnumerateDomainTrustsA)
| 0xEBA7C6B3 |      14 |    D | DsEnumerateDomainTrustsW (forwarded to LOGONCLI.DsEnumerateDomainTrustsW)
| 0x97A4120B |      15 |    E | DsGetDcCloseW (forwarded to LOGONCLI.DsGetDcCloseW)
| 0x6BC74250 |      16 |    F | DsGetDcNameA (forwarded to LOGONCLI.DsGetDcNameA)
| 0x6BC74266 |      17 |   10 | DsGetDcNameW (forwarded to LOGONCLI.DsGetDcNameW)
| 0x9C038BBC |      18 |   11 | DsGetDcNameWithAccountA (forwarded to LOGONCLI.DsGetDcNameWithAccountA)
| 0x9C038BD2 |      19 |   12 | DsGetDcNameWithAccountW (forwarded to LOGONCLI.DsGetDcNameWithAccountW)
| 0x743F4510 |      20 |   13 | DsGetDcNextA (forwarded to LOGONCLI.DsGetDcNextA)
| 0x743F4526 |      21 |   14 | DsGetDcNextW (forwarded to LOGONCLI.DsGetDcNextW)
| 0x8A0F5050 |      22 |   15 | DsGetDcOpenA (forwarded to LOGONCLI.DsGetDcOpenA)
| 0x8A0F5066 |      23 |   16 | DsGetDcOpenW (forwarded to LOGONCLI.DsGetDcOpenW)
| 0x59830FA8 |      24 |   17 | DsGetDcSiteCoverageA (forwarded to LOGONCLI.DsGetDcSiteCoverageA)
| 0x59830FBE |      25 |   18 | DsGetDcSiteCoverageW (forwarded to LOGONCLI.DsGetDcSiteCoverageW)
| 0x442BEA3C |      26 |   19 | DsGetForestTrustInformationW (forwarded to LOGONCLI.DsGetForestTrustInformationW)
| 0xFC8EB01D |      27 |   1A | DsGetSiteNameA (forwarded to LOGONCLI.DsGetSiteNameA)
| 0xFC8EB033 |      28 |   1B | DsGetSiteNameW (forwarded to LOGONCLI.DsGetSiteNameW)
| 0xA1788E4F |      29 |   1C | DsMergeForestTrustInformationW (forwarded to LOGONCLI.DsMergeForestTrustInformationW)
| 0xBB067C12 |      30 |   1D | DsRoleFreeMemory (forwarded to DSROLE.DsRoleFreeMemory)
| 0x9281779F |      31 |   1E | DsRoleGetPrimaryDomainInformation (forwarded to DSROLE.DsRoleGetPrimaryDomainInformation)
| 0x8FFD31EA |      32 |   1F | DsValidateSubnetNameA (forwarded to LOGONCLI.DsValidateSubnetNameA)
| 0x8FFD3200 |      33 |   20 | DsValidateSubnetNameW (forwarded to LOGONCLI.DsValidateSubnetNameW)
| 0x107C89FC |      34 |   21 | I_BrowserSetNetlogonState
| 0xC60F8AB4 |      35 |   22 | I_DsUpdateReadOnlyServerDnsRecords (forwarded to LOGONCLI.I_DsUpdateReadOnlyServerDnsRecords)
| 0xD088DD1  |      36 |   23 | I_NetAccountDeltas (forwarded to LOGONCLI.I_NetAccountDeltas)
| 0x96380724 |      37 |   24 | I_NetAccountSync (forwarded to LOGONCLI.I_NetAccountSync)
| 0x52BF602E |      38 |   25 | I_NetChainSetClientAttributes (forwarded to LOGONCLI.I_NetChainSetClientAttributes)
| 0x172962D  |      39 |   26 | I_NetChainSetClientAttributes2 (forwarded to LOGONCLI.I_NetChainSetClientAttributes2)
| 0x531D6523 |      40 |   27 | I_NetDatabaseDeltas (forwarded to LOGONCLI.I_NetDatabaseDeltas)
| 0xDD00558D |      41 |   28 | I_NetDatabaseRedo (forwarded to LOGONCLI.I_NetDatabaseRedo)
| 0xDF505A81 |      42 |   29 | I_NetDatabaseSync (forwarded to LOGONCLI.I_NetDatabaseSync)
| 0xD40EFAB4 |      43 |   2A | I_NetDatabaseSync2 (forwarded to LOGONCLI.I_NetDatabaseSync2)
| 0x8B061C10 |      44 |   2B | I_NetDfsGetVersion (forwarded to SRVCLI.I_NetDfsGetVersion)
| 0xCAB8D300 |      45 |   2C | I_NetDfsIsThisADomainName (forwarded to DFSCLI.I_NetDfsIsThisADomainName)
| 0x498BFD80 |      46 |   2D | I_NetGetDCList (forwarded to LOGONCLI.I_NetGetDCList)
| 0x8B350DA1 |      47 |   2E | I_NetGetForestTrustInformation (forwarded to LOGONCLI.I_NetGetForestTrustInformation)
| 0xAEF0824C |      48 |   2F | I_NetLogonControl (forwarded to LOGONCLI.I_NetLogonControl)
| 0x126577B6 |      49 |   30 | I_NetLogonControl2 (forwarded to LOGONCLI.I_NetLogonControl2)
| 0x9B2837E7 |      50 |   31 | I_NetLogonGetDomainInfo (forwarded to LOGONCLI.I_NetLogonGetDomainInfo)
| 0xBF4C627D |      51 |   32 | I_NetLogonSamLogoff (forwarded to LOGONCLI.I_NetLogonSamLogoff)
| 0x8C42F7F1 |      52 |   33 | I_NetLogonSamLogon (forwarded to LOGONCLI.I_NetLogonSamLogon)
| 0x12E5FCDB |      53 |   34 | I_NetLogonSamLogonEx (forwarded to LOGONCLI.I_NetLogonSamLogonEx)
| 0x4BCC126A |      54 |   35 | I_NetLogonSamLogonWithFlags (forwarded to LOGONCLI.I_NetLogonSamLogonWithFlags)
| 0xCF26AC10 |      55 |   36 | I_NetLogonSendToSam (forwarded to LOGONCLI.I_NetLogonSendToSam)
| 0xC164627D |      56 |   37 | I_NetLogonUasLogoff (forwarded to LOGONCLI.I_NetLogonUasLogoff)
| 0x8C42F834 |      57 |   38 | I_NetLogonUasLogon (forwarded to LOGONCLI.I_NetLogonUasLogon)
| 0xE3FB828C |      58 |   39 | I_NetServerAuthenticate (forwarded to LOGONCLI.I_NetServerAuthenticate)
| 0x1467200E |      59 |   3A | I_NetServerAuthenticate2 (forwarded to LOGONCLI.I_NetServerAuthenticate2)
| 0x1467200F |      60 |   3B | I_NetServerAuthenticate3 (forwarded to LOGONCLI.I_NetServerAuthenticate3)
| 0x1BB43772 |      61 |   3C | I_NetServerGetTrustInfo (forwarded to LOGONCLI.I_NetServerGetTrustInfo)
| 0xA5AC36E3 |      62 |   3D | I_NetServerPasswordGet (forwarded to LOGONCLI.I_NetServerPasswordGet)
| 0xA5AC39E3 |      63 |   3E | I_NetServerPasswordSet (forwarded to LOGONCLI.I_NetServerPasswordSet)
| 0xCF1D2D93 |      64 |   3F | I_NetServerPasswordSet2 (forwarded to LOGONCLI.I_NetServerPasswordSet2)
| 0xC2819E24 |      65 |   40 | I_NetServerReqChallenge (forwarded to LOGONCLI.I_NetServerReqChallenge)
| 0x6B80E3E6 |      66 |   41 | I_NetServerSetServiceBits (forwarded to SRVCLI.I_NetServerSetServiceBits)
| 0xE260FA12 |      67 |   42 | I_NetServerSetServiceBitsEx (forwarded to SRVCLI.I_NetServerSetServiceBitsEx)
| 0xD06F6B2C |      68 |   43 | I_NetServerTrustPasswordsGet (forwarded to LOGONCLI.I_NetServerTrustPasswordsGet)
| 0xAE7F300C |      69 |   44 | I_NetlogonComputeClientDigest (forwarded to LOGONCLI.I_NetlogonComputeClientDigest)
| 0xFF9776EA |      70 |   45 | I_NetlogonComputeServerDigest (forwarded to LOGONCLI.I_NetlogonComputeServerDigest)
| 0xEC52ED50 |      71 |   46 | NetAccessAdd
| 0xEC5AEE18 |      72 |   47 | NetAccessDel
| 0x730F6584 |      73 |   48 | NetAccessEnum
| 0x441E2AB5 |      74 |   49 | NetAccessGetInfo
| 0xFB7832EF |      75 |   4A | NetAccessGetUserPerms
| 0x444E2AB5 |      76 |   4B | NetAccessSetInfo
| 0xA9A30AB1 |      77 |   4C | NetAddAlternateComputerName (forwarded to WKSCLI.NetAddAlternateComputerName)
| 0x964D8A1  |      78 |   4D | NetAddServiceAccount (forwarded to LOGONCLI.NetAddServiceAccount)
| 0x3431547D |      79 |   4E | NetAlertRaise
| 0xE7D1FC5  |      80 |   4F | NetAlertRaiseEx
| 0xF8A98413 |      81 |   50 | NetApiBufferAllocate (forwarded to NETUTILS.NetApiBufferAllocate)
| 0xC0AAF20C |      82 |   51 | NetApiBufferFree (forwarded to NETUTILS.NetApiBufferFree)
| 0x84F66B07 |      83 |   52 | NetApiBufferReallocate (forwarded to NETUTILS.NetApiBufferReallocate)
| 0xDB52EFCC |      84 |   53 | NetApiBufferSize (forwarded to NETUTILS.NetApiBufferSize)
| 0x527C636A |      85 |   54 | NetAuditClear
| 0xAA3F0892 |      86 |   55 | NetAuditRead
| 0x5F15A45D |      87 |   56 | NetAuditWrite
| 0x56865061 |      88 |   57 | NetConfigGet
| 0xC60D1D4C |      89 |   58 | NetConfigGetAll
| 0x56865361 |      90 |   59 | NetConfigSet
| 0xB50209BD |      91 |   5A | NetConnectionEnum (forwarded to SRVCLI.NetConnectionEnum)
| 0x45DB1B3C |      92 |   5B | NetCreateProvisioningPackage (forwarded to NETJOIN.NetCreateProvisioningPackage)
| 0x38F67D67 |      93 |   5C | NetDfsAdd (forwarded to DFSCLI.NetDfsAdd)
| 0x9D1C4031 |      94 |   5D | NetDfsAddFtRoot (forwarded to DFSCLI.NetDfsAddFtRoot)
| 0x263E6799 |      95 |   5E | NetDfsAddRootTarget (forwarded to DFSCLI.NetDfsAddRootTarget)
| 0xC79A0955 |      96 |   5F | NetDfsAddStdRoot (forwarded to DFSCLI.NetDfsAddStdRoot)
| 0xC8627B0  |      97 |   60 | NetDfsAddStdRootForced (forwarded to DFSCLI.NetDfsAddStdRootForced)
| 0xF3C1CAA0 |      98 |   61 | NetDfsEnum (forwarded to DFSCLI.NetDfsEnum)
| 0xD10D2104 |      99 |   62 | NetDfsGetClientInfo (forwarded to DFSCLI.NetDfsGetClientInfo)
| 0x209A200E |     100 |   63 | NetDfsGetDcAddress (forwarded to DFSCLI.NetDfsGetDcAddress)
| 0x84D34D97 |     101 |   64 | NetDfsGetFtContainerSecurity (forwarded to DFSCLI.NetDfsGetFtContainerSecurity)
| 0x7D1F8F7F |     102 |   65 | NetDfsGetInfo (forwarded to DFSCLI.NetDfsGetInfo)
| 0x607473CA |     103 |   66 | NetDfsGetSecurity (forwarded to DFSCLI.NetDfsGetSecurity)
| 0x6E5EC95  |     104 |   67 | NetDfsGetStdContainerSecurity (forwarded to DFSCLI.NetDfsGetStdContainerSecurity)
| 0x9B4709DE |     105 |   68 | NetDfsGetSupportedNamespaceVersion (forwarded to DFSCLI.NetDfsGetSupportedNamespaceVersion)
| 0x66F14E08 |     106 |   69 | NetDfsManagerGetConfigInfo (forwarded to DFSCLI.NetDfsManagerGetConfigInfo)
| 0xF6F44B6A |     107 |   6A | NetDfsManagerInitialize (forwarded to DFSCLI.NetDfsManagerInitialize)
| 0xE76C2AE  |     108 |   6B | NetDfsManagerSendSiteInfo (forwarded to DFSCLI.NetDfsManagerSendSiteInfo)
| 0x3C9CAD9  |     109 |   6C | NetDfsMove (forwarded to DFSCLI.NetDfsMove)
| 0x64221928 |     110 |   6D | NetDfsRemove (forwarded to DFSCLI.NetDfsRemove)
| 0xC20ECE0  |     111 |   6E | NetDfsRemoveFtRoot (forwarded to DFSCLI.NetDfsRemoveFtRoot)
| 0x9AAF39CB |     112 |   6F | NetDfsRemoveFtRootForced (forwarded to DFSCLI.NetDfsRemoveFtRootForced)
| 0x71094E89 |     113 |   70 | NetDfsRemoveRootTarget (forwarded to DFSCLI.NetDfsRemoveRootTarget)
| 0x2D0D817B |     114 |   71 | NetDfsRemoveStdRoot (forwarded to DFSCLI.NetDfsRemoveStdRoot)
| 0x65DA15A8 |     115 |   72 | NetDfsRename (forwarded to DFSCLI.NetDfsRename)
| 0xD10D21C4 |     116 |   73 | NetDfsSetClientInfo (forwarded to DFSCLI.NetDfsSetClientInfo)
| 0x84D94D97 |     117 |   74 | NetDfsSetFtContainerSecurity (forwarded to DFSCLI.NetDfsSetFtContainerSecurity)
| 0x7D4F8F7F |     118 |   75 | NetDfsSetInfo (forwarded to DFSCLI.NetDfsSetInfo)
| 0x607473CD |     119 |   76 | NetDfsSetSecurity (forwarded to DFSCLI.NetDfsSetSecurity)
| 0x6E5ECC5  |     120 |   77 | NetDfsSetStdContainerSecurity (forwarded to DFSCLI.NetDfsSetStdContainerSecurity)
| 0xD79A1BC3 |     121 |   78 | NetEnumerateComputerNames (forwarded to WKSCLI.NetEnumerateComputerNames)
| 0x586C257  |     122 |   79 | NetEnumerateServiceAccounts (forwarded to LOGONCLI.NetEnumerateServiceAccounts)
| 0xFECF7664 |     123 |   7A | NetEnumerateTrustedDomains (forwarded to LOGONCLI.NetEnumerateTrustedDomains)
| 0x49B163DD |     124 |   7B | NetErrorLogClear
| 0x4A4D6779 |     125 |   7C | NetErrorLogRead
| 0x564AA4D0 |     126 |   7D | NetErrorLogWrite
| 0xE3EBF991 |     127 |   7E | NetFileClose (forwarded to SRVCLI.NetFileClose)
| 0x83559CF7 |     128 |   7F | NetFileEnum (forwarded to SRVCLI.NetFileEnum)
| 0x2A3EB724 |     129 |   80 | NetFileGetInfo (forwarded to SRVCLI.NetFileGetInfo)
| 0x120BF354 |     130 |   81 | NetFreeAadJoinInformation (forwarded to DSREG.DsrFreeJoinInfo)
| 0x6302A515 |     131 |   82 | NetGetAadJoinInformation (forwarded to DSREG.DsrGetJoinInfo)
| 0x556335E1 |     132 |   83 | NetGetAnyDCName (forwarded to LOGONCLI.NetGetAnyDCName)
| 0x28DBF581 |     133 |   84 | NetGetDCName (forwarded to LOGONCLI.NetGetDCName)
| 0x7FFD47D0 |     134 |   85 | NetGetDisplayInformationIndex (forwarded to SAMCLI.NetGetDisplayInformationIndex)
| 0xC90CA3B3 |     135 |   86 | NetGetJoinInformation (forwarded to WKSCLI.NetGetJoinInformation)
| 0x7BEE3094 |     136 |   87 | NetGetJoinableOUs (forwarded to WKSCLI.NetGetJoinableOUs)
| 0x58F291D0 |     137 |   88 | NetGroupAdd (forwarded to SAMCLI.NetGroupAdd)
| 0xD64522C1 |     138 |   89 | NetGroupAddUser (forwarded to SAMCLI.NetGroupAddUser)
| 0x58FA9298 |     139 |   8A | NetGroupDel (forwarded to SAMCLI.NetGroupDel)
| 0x5651A2C2 |     140 |   8B | NetGroupDelUser (forwarded to SAMCLI.NetGroupDelUser)
| 0x970ACA81 |     141 |   8C | NetGroupEnum (forwarded to SAMCLI.NetGroupEnum)
| 0x3E66217F |     142 |   8D | NetGroupGetInfo (forwarded to SAMCLI.NetGroupGetInfo)
| 0x1612B364 |     143 |   8E | NetGroupGetUsers (forwarded to SAMCLI.NetGroupGetUsers)
| 0x3E96217F |     144 |   8F | NetGroupSetInfo (forwarded to SAMCLI.NetGroupSetInfo)
| 0x1612B4E4 |     145 |   90 | NetGroupSetUsers (forwarded to SAMCLI.NetGroupSetUsers)
| 0xA3D77825 |     146 |   91 | NetIsServiceAccount (forwarded to LOGONCLI.NetIsServiceAccount)
| 0x4ED36AEE |     147 |   92 | NetJoinDomain (forwarded to WKSCLI.NetJoinDomain)
| 0x8BD20A9F |     148 |   93 | NetLocalGroupAdd (forwarded to SAMCLI.NetLocalGroupAdd)
| 0x87AC9861 |     149 |   94 | NetLocalGroupAddMember (forwarded to SAMCLI.NetLocalGroupAddMember)
| 0xC30C3DD7 |     150 |   95 | NetLocalGroupAddMembers (forwarded to SAMCLI.NetLocalGroupAddMembers)
| 0x8BDA0B67 |     151 |   96 | NetLocalGroupDel (forwarded to SAMCLI.NetLocalGroupDel)
| 0x8ACC9881 |     152 |   97 | NetLocalGroupDelMember (forwarded to SAMCLI.NetLocalGroupDelMember)
| 0xC40C56D7 |     153 |   98 | NetLocalGroupDelMembers (forwarded to SAMCLI.NetLocalGroupDelMembers)
| 0x5D84617D |     154 |   99 | NetLocalGroupEnum (forwarded to SAMCLI.NetLocalGroupEnum)
| 0x35F314AD |     155 |   9A | NetLocalGroupGetInfo (forwarded to SAMCLI.NetLocalGroupGetInfo)
| 0xC40C6FD7 |     156 |   9B | NetLocalGroupGetMembers (forwarded to SAMCLI.NetLocalGroupGetMembers)
| 0x362314AD |     157 |   9C | NetLocalGroupSetInfo (forwarded to SAMCLI.NetLocalGroupSetInfo)
| 0xC40CCFD7 |     158 |   9D | NetLocalGroupSetMembers (forwarded to SAMCLI.NetLocalGroupSetMembers)
| 0xDB363D4D |     159 |   9E | NetLogonGetTimeServiceParentDomain (forwarded to LOGONCLI.NetLogonGetTimeServiceParentDomain)
| 0xA9464B96 |     160 |   9F | NetLogonSetServiceBits (forwarded to LOGONCLI.NetLogonSetServiceBits)
| 0xD3EEC86D |     161 |   A0 | NetMessageBufferSend
| 0x3D17CBEF |     162 |   A1 | NetMessageNameAdd
| 0x3D1FCCB7 |     163 |   A2 | NetMessageNameDel
| 0x6801EBAB |     164 |   A3 | NetMessageNameEnum
| 0x92080FC1 |     165 |   A4 | NetMessageNameGetInfo
| 0xAF5A5A3C |     166 |   A5 | NetProvisionComputerAccount (forwarded to NETJOIN.NetProvisionComputerAccount)
| 0x97A23B63 |     167 |   A6 | NetQueryDisplayInformation (forwarded to SAMCLI.NetQueryDisplayInformation)
| 0x14B078B1 |     168 |   A7 | NetQueryServiceAccount (forwarded to LOGONCLI.NetQueryServiceAccount)
| 0x88F581D8 |     169 |   A8 | NetRegisterDomainNameChangeNotification
| 0x65D94028 |     170 |   A9 | NetRemoteComputerSupports (forwarded to NETUTILS.NetRemoteComputerSupports)
| 0xE0D30235 |     171 |   AA | NetRemoteTOD (forwarded to SRVCLI.NetRemoteTOD)
| 0xB5B4ABE1 |     172 |   AB | NetRemoveAlternateComputerName (forwarded to WKSCLI.NetRemoveAlternateComputerName)
| 0x89C565AA |     173 |   AC | NetRemoveServiceAccount (forwarded to LOGONCLI.NetRemoveServiceAccount)
| 0x9B438AE9 |     174 |   AD | NetRenameMachineInDomain (forwarded to WKSCLI.NetRenameMachineInDomain)
| 0xE479CD17 |     175 |   AE | NetReplExportDirAdd
| 0xE481CDDF |     176 |   AF | NetReplExportDirDel
| 0x714726BB |     177 |   B0 | NetReplExportDirEnum
| 0xB21A9A37 |     178 |   B1 | NetReplExportDirGetInfo
| 0x7EB726F9 |     179 |   B2 | NetReplExportDirLock
| 0xB24A9A37 |     180 |   B3 | NetReplExportDirSetInfo
| 0x42E1AFCF |     181 |   B4 | NetReplExportDirUnlock
| 0x2E3E9807 |     182 |   B5 | NetReplGetInfo
| 0x2481CD15 |     183 |   B6 | NetReplImportDirAdd
| 0x2489CDDD |     184 |   B7 | NetReplImportDirDel
| 0x713126FB |     185 |   B8 | NetReplImportDirEnum
| 0x321A6E38 |     186 |   B9 | NetReplImportDirGetInfo
| 0x7EA12739 |     187 |   BA | NetReplImportDirLock
| 0x3D61BFCF |     188 |   BB | NetReplImportDirUnlock
| 0x2E6E9807 |     189 |   BC | NetReplSetInfo
| 0x5E4F0BF8 |     190 |   BD | NetRequestOfflineDomainJoin (forwarded to NETJOIN.NetRequestOfflineDomainJoin)
| 0x40AEBE09 |     191 |   BE | NetRequestProvisioningPackageInstall (forwarded to NETJOIN.NetRequestProvisioningPackageInstall)
| 0x485E04A0 |     192 |   BF | NetScheduleJobAdd (forwarded to SCHEDCLI.NetScheduleJobAdd)
| 0x48660568 |     193 |   C0 | NetScheduleJobDel (forwarded to SCHEDCLI.NetScheduleJobDel)
| 0x2D8A45DD |     194 |   C1 | NetScheduleJobEnum (forwarded to SCHEDCLI.NetScheduleJobEnum)
| 0xF5932075 |     195 |   C2 | NetScheduleJobGetInfo (forwarded to SCHEDCLI.NetScheduleJobGetInfo)
| 0x278D2774 |     196 |   C3 | NetServerAliasAdd (forwarded to SRVCLI.NetServerAliasAdd)
| 0x2795283C |     197 |   C4 | NetServerAliasDel (forwarded to SRVCLI.NetServerAliasDel)
| 0x44293F56 |     198 |   C5 | NetServerAliasEnum (forwarded to SRVCLI.NetServerAliasEnum)
| 0xC2A3715A |     199 |   C6 | NetServerComputerNameAdd (forwarded to SRVCLI.NetServerComputerNameAdd)
| 0xC2AB7222 |     200 |   C7 | NetServerComputerNameDel (forwarded to SRVCLI.NetServerComputerNameDel)
| 0xCC09D321 |     201 |   C8 | NetServerDiskEnum (forwarded to SRVCLI.NetServerDiskEnum)
| 0x7553E75D |     202 |   C9 | NetServerEnum
| 0x5721D7D5 |     203 |   CA | NetServerEnumEx
| 0xF622B3B8 |     204 |   CB | NetServerGetInfo (forwarded to SRVCLI.NetServerGetInfo)
| 0xF652B3B8 |     205 |   CC | NetServerSetInfo (forwarded to SRVCLI.NetServerSetInfo)
| 0xCB79F324 |     206 |   CD | NetServerTransportAdd (forwarded to SRVCLI.NetServerTransportAdd)
| 0xE0A4C9AA |     207 |   CE | NetServerTransportAddEx (forwarded to SRVCLI.NetServerTransportAddEx)
| 0xCB81F3EC |     208 |   CF | NetServerTransportDel (forwarded to SRVCLI.NetServerTransportDel)
| 0xA1AE5EBC |     209 |   D0 | NetServerTransportEnum (forwarded to SRVCLI.NetServerTransportEnum)
| 0x1A42283F |     210 |   D1 | NetServiceControl
| 0x693DA944 |     211 |   D2 | NetServiceEnum
| 0xC40A873C |     212 |   D3 | NetServiceGetInfo
| 0x9A4273FE |     213 |   D4 | NetServiceInstall
| 0xC6C7ACFE |     214 |   D5 | NetSessionDel (forwarded to SRVCLI.NetSessionDel)
| 0x6A3E38EA |     215 |   D6 | NetSessionEnum (forwarded to SRVCLI.NetSessionEnum)
| 0x100C885C |     216 |   D7 | NetSessionGetInfo (forwarded to SRVCLI.NetSessionGetInfo)
| 0x9BFDF698 |     217 |   D8 | NetSetPrimaryComputerName (forwarded to WKSCLI.NetSetPrimaryComputerName)
| 0x42CA6349 |     218 |   D9 | NetShareAdd (forwarded to SRVCLI.NetShareAdd)
| 0xBDB0F2FB |     219 |   DA | NetShareCheck (forwarded to SRVCLI.NetShareCheck)
| 0x42D26411 |     220 |   DB | NetShareDel (forwarded to SRVCLI.NetShareDel)
| 0xB6C104C8 |     221 |   DC | NetShareDelEx (forwarded to SRVCLI.NetShareDelEx)
| 0xE5A464AC |     222 |   DD | NetShareDelSticky (forwarded to SRVCLI.NetShareDelSticky)
| 0x22D21940 |     223 |   DE | NetShareEnum (forwarded to SRVCLI.NetShareEnum)
| 0xBA5FE4AB |     224 |   DF | NetShareEnumSticky (forwarded to SRVCLI.NetShareEnumSticky)
| 0xBB7DB01C |     225 |   E0 | NetShareGetInfo (forwarded to SRVCLI.NetShareGetInfo)
| 0xBBADB01C |     226 |   E1 | NetShareSetInfo (forwarded to SRVCLI.NetShareSetInfo)
| 0xEEB8A1C  |     227 |   E2 | NetStatisticsGet
| 0x135A54D  |     228 |   E3 | NetUnjoinDomain (forwarded to WKSCLI.NetUnjoinDomain)
| 0x178D2E71 |     229 |   E4 | NetUnregisterDomainNameChangeNotification
| 0x9CF74D6F |     230 |   E5 | NetUseAdd (forwarded to WKSCLI.NetUseAdd)
| 0x9CFF4E37 |     231 |   E6 | NetUseDel (forwarded to WKSCLI.NetUseDel)
| 0x7404EAA7 |     232 |   E7 | NetUseEnum (forwarded to WKSCLI.NetUseEnum)
| 0x8A2015BF |     233 |   E8 | NetUseGetInfo (forwarded to WKSCLI.NetUseGetInfo)
| 0xCD7CDF5E |     234 |   E9 | NetUserAdd (forwarded to SAMCLI.NetUserAdd)
| 0x17D629B4 |     235 |   EA | NetUserChangePassword (forwarded to SAMCLI.NetUserChangePassword)
| 0xCD84E026 |     236 |   EB | NetUserDel (forwarded to SAMCLI.NetUserDel)
| 0x37E6ED4  |     237 |   EC | NetUserEnum (forwarded to SAMCLI.NetUserEnum)
| 0xE54273EA |     238 |   ED | NetUserGetGroups (forwarded to SAMCLI.NetUserGetGroups)
| 0xE33F08C7 |     239 |   EE | NetUserGetInfo (forwarded to SAMCLI.NetUserGetInfo)
| 0x88185D14 |     240 |   EF | NetUserGetLocalGroups (forwarded to SAMCLI.NetUserGetLocalGroups)
| 0xF2AA09B8 |     241 |   F0 | NetUserModalsGet (forwarded to SAMCLI.NetUserModalsGet)
| 0xF2AA0CB8 |     242 |   F1 | NetUserModalsSet (forwarded to SAMCLI.NetUserModalsSet)
| 0xF14273EA |     243 |   F2 | NetUserSetGroups (forwarded to SAMCLI.NetUserSetGroups)
| 0xE36F08C7 |     244 |   F3 | NetUserSetInfo (forwarded to SAMCLI.NetUserSetInfo)
| 0x7D2314B8 |     245 |   F4 | NetValidateName (forwarded to WKSCLI.NetValidateName)
| 0xEC079653 |     246 |   F5 | NetValidatePasswordPolicy (forwarded to SAMCLI.NetValidatePasswordPolicy)
| 0x88D5BA6  |     247 |   F6 | NetValidatePasswordPolicyFree (forwarded to SAMCLI.NetValidatePasswordPolicyFree)
| 0x7D863F9D |     248 |   F7 | NetWkstaGetInfo
| 0x7DB63F9D |     249 |   F8 | NetWkstaSetInfo
| 0xF2BB917  |     250 |   F9 | NetWkstaTransportAdd (forwarded to WKSCLI.NetWkstaTransportAdd)
| 0xF33B9DF  |     251 |   FA | NetWkstaTransportDel (forwarded to WKSCLI.NetWkstaTransportDel)
| 0xD1407C4A |     252 |   FB | NetWkstaTransportEnum (forwarded to WKSCLI.NetWkstaTransportEnum)
| 0x2B568057 |     253 |   FC | NetWkstaUserEnum (forwarded to WKSCLI.NetWkstaUserEnum)
| 0xE98EB8EA |     254 |   FD | NetWkstaUserGetInfo (forwarded to WKSCLI.NetWkstaUserGetInfo)
| 0xE9BEB8EA |     255 |   FE | NetWkstaUserSetInfo (forwarded to WKSCLI.NetWkstaUserSetInfo)
| 0xFC98CD7F |     256 |   FF | NetapipBufferAllocate (forwarded to NETUTILS.NetapipBufferAllocate)
| 0x48B75AE6 |     257 |  100 | Netbios
| 0xF24F7FD4 |     258 |  101 | NetpAddTlnFtinfoEntry
| 0xBAA8721B |     259 |  102 | NetpAllocFtinfoEntry
| 0xF6856CEE |     260 |  103 | NetpAssertFailed
| 0x5753EA72 |     261 |  104 | NetpCleanFtinfoContext
| 0x71BC4D6  |     262 |  105 | NetpCloseConfigData
| 0x2D8409DA |     263 |  106 | NetpCopyFtinfoContext
| 0x199CC382 |     264 |  107 | NetpDbgPrint
| 0x513286BB |     265 |  108 | NetpGetConfigBool
| 0x460AA9F8 |     266 |  109 | NetpGetConfigDword
| 0xA1B96CDA |     267 |  10A | NetpGetConfigTStrArray
| 0x1A23C939 |     268 |  10B | NetpGetConfigValue
| 0x553FFBDC |     269 |  10C | NetpGetFileSecurity
| 0x92D3F7   |     270 |  10D | NetpHexDump
| 0xB09EDDA  |     271 |  10E | NetpInitFtinfoContext
| 0x90121588 |     272 |  10F | NetpIsRemote (forwarded to NETUTILS.NetpIsRemote)
| 0xB8576710 |     273 |  110 | NetpIsUncComputerNameValid
| 0xBC2FD046 |     274 |  111 | NetpMergeFtinfo
| 0xCB8A85B1 |     275 |  112 | NetpNetBiosReset
| 0x2965F6E1 |     276 |  113 | NetpNetBiosStatusToApiStatus
| 0xA4F17830 |     277 |  114 | NetpOpenConfigData
| 0x55402BDC |     278 |  115 | NetpSetFileSecurity
| 0xFD008F   |     279 |  116 | NetpwNameCanonicalize (forwarded to NETUTILS.NetpwNameCanonicalize)
| 0x4C95989B |     280 |  117 | NetpwNameCompare (forwarded to NETUTILS.NetpwNameCompare)
| 0x4B19F331 |     281 |  118 | NetpwNameValidate (forwarded to NETUTILS.NetpwNameValidate)
| 0x447D00BF |     282 |  119 | NetpwPathCanonicalize (forwarded to NETUTILS.NetpwPathCanonicalize)
| 0xD39598FB |     283 |  11A | NetpwPathCompare (forwarded to NETUTILS.NetpwPathCompare)
| 0x24D82DDD |     284 |  11B | NetpwPathType (forwarded to NETUTILS.NetpwPathType)
| 0x86C03771 |     285 |  11C | NlBindingAddServerToCache (forwarded to LOGONCLI.NlBindingAddServerToCache)
| 0x6056559F |     286 |  11D | NlBindingRemoveServerFromCache (forwarded to LOGONCLI.NlBindingRemoveServerFromCache)
| 0xDBC7015C |     287 |  11E | NlBindingSetAuthInfo (forwarded to LOGONCLI.NlBindingSetAuthInfo)
| 0x1552F4D1 |     288 |  11F | RxNetAccessAdd
| 0x155AF599 |     289 |  120 | RxNetAccessDel
| 0xAF10AD84 |     290 |  121 | RxNetAccessEnum
| 0x44962D45 |     291 |  122 | RxNetAccessGetInfo
| 0xFBB43437 |     292 |  123 | RxNetAccessGetUserPerms
| 0x44C62D45 |     293 |  124 | RxNetAccessSetInfo
| 0xB1552F5D |     294 |  125 | RxNetServerEnum
| 0x98D94CAF |     295 |  126 | RxNetUserPasswordSet
| 0x213F1D96 |     296 |  127 | RxRemoteApi
