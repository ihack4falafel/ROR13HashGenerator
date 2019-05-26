The following is table of pre-computed ROR-13 hashes for all Kernel32.dll Win32 APIs. The Win32 APIs list was generated using the below command.

```
dumpbin.exe /exports c:\windows\system32\kernel32.dll
```

| hashes     | ordinal | hint | name
| -----------|:-------:|:----:|---------------------------------------------------------------------------------------------------------
| 0x6AD53C0C |       1 |   0  | AcquireSRWLockExclusive (forwarded to NTDLL.RtlAcquireSRWLockExclusive)
| 0xE24F11E2 |       2 |   1  | AcquireSRWLockShared (forwarded to NTDLL.RtlAcquireSRWLockShared)
| 0x2FA60624 |       3 |   2  | ActivateActCtx
| 0x7FBFC9F6 |       4 |   3  | ActivateActCtxWorker
| 0xECFC3453 |       5 |   4  | AddAtomA
| 0xECFC3469 |       6 |   5  | AddAtomW
| 0x99161276 |       7 |   6  | AddConsoleAliasA
| 0x9916128C |       8 |   7  | AddConsoleAliasW
| 0x1F3F1F76 |       9 |   8  | AddDllDirectory (forwarded to api-ms-win-core-libraryloader-l1-1-0.AddDllDirectory)
| 0x730CEFAE |      10 |   9  | AddIntegrityLabelToBoundaryDescriptor
| 0x33675025 |      11 |   A  | AddLocalAlternateComputerNameA
| 0x3367503B |      12 |   B  | AddLocalAlternateComputerNameW
| 0xBFC36E12 |      13 |   C  | AddRefActCtx
| 0x1F7A0A6C |      14 |   D  | AddRefActCtxWorker
| 0xEC90751E |      15 |   E  | AddResourceAttributeAce
| 0xCDC729AB |      16 |   F  | AddSIDToBoundaryDescriptor
| 0x2AC96D93 |      17 |  10  | AddScopedPolicyIDAce
| 0x6B8B8FD9 |      18 |  11  | AddSecureMemoryCacheCallback
| 0xE1D8D4C2 |      19 |  12  | AddVectoredContinueHandler (forwarded to NTDLL.RtlAddVectoredContinueHandler)
| 0xF500ACF9 |      20 |  13  | AddVectoredExceptionHandler (forwarded to NTDLL.RtlAddVectoredExceptionHandler)
| 0x2CA68404 |      21 |  14  | AdjustCalendarDate
| 0xD9F868D8 |      22 |  15  | AllocConsole
| 0x6493DFD5 |      23 |  16  | AllocateUserPhysicalPages
| 0xDD6573EA |      24 |  17  | AllocateUserPhysicalPagesNuma
| 0x428E02F2 |      25 |  18  | AppPolicyGetClrCompat (forwarded to kernelbase.AppPolicyGetClrCompat)
| 0xE752C040 |      26 |  19  | AppPolicyGetCreateFileAccess (forwarded to kernelbase.AppPolicyGetCreateFileAccess)
| 0x6ADC30A  |      27 |  1A  | AppPolicyGetLifecycleManagement (forwarded to kernelbase.AppPolicyGetLifecycleManagement)
| 0xAE1FCDA9 |      28 |  1B  | AppPolicyGetMediaFoundationCodecLoading (forwarded to kernelbase.AppPolicyGetMediaFoundationCodecLoading)
| 0xE27545C4 |      29 |  1C  | AppPolicyGetProcessTerminationMethod (forwarded to kernelbase.AppPolicyGetProcessTerminationMethod)
| 0x7ECDD506 |      30 |  1D  | AppPolicyGetShowDeveloperDiagnostic (forwarded to kernelbase.AppPolicyGetShowDeveloperDiagnostic)
| 0xFA57DC26 |      31 |  1E  | AppPolicyGetThreadInitializationType (forwarded to kernelbase.AppPolicyGetThreadInitializationType)
| 0x643CAC50 |      32 |  1F  | AppPolicyGetWindowingModel (forwarded to kernelbase.AppPolicyGetWindowingModel)
| 0x619261CD |      33 |  20  | AppXGetOSMaxVersionTested (forwarded to kernelbase.AppXGetOSMaxVersionTested)
| 0xCEB4FB95 |      34 |  21  | ApplicationRecoveryFinished
| 0xCFFAEA64 |      35 |  22  | ApplicationRecoveryInProgress
| 0xE4EFB688 |      36 |  23  | AreFileApisANSI
| 0x6A5DA562 |      37 |  24  | AssignProcessToJobObject
| 0xCE5E158A |      38 |  25  | AttachConsole
| 0x89BD363F |      39 |  26  | BackupRead
| 0x8BDD3646 |      40 |  27  | BackupSeek
| 0xCC7CA04E |      41 |  28  | BackupWrite
| 0xB683D0D4 |      42 |  29  | BaseCheckAppcompatCache
| 0xA31C35A5 |      43 |  2A  | BaseCheckAppcompatCacheEx
| 0x3DC597CF |      44 |  2B  | BaseCheckAppcompatCacheExWorker
| 0xAA81E56D |      45 |  2C  | BaseCheckAppcompatCacheWorker
| 0x74C22D21 |      46 |  2D  | BaseCheckElevation
| 0xCAC9C870 |      47 |  2E  | BaseCleanupAppcompatCacheSupport
| 0x88F23685 |      48 |  2F  | BaseCleanupAppcompatCacheSupportWorker
| 0x8A63F0DC |      49 |  30  | BaseDestroyVDMEnvironment
| 0x375AE853 |      50 |  31  | BaseDllReadWriteIniFile
| 0xDF047EAC |      51 |  32  | BaseDumpAppcompatCache
| 0x61E28770 |      52 |  33  | BaseDumpAppcompatCacheWorker
| 0x637E7B93 |      53 |  34  | BaseElevationPostProcessing
| 0xB753C4F6 |      54 |  35  | BaseFlushAppcompatCache
| 0x7B09E8AD |      55 |  36  | BaseFlushAppcompatCacheWorker
| 0x22F82C45 |      56 |  37  | BaseFormatObjectAttributes
| 0x83A42B72 |      57 |  38  | BaseFormatTimeOut
| 0x63BD1FB5 |      58 |  39  | BaseFreeAppCompatDataForProcessWorker
| 0x6810E3A3 |      59 |  3A  | BaseGenerateAppCompatData
| 0x90B64FE0 |      60 |  3B  | BaseGetNamedObjectDirectory
| 0x4494F6FB |      61 |  3C  | BaseInitAppcompatCacheSupport
| 0x431C1DB2 |      62 |  3D  | BaseInitAppcompatCacheSupportWorker
| 0xEACEE92D |      63 |  3E  | BaseIsAppcompatInfrastructureDisabled
| 0xBE6B69A  |      64 |  3F  | BaseIsAppcompatInfrastructureDisabledWorker
| 0x78B31302 |      65 |  40  | BaseIsDosApplication
| 0x28D52ADB |      66 |  41  | BaseQueryModuleData
| 0x53BB7F41 |      67 |  42  | BaseReadAppCompatDataForProcessWorker
| 0xE682201E |      68 |  43  | BaseSetLastNTError
| 0x43DAE5F3 |      69 |  44  | BaseThreadInitThunk
| 0xA089932  |      70 |  45  | BaseUpdateAppcompatCache
| 0xCBF73380 |      71 |  46  | BaseUpdateAppcompatCacheWorker
| 0x9152B597 |      72 |  47  | BaseUpdateVDMEntry
| 0xBB8F6B00 |      73 |  48  | BaseVerifyUnicodeString
| 0xC4C4103C |      74 |  49  | BaseWriteErrorElevationRequiredEvent
| 0x6B889138 |      75 |  4A  | Basep8BitStringToDynamicUnicodeString
| 0xCD75FF00 |      76 |  4B  | BasepAllocateActivationContextActivationBlock
| 0x1AD9B639 |      77 |  4C  | BasepAnsiStringToDynamicUnicodeString
| 0x1ADAF35F |      78 |  4D  | BasepAppContainerEnvironmentExtension
| 0x4994642C |      79 |  4E  | BasepAppXExtension
| 0x33113C44 |      80 |  4F  | BasepCheckAppCompat
| 0xC1AAAE4F |      81 |  50  | BasepCheckWebBladeHashes
| 0xBC3379DF |      82 |  51  | BasepCheckWinSaferRestrictions
| 0xD2755D19 |      83 |  52  | BasepConstructSxsCreateProcessMessage
| 0xEE9E196E |      84 |  53  | BasepCopyEncryption
| 0x2454EB00 |      85 |  54  | BasepFreeActivationContextActivationBlock
| 0x19730033 |      86 |  55  | BasepFreeAppCompatData
| 0xD47BDBD3 |      87 |  56  | BasepGetAppCompatData
| 0xBE996D4E |      88 |  57  | BasepGetComputerNameFromNtPath
| 0xA7AF306D |      89 |  58  | BasepGetExeArchType
| 0xA0F61032 |      90 |  59  | BasepInitAppCompatData
| 0x9B46AD29 |      91 |  5A  | BasepIsProcessAllowed
| 0x5FBE19CC |      92 |  5B  | BasepMapModuleHandle
| 0x45031FAE |      93 |  5C  | BasepNotifyLoadStringResource
| 0x1ECDF5BB |      94 |  5D  | BasepPostSuccessAppXExtension
| 0xC6E166CA |      95 |  5E  | BasepProcessInvalidImage
| 0xFA11AD17 |      96 |  5F  | BasepQueryAppCompat
| 0x761CE3F  |      97 |  60  | BasepQueryModuleChpeSettings
| 0x1AB86DDA |      98 |  61  | BasepReleaseAppXContext
| 0xBABAEE44 |      99 |  62  | BasepReleaseSxsCreateProcessUtilityStruct
| 0x31913E3C |     100 |  63  | BasepReportFault
| 0xB75AE2A2 |     101 |  64  | BasepSetFileEncryptionCompression
| 0x872819B0 |     102 |  65  | Beep
| 0xCD6B7F7C |     103 |  66  | BeginUpdateResourceA
| 0xCD6B7F92 |     104 |  67  | BeginUpdateResourceW
| 0xB236B57C |     105 |  68  | BindIoCompletionCallback
| 0xB0C04DD2 |     106 |  69  | BuildCommDCBA
| 0xDEFB9C30 |     107 |  6A  | BuildCommDCBAndTimeoutsA
| 0xDEFB9C46 |     108 |  6B  | BuildCommDCBAndTimeoutsW
| 0xB0C04DE8 |     109 |  6C  | BuildCommDCBW
| 0x5A1BA03F |     110 |  6D  | CallNamedPipeA
| 0x5A1BA055 |     111 |  6E  | CallNamedPipeW
| 0xEFEA2BD2 |     112 |  6F  | CallbackMayRunLong
| 0x64F69166 |     113 |  70  | CancelDeviceWakeupRequest
| 0xCDD25406 |     114 |  71  | CancelIo
| 0x76BD022B |     115 |  72  | CancelIoEx
| 0x7E2FD007 |     116 |  73  | CancelSynchronousIo
| 0xE641D389 |     117 |  74  | CancelThreadpoolIo (forwarded to NTDLL.TpCancelAsyncIoOperation)
| 0x4D350C9C |     118 |  75  | CancelTimerQueueTimer
| 0x9FD2A4C4 |     119 |  76  | CancelWaitableTimer
| 0x628ABAE7 |     120 |  77  | CeipIsOptedIn (forwarded to kernelbase.CeipIsOptedIn)
| 0x69F71AF3 |     121 |  78  | ChangeTimerQueueTimer
| 0x5AFF55B3 |     122 |  79  | CheckAllowDecryptedRemoteDestinationPolicy
| 0x145F9703 |     123 |  7A  | CheckElevation
| 0x54350BFE |     124 |  7B  | CheckElevationEnabled
| 0x235B6CE4 |     125 |  7C  | CheckForReadOnlyResource
| 0x8EBF3B03 |     126 |  7D  | CheckForReadOnlyResourceFilter
| 0x97112B36 |     127 |  7E  | CheckNameLegalDOS8Dot3A
| 0x97112B4C |     128 |  7F  | CheckNameLegalDOS8Dot3W
| 0x43AF7D80 |     129 |  80  | CheckRemoteDebuggerPresent
| 0x70DBB0EC |     130 |  81  | CheckTokenCapability
| 0xA44C11B8 |     131 |  82  | CheckTokenMembershipEx
| 0xE0DDE9B  |     132 |  83  | ClearCommBreak
| 0xE7E11E2  |     133 |  84  | ClearCommError
| 0xE3C9A17B |     134 |  85  | CloseConsoleHandle
| 0xFFD97FB  |     135 |  86  | CloseHandle
| 0xC6809069 |     136 |  87  | ClosePackageInfo (forwarded to kernelbase.ClosePackageInfo)
| 0x3440281C |     137 |  88  | ClosePrivateNamespace
| 0x28E3498F |     138 |  89  | CloseProfileUserMapping
| 0x224A857D |     139 |  8A  | ClosePseudoConsole
| 0x75C6CBBB |     140 |  8B  | CloseState (forwarded to kernelbase.CloseState)
| 0xED3A2000 |     141 |  8C  | CloseThreadpool (forwarded to NTDLL.TpReleasePool)
| 0xE5C4567C |     142 |  8D  | CloseThreadpoolCleanupGroup (forwarded to NTDLL.TpReleaseCleanupGroup)
| 0x7BD1214  |     143 |  8E  | CloseThreadpoolCleanupGroupMembers (forwarded to NTDLL.TpReleaseCleanupGroupMembers)
| 0x52000A9B |     144 |  8F  | CloseThreadpoolIo (forwarded to NTDLL.TpReleaseIoCompletion)
| 0x5433B97B |     145 |  90  | CloseThreadpoolTimer (forwarded to NTDLL.TpReleaseTimer)
| 0x67A39934 |     146 |  91  | CloseThreadpoolWait (forwarded to NTDLL.TpReleaseWait)
| 0x835B9B74 |     147 |  92  | CloseThreadpoolWork (forwarded to NTDLL.TpReleaseWork)
| 0x47AFE921 |     148 |  93  | CmdBatNotification
| 0x5CF42170 |     149 |  94  | CommConfigDialogA
| 0x5CF42186 |     150 |  95  | CommConfigDialogW
| 0xA427E7EC |     151 |  96  | CompareCalendarDates
| 0x8A771684 |     152 |  97  | CompareFileTime
| 0x6AE857A8 |     153 |  98  | CompareStringA
| 0xBD6357BA |     154 |  99  | CompareStringEx
| 0x33E807C7 |     155 |  9A  | CompareStringOrdinal
| 0x6AE857BE |     156 |  9B  | CompareStringW
| 0xCB09C9F9 |     157 |  9C  | ConnectNamedPipe
| 0x134908BE |     158 |  9D  | ConsoleMenuControl
| 0xC256F48  |     159 |  9E  | ContinueDebugEvent
| 0x33CF5CC1 |     160 |  9F  | ConvertCalDateTimeToSystemTime
| 0xB73C7422 |     161 |  A0  | ConvertDefaultLocale
| 0xD1D82244 |     162 |  A1  | ConvertFiberToThread
| 0xA03F5A7B |     163 |  A2  | ConvertNLSDayOfWeekToWin32DayOfWeek
| 0xB3B4B5D8 |     164 |  A3  | ConvertSystemTimeToCalDateTime
| 0x2E880484 |     165 |  A4  | ConvertThreadToFiber
| 0xA4292183 |     166 |  A5  | ConvertThreadToFiberEx
| 0x9CD6811D |     167 |  A6  | CopyContext
| 0x99EC894F |     168 |  A7  | CopyFile2
| 0x99EC895E |     169 |  A8  | CopyFileA
| 0x7EE258E7 |     170 |  A9  | CopyFileExA
| 0x7EE258FD |     171 |  AA  | CopyFileExW
| 0x347109CF |     172 |  AB  | CopyFileTransactedA
| 0x347109E5 |     173 |  AC  | CopyFileTransactedW
| 0x99EC8974 |     174 |  AD  | CopyFileW
| 0x4BE0CC   |     175 |  AE  | CopyLZFile
| 0xBFB2765C |     176 |  AF  | CreateActCtxA
| 0xBFB27672 |     177 |  B0  | CreateActCtxW
| 0x40FA0A28 |     178 |  B1  | CreateActCtxWWorker
| 0x313C79E9 |     179 |  B2  | CreateBoundaryDescriptorA
| 0x313C79FF |     180 |  B3  | CreateBoundaryDescriptorW
| 0xEC325B3E |     181 |  B4  | CreateConsoleScreenBuffer
| 0x9FCF5965 |     182 |  B5  | CreateDirectoryA
| 0xF7965AA8 |     183 |  B6  | CreateDirectoryExA
| 0xF7965ABE |     184 |  B7  | CreateDirectoryExW
| 0xF5E9BDD0 |     185 |  B8  | CreateDirectoryTransactedA
| 0xF5E9BDE6 |     186 |  B9  | CreateDirectoryTransactedW
| 0x9FCF597B |     187 |  BA  | CreateDirectoryW
| 0xE348DAB  |     188 |  BB  | CreateEnclave (forwarded to api-ms-win-core-enclave-l1-1-0.CreateEnclave)
| 0x30C4B281 |     189 |  BC  | CreateEventA
| 0x34ECA18D |     190 |  BD  | CreateEventExA
| 0x34ECA1A3 |     191 |  BE  | CreateEventExW
| 0x30C4B297 |     192 |  BF  | CreateEventW
| 0x7C001556 |     193 |  C0  | CreateFiber
| 0x22D5617  |     194 |  C1  | CreateFiberEx
| 0x7C001796 |     195 |  C2  | CreateFile2
| 0x7C0017A5 |     196 |  C3  | CreateFileA
| 0x56C61229 |     197 |  C4  | CreateFileMappingA
| 0xE0113222 |     198 |  C5  | CreateFileMappingFromApp (forwarded to api-ms-win-core-memory-l1-1-1.CreateFileMappingFromApp)
| 0x4E2B80EE |     199 |  C6  | CreateFileMappingNumaA
| 0x4E2B8104 |     200 |  C7  | CreateFileMappingNumaW
| 0x56C6123F |     201 |  C8  | CreateFileMappingW
| 0xECF5ED60 |     202 |  C9  | CreateFileTransactedA
| 0xECF5ED76 |     203 |  CA  | CreateFileTransactedW
| 0x7C0017BB |     204 |  CB  | CreateFileW
| 0x58EB2281 |     205 |  CC  | CreateHardLinkA
| 0xE430B017 |     206 |  CD  | CreateHardLinkTransactedA
| 0xE430B02D |     207 |  CE  | CreateHardLinkTransactedW
| 0x58EB2297 |     208 |  CF  | CreateHardLinkW
| 0x5617BA9  |     209 |  D0  | CreateIoCompletionPort
| 0x114EE3A5 |     210 |  D1  | CreateJobObjectA
| 0x114EE3BB |     211 |  D2  | CreateJobObjectW
| 0xAA4C3BF6 |     212 |  D3  | CreateJobSet
| 0x641192C5 |     213 |  D4  | CreateMailslotA
| 0x641192DB |     214 |  D5  | CreateMailslotW
| 0x55FE87E3 |     215 |  D6  | CreateMemoryResourceNotification
| 0x4EE4A045 |     216 |  D7  | CreateMutexA
| 0xBCE81294 |     217 |  D8  | CreateMutexExA
| 0xBCE812AA |     218 |  D9  | CreateMutexExW
| 0x4EE4A05B |     219 |  DA  | CreateMutexW
| 0xB2D6846  |     220 |  DB  | CreateNamedPipeA
| 0xB2D685C  |     221 |  DC  | CreateNamedPipeW
| 0x170C8F80 |     222 |  DD  | CreatePipe
| 0xD139074D |     223 |  DE  | CreatePrivateNamespaceA
| 0xD1390763 |     224 |  DF  | CreatePrivateNamespaceW
| 0x16B3FE72 |     225 |  E0  | CreateProcessA
| 0x635DC48B |     226 |  E1  | CreateProcessAsUserA
| 0x635DC4A1 |     227 |  E2  | CreateProcessAsUserW
| 0xDB4DFA72 |     228 |  E3  | CreateProcessInternalA
| 0xDB4DFA88 |     229 |  E4  | CreateProcessInternalW
| 0x16B3FE88 |     230 |  E5  | CreateProcessW
| 0x73038AF3 |     231 |  E6  | CreatePseudoConsole
| 0x72BD9CDD |     232 |  E7  | CreateRemoteThread
| 0xBEA58C99 |     233 |  E8  | CreateRemoteThreadEx (forwarded to api-ms-win-core-processthreads-l1-1-0.CreateRemoteThreadEx)
| 0x1B1F10CC |     234 |  E9  | CreateSemaphoreA
| 0xCB843447 |     235 |  EA  | CreateSemaphoreExA
| 0xCB84345D |     236 |  EB  | CreateSemaphoreExW
| 0x1B1F10E2 |     237 |  EC  | CreateSemaphoreW
| 0x6A9CD25B |     238 |  ED  | CreateSymbolicLinkA
| 0x689D1C0E |     239 |  EE  | CreateSymbolicLinkTransactedA
| 0x689D1C24 |     240 |  EF  | CreateSymbolicLinkTransactedW
| 0x6A9CD271 |     241 |  F0  | CreateSymbolicLinkW
| 0xA1B2B801 |     242 |  F1  | CreateTapePartition
| 0xCA2BD06B |     243 |  F2  | CreateThread
| 0xA07ED8CF |     244 |  F3  | CreateThreadpool
| 0x52F74F3E |     245 |  F4  | CreateThreadpoolCleanupGroup
| 0x21FE3457 |     246 |  F5  | CreateThreadpoolIo
| 0xA56CC81A |     247 |  F6  | CreateThreadpoolTimer
| 0x9ED512BC |     248 |  F7  | CreateThreadpoolWait
| 0x9F1D1633 |     249 |  F8  | CreateThreadpoolWork
| 0x2BADA5B1 |     250 |  F9  | CreateTimerQueue
| 0x6B042E8B |     251 |  FA  | CreateTimerQueueTimer
| 0xE454DFED |     252 |  FB  | CreateToolhelp32Snapshot
| 0xB23102C0 |     253 |  FC  | CreateUmsCompletionList
| 0x60EF357B |     254 |  FD  | CreateUmsThreadContext
| 0xA62E290  |     255 |  FE  | CreateWaitableTimerA
| 0x9C78A543 |     256 |  FF  | CreateWaitableTimerExA
| 0x9C78A559 |     257 | 100  | CreateWaitableTimerExW
| 0xA62E2A6  |     258 | 101  | CreateWaitableTimerW
| 0xC374F638 |     259 | 102  | CtrlRoutine (forwarded to kernelbase.CtrlRoutine)
| 0xBFA79A2C |     260 | 103  | DeactivateActCtx
| 0xCFE209FC |     261 | 104  | DeactivateActCtxWorker
| 0xB58F38E6 |     262 | 105  | DebugActiveProcess
| 0x9D0688C9 |     263 | 106  | DebugActiveProcessStop
| 0xCDE2661F |     264 | 107  | DebugBreak
| 0x872BCDE6 |     265 | 108  | DebugBreakProcess
| 0x40D495C6 |     266 | 109  | DebugSetProcessKillOnExit
| 0xB51C2A01 |     267 | 10A  | DecodePointer (forwarded to NTDLL.RtlDecodePointer)
| 0x9E6D5267 |     268 | 10B  | DecodeSystemPointer (forwarded to NTDLL.RtlDecodeSystemPointer)
| 0xB91F4246 |     269 | 10C  | DefineDosDeviceA
| 0xB91F425C |     270 | 10D  | DefineDosDeviceW
| 0xF0404375 |     271 | 10E  | DelayLoadFailureHook
| 0xEC149B27 |     272 | 10F  | DeleteAtom
| 0xCF5885F3 |     273 | 110  | DeleteBoundaryDescriptor
| 0x822A197A |     274 | 111  | DeleteCriticalSection (forwarded to NTDLL.RtlDeleteCriticalSection)
| 0xC2FFADD6 |     275 | 112  | DeleteFiber
| 0xC2FFB025 |     276 | 113  | DeleteFileA
| 0xFEB5D380 |     277 | 114  | DeleteFileTransactedA
| 0xFEB5D396 |     278 | 115  | DeleteFileTransactedW
| 0xC2FFB03B |     279 | 116  | DeleteFileW
| 0x75E8C056 |     280 | 117  | DeleteProcThreadAttributeList (forwarded to api-ms-win-core-processthreads-l1-1-0.DeleteProcThreadAttributeList)
| 0x47456D6  |     281 | 118  | DeleteSynchronizationBarrier
| 0x4F2D71F1 |     282 | 119  | DeleteTimerQueue
| 0xCD847CCB |     283 | 11A  | DeleteTimerQueueEx
| 0x7CC414AB |     284 | 11B  | DeleteTimerQueueTimer
| 0x222A8AC5 |     285 | 11C  | DeleteUmsCompletionList
| 0x91EFC37A |     286 | 11D  | DeleteUmsThreadContext
| 0x854F96DA |     287 | 11E  | DeleteVolumeMountPointA
| 0x854F96F0 |     288 | 11F  | DeleteVolumeMountPointW
| 0xC8E4EF58 |     289 | 120  | DequeueUmsCompletionListItems
| 0xA8E14A7D |     290 | 121  | DeviceIoControl
| 0xB142A2AB |     291 | 122  | DisableThreadLibraryCalls
| 0xEAD01976 |     292 | 123  | DisableThreadProfiling
| 0x34B31610 |     293 | 124  | DisassociateCurrentThreadFromCallback (forwarded to NTDLL.TpDisassociateCallback)
| 0x8D0E0E2B |     294 | 125  | DiscardVirtualMemory (forwarded to api-ms-win-core-memory-l1-1-2.DiscardVirtualMemory)
| 0xDC7CCD45 |     295 | 126  | DisconnectNamedPipe
| 0xCEA9B8C4 |     296 | 127  | DnsHostnameToComputerNameA
| 0xAE2E328A |     297 | 128  | DnsHostnameToComputerNameExW
| 0xCEA9B8DA |     298 | 129  | DnsHostnameToComputerNameW
| 0x64128E78 |     299 | 12A  | DosDateTimeToFileTime
| 0x81CE4A35 |     300 | 12B  | DosPathToSessionPathA
| 0x81CE4A4B |     301 | 12C  | DosPathToSessionPathW
| 0x8EE386B1 |     302 | 12D  | DuplicateConsoleHandle
| 0xEF380E21 |     303 | 12E  | DuplicateEncryptionInfoFileExt
| 0xBD566724 |     304 | 12F  | DuplicateHandle
| 0xAAAE0F74 |     305 | 130  | EnableThreadProfiling
| 0xB59C2A91 |     306 | 131  | EncodePointer (forwarded to NTDLL.RtlEncodePointer)
| 0xA0AD5467 |     307 | 132  | EncodeSystemPointer (forwarded to NTDLL.RtlEncodeSystemPointer)
| 0x742FFA6B |     308 | 133  | EndUpdateResourceA
| 0x742FFA81 |     309 | 134  | EndUpdateResourceW
| 0x85D51D00 |     310 | 135  | EnterCriticalSection (forwarded to NTDLL.RtlEnterCriticalSection)
| 0x128C6582 |     311 | 136  | EnterSynchronizationBarrier
| 0x17D7F7CB |     312 | 137  | EnterUmsSchedulingMode
| 0x468CB6D4 |     313 | 138  | EnumCalendarInfoA
| 0xA6EDB652 |     314 | 139  | EnumCalendarInfoExA
| 0xB2B537E5 |     315 | 13A  | EnumCalendarInfoExEx
| 0xA6EDB668 |     316 | 13B  | EnumCalendarInfoExW
| 0x468CB6EA |     317 | 13C  | EnumCalendarInfoW
| 0x4768552C |     318 | 13D  | EnumDateFormatsA
| 0xDDD54C52 |     319 | 13E  | EnumDateFormatsExA
| 0x62B6EF22 |     320 | 13F  | EnumDateFormatsExEx
| 0xDDD54C68 |     321 | 140  | EnumDateFormatsExW
| 0x47685542 |     322 | 141  | EnumDateFormatsW
| 0xCAB007DC |     323 | 142  | EnumLanguageGroupLocalesA
| 0xCAB007F2 |     324 | 143  | EnumLanguageGroupLocalesW
| 0x8B4CC75B |     325 | 144  | EnumResourceLanguagesA
| 0xD6F1D823 |     326 | 145  | EnumResourceLanguagesExA
| 0xD6F1D839 |     327 | 146  | EnumResourceLanguagesExW
| 0x8B4CC771 |     328 | 147  | EnumResourceLanguagesW
| 0xDB8B9AAB |     329 | 148  | EnumResourceNamesA
| 0xE6A6AC37 |     330 | 149  | EnumResourceNamesExA
| 0xE6A6AC4D |     331 | 14A  | EnumResourceNamesExW
| 0xDB8B9AC1 |     332 | 14B  | EnumResourceNamesW
| 0xE18D1AAE |     333 | 14C  | EnumResourceTypesA
| 0x6706ACF9 |     334 | 14D  | EnumResourceTypesExA
| 0x6706AD0F |     335 | 14E  | EnumResourceTypesExW
| 0xE18D1AC4 |     336 | 14F  | EnumResourceTypesW
| 0x386DC738 |     337 | 150  | EnumSystemCodePagesA
| 0x386DC74E |     338 | 151  | EnumSystemCodePagesW
| 0x253AD7ED |     339 | 152  | EnumSystemFirmwareTables
| 0xB8BF7E20 |     340 | 153  | EnumSystemGeoID
| 0x7E99EAAF |     341 | 154  | EnumSystemGeoNames
| 0xC22A149F |     342 | 155  | EnumSystemLanguageGroupsA
| 0xC22A14B5 |     343 | 156  | EnumSystemLanguageGroupsW
| 0x95331917 |     344 | 157  | EnumSystemLocalesA
| 0xC8DCAA10 |     345 | 158  | EnumSystemLocalesEx
| 0x9533192D |     346 | 159  | EnumSystemLocalesW
| 0x47881D2E |     347 | 15A  | EnumTimeFormatsA
| 0xE9923CB8 |     348 | 15B  | EnumTimeFormatsEx
| 0x47881D44 |     349 | 15C  | EnumTimeFormatsW
| 0xCF685667 |     350 | 15D  | EnumUILanguagesA
| 0xCF68567D |     351 | 15E  | EnumUILanguagesW
| 0x9E15D236 |     352 | 15F  | EnumerateLocalComputerNamesA
| 0x9E15D24C |     353 | 160  | EnumerateLocalComputerNamesW
| 0x720A771F |     354 | 161  | EraseTape
| 0xB3504846 |     355 | 162  | EscapeCommFunction
| 0x1149B5C5 |     356 | 163  | ExecuteUmsThread
| 0x73E2D87E |     357 | 164  | ExitProcess
| 0x777B0726 |     358 | 165  | ExitThread (forwarded to NTDLL.RtlExitUserThread)
| 0xEB3AA609 |     359 | 166  | ExitVDM
| 0xEEB585D8 |     360 | 167  | ExpandEnvironmentStringsA
| 0xEEB585EE |     361 | 168  | ExpandEnvironmentStringsW
| 0xA66CB8F7 |     362 | 169  | ExpungeConsoleCommandHistoryA
| 0xA66CB90D |     363 | 16A  | ExpungeConsoleCommandHistoryW
| 0x62297F57 |     364 | 16B  | FatalAppExitA
| 0x62297F6D |     365 | 16C  | FatalAppExitW
| 0x551EEAC5 |     366 | 16D  | FatalExit
| 0xEEAA79EA |     367 | 16E  | FileTimeToDosDateTime
| 0x87171EE8 |     368 | 16F  | FileTimeToLocalFileTime
| 0x3810CB0F |     369 | 170  | FileTimeToSystemTime
| 0x70AA69FA |     370 | 171  | FillConsoleOutputAttribute
| 0x423B9F70 |     371 | 172  | FillConsoleOutputCharacterA
| 0x423B9F86 |     372 | 173  | FillConsoleOutputCharacterW
| 0x3429E0E2 |     373 | 174  | FindActCtxSectionGuid
| 0xEAB7DC05 |     374 | 175  | FindActCtxSectionGuidWorker
| 0x51D0FF82 |     375 | 176  | FindActCtxSectionStringA
| 0x51D0FF98 |     376 | 177  | FindActCtxSectionStringW
| 0x659052A2 |     377 | 178  | FindActCtxSectionStringWWorker
| 0x33243954 |     378 | 179  | FindAtomA
| 0x3324396A |     379 | 17A  | FindAtomW
| 0x23545978 |     380 | 17B  | FindClose
| 0x48B46D47 |     381 | 17C  | FindCloseChangeNotification
| 0x6A9BE3D8 |     382 | 17D  | FindFirstChangeNotificationA
| 0x6A9BE3EE |     383 | 17E  | FindFirstChangeNotificationW
| 0x63D6C065 |     384 | 17F  | FindFirstFileA
| 0xF9701A99 |     385 | 180  | FindFirstFileExA
| 0xF9701AAF |     386 | 181  | FindFirstFileExW
| 0x5A41B7FD |     387 | 182  | FindFirstFileNameTransactedW
| 0x312F41D5 |     388 | 183  | FindFirstFileNameW
| 0xE6EB9790 |     389 | 184  | FindFirstFileTransactedA
| 0xE6EB97A6 |     390 | 185  | FindFirstFileTransactedW
| 0x63D6C07B |     391 | 186  | FindFirstFileW
| 0x6C4907F5 |     392 | 187  | FindFirstStreamTransactedW
| 0xDABCA84  |     393 | 188  | FindFirstStreamW (forwarded to api-ms-win-core-file-l1-2-2.FindFirstStreamW)
| 0x1918249D |     394 | 189  | FindFirstVolumeA
| 0x92C09AD4 |     395 | 18A  | FindFirstVolumeMountPointA
| 0x92C09AEA |     396 | 18B  | FindFirstVolumeMountPointW
| 0x191824B3 |     397 | 18C  | FindFirstVolumeW
| 0x379888CD |     398 | 18D  | FindNLSString
| 0xE84A33C5 |     399 | 18E  | FindNLSStringEx
| 0x9593F2C9 |     400 | 18F  | FindNextChangeNotification
| 0xA5E1AC97 |     401 | 190  | FindNextFileA
| 0xDFF265F5 |     402 | 191  | FindNextFileNameW
| 0xA5E1ACAD |     403 | 192  | FindNextFileW
| 0x722FE05C |     404 | 193  | FindNextStreamW (forwarded to api-ms-win-core-file-l1-2-2.FindNextStreamW)
| 0x9BD3312D |     405 | 194  | FindNextVolumeA
| 0xB36F5DF8 |     406 | 195  | FindNextVolumeMountPointA
| 0xB36F5E0E |     407 | 196  | FindNextVolumeMountPointW
| 0x9BD33143 |     408 | 197  | FindNextVolumeW
| 0x2B31D567 |     409 | 198  | FindPackagesByPackageFamily (forwarded to kernelbase.FindPackagesByPackageFamily)
| 0x3BD09A55 |     410 | 199  | FindResourceA
| 0xF7E6968F |     411 | 19A  | FindResourceExA
| 0xF7E696A5 |     412 | 19B  | FindResourceExW
| 0x3BD09A6B |     413 | 19C  | FindResourceW
| 0x177D6E60 |     414 | 19D  | FindStringOrdinal
| 0x7E9CF1EE |     415 | 19E  | FindVolumeClose
| 0xAD743E5F |     416 | 19F  | FindVolumeMountPointClose
| 0x5D2C345D |     417 | 1A0  | FlsAlloc
| 0x90474D1B |     418 | 1A1  | FlsFree
| 0xBA44E491 |     419 | 1A2  | FlsGetValue
| 0xBA44E611 |     420 | 1A3  | FlsSetValue
| 0xE3F4A4CB |     421 | 1A4  | FlushConsoleInputBuffer
| 0x37F385D9 |     422 | 1A5  | FlushFileBuffers
| 0x53120980 |     423 | 1A6  | FlushInstructionCache
| 0xF97961FD |     424 | 1A7  | FlushProcessWriteBuffers (forwarded to NTDLL.NtFlushProcessWriteBuffers)
| 0xB12C56D7 |     425 | 1A8  | FlushViewOfFile
| 0xC28EC08D |     426 | 1A9  | FoldStringA
| 0xC28EC0A3 |     427 | 1AA  | FoldStringW
| 0x5CE7FD43 |     428 | 1AB  | FormatApplicationUserModelId (forwarded to kernelbase.FormatApplicationUserModelId)
| 0x1EAA62E7 |     429 | 1AC  | FormatMessageA
| 0x1EAA62FD |     430 | 1AD  | FormatMessageW
| 0x4F76990F |     431 | 1AE  | FreeConsole
| 0x4FBDC230 |     432 | 1AF  | FreeEnvironmentStringsA
| 0x4FBDC246 |     433 | 1B0  | FreeEnvironmentStringsW
| 0x4DC9D5A0 |     434 | 1B1  | FreeLibrary
| 0x31E3B803 |     435 | 1B2  | FreeLibraryAndExitThread
| 0x4A47677E |     436 | 1B3  | FreeLibraryWhenCallbackReturns (forwarded to NTDLL.TpCallbackUnloadDllOnCompletion)
| 0x7EE4E46  |     437 | 1B4  | FreeMemoryJobObject
| 0x54423F7C |     438 | 1B5  | FreeResource
| 0x831C3F23 |     439 | 1B6  | FreeUserPhysicalPages
| 0x3DDC4CF9 |     440 | 1B7  | GenerateConsoleCtrlEvent
| 0x6A1E60B4 |     441 | 1B8  | GetACP
| 0x586F2659 |     442 | 1B9  | GetActiveProcessorCount
| 0x90C8001F |     443 | 1BA  | GetActiveProcessorGroupCount
| 0xD5B1EA5F |     444 | 1BB  | GetAppContainerAce
| 0xE226B8B0 |     445 | 1BC  | GetAppContainerNamedObjectPath
| 0xB2D54DE3 |     446 | 1BD  | GetApplicationRecoveryCallback
| 0x9EBDD6B3 |     447 | 1BE  | GetApplicationRecoveryCallbackWorker
| 0xE671FDAE |     448 | 1BF  | GetApplicationRestartSettings
| 0x5DEAA526 |     449 | 1C0  | GetApplicationRestartSettingsWorker
| 0x286B8064 |     450 | 1C1  | GetApplicationUserModelId (forwarded to kernelbase.GetApplicationUserModelId)
| 0xC87AAA51 |     451 | 1C2  | GetAtomNameA
| 0xC87AAA67 |     452 | 1C3  | GetAtomNameW
| 0x16D7D12C |     453 | 1C4  | GetBinaryType
| 0x8960B6FF |     454 | 1C5  | GetBinaryTypeA
| 0x8960B715 |     455 | 1C6  | GetBinaryTypeW
| 0x5E0528B1 |     456 | 1C7  | GetCPInfo
| 0x667C1BD2 |     457 | 1C8  | GetCPInfoExA
| 0x667C1BE8 |     458 | 1C9  | GetCPInfoExW
| 0x1D7195C4 |     459 | 1CA  | GetCachedSigningLevel
| 0xECAA0DF  |     460 | 1CB  | GetCalendarDateFormat
| 0xB4D0383B |     461 | 1CC  | GetCalendarDateFormatEx
| 0x90022BBC |     462 | 1CD  | GetCalendarDaysInMonth
| 0x494CEC53 |     463 | 1CE  | GetCalendarDifferenceInDays
| 0x69C776CF |     464 | 1CF  | GetCalendarInfoA
| 0xB69B4EB3 |     465 | 1D0  | GetCalendarInfoEx
| 0x69C776E5 |     466 | 1D1  | GetCalendarInfoW
| 0xB4D218A4 |     467 | 1D2  | GetCalendarMonthsInYear
| 0x8AB4577E |     468 | 1D3  | GetCalendarSupportedDateRange
| 0x9039441  |     469 | 1D4  | GetCalendarWeekNumber
| 0x8D082211 |     470 | 1D5  | GetComPlusPackageInstallStatus
| 0xD0CF3436 |     471 | 1D6  | GetCommConfig
| 0x535E1954 |     472 | 1D7  | GetCommMask
| 0xA426F767 |     473 | 1D8  | GetCommModemStatus
| 0xE1949FDE |     474 | 1D9  | GetCommProperties
| 0xF0EAF6D5 |     475 | 1DA  | GetCommState
| 0xC35503C6 |     476 | 1DB  | GetCommTimeouts
| 0x36EF7370 |     477 | 1DC  | GetCommandLineA
| 0x36EF7386 |     478 | 1DD  | GetCommandLineW
| 0x7199B6EA |     479 | 1DE  | GetCompressedFileSizeA
| 0x2A5C5532 |     480 | 1DF  | GetCompressedFileSizeTransactedA
| 0x2A5C5548 |     481 | 1E0  | GetCompressedFileSizeTransactedW
| 0x7199B700 |     482 | 1E1  | GetCompressedFileSizeW
| 0x96A4228F |     483 | 1E2  | GetComputerNameA
| 0xACC8A526 |     484 | 1E3  | GetComputerNameExA
| 0xACC8A53C |     485 | 1E4  | GetComputerNameExW
| 0x96A422A5 |     486 | 1E5  | GetComputerNameW
| 0x61161677 |     487 | 1E6  | GetConsoleAliasA
| 0x54FFCF93 |     488 | 1E7  | GetConsoleAliasExesA
| 0x8FC05173 |     489 | 1E8  | GetConsoleAliasExesLengthA
| 0x8FC05189 |     490 | 1E9  | GetConsoleAliasExesLengthW
| 0x54FFCFA9 |     491 | 1EA  | GetConsoleAliasExesW
| 0x6116168D |     492 | 1EB  | GetConsoleAliasW
| 0x491DA719 |     493 | 1EC  | GetConsoleAliasesA
| 0xEDD821EA |     494 | 1ED  | GetConsoleAliasesLengthA
| 0xEDD82200 |     495 | 1EE  | GetConsoleAliasesLengthW
| 0x491DA72F |     496 | 1EF  | GetConsoleAliasesW
| 0xDF68B7C3 |     497 | 1F0  | GetConsoleCP
| 0xAF6BC79  |     498 | 1F1  | GetConsoleCharType
| 0xF9C0913F |     499 | 1F2  | GetConsoleCommandHistoryA
| 0x9672E476 |     500 | 1F3  | GetConsoleCommandHistoryLengthA
| 0x9672E48C |     501 | 1F4  | GetConsoleCommandHistoryLengthW
| 0xF9C09155 |     502 | 1F5  | GetConsoleCommandHistoryW
| 0xFFE2B31E |     503 | 1F6  | GetConsoleCursorInfo
| 0x7D2B355  |     504 | 1F7  | GetConsoleCursorMode
| 0x1796A152 |     505 | 1F8  | GetConsoleDisplayMode
| 0x74C2DA29 |     506 | 1F9  | GetConsoleFontInfo
| 0x8962D8DF |     507 | 1FA  | GetConsoleFontSize
| 0xD41A3436 |     508 | 1FB  | GetConsoleHardwareState
| 0x8FB2A1A5 |     509 | 1FC  | GetConsoleHistoryInfo
| 0x5D1156C3 |     510 | 1FD  | GetConsoleInputExeNameA (forwarded to kernelbase.GetConsoleInputExeNameA)
| 0x5DC156C3 |     511 | 1FE  | GetConsoleInputExeNameW (forwarded to kernelbase.GetConsoleInputExeNameW)
| 0x3412C223 |     512 | 1FF  | GetConsoleInputWaitHandle
| 0xAF0C93A2 |     513 | 200  | GetConsoleKeyboardLayoutNameA
| 0xAF0C93B8 |     514 | 201  | GetConsoleKeyboardLayoutNameW
| 0xF14DF91C |     515 | 202  | GetConsoleMode
| 0x8D07A815 |     516 | 203  | GetConsoleNlsMode
| 0x183F7E04 |     517 | 204  | GetConsoleOriginalTitleA
| 0x183F7E1A |     518 | 205  | GetConsoleOriginalTitleW
| 0xCBC29CAD |     519 | 206  | GetConsoleOutputCP
| 0x11F2864D |     520 | 207  | GetConsoleProcessList
| 0xE87ABACD |     521 | 208  | GetConsoleScreenBufferInfo
| 0x20D6B3F2 |     522 | 209  | GetConsoleScreenBufferInfoEx
| 0xE98FF293 |     523 | 20A  | GetConsoleSelectionInfo
| 0xF6A5E940 |     524 | 20B  | GetConsoleTitleA
| 0xF6A5E956 |     525 | 20C  | GetConsoleTitleW
| 0x6AF5E778 |     526 | 20D  | GetConsoleWindow
| 0xBD8CCD59 |     527 | 20E  | GetCurrencyFormatA
| 0x6AEDECDE |     528 | 20F  | GetCurrencyFormatEx
| 0xBD8CCD6F |     529 | 210  | GetCurrencyFormatW
| 0x6D65776F |     530 | 211  | GetCurrentActCtx
| 0x44ECC0F4 |     531 | 212  | GetCurrentActCtxWorker
| 0xEFE4CC11 |     532 | 213  | GetCurrentApplicationUserModelId (forwarded to kernelbase.GetCurrentApplicationUserModelId)
| 0xC0158DE6 |     533 | 214  | GetCurrentConsoleFont
| 0x78B7A28  |     534 | 215  | GetCurrentConsoleFontEx
| 0xBFC6EB4F |     535 | 216  | GetCurrentDirectoryA
| 0xBFC6EB65 |     536 | 217  | GetCurrentDirectoryW
| 0xE180272B |     537 | 218  | GetCurrentPackageFamilyName (forwarded to kernelbase.GetCurrentPackageFamilyName)
| 0x7F938A90 |     538 | 219  | GetCurrentPackageFullName (forwarded to kernelbase.GetCurrentPackageFullName)
| 0xA3366F0D |     539 | 21A  | GetCurrentPackageId (forwarded to kernelbase.GetCurrentPackageId)
| 0xE513D508 |     540 | 21B  | GetCurrentPackageInfo (forwarded to kernelbase.GetCurrentPackageInfo)
| 0xCADC4888 |     541 | 21C  | GetCurrentPackagePath (forwarded to kernelbase.GetCurrentPackagePath)
| 0x7B8F17E6 |     542 | 21D  | GetCurrentProcess
| 0xE60DFA02 |     543 | 21E  | GetCurrentProcessId
| 0x308E2BB8 |     544 | 21F  | GetCurrentProcessorNumber (forwarded to NTDLL.RtlGetCurrentProcessorNumber)
| 0x274AF76C |     545 | 220  | GetCurrentProcessorNumberEx (forwarded to NTDLL.RtlGetCurrentProcessorNumberEx)
| 0xE8CDCFE4 |     546 | 221  | GetCurrentThread
| 0x35BBF99E |     547 | 222  | GetCurrentThreadId
| 0x47550121 |     548 | 223  | GetCurrentThreadStackLimits (forwarded to api-ms-win-core-processthreads-l1-1-0.GetCurrentThreadStackLimits)
| 0x69DE25DB |     549 | 224  | GetCurrentUmsThread
| 0xF72A53BA |     550 | 225  | GetDateFormatA
| 0xB61AE807 |     551 | 226  | GetDateFormatAWorker
| 0x9DF7B9CA |     552 | 227  | GetDateFormatEx
| 0xF72A53D0 |     553 | 228  | GetDateFormatW
| 0xB672E807 |     554 | 229  | GetDateFormatWWorker
| 0x61DD75C  |     555 | 22A  | GetDefaultCommConfigA
| 0x61DD772  |     556 | 22B  | GetDefaultCommConfigW
| 0x6A377599 |     557 | 22C  | GetDevicePowerState
| 0x3BF42C83 |     558 | 22D  | GetDiskFreeSpaceA
| 0xCB2210   |     559 | 22E  | GetDiskFreeSpaceExA
| 0xCB2226   |     560 | 22F  | GetDiskFreeSpaceExW
| 0x3BF42C99 |     561 | 230  | GetDiskFreeSpaceW
| 0xDEE6F39F |     562 | 231  | GetDiskSpaceInformationA (forwarded to api-ms-win-core-file-l1-2-3.GetDiskSpaceInformationA)
| 0xDF96F39F |     563 | 232  | GetDiskSpaceInformationW (forwarded to api-ms-win-core-file-l1-2-3.GetDiskSpaceInformationW)
| 0xE73F2397 |     564 | 233  | GetDllDirectoryA
| 0xE73F23AD |     565 | 234  | GetDllDirectoryW
| 0xE9D18E21 |     566 | 235  | GetDriveTypeA
| 0xE9D18E37 |     567 | 236  | GetDriveTypeW
| 0x54F7912D |     568 | 237  | GetDurationFormat
| 0x400C4BCD |     569 | 238  | GetDurationFormatEx
| 0xC386DC63 |     570 | 239  | GetDynamicTimeZoneInformation
| 0x52777BE2 |     571 | 23A  | GetEnabledXStateFeatures
| 0x5FDBA47C |     572 | 23B  | GetEncryptedFileVersionExt
| 0xBDAE9F5  |     573 | 23C  | GetEnvironmentStrings
| 0x4FA85F18 |     574 | 23D  | GetEnvironmentStringsA
| 0x4FA85F2E |     575 | 23E  | GetEnvironmentStringsW
| 0xF2E1A963 |     576 | 23F  | GetEnvironmentVariableA
| 0xF2E1A979 |     577 | 240  | GetEnvironmentVariableW
| 0xCD6B9DF6 |     578 | 241  | GetEraNameCountedString
| 0xA480EAB6 |     579 | 242  | GetErrorMode
| 0xAC30AB74 |     580 | 243  | GetExitCodeProcess
| 0x1B3F95F9 |     581 | 244  | GetExitCodeThread
| 0x4FB5A8A9 |     582 | 245  | GetExpandedNameA
| 0x4FB5A8BF |     583 | 246  | GetExpandedNameW
| 0x56F7390A |     584 | 247  | GetFileAttributesA
| 0xC18E43D6 |     585 | 248  | GetFileAttributesExA
| 0xC18E43EC |     586 | 249  | GetFileAttributesExW
| 0x23B3B5BA |     587 | 24A  | GetFileAttributesTransactedA
| 0x23B3B5D0 |     588 | 24B  | GetFileAttributesTransactedW
| 0x56F73920 |     589 | 24C  | GetFileAttributesW
| 0x8CC7C80B |     590 | 24D  | GetFileBandwidthReservation
| 0xC0132B93 |     591 | 24E  | GetFileInformationByHandle
| 0x6F2E568  |     592 | 24F  | GetFileInformationByHandleEx
| 0x26D4071C |     593 | 250  | GetFileMUIInfo
| 0x354403D5 |     594 | 251  | GetFileMUIPath
| 0xDF7D9BAD |     595 | 252  | GetFileSize
| 0xE18EEBEF |     596 | 253  | GetFileSizeEx
| 0xE1159BAD |     597 | 254  | GetFileTime
| 0xE12D9FAD |     598 | 255  | GetFileType
| 0xD86A2FD0 |     599 | 256  | GetFinalPathNameByHandleA
| 0xD86A2FE6 |     600 | 257  | GetFinalPathNameByHandleW
| 0xC52309DB |     601 | 258  | GetFirmwareEnvironmentVariableA
| 0x4C827832 |     602 | 259  | GetFirmwareEnvironmentVariableExA
| 0x4C827848 |     603 | 25A  | GetFirmwareEnvironmentVariableExW
| 0xC52309F1 |     604 | 25B  | GetFirmwareEnvironmentVariableW
| 0x8D1B3119 |     605 | 25C  | GetFirmwareType
| 0x31EC005A |     606 | 25D  | GetFullPathNameA
| 0x1A70E78E |     607 | 25E  | GetFullPathNameTransactedA
| 0x1A70E7A4 |     608 | 25F  | GetFullPathNameTransactedW
| 0x31EC0070 |     609 | 260  | GetFullPathNameW
| 0x9513DAEB |     610 | 261  | GetGeoInfoA
| 0xD77CA916 |     611 | 262  | GetGeoInfoEx
| 0x9513DB01 |     612 | 263  | GetGeoInfoW
| 0x7F9DF944 |     613 | 264  | GetHandleInformation
| 0x89E59E38 |     614 | 265  | GetLargePageMinimum
| 0xAD9312E2 |     615 | 266  | GetLargestConsoleWindowSize
| 0x75DA1966 |     616 | 267  | GetLastError
| 0xB98C88CF |     617 | 268  | GetLocalTime
| 0xE8983477 |     618 | 269  | GetLocaleInfoA
| 0xA3DF4539 |     619 | 26A  | GetLocaleInfoEx
| 0xE898348D |     620 | 26B  | GetLocaleInfoW
| 0x79B4095D |     621 | 26C  | GetLogicalDriveStringsA
| 0x79B40973 |     622 | 26D  | GetLogicalDriveStringsW
| 0x14C22B19 |     623 | 26E  | GetLogicalDrives
| 0x56472C4B |     624 | 26F  | GetLogicalProcessorInformation
| 0x9A6C9FB8 |     625 | 270  | GetLogicalProcessorInformationEx (forwarded to api-ms-win-core-sysinfo-l1-1-0.GetLogicalProcessorInformationEx)
| 0xB1DFD8BA |     626 | 271  | GetLongPathNameA
| 0x3A6DDDA6 |     627 | 272  | GetLongPathNameTransactedA
| 0x3A6DDDBC |     628 | 273  | GetLongPathNameTransactedW
| 0xB1DFD8D0 |     629 | 274  | GetLongPathNameW
| 0xF605D5DF |     630 | 275  | GetMailslotInfo
| 0xD69B0676 |     631 | 276  | GetMaximumProcessorCount
| 0x4FDDF02E |     632 | 277  | GetMaximumProcessorGroupCount
| 0x91AD6FC7 |     633 | 278  | GetMemoryErrorHandlingCapabilities
| 0x45B06D76 |     634 | 279  | GetModuleFileNameA
| 0x45B06D8C |     635 | 27A  | GetModuleFileNameW
| 0xD3324904 |     636 | 27B  | GetModuleHandleA
| 0xD0524275 |     637 | 27C  | GetModuleHandleExA
| 0xD052428B |     638 | 27D  | GetModuleHandleExW
| 0xD332491A |     639 | 27E  | GetModuleHandleW
| 0xB7A3B9CE |     640 | 27F  | GetNLSVersion
| 0xEB167425 |     641 | 280  | GetNLSVersionEx
| 0x6AAF49FD |     642 | 281  | GetNamedPipeAttribute
| 0xFFDB6D5A |     643 | 282  | GetNamedPipeClientComputerNameA
| 0xFFDB6D70 |     644 | 283  | GetNamedPipeClientComputerNameW
| 0xA752AF24 |     645 | 284  | GetNamedPipeClientProcessId
| 0xA262EC4C |     646 | 285  | GetNamedPipeClientSessionId
| 0x28174C1F |     647 | 286  | GetNamedPipeHandleStateA
| 0x28174C35 |     648 | 287  | GetNamedPipeHandleStateW
| 0xB962AD29 |     649 | 288  | GetNamedPipeInfo (forwarded to api-ms-win-core-namedpipe-l1-2-1.GetNamedPipeInfo)
| 0x63F4DFB2 |     650 | 289  | GetNamedPipeServerProcessId
| 0x5F051CDA |     651 | 28A  | GetNamedPipeServerSessionId
| 0xDD2B205D |     652 | 28B  | GetNativeSystemInfo
| 0x7DA51103 |     653 | 28C  | GetNextUmsListItem
| 0x6ABE78F6 |     654 | 28D  | GetNextVDMCommand
| 0xBE9C8436 |     655 | 28E  | GetNumaAvailableMemoryNode
| 0xA9490E27 |     656 | 28F  | GetNumaAvailableMemoryNodeEx
| 0xA75076B5 |     657 | 290  | GetNumaHighestNodeNumber
| 0x289696AE |     658 | 291  | GetNumaNodeNumberFromHandle
| 0x5C7CE30E |     659 | 292  | GetNumaNodeProcessorMask
| 0x2160C40F |     660 | 293  | GetNumaNodeProcessorMaskEx
| 0x30EAAD88 |     661 | 294  | GetNumaProcessorNode
| 0x3CD36284 |     662 | 295  | GetNumaProcessorNodeEx
| 0xB4C3C4CA |     663 | 296  | GetNumaProximityNode
| 0x33193325 |     664 | 297  | GetNumaProximityNodeEx
| 0x1EADEFFE |     665 | 298  | GetNumberFormatA
| 0x8010F5E7 |     666 | 299  | GetNumberFormatEx
| 0x1EADF014 |     667 | 29A  | GetNumberFormatW
| 0xBC34E91A |     668 | 29B  | GetNumberOfConsoleFonts
| 0xB416650A |     669 | 29C  | GetNumberOfConsoleInputEvents
| 0xF22AB605 |     670 | 29D  | GetNumberOfConsoleMouseButtons
| 0x8DB10CAA |     671 | 29E  | GetOEMCP
| 0xC087DCE8 |     672 | 29F  | GetOverlappedResult
| 0xD5412119 |     673 | 2A0  | GetOverlappedResultEx (forwarded to api-ms-win-core-io-l1-1-1.GetOverlappedResultEx)
| 0xC90F3CDD |     674 | 2A1  | GetPackageApplicationIds (forwarded to kernelbase.GetPackageApplicationIds)
| 0x528D8FD0 |     675 | 2A2  | GetPackageFamilyName (forwarded to kernelbase.GetPackageFamilyName)
| 0x1157C033 |     676 | 2A3  | GetPackageFullName (forwarded to kernelbase.GetPackageFullName)
| 0xB09F137E |     677 | 2A4  | GetPackageId (forwarded to kernelbase.GetPackageId)
| 0x3F3CF14C |     678 | 2A5  | GetPackageInfo (forwarded to kernelbase.GetPackageInfo)
| 0x250564CC |     679 | 2A6  | GetPackagePath (forwarded to kernelbase.GetPackagePath)
| 0x96222B72 |     680 | 2A7  | GetPackagePathByFullName (forwarded to kernelbase.GetPackagePathByFullName)
| 0xE32964DA |     681 | 2A8  | GetPackagesByPackageFamily (forwarded to kernelbase.GetPackagesByPackageFamily)
| 0xE3457F10 |     682 | 2A9  | GetPhysicallyInstalledSystemMemory
| 0x2A556734 |     683 | 2AA  | GetPriorityClass
| 0xE50CB49D |     684 | 2AB  | GetPrivateProfileIntA
| 0xE50CB4B3 |     685 | 2AC  | GetPrivateProfileIntW
| 0x20992B8A |     686 | 2AD  | GetPrivateProfileSectionA
| 0x6DEABF4D |     687 | 2AE  | GetPrivateProfileSectionNamesA
| 0x6DEABF63 |     688 | 2AF  | GetPrivateProfileSectionNamesW
| 0x20992BA0 |     689 | 2B0  | GetPrivateProfileSectionW
| 0x8F2A152D |     690 | 2B1  | GetPrivateProfileStringA
| 0x8F2A1543 |     691 | 2B2  | GetPrivateProfileStringW
| 0xA792126D |     692 | 2B3  | GetPrivateProfileStructA
| 0xA7921283 |     693 | 2B4  | GetPrivateProfileStructW
| 0x7C0DFCAA |     694 | 2B5  | GetProcAddress
| 0x86DDED92 |     695 | 2B6  | GetProcessAffinityMask
| 0x2AE27D01 |     696 | 2B7  | GetProcessDEPPolicy
| 0xDC9FF646 |     697 | 2B8  | GetProcessDefaultCpuSets (forwarded to api-ms-win-core-processthreads-l1-1-3.GetProcessDefaultCpuSets)
| 0x48BE5041 |     698 | 2B9  | GetProcessGroupAffinity
| 0x7201C23C |     699 | 2BA  | GetProcessHandleCount
| 0xA80EECAE |     700 | 2BB  | GetProcessHeap
| 0x657540EA |     701 | 2BC  | GetProcessHeaps
| 0xFA9C1BAF |     702 | 2BD  | GetProcessId
| 0x98A13FCA |     703 | 2BE  | GetProcessIdOfThread
| 0xB424089A |     704 | 2BF  | GetProcessInformation
| 0x284D9E6A |     705 | 2C0  | GetProcessIoCounters
| 0x9AAD88DC |     706 | 2C1  | GetProcessMitigationPolicy (forwarded to api-ms-win-core-processthreads-l1-1-1.GetProcessMitigationPolicy)
| 0x9C984528 |     707 | 2C2  | GetProcessPreferredUILanguages
| 0x4CEBB754 |     708 | 2C3  | GetProcessPriorityBoost
| 0x3CC0CA31 |     709 | 2C4  | GetProcessShutdownParameters
| 0x6D1E03EA |     710 | 2C5  | GetProcessTimes
| 0x67014887 |     711 | 2C6  | GetProcessVersion
| 0xACC6B83  |     712 | 2C7  | GetProcessWorkingSetSize
| 0xB542E13A |     713 | 2C8  | GetProcessWorkingSetSizeEx
| 0xC5E96725 |     714 | 2C9  | GetProcessorSystemCycleTime (forwarded to api-ms-win-core-sysinfo-l1-2-2.GetProcessorSystemCycleTime)
| 0xAA76FF05 |     715 | 2CA  | GetProductInfo
| 0x2AB60F1C |     716 | 2CB  | GetProfileIntA
| 0x2AB60F32 |     717 | 2CC  | GetProfileIntW
| 0xB6410FE4 |     718 | 2CD  | GetProfileSectionA
| 0xB6410FFA |     719 | 2CE  | GetProfileSectionW
| 0x8BB567E2 |     720 | 2CF  | GetProfileStringA
| 0x8BB567F8 |     721 | 2D0  | GetProfileStringW
| 0x232649F  |     722 | 2D1  | GetQueuedCompletionStatus
| 0x8EC12838 |     723 | 2D2  | GetQueuedCompletionStatusEx
| 0x61A77E7F |     724 | 2D3  | GetShortPathNameA
| 0x61A77E95 |     725 | 2D4  | GetShortPathNameW
| 0xC17F7E5C |     726 | 2D5  | GetStagedPackagePathByFullName (forwarded to kernelbase.GetStagedPackagePathByFullName)
| 0x867AE3D7 |     727 | 2D6  | GetStartupInfoA
| 0x867AE3ED |     728 | 2D7  | GetStartupInfoW
| 0xF3D91195 |     729 | 2D8  | GetStateFolder (forwarded to kernelbase.GetStateFolder)
| 0x7487D823 |     730 | 2D9  | GetStdHandle
| 0x5FE02ADB |     731 | 2DA  | GetStringScripts
| 0xCD510FFA |     732 | 2DB  | GetStringTypeA
| 0x5803FFF4 |     733 | 2DC  | GetStringTypeExA
| 0x5804000A |     734 | 2DD  | GetStringTypeExW
| 0xCD511010 |     735 | 2DE  | GetStringTypeW
| 0xBFC5162A |     736 | 2DF  | GetSystemAppDataKey (forwarded to kernelbase.GetSystemAppDataKey)
| 0xA79E6FC2 |     737 | 2E0  | GetSystemCpuSetInformation (forwarded to api-ms-win-core-processthreads-l1-1-3.GetSystemCpuSetInformation)
| 0x1E30D112 |     738 | 2E1  | GetSystemDEPPolicy
| 0x7695E96B |     739 | 2E2  | GetSystemDefaultLCID
| 0xF1C443E1 |     740 | 2E3  | GetSystemDefaultLangID
| 0x71904673 |     741 | 2E4  | GetSystemDefaultLocaleName
| 0x9960AB94 |     742 | 2E5  | GetSystemDefaultUILanguage
| 0xB8E579C1 |     743 | 2E6  | GetSystemDirectoryA
| 0xB8E579D7 |     744 | 2E7  | GetSystemDirectoryW
| 0xB10A352  |     745 | 2E8  | GetSystemFileCacheSize
| 0x5ADBD192 |     746 | 2E9  | GetSystemFirmwareTable
| 0x90D3970F |     747 | 2EA  | GetSystemInfo
| 0x32EA4651 |     748 | 2EB  | GetSystemPowerStatus
| 0x44BA2BC5 |     749 | 2EC  | GetSystemPreferredUILanguages
| 0xBF1387F5 |     750 | 2ED  | GetSystemRegistryQuota
| 0xA70B95C5 |     751 | 2EE  | GetSystemTime
| 0x2D1054A0 |     752 | 2EF  | GetSystemTimeAdjustment
| 0x89D7610D |     753 | 2F0  | GetSystemTimeAsFileTime
| 0xB28C481  |     754 | 2F1  | GetSystemTimePreciseAsFileTime
| 0xAE2D38CF |     755 | 2F2  | GetSystemTimes
| 0x6FAA1C0B |     756 | 2F3  | GetSystemWindowsDirectoryA
| 0x6FAA1C21 |     757 | 2F4  | GetSystemWindowsDirectoryW
| 0xFA92E5F7 |     758 | 2F5  | GetSystemWow64DirectoryA
| 0xFA92E60D |     759 | 2F6  | GetSystemWow64DirectoryW
| 0xD945CE60 |     760 | 2F7  | GetTapeParameters
| 0x45675841 |     761 | 2F8  | GetTapePosition
| 0xA910102A |     762 | 2F9  | GetTapeStatus
| 0xE7AC2238 |     763 | 2FA  | GetTempFileNameA
| 0xE7AC224E |     764 | 2FB  | GetTempFileNameW
| 0x5B8ACA33 |     765 | 2FC  | GetTempPathA
| 0x5B8ACA49 |     766 | 2FD  | GetTempPathW
| 0x68A7C7D2 |     767 | 2FE  | GetThreadContext
| 0x78916965 |     768 | 2FF  | GetThreadDescription (forwarded to api-ms-win-core-processthreads-l1-1-3.GetThreadDescription)
| 0x5922C41C |     769 | 300  | GetThreadErrorMode
| 0x49BE4EEC |     770 | 301  | GetThreadGroupAffinity
| 0x36EBB416 |     771 | 302  | GetThreadIOPendingFlag
| 0xF9F19C2F |     772 | 303  | GetThreadId
| 0xCA8FAF9E |     773 | 304  | GetThreadIdealProcessorEx
| 0x60280895 |     774 | 305  | GetThreadInformation
| 0x6323C846 |     775 | 306  | GetThreadLocale
| 0xBC981A88 |     776 | 307  | GetThreadPreferredUILanguages
| 0xD89EF394 |     777 | 308  | GetThreadPriority
| 0x4DEBB5FF |     778 | 309  | GetThreadPriorityBoost
| 0xF0974811 |     779 | 30A  | GetThreadSelectedCpuSets (forwarded to api-ms-win-core-processthreads-l1-1-3.GetThreadSelectedCpuSets)
| 0x7CB598D1 |     780 | 30B  | GetThreadSelectorEntry
| 0x6D1CAEEB |     781 | 30C  | GetThreadTimes
| 0x3BCE3F9  |     782 | 30D  | GetThreadUILanguage
| 0xF791FB23 |     783 | 30E  | GetTickCount
| 0xE62EC931 |     784 | 30F  | GetTickCount64
| 0xF02A93BE |     785 | 310  | GetTimeFormatA
| 0xB62ACC08 |     786 | 311  | GetTimeFormatAWorker
| 0x9E1781CC |     787 | 312  | GetTimeFormatEx
| 0xF02A93D4 |     788 | 313  | GetTimeFormatW
| 0xB682CC08 |     789 | 314  | GetTimeFormatWWorker
| 0x51268313 |     790 | 315  | GetTimeZoneInformation
| 0x5AF79C54 |     791 | 316  | GetTimeZoneInformationForYear
| 0x891EBF78 |     792 | 317  | GetUILanguageInfo
| 0x1E9050C8 |     793 | 318  | GetUmsCompletionListEvent
| 0x4B52517D |     794 | 319  | GetUmsSystemThreadInformation
| 0x1CD05A7A |     795 | 31A  | GetUserDefaultGeoName
| 0xBCF0E202 |     796 | 31B  | GetUserDefaultLCID
| 0x888269B3 |     797 | 31C  | GetUserDefaultLangID
| 0x53ED5FDF |     798 | 31D  | GetUserDefaultLocaleName
| 0x7BBDC500 |     799 | 31E  | GetUserDefaultUILanguage
| 0x63723AB7 |     800 | 31F  | GetUserGeoID
| 0x1C7EE5F8 |     801 | 320  | GetUserPreferredUILanguages
| 0x4AF7BA3F |     802 | 321  | GetVDMCurrentDirectories
| 0xCFD98161 |     803 | 322  | GetVersion
| 0xC75FC483 |     804 | 323  | GetVersionExA
| 0xC75FC499 |     805 | 324  | GetVersionExW
| 0x8AB241A0 |     806 | 325  | GetVolumeInformationA
| 0xEDD9BCE9 |     807 | 326  | GetVolumeInformationByHandleW
| 0x8AB241B6 |     808 | 327  | GetVolumeInformationW
| 0x5CEDCADA |     809 | 328  | GetVolumeNameForVolumeMountPointA
| 0x5CEDCAF0 |     810 | 329  | GetVolumeNameForVolumeMountPointW
| 0xFD090F8  |     811 | 32A  | GetVolumePathNameA
| 0xFD0910E  |     812 | 32B  | GetVolumePathNameW
| 0x990D3199 |     813 | 32C  | GetVolumePathNamesForVolumeNameA
| 0x990D31AF |     814 | 32D  | GetVolumePathNamesForVolumeNameW
| 0xF8ECDBED |     815 | 32E  | GetWindowsDirectoryA
| 0xF8ECDC03 |     816 | 32F  | GetWindowsDirectoryW
| 0xB9BA5748 |     817 | 330  | GetWriteWatch
| 0x1B4BB6BB |     818 | 331  | GetXStateFeaturesMask
| 0xFD5D432C |     819 | 332  | GlobalAddAtomA
| 0x5B10CC80 |     820 | 333  | GlobalAddAtomExA
| 0x5B10CC96 |     821 | 334  | GlobalAddAtomExW
| 0xFD5D4342 |     822 | 335  | GlobalAddAtomW
| 0xC0397EC  |     823 | 336  | GlobalAlloc
| 0x86060AF8 |     824 | 337  | GlobalCompact
| 0x458516C  |     825 | 338  | GlobalDeleteAtom
| 0xA9ECBC5C |     826 | 339  | GlobalFindAtomA
| 0xA9ECBC72 |     827 | 33A  | GlobalFindAtomW
| 0x240A2FAA |     828 | 33B  | GlobalFix
| 0xBC3E53C  |     829 | 33C  | GlobalFlags
| 0x7CB922F6 |     830 | 33D  | GlobalFree
| 0xD9683B57 |     831 | 33E  | GlobalGetAtomNameA
| 0xD9683B6D |     832 | 33F  | GlobalGetAtomNameW
| 0x43A7ADC5 |     833 | 340  | GlobalHandle
| 0x88A9223C |     834 | 341  | GlobalLock
| 0x81E64FD  |     835 | 342  | GlobalMemoryStatus
| 0x9C13FBA  |     836 | 343  | GlobalMemoryStatusEx
| 0x7E9F4DA2 |     837 | 344  | GlobalReAlloc
| 0x976120B6 |     838 | 345  | GlobalSize
| 0x95D87F0B |     839 | 346  | GlobalUnWire
| 0xFD4D681  |     840 | 347  | GlobalUnfix
| 0xBF608091 |     841 | 348  | GlobalUnlock
| 0x9F2120B6 |     842 | 349  | GlobalWire
| 0x376BB320 |     843 | 34A  | Heap32First
| 0x16CB406C |     844 | 34B  | Heap32ListFirst
| 0x782F01DA |     845 | 34C  | Heap32ListNext
| 0x868585EE |     846 | 34D  | Heap32Next
| 0xC1E12821 |     847 | 34E  | HeapAlloc (forwarded to NTDLL.RtlAllocateHeap)
| 0xC52E1EFE |     848 | 34F  | HeapCompact
| 0xB46984E7 |     849 | 350  | HeapCreate
| 0xCD92833E |     850 | 351  | HeapDestroy
| 0x10C32616 |     851 | 352  | HeapFree
| 0x1CB3255C |     852 | 353  | HeapLock
| 0x806E170A |     853 | 354  | HeapQueryInformation
| 0xD45EE5B  |     854 | 355  | HeapReAlloc (forwarded to NTDLL.RtlReAllocateHeap)
| 0x5E187174 |     855 | 356  | HeapSetInformation
| 0x1EB15B79 |     856 | 357  | HeapSize (forwarded to NTDLL.RtlSizeHeap)
| 0xBFE61F06 |     857 | 358  | HeapSummary
| 0xC1E14876 |     858 | 359  | HeapUnlock
| 0x7DBDBBB5 |     859 | 35A  | HeapValidate
| 0x32FB21DC |     860 | 35B  | HeapWalk
| 0xCE9E7F21 |     861 | 35C  | IdnToAscii
| 0x5A1E1EC7 |     862 | 35D  | IdnToNameprepUnicode
| 0x1F102A56 |     863 | 35E  | IdnToUnicode
| 0xC9010C46 |     864 | 35F  | InitAtomTable
| 0xD96E1AD3 |     865 | 360  | InitOnceBeginInitialize (forwarded to api-ms-win-core-synch-l1-2-0.InitOnceBeginInitialize)
| 0xCD0CBC4F |     866 | 361  | InitOnceComplete (forwarded to api-ms-win-core-synch-l1-2-0.InitOnceComplete)
| 0xF2009373 |     867 | 362  | InitOnceExecuteOnce (forwarded to api-ms-win-core-synch-l1-2-0.InitOnceExecuteOnce)
| 0xCA4AA312 |     868 | 363  | InitOnceInitialize (forwarded to NTDLL.RtlRunOnceInitialize)
| 0x536F2B17 |     869 | 364  | InitializeConditionVariable (forwarded to NTDLL.RtlInitializeConditionVariable)
| 0xE1E2F945 |     870 | 365  | InitializeContext
| 0xCA2F0F49 |     871 | 366  | InitializeContext2
| 0x985D097C |     872 | 367  | InitializeCriticalSection (forwarded to NTDLL.RtlInitializeCriticalSection)
| 0xC956ACC1 |     873 | 368  | InitializeCriticalSectionAndSpinCount
| 0x4D0CC360 |     874 | 369  | InitializeCriticalSectionEx
| 0x41B28EF2 |     875 | 36A  | InitializeEnclave (forwarded to api-ms-win-core-enclave-l1-1-0.InitializeEnclave)
| 0x77FEF346 |     876 | 36B  | InitializeProcThreadAttributeList (forwarded to api-ms-win-core-processthreads-l1-1-0.InitializeProcThreadAttributeList)
| 0xCDDD5DB9 |     877 | 36C  | InitializeSListHead (forwarded to NTDLL.RtlInitializeSListHead)
| 0x5D708BEC |     878 | 36D  | InitializeSRWLock (forwarded to NTDLL.RtlInitializeSRWLock)
| 0xC47CAFA1 |     879 | 36E  | InitializeSynchronizationBarrier
| 0x3039D9EC |     880 | 36F  | InstallELAMCertificateInfo (forwarded to api-ms-win-core-sysinfo-l1-2-1.InstallELAMCertificateInfo)
| 0x5C634971 |     881 | 370  | InterlockedFlushSList (forwarded to NTDLL.RtlInterlockedFlushSList)
| 0x1E8C9848 |     882 | 371  | InterlockedPopEntrySList (forwarded to NTDLL.RtlInterlockedPopEntrySList)
| 0xF6BCF38D |     883 | 372  | InterlockedPushEntrySList (forwarded to NTDLL.RtlInterlockedPushEntrySList)
| 0xD37D88D0 |     884 | 373  | InterlockedPushListSList (forwarded to NTDLL.RtlInterlockedPushListSList)
| 0xE3223D94 |     885 | 374  | InterlockedPushListSListEx (forwarded to NTDLL.RtlInterlockedPushListSListEx)
| 0x4737EB21 |     886 | 375  | InvalidateConsoleDIBits
| 0x70467147 |     887 | 376  | IsBadCodePtr
| 0xF5BBAB70 |     888 | 377  | IsBadHugeReadPtr
| 0x85CCA5F3 |     889 | 378  | IsBadHugeWritePtr
| 0x6E824142 |     890 | 379  | IsBadReadPtr
| 0x53805BF2 |     891 | 37A  | IsBadStringPtrA
| 0x53805C08 |     892 | 37B  | IsBadStringPtrW
| 0x34586C28 |     893 | 37C  | IsBadWritePtr
| 0xD6D562D6 |     894 | 37D  | IsCalendarLeapDay
| 0xD4F9435D |     895 | 37E  | IsCalendarLeapMonth
| 0x3FF6B81D |     896 | 37F  | IsCalendarLeapYear
| 0x1448797  |     897 | 380  | IsDBCSLeadByte
| 0x5349E638 |     898 | 381  | IsDBCSLeadByteEx
| 0xA36DC676 |     899 | 382  | IsDebuggerPresent
| 0x7626DBD9 |     900 | 383  | IsEnclaveTypeSupported (forwarded to api-ms-win-core-enclave-l1-1-0.IsEnclaveTypeSupported)
| 0x41C8E61D |     901 | 384  | IsNLSDefinedString
| 0x391CDA06 |     902 | 385  | IsNativeVhdBoot
| 0xDD4174AE |     903 | 386  | IsNormalizedString
| 0x6CD1F7A  |     904 | 387  | IsProcessCritical (forwarded to api-ms-win-core-processthreads-l1-1-2.IsProcessCritical)
| 0x696C2F09 |     905 | 388  | IsProcessInJob
| 0x78CB00E8 |     906 | 389  | IsProcessorFeaturePresent
| 0xE8ECEA5D |     907 | 38A  | IsSystemResumeAutomatic
| 0xE0E81C7D |     908 | 38B  | IsThreadAFiber
| 0xB7B11B20 |     909 | 38C  | IsThreadpoolTimerSet (forwarded to NTDLL.TpIsTimerSet)
| 0xD0320853 |     910 | 38D  | IsValidCalDateTime
| 0x4340E2B3 |     911 | 38E  | IsValidCodePage
| 0x2E310E1D |     912 | 38F  | IsValidLanguageGroup
| 0xB7E02291 |     913 | 390  | IsValidLocale
| 0xA1913423 |     914 | 391  | IsValidLocaleName
| 0x48761429 |     915 | 392  | IsValidNLSVersion
| 0x675EF8AF |     916 | 393  | IsWow64GuestMachineSupported (forwarded to api-ms-win-core-wow64-l1-1-2.IsWow64GuestMachineSupported)
| 0xE610CFB8 |     917 | 394  | IsWow64Process
| 0x85C3EE59 |     918 | 395  | IsWow64Process2 (forwarded to api-ms-win-core-wow64-l1-1-1.IsWow64Process2)
| 0x7979D926 |     919 | 396  | K32EmptyWorkingSet
| 0xD7FB6E88 |     920 | 397  | K32EnumDeviceDrivers
| 0x1EB0587  |     921 | 398  | K32EnumPageFilesA
| 0x1EB059D  |     922 | 399  | K32EnumPageFilesW
| 0x2733B580 |     923 | 39A  | K32EnumProcessModules
| 0xCF156081 |     924 | 39B  | K32EnumProcessModulesEx
| 0x74CAB41C |     925 | 39C  | K32EnumProcesses
| 0xA1FA6F6C |     926 | 39D  | K32GetDeviceDriverBaseNameA
| 0xA1FA6F82 |     927 | 39E  | K32GetDeviceDriverBaseNameW
| 0xA5DE706C |     928 | 39F  | K32GetDeviceDriverFileNameA
| 0xA5DE7082 |     929 | 3A0  | K32GetDeviceDriverFileNameW
| 0x3B26CC39 |     930 | 3A1  | K32GetMappedFileNameA
| 0x3B26CC4F |     931 | 3A2  | K32GetMappedFileNameW
| 0xFE4CD27A |     932 | 3A3  | K32GetModuleBaseNameA
| 0xFE4CD290 |     933 | 3A4  | K32GetModuleBaseNameW
| 0x8FF4E001 |     934 | 3A5  | K32GetModuleFileNameExA
| 0x8FF4E017 |     935 | 3A6  | K32GetModuleFileNameExW
| 0x683C5275 |     936 | 3A7  | K32GetModuleInformation
| 0xB424B7C8 |     937 | 3A8  | K32GetPerformanceInfo
| 0x8F76DE7F |     938 | 3A9  | K32GetProcessImageFileNameA
| 0x8F76DE95 |     939 | 3AA  | K32GetProcessImageFileNameW
| 0x6807F713 |     940 | 3AB  | K32GetProcessMemoryInfo
| 0x914D0801 |     941 | 3AC  | K32GetWsChanges
| 0x556A00DC |     942 | 3AD  | K32GetWsChangesEx
| 0x48A7B418 |     943 | 3AE  | K32InitializeProcessForWsWatch
| 0x7D760876 |     944 | 3AF  | K32QueryWorkingSet
| 0x5FAA1E17 |     945 | 3B0  | K32QueryWorkingSetEx
| 0x751DE5A1 |     946 | 3B1  | LCIDToLocaleName
| 0xF825B20C |     947 | 3B2  | LCMapStringA
| 0x9087C1A5 |     948 | 3B3  | LCMapStringEx
| 0xF825B222 |     949 | 3B4  | LCMapStringW
| 0xDCCC4C52 |     950 | 3B5  | LZClose
| 0x54254872 |     951 | 3B6  | LZCloseFile
| 0x8985BC5F |     952 | 3B7  | LZCopy
| 0x7CB41C7B |     953 | 3B8  | LZCreateFileW
| 0x8B75BC4B |     954 | 3B9  | LZDone
| 0x954DBC1A |     955 | 3BA  | LZInit
| 0x25C3598C |     956 | 3BB  | LZOpenFileA
| 0x25C359A2 |     957 | 3BC  | LZOpenFileW
| 0xA70DB9CA |     958 | 3BD  | LZRead
| 0xA92DB9D1 |     959 | 3BE  | LZSeek
| 0xECC548E1 |     960 | 3BF  | LZStart
| 0xF1080B88 |     961 | 3C0  | LeaveCriticalSection (forwarded to NTDLL.RtlLeaveCriticalSection)
| 0x55819C06 |     962 | 3C1  | LeaveCriticalSectionWhenCallbackReturns (forwarded to NTDLL.TpCallbackLeaveCriticalSectionOnCompletion)
| 0xF56C1AE8 |     963 | 3C2  | LoadAppInitDlls
| 0xE3F343D8 |     964 | 3C3  | LoadEnclaveData (forwarded to api-ms-win-core-enclave-l1-1-0.LoadEnclaveData)
| 0xEC0E4E8E |     965 | 3C4  | LoadLibraryA
| 0x753A4FC  |     966 | 3C5  | LoadLibraryExA
| 0x753A512  |     967 | 3C6  | LoadLibraryExW
| 0xEC0E4EA4 |     968 | 3C7  | LoadLibraryW
| 0xBBF979EC |     969 | 3C8  | LoadModule
| 0xD281C73B |     970 | 3C9  | LoadPackagedLibrary
| 0x934E1F7B |     971 | 3CA  | LoadResource
| 0x50082003 |     972 | 3CB  | LoadStringBaseExW
| 0xB1312090 |     973 | 3CC  | LoadStringBaseW
| 0x4C0297FA |     974 | 3CD  | LocalAlloc
| 0x85C60E88 |     975 | 3CE  | LocalCompact
| 0x5291F3B9 |     976 | 3CF  | LocalFileTimeToFileTime
| 0x59C473C6 |     977 | 3D0  | LocalFileTimeToLocalSystemTime (forwarded to api-ms-win-core-timezone-l1-1-1.LocalFileTimeToLocalSystemTime)
| 0x4BC2E54A |     978 | 3D1  | LocalFlags
| 0x5CBAEAF6 |     979 | 3D2  | LocalFree
| 0x4419ADBD |     980 | 3D3  | LocalHandle
| 0x68AAEA3C |     981 | 3D4  | LocalLock
| 0x7E5F5132 |     982 | 3D5  | LocalReAlloc
| 0xCC2A1F08 |     983 | 3D6  | LocalShrink
| 0x7762E8B6 |     984 | 3D7  | LocalSize
| 0x4B2C6A4B |     985 | 3D8  | LocalSystemTimeToLocalFileTime (forwarded to api-ms-win-core-timezone-l1-1-1.LocalSystemTimeToLocalFileTime)
| 0xBFD28089 |     986 | 3D9  | LocalUnlock
| 0xEF3F4101 |     987 | 3DA  | LocaleNameToLCID
| 0x473C1B9A |     988 | 3DB  | LocateXStateFeature
| 0x1122D457 |     989 | 3DC  | LockFile
| 0x4ADD163C |     990 | 3DD  | LockFileEx
| 0x9A4E2F7B |     991 | 3DE  | LockResource
| 0x221BF577 |     992 | 3DF  | MapUserPhysicalPages
| 0xAFF8DC88 |     993 | 3E0  | MapUserPhysicalPagesScatter
| 0x7B073C59 |     994 | 3E1  | MapViewOfFile
| 0xC3F716D6 |     995 | 3E2  | MapViewOfFileEx
| 0x10D589E1 |     996 | 3E3  | MapViewOfFileExNuma
| 0x60C9FC54 |     997 | 3E4  | MapViewOfFileFromApp (forwarded to api-ms-win-core-memory-l1-1-1.MapViewOfFileFromApp)
| 0x434A3697 |     998 | 3E5  | Module32First
| 0xB4BA1AA8 |     999 | 3E6  | Module32FirstW
| 0x56F4676A |    1000 | 3E7  | Module32Next
| 0x3B52B7FA |    1001 | 3E8  | Module32NextW
| 0xA4048954 |    1002 | 3E9  | MoveFileA
| 0x4E2566A  |    1003 | 3EA  | MoveFileExA
| 0x4E25680  |    1004 | 3EB  | MoveFileExW
| 0xB6F709CC |    1005 | 3EC  | MoveFileTransactedA
| 0xB6F709E2 |    1006 | 3ED  | MoveFileTransactedW
| 0xA404896A |    1007 | 3EE  | MoveFileW
| 0xE079223C |    1008 | 3EF  | MoveFileWithProgressA
| 0xE0792252 |    1009 | 3F0  | MoveFileWithProgressW
| 0x5B4F619D |    1010 | 3F1  | MulDiv
| 0xEF4AC4E4 |    1011 | 3F2  | MultiByteToWideChar
| 0x211A67CB |    1012 | 3F3  | NeedCurrentDirectoryForExePathA
| 0x211A67E1 |    1013 | 3F4  | NeedCurrentDirectoryForExePathW
| 0x29B45E13 |    1014 | 3F5  | NlsCheckPolicy
| 0xA8EC2714 |    1015 | 3F6  | NlsEventDataDescCreate
| 0x6BEF4DD4 |    1016 | 3F7  | NlsGetCacheUpdateCount
| 0x62A97698 |    1017 | 3F8  | NlsUpdateLocale
| 0x36F71294 |    1018 | 3F9  | NlsUpdateSystemLocale
| 0x10ADC825 |    1019 | 3FA  | NlsWriteEtwEvent
| 0x4A6A094A |    1020 | 3FB  | NormalizeString
| 0x4DE63498 |    1021 | 3FC  | NotifyMountMgr
| 0x39946653 |    1022 | 3FD  | NotifyUILanguageChange
| 0x703E944  |    1023 | 3FE  | NtVdm64CreateProcessInternalW
| 0x63033250 |    1024 | 3FF  | OOBEComplete
| 0xA412743D |    1025 | 400  | OfferVirtualMemory (forwarded to api-ms-win-core-memory-l1-1-2.OfferVirtualMemory)
| 0x518C7C0B |    1026 | 401  | OpenConsoleW
| 0x7168D27B |    1027 | 402  | OpenConsoleWStub
| 0xBF620084 |    1028 | 403  | OpenEventA
| 0xBF62009A |    1029 | 404  | OpenEventW
| 0x112704B8 |    1030 | 405  | OpenFile
| 0xF6939FB6 |    1031 | 406  | OpenFileById
| 0x8ED44C9E |    1032 | 407  | OpenFileMappingA
| 0x8ED44CB4 |    1033 | 408  | OpenFileMappingW
| 0xE62F1C8E |    1034 | 409  | OpenJobObjectA
| 0xE62F1CA4 |    1035 | 40A  | OpenJobObjectW
| 0xDD81EE48 |    1036 | 40B  | OpenMutexA
| 0xDD81EE5E |    1037 | 40C  | OpenMutexW
| 0x14B0377D |    1038 | 40D  | OpenPackageInfoByFullName (forwarded to kernelbase.OpenPackageInfoByFullName)
| 0x6D402488 |    1039 | 40E  | OpenPrivateNamespaceA
| 0x6D40249E |    1040 | 40F  | OpenPrivateNamespaceW
| 0xEFE297C0 |    1041 | 410  | OpenProcess
| 0x387AC915 |    1042 | 411  | OpenProcessToken (forwarded to api-ms-win-core-processthreads-l1-1-0.OpenProcessToken)
| 0x3B14AC83 |    1043 | 412  | OpenProfileUserMapping
| 0xEFFF49B5 |    1044 | 413  | OpenSemaphoreA
| 0xEFFF49CB |    1045 | 414  | OpenSemaphoreW
| 0xB6E9E1EA |    1046 | 415  | OpenState (forwarded to kernelbase.OpenState)
| 0xDB1DA378 |    1047 | 416  | OpenStateExplicit (forwarded to kernelbase.OpenStateExplicit)
| 0x58C91E6F |    1048 | 417  | OpenThread
| 0x53346CAF |    1049 | 418  | OpenThreadToken (forwarded to api-ms-win-core-processthreads-l1-1-0.OpenThreadToken)
| 0xDF17FDE  |    1050 | 419  | OpenWaitableTimerA
| 0xDF17FF4  |    1051 | 41A  | OpenWaitableTimerW
| 0x470D22BC |    1052 | 41B  | OutputDebugStringA
| 0x470D22D2 |    1053 | 41C  | OutputDebugStringW
| 0x2690D16F |    1054 | 41D  | PackageFamilyNameFromFullName (forwarded to kernelbase.PackageFamilyNameFromFullName)
| 0xF4EE18CC |    1055 | 41E  | PackageFamilyNameFromId (forwarded to kernelbase.PackageFamilyNameFromId)
| 0xD1EAFF28 |    1056 | 41F  | PackageFullNameFromId (forwarded to kernelbase.PackageFullNameFromId)
| 0xCB1563CD |    1057 | 420  | PackageIdFromFullName (forwarded to kernelbase.PackageIdFromFullName)
| 0xC2A221B3 |    1058 | 421  | PackageNameAndPublisherIdFromFamilyName (forwarded to kernelbase.PackageNameAndPublisherIdFromFamilyName)
| 0x7EA3CF05 |    1059 | 422  | ParseApplicationUserModelId (forwarded to kernelbase.ParseApplicationUserModelId)
| 0x2AEE3B7F |    1060 | 423  | PeekConsoleInputA
| 0x2AEE3B95 |    1061 | 424  | PeekConsoleInputW
| 0xB407C411 |    1062 | 425  | PeekNamedPipe
| 0x83F28CA1 |    1063 | 426  | PostQueuedCompletionStatus
| 0xE3424370 |    1064 | 427  | PowerClearRequest
| 0x3D3ED960 |    1065 | 428  | PowerCreateRequest
| 0x8C3517F4 |    1066 | 429  | PowerSetRequest
| 0x8A09163C |    1067 | 42A  | PrefetchVirtualMemory (forwarded to api-ms-win-core-memory-l1-1-1.PrefetchVirtualMemory)
| 0x120E06F3 |    1068 | 42B  | PrepareTape
| 0xB8CF9F8D |    1069 | 42C  | PrivCopyFileExW
| 0x4E48564D |    1070 | 42D  | PrivMoveFileIdentityW
| 0x3249BAA7 |    1071 | 42E  | Process32First
| 0xD53992A4 |    1072 | 42F  | Process32FirstW
| 0x4776654A |    1073 | 430  | Process32Next
| 0x2A523C0A |    1074 | 431  | Process32NextW
| 0xAC4BA4E8 |    1075 | 432  | ProcessIdToSessionId
| 0xA216CAB1 |    1076 | 433  | PssCaptureSnapshot
| 0x4072F55  |    1077 | 434  | PssDuplicateSnapshot
| 0x8A479452 |    1078 | 435  | PssFreeSnapshot
| 0x5EA68639 |    1079 | 436  | PssQuerySnapshot
| 0x258163D3 |    1080 | 437  | PssWalkMarkerCreate
| 0xBE878591 |    1081 | 438  | PssWalkMarkerFree
| 0x8D2AF280 |    1082 | 439  | PssWalkMarkerGetPosition
| 0xC95095D9 |    1083 | 43A  | PssWalkMarkerRewind
| 0xD8878257 |    1084 | 43B  | PssWalkMarkerSeek
| 0xA7C630A0 |    1085 | 43C  | PssWalkMarkerSeekToBeginning
| 0x8D2AF283 |    1086 | 43D  | PssWalkMarkerSetPosition
| 0xDABF8258 |    1087 | 43E  | PssWalkMarkerTell
| 0x5069CC4E |    1088 | 43F  | PssWalkSnapshot
| 0xE642F767 |    1089 | 440  | PulseEvent
| 0x5B367B01 |    1090 | 441  | PurgeComm
| 0xA42C2786 |    1091 | 442  | QueryActCtxSettingsW
| 0x5499C0F  |    1092 | 443  | QueryActCtxSettingsWWorker
| 0xBD7094C6 |    1093 | 444  | QueryActCtxW
| 0xBA4A0120 |    1094 | 445  | QueryActCtxWWorker
| 0x1ABBEEC6 |    1095 | 446  | QueryDepthSList (forwarded to NTDLL.RtlQueryDepthSList)
| 0x40A6F203 |    1096 | 447  | QueryDosDeviceA
| 0x40A6F219 |    1097 | 448  | QueryDosDeviceW
| 0xF660F67E |    1098 | 449  | QueryFullProcessImageNameA
| 0xF660F694 |    1099 | 44A  | QueryFullProcessImageNameW
| 0xD3919EC3 |    1100 | 44B  | QueryIdleProcessorCycleTime
| 0xE68FB16C |    1101 | 44C  | QueryIdleProcessorCycleTimeEx
| 0x8EC65AF2 |    1102 | 44D  | QueryInformationJobObject
| 0xD3D33666 |    1103 | 44E  | QueryIoRateControlInformationJobObject
| 0xD23B2FDE |    1104 | 44F  | QueryMemoryResourceNotification
| 0xEA7AF15B |    1105 | 450  | QueryPerformanceCounter
| 0x249466D5 |    1106 | 451  | QueryPerformanceFrequency
| 0x919C2EB3 |    1107 | 452  | QueryProcessAffinityUpdateMode
| 0x1203CDE8 |    1108 | 453  | QueryProcessCycleTime
| 0xDE184290 |    1109 | 454  | QueryProtectedPolicy (forwarded to api-ms-win-core-processthreads-l1-1-2.QueryProtectedPolicy)
| 0xA27B966B |    1110 | 455  | QueryThreadCycleTime
| 0xDFB3D58A |    1111 | 456  | QueryThreadProfiling
| 0xF9ADC78C |    1112 | 457  | QueryThreadpoolStackInformation
| 0x1017729  |    1113 | 458  | QueryUmsThreadInformation
| 0xAFE2FFF1 |    1114 | 459  | QueryUnbiasedInterruptTime
| 0x1D7F957B |    1115 | 45A  | QueueUserAPC
| 0xA46A9B02 |    1116 | 45B  | QueueUserWorkItem
| 0x550CD596 |    1117 | 45C  | QuirkGetData2Worker
| 0x20760901 |    1118 | 45D  | QuirkGetDataWorker
| 0xBAEA3875 |    1119 | 45E  | QuirkIsEnabled2Worker
| 0xBAEE3875 |    1120 | 45F  | QuirkIsEnabled3Worker
| 0x6CC4B97D |    1121 | 460  | QuirkIsEnabledForPackage2Worker
| 0x6CC8B97D |    1122 | 461  | QuirkIsEnabledForPackage3Worker
| 0x6CCCB97D |    1123 | 462  | QuirkIsEnabledForPackage4Worker
| 0x1CF2EBF8 |    1124 | 463  | QuirkIsEnabledForPackageWorker
| 0x214CAD7B |    1125 | 464  | QuirkIsEnabledForProcessWorker
| 0xCCD1F5BC |    1126 | 465  | QuirkIsEnabledWorker
| 0x9BE0580E |    1127 | 466  | RaiseException
| 0x3CC7B032 |    1128 | 467  | RaiseFailFastException (forwarded to kernelbase.RaiseFailFastException)
| 0x8808CE4E |    1129 | 468  | RaiseInvalid16BitExeError
| 0x762994B8 |    1130 | 469  | ReOpenFile
| 0x87925BF2 |    1131 | 46A  | ReadConsoleA
| 0x27702B7F |    1132 | 46B  | ReadConsoleInputA
| 0x856FE77  |    1133 | 46C  | ReadConsoleInputExA (forwarded to kernelbase.ReadConsoleInputExA)
| 0x906FE77  |    1134 | 46D  | ReadConsoleInputExW (forwarded to kernelbase.ReadConsoleInputExW)
| 0x27702B95 |    1135 | 46E  | ReadConsoleInputW
| 0xD3A97C05 |    1136 | 46F  | ReadConsoleOutputA
| 0xCF4A65DA |    1137 | 470  | ReadConsoleOutputAttribute
| 0x213E9470 |    1138 | 471  | ReadConsoleOutputCharacterA
| 0x213E9486 |    1139 | 472  | ReadConsoleOutputCharacterW
| 0xD3A97C1B |    1140 | 473  | ReadConsoleOutputW
| 0x87925C08 |    1141 | 474  | ReadConsoleW
| 0x100B659D |    1142 | 475  | ReadDirectoryChangesExW
| 0x18312DA7 |    1143 | 476  | ReadDirectoryChangesW
| 0x10FA6516 |    1144 | 477  | ReadFile
| 0x40C145FC |    1145 | 478  | ReadFileEx
| 0x8BC6D066 |    1146 | 479  | ReadFileScatter
| 0x579D1BE9 |    1147 | 47A  | ReadProcessMemory
| 0xAED89C0F |    1148 | 47B  | ReadThreadProfilingData
| 0x490E2A73 |    1149 | 47C  | ReclaimVirtualMemory (forwarded to api-ms-win-core-memory-l1-1-2.ReclaimVirtualMemory)
| 0x35E273E6 |    1150 | 47D  | RegCloseKey
| 0xEC949FCD |    1151 | 47E  | RegCopyTreeW
| 0x8B64E6B4 |    1152 | 47F  | RegCreateKeyExA
| 0x8B64E6CA |    1153 | 480  | RegCreateKeyExW
| 0x4F671EB1 |    1154 | 481  | RegDeleteKeyExA
| 0x4F671EC7 |    1155 | 482  | RegDeleteKeyExW
| 0xFECE94B5 |    1156 | 483  | RegDeleteTreeA
| 0xFECE94CB |    1157 | 484  | RegDeleteTreeW
| 0xB4CEEAB6 |    1158 | 485  | RegDeleteValueA
| 0xB4CEEACC |    1159 | 486  | RegDeleteValueW
| 0xC72A90B7 |    1160 | 487  | RegDisablePredefinedCacheEx
| 0xA6469D81 |    1161 | 488  | RegEnumKeyExA
| 0xA6469D97 |    1162 | 489  | RegEnumKeyExW
| 0xBAE6987  |    1163 | 48A  | RegEnumValueA
| 0xBAE699D  |    1164 | 48B  | RegEnumValueW
| 0x3BE27449 |    1165 | 48C  | RegFlushKey
| 0x66FA3FBB |    1166 | 48D  | RegGetKeySecurity
| 0x64A57266 |    1167 | 48E  | RegGetValueA
| 0x64A5727C |    1168 | 48F  | RegGetValueW
| 0x28D8B47  |    1169 | 490  | RegLoadKeyA
| 0x28D8B5D  |    1170 | 491  | RegLoadKeyW
| 0xF2A35031 |    1171 | 492  | RegLoadMUIStringA
| 0xF2A35047 |    1172 | 493  | RegLoadMUIStringW
| 0x9AE4C899 |    1173 | 494  | RegNotifyChangeKeyValue
| 0xFA0958A7 |    1174 | 495  | RegOpenCurrentUser
| 0xA84AEB81 |    1175 | 496  | RegOpenKeyExA
| 0xA84AEB97 |    1176 | 497  | RegOpenKeyExW
| 0xA902E6BC |    1177 | 498  | RegOpenUserClassesRoot
| 0xC8F63C08 |    1178 | 499  | RegQueryInfoKeyA
| 0xC8F63C1E |    1179 | 49A  | RegQueryInfoKeyW
| 0xFCBA95AB |    1180 | 49B  | RegQueryValueExA
| 0xFCBA95C1 |    1181 | 49C  | RegQueryValueExW
| 0xB85BA69F |    1182 | 49D  | RegRestoreKeyA
| 0xB85BA6B5 |    1183 | 49E  | RegRestoreKeyW
| 0x99270DA1 |    1184 | 49F  | RegSaveKeyExA
| 0x99270DB7 |    1185 | 4A0  | RegSaveKeyExW
| 0x6CFA3FBB |    1186 | 4A1  | RegSetKeySecurity
| 0x2D1C9ADD |    1187 | 4A2  | RegSetValueExA
| 0x2D1C9AF3 |    1188 | 4A3  | RegSetValueExW
| 0x4A57106C |    1189 | 4A4  | RegUnLoadKeyA
| 0x4A571082 |    1190 | 4A5  | RegUnLoadKeyW
| 0x820A9948 |    1191 | 4A6  | RegisterApplicationRecoveryCallback
| 0xB3107B9  |    1192 | 4A7  | RegisterApplicationRestart
| 0x51C9528  |    1193 | 4A8  | RegisterBadMemoryNotification
| 0x57EDA677 |    1194 | 4A9  | RegisterConsoleIME
| 0x581DA7E4 |    1195 | 4AA  | RegisterConsoleOS2
| 0x57A5A9BF |    1196 | 4AB  | RegisterConsoleVDM
| 0xED1EED89 |    1197 | 4AC  | RegisterWaitForInputIdle
| 0x5375A683 |    1198 | 4AD  | RegisterWaitForSingleObject
| 0xDF91A14C |    1199 | 4AE  | RegisterWaitForSingleObjectEx
| 0x2129F0D4 |    1200 | 4AF  | RegisterWaitUntilOOBECompleted
| 0x877BB570 |    1201 | 4B0  | RegisterWowBaseHandlers
| 0x66E28B68 |    1202 | 4B1  | RegisterWowExec
| 0xCF077CF4 |    1203 | 4B2  | ReleaseActCtx
| 0x5B02477C |    1204 | 4B3  | ReleaseActCtxWorker
| 0x14A059E5 |    1205 | 4B4  | ReleaseMutex
| 0x96B4CFC2 |    1206 | 4B5  | ReleaseMutexWhenCallbackReturns (forwarded to NTDLL.TpCallbackReleaseMutexOnCompletion)
| 0x6D32AC13 |    1207 | 4B6  | ReleaseSRWLockExclusive (forwarded to NTDLL.RtlReleaseSRWLockExclusive)
| 0x11071564 |    1208 | 4B7  | ReleaseSRWLockShared (forwarded to NTDLL.RtlReleaseSRWLockShared)
| 0xDF11EB6D |    1209 | 4B8  | ReleaseSemaphore
| 0x235BE8DB |    1210 | 4B9  | ReleaseSemaphoreWhenCallbackReturns (forwarded to NTDLL.TpCallbackReleaseSemaphoreOnCompletion)
| 0x83D32647 |    1211 | 4BA  | RemoveDirectoryA
| 0x6EEAB109 |    1212 | 4BB  | RemoveDirectoryTransactedA
| 0x6EEAB11F |    1213 | 4BC  | RemoveDirectoryTransactedW
| 0x83D3265D |    1214 | 4BD  | RemoveDirectoryW
| 0xF4AC6AA3 |    1215 | 4BE  | RemoveDllDirectory (forwarded to api-ms-win-core-libraryloader-l1-1-0.RemoveDllDirectory)
| 0xE894077A |    1216 | 4BF  | RemoveLocalAlternateComputerNameA
| 0xE8940790 |    1217 | 4C0  | RemoveLocalAlternateComputerNameW
| 0xC26042B6 |    1218 | 4C1  | RemoveSecureMemoryCacheCallback
| 0x78347F9D |    1219 | 4C2  | RemoveVectoredContinueHandler (forwarded to NTDLL.RtlRemoveVectoredContinueHandler)
| 0x4BD55FD7 |    1220 | 4C3  | RemoveVectoredExceptionHandler (forwarded to NTDLL.RtlRemoveVectoredExceptionHandler)
| 0xEDA06C   |    1221 | 4C4  | ReplaceFile
| 0x36007AE  |    1222 | 4C5  | ReplaceFileA
| 0x36007C4  |    1223 | 4C6  | ReplaceFileW
| 0x84E6E355 |    1224 | 4C7  | ReplacePartitionUnit
| 0xF34084CC |    1225 | 4C8  | RequestDeviceWakeup
| 0x77CC0B4A |    1226 | 4C9  | RequestWakeupLatency
| 0x560B084F |    1227 | 4CA  | ResetEvent
| 0xEC3BA208 |    1228 | 4CB  | ResetWriteWatch
| 0x76D1A28C |    1229 | 4CC  | ResizePseudoConsole
| 0xF483C0C4 |    1230 | 4CD  | ResolveDelayLoadedAPI (forwarded to NTDLL.LdrResolveDelayLoadedAPI)
| 0x640F5EF1 |    1231 | 4CE  | ResolveDelayLoadsFromDll (forwarded to NTDLL.LdrResolveDelayLoadsFromDll)
| 0x28B4A822 |    1232 | 4CF  | ResolveLocaleName
| 0xE5A17D79 |    1233 | 4D0  | RestoreLastError (forwarded to NTDLL.RtlRestoreLastWin32Error)
| 0x9E4A3F88 |    1234 | 4D1  | ResumeThread
| 0x22FC1661 |    1235 | 4D2  | RtlAddFunctionTable
| 0x818A64C8 |    1236 | 4D3  | RtlCaptureContext
| 0x2BDC1FD7 |    1237 | 4D4  | RtlCaptureStackBackTrace
| 0x770DCEF6 |    1238 | 4D5  | RtlCompareMemory
| 0xCF64979B |    1239 | 4D6  | RtlCopyMemory
| 0xE0262DF4 |    1240 | 4D7  | RtlDeleteFunctionTable
| 0xC930AF1B |    1241 | 4D8  | RtlFillMemory
| 0x7491200B |    1242 | 4D9  | RtlInstallFunctionTableCallback
| 0xC1D846D9 |    1243 | 4DA  | RtlLookupFunctionEntry
| 0xCF14E85B |    1244 | 4DB  | RtlMoveMemory
| 0x98C05D71 |    1245 | 4DC  | RtlPcToFileHeader
| 0x1C34081D |    1246 | 4DD  | RtlRaiseException
| 0x89103508 |    1247 | 4DE  | RtlRestoreContext
| 0xC527094F |    1248 | 4DF  | RtlUnwind
| 0x4BEA5469 |    1249 | 4E0  | RtlUnwindEx
| 0xDEFE7C76 |    1250 | 4E1  | RtlVirtualUnwind
| 0x7EDE2A0A |    1251 | 4E2  | RtlZeroMemory (forwarded to NTDLL.RtlZeroMemory)
| 0xCB93530C |    1252 | 4E3  | ScrollConsoleScreenBufferA
| 0xCB935322 |    1253 | 4E4  | ScrollConsoleScreenBufferW
| 0xE7D453CA |    1254 | 4E5  | SearchPathA
| 0xE7D453E0 |    1255 | 4E6  | SearchPathW
| 0xDD7195C4 |    1256 | 4E7  | SetCachedSigningLevel
| 0xE9C776D0 |    1257 | 4E8  | SetCalendarInfoA
| 0xE9C776E6 |    1258 | 4E9  | SetCalendarInfoW
| 0x8D082811 |    1259 | 4EA  | SetComPlusPackageInstallStatus
| 0xEC69E7DB |    1260 | 4EB  | SetCommBreak
| 0xD0CF34F6 |    1261 | 4EC  | SetCommConfig
| 0x535E1957 |    1262 | 4ED  | SetCommMask
| 0xF102F6D5 |    1263 | 4EE  | SetCommState
| 0xC35533C6 |    1264 | 4EF  | SetCommTimeouts
| 0x16A42291 |    1265 | 4F0  | SetComputerNameA
| 0x2BBD669C |    1266 | 4F1  | SetComputerNameEx2W
| 0xACC8A586 |    1267 | 4F2  | SetComputerNameExA
| 0xACC8A59C |    1268 | 4F3  | SetComputerNameExW
| 0x16A422A7 |    1269 | 4F4  | SetComputerNameW
| 0x6969909C |    1270 | 4F5  | SetConsoleActiveScreenBuffer
| 0xDF80B7C3 |    1271 | 4F6  | SetConsoleCP
| 0xC40E481F |    1272 | 4F7  | SetConsoleCtrlHandler
| 0xF2F6AB2A |    1273 | 4F8  | SetConsoleCursor
| 0xFFE2CB1E |    1274 | 4F9  | SetConsoleCursorInfo
| 0x7D2CB55  |    1275 | 4FA  | SetConsoleCursorMode
| 0x982DAB93 |    1276 | 4FB  | SetConsoleCursorPosition
| 0xD796A152 |    1277 | 4FC  | SetConsoleDisplayMode
| 0xE99DF92B |    1278 | 4FD  | SetConsoleFont
| 0xD41A3466 |    1279 | 4FE  | SetConsoleHardwareState
| 0x4FB2A1A6 |    1280 | 4FF  | SetConsoleHistoryInfo
| 0xEFA5F625 |    1281 | 500  | SetConsoleIcon
| 0x5E9156C3 |    1282 | 501  | SetConsoleInputExeNameA (forwarded to kernelbase.SetConsoleInputExeNameA)
| 0x5F4156C3 |    1283 | 502  | SetConsoleInputExeNameW (forwarded to kernelbase.SetConsoleInputExeNameW)
| 0x565760E3 |    1284 | 503  | SetConsoleKeyShortcuts
| 0x6C9D210  |    1285 | 504  | SetConsoleLocalEUDC
| 0xA5D04E83 |    1286 | 505  | SetConsoleMaximumWindowSize
| 0x576B477C |    1287 | 506  | SetConsoleMenuClose
| 0xF74DF91C |    1288 | 507  | SetConsoleMode
| 0x8D13A815 |    1289 | 508  | SetConsoleNlsMode
| 0xB23638B9 |    1290 | 509  | SetConsoleNumberOfCommandsA
| 0xB23638CF |    1291 | 50A  | SetConsoleNumberOfCommandsW
| 0xEFBCD669 |    1292 | 50B  | SetConsoleOS2OemFormat
| 0xCBC29D0D |    1293 | 50C  | SetConsoleOutputCP
| 0x3D9B3950 |    1294 | 50D  | SetConsolePalette
| 0x20D6B40A |    1295 | 50E  | SetConsoleScreenBufferInfoEx
| 0x5D1AB984 |    1296 | 50F  | SetConsoleScreenBufferSize
| 0x7A2C1C8E |    1297 | 510  | SetConsoleTextAttribute
| 0x76A5E942 |    1298 | 511  | SetConsoleTitleA
| 0x76A5E958 |    1299 | 512  | SetConsoleTitleW
| 0xF3A7BA9E |    1300 | 513  | SetConsoleWindowInfo
| 0x9168924F |    1301 | 514  | SetCriticalSectionSpinCount (forwarded to NTDLL.RtlSetCriticalSectionSpinCount)
| 0x78B7A58  |    1302 | 515  | SetCurrentConsoleFontEx
| 0xBFC7034F |    1303 | 516  | SetCurrentDirectoryA
| 0xBFC70365 |    1304 | 517  | SetCurrentDirectoryW
| 0xC61DD75C |    1305 | 518  | SetDefaultCommConfigA
| 0xC61DD772 |    1306 | 519  | SetDefaultCommConfigW
| 0x286B1160 |    1307 | 51A  | SetDefaultDllDirectories (forwarded to api-ms-win-core-libraryloader-l1-1-0.SetDefaultDllDirectories)
| 0x673F2399 |    1308 | 51B  | SetDllDirectoryA
| 0x673F23AF |    1309 | 51C  | SetDllDirectoryW
| 0xC446DC63 |    1310 | 51D  | SetDynamicTimeZoneInformation
| 0x96A028A6 |    1311 | 51E  | SetEndOfFile
| 0x4FAE5F18 |    1312 | 51F  | SetEnvironmentStringsA
| 0x4FAE5F2E |    1313 | 520  | SetEnvironmentStringsW
| 0xF2E1A993 |    1314 | 521  | SetEnvironmentVariableA
| 0xF2E1A9A9 |    1315 | 522  | SetEnvironmentVariableW
| 0xA498EAB6 |    1316 | 523  | SetErrorMode
| 0xF108744E |    1317 | 524  | SetEvent
| 0x347B5169 |    1318 | 525  | SetEventWhenCallbackReturns (forwarded to NTDLL.TpCallbackSetEventOnCompletion)
| 0xFA99EFC9 |    1319 | 526  | SetFileApisToANSI
| 0x3DA822CD |    1320 | 527  | SetFileApisToOEM
| 0x56F7396A |    1321 | 528  | SetFileAttributesA
| 0x23B3B5D2 |    1322 | 529  | SetFileAttributesTransactedA
| 0x23B3B5E8 |    1323 | 52A  | SetFileAttributesTransactedW
| 0x56F73980 |    1324 | 52B  | SetFileAttributesW
| 0x8CCAC80B |    1325 | 52C  | SetFileBandwidthReservation
| 0x2FF90F2D |    1326 | 52D  | SetFileCompletionNotificationModes
| 0x20132B94 |    1327 | 52E  | SetFileInformationByHandle
| 0xD89D6B51 |    1328 | 52F  | SetFileIoOverlappedRange
| 0x76DA08AC |    1329 | 530  | SetFilePointer
| 0xB8AA2B95 |    1330 | 531  | SetFilePointerEx
| 0x33247852 |    1331 | 532  | SetFileShortNameA
| 0x33247868 |    1332 | 533  | SetFileShortNameW
| 0xE1159BB0 |    1333 | 534  | SetFileTime
| 0xFE2D257B |    1334 | 535  | SetFileValidData
| 0xF52309DB |    1335 | 536  | SetFirmwareEnvironmentVariableA
| 0x4C82783E |    1336 | 537  | SetFirmwareEnvironmentVariableExA
| 0x4C827854 |    1337 | 538  | SetFirmwareEnvironmentVariableExW
| 0xF52309F1 |    1338 | 539  | SetFirmwareEnvironmentVariableW
| 0xFB8F68C9 |    1339 | 53A  | SetHandleCount
| 0x7F9E1144 |    1340 | 53B  | SetHandleInformation
| 0x301F89AA |    1341 | 53C  | SetInformationJobObject
| 0x2FA3E2FE |    1342 | 53D  | SetIoRateControlInformationJobObject
| 0xC2A22880 |    1343 | 53E  | SetLastConsoleEventActive (forwarded to kernelbase.SetLastConsoleEventActive)
| 0x75F21966 |    1344 | 53F  | SetLastError
| 0x643C0817 |    1345 | 540  | SetLocalPrimaryComputerNameA
| 0x643C082D |    1346 | 541  | SetLocalPrimaryComputerNameW
| 0xB9A488CF |    1347 | 542  | SetLocalTime
| 0xEE983477 |    1348 | 543  | SetLocaleInfoA
| 0xEE98348D |    1349 | 544  | SetLocaleInfoW
| 0xF60605DF |    1350 | 545  | SetMailslotInfo
| 0x14BDEE44 |    1351 | 546  | SetMessageWaitingIndicator
| 0x2AAF49FE |    1352 | 547  | SetNamedPipeAttribute
| 0xE97BC532 |    1353 | 548  | SetNamedPipeHandleState
| 0xAA556735 |    1354 | 549  | SetPriorityClass
| 0x86E3ED92 |    1355 | 54A  | SetProcessAffinityMask
| 0x6248C60F |    1356 | 54B  | SetProcessAffinityUpdateMode
| 0x2DE27D01 |    1357 | 54C  | SetProcessDEPPolicy
| 0xDCA00246 |    1358 | 54D  | SetProcessDefaultCpuSets (forwarded to api-ms-win-core-processthreads-l1-1-3.SetProcessDefaultCpuSets)
| 0x7424089B |    1359 | 54E  | SetProcessInformation
| 0x9AB088DC |    1360 | 54F  | SetProcessMitigationPolicy (forwarded to api-ms-win-core-processthreads-l1-1-1.SetProcessMitigationPolicy)
| 0x9C984B28 |    1361 | 550  | SetProcessPreferredUILanguages
| 0x4CEBB784 |    1362 | 551  | SetProcessPriorityBoost
| 0x3CC0CA49 |    1363 | 552  | SetProcessShutdownParameters
| 0xC4C6B83  |    1364 | 553  | SetProcessWorkingSetSize
| 0x1542E13B |    1365 | 554  | SetProcessWorkingSetSizeEx
| 0xC9925823 |    1366 | 555  | SetProtectedPolicy (forwarded to api-ms-win-core-processthreads-l1-1-2.SetProtectedPolicy)
| 0x514494D9 |    1367 | 556  | SetSearchPathMode
| 0x749FD823 |    1368 | 557  | SetStdHandle
| 0x2A1E0955 |    1369 | 558  | SetStdHandleEx
| 0xB16A352  |    1370 | 559  | SetSystemFileCacheSize
| 0x4BBBC64D |    1371 | 55A  | SetSystemPowerState
| 0xA70B9685 |    1372 | 55B  | SetSystemTime
| 0x2D1054D0 |    1373 | 55C  | SetSystemTimeAdjustment
| 0xD951CE60 |    1374 | 55D  | SetTapeParameters
| 0x45678841 |    1375 | 55E  | SetTapePosition
| 0x1A9E08FE |    1376 | 55F  | SetTermsrvAppInstallMode
| 0x46B34DB3 |    1377 | 560  | SetThreadAffinityMask
| 0xE8A7C7D3 |    1378 | 561  | SetThreadContext
| 0x38916966 |    1379 | 562  | SetThreadDescription (forwarded to api-ms-win-core-processthreads-l1-1-3.SetThreadDescription)
| 0x5922C47C |    1380 | 563  | SetThreadErrorMode
| 0xBF48C285 |    1381 | 564  | SetThreadExecutionState
| 0x49C44EEC |    1382 | 565  | SetThreadGroupAffinity
| 0x9B219EEC |    1383 | 566  | SetThreadIdealProcessor
| 0xCA8FBB9E |    1384 | 567  | SetThreadIdealProcessorEx
| 0x60282095 |    1385 | 568  | SetThreadInformation
| 0x6323F846 |    1386 | 569  | SetThreadLocale
| 0xBD581A88 |    1387 | 56A  | SetThreadPreferredUILanguages
| 0xD8AAF394 |    1388 | 56B  | SetThreadPriority
| 0x4DF1B5FF |    1389 | 56C  | SetThreadPriorityBoost
| 0xF0975411 |    1390 | 56D  | SetThreadSelectedCpuSets (forwarded to api-ms-win-core-processthreads-l1-1-3.SetThreadSelectedCpuSets)
| 0x8C915887 |    1391 | 56E  | SetThreadStackGuarantee
| 0x7333F905 |    1392 | 56F  | SetThreadToken (forwarded to api-ms-win-core-processthreads-l1-1-0.SetThreadToken)
| 0x6BCE3F9  |    1393 | 570  | SetThreadUILanguage
| 0xB48C4CF1 |    1394 | 571  | SetThreadpoolStackInformation
| 0x2A19710E |    1395 | 572  | SetThreadpoolThreadMaximum (forwarded to NTDLL.TpSetPoolMaxThreads)
| 0x2E1D2547 |    1396 | 573  | SetThreadpoolThreadMinimum
| 0x1D41E107 |    1397 | 574  | SetThreadpoolTimer (forwarded to NTDLL.TpSetTimer)
| 0x54384B27 |    1398 | 575  | SetThreadpoolTimerEx (forwarded to NTDLL.TpSetTimerEx)
| 0x2C951256 |    1399 | 576  | SetThreadpoolWait (forwarded to NTDLL.TpSetWait)
| 0x29049EEB |    1400 | 577  | SetThreadpoolWaitEx (forwarded to NTDLL.TpSetWaitEx)
| 0x512C8313 |    1401 | 578  | SetTimeZoneInformation
| 0x1B44A19  |    1402 | 579  | SetTimerQueueTimer
| 0xA25AA5E0 |    1403 | 57A  | SetUmsThreadInformation
| 0x5F048AF0 |    1404 | 57B  | SetUnhandledExceptionFilter
| 0x638A3AB7 |    1405 | 57C  | SetUserGeoID
| 0xEFF6B57D |    1406 | 57D  | SetUserGeoName
| 0x4C77BA3F |    1407 | 57E  | SetVDMCurrentDirectories
| 0x312AEAA4 |    1408 | 57F  | SetVolumeLabelA
| 0x312AEABA |    1409 | 580  | SetVolumeLabelW
| 0xC15CF23B |    1410 | 581  | SetVolumeMountPointA
| 0xC15CF251 |    1411 | 582  | SetVolumeMountPointW
| 0x78CD3978 |    1412 | 583  | SetVolumeMountPointWStub
| 0x92A4A1BA |    1413 | 584  | SetWaitableTimer
| 0x78E55AA3 |    1414 | 585  | SetWaitableTimerEx (forwarded to api-ms-win-core-synch-l1-1-0.SetWaitableTimerEx)
| 0xDB4BB6BB |    1415 | 586  | SetXStateFeaturesMask
| 0x5E3F2908 |    1416 | 587  | SetupComm
| 0x94C9D32D |    1417 | 588  | ShowConsoleCursor
| 0xA1421BCC |    1418 | 589  | SignalObjectAndWait
| 0x3F2A9609 |    1419 | 58A  | SizeofResource
| 0xDB2D49B0 |    1420 | 58B  | Sleep
| 0x3F5B1B50 |    1421 | 58C  | SleepConditionVariableCS (forwarded to api-ms-win-core-synch-l1-2-0.SleepConditionVariableCS)
| 0xFC39FAB8 |    1422 | 58D  | SleepConditionVariableSRW (forwarded to api-ms-win-core-synch-l1-2-0.SleepConditionVariableSRW)
| 0xCD7A6CAE |    1423 | 58E  | SleepEx
| 0x4866EB1B |    1424 | 58F  | SortCloseHandle
| 0xA917DB76 |    1425 | 590  | SortGetHandle
| 0x99880719 |    1426 | 591  | StartThreadpoolIo (forwarded to NTDLL.TpStartAsyncIoOperation)
| 0x90D1FF6B |    1427 | 592  | SubmitThreadpoolWork (forwarded to NTDLL.TpPostWork)
| 0xE8C2CDC  |    1428 | 593  | SuspendThread
| 0xFA6E2B74 |    1429 | 594  | SwitchToFiber
| 0x7B1FC3DC |    1430 | 595  | SwitchToThread
| 0x45A577EA |    1431 | 596  | SystemTimeToFileTime
| 0x93BD065  |    1432 | 597  | SystemTimeToTzSpecificLocalTime
| 0xCDD28900 |    1433 | 598  | SystemTimeToTzSpecificLocalTimeEx (forwarded to api-ms-win-core-timezone-l1-1-0.SystemTimeToTzSpecificLocalTimeEx)
| 0x18522D68 |    1434 | 599  | TerminateJobObject
| 0x78B5B983 |    1435 | 59A  | TerminateProcess
| 0xBD016F89 |    1436 | 59B  | TerminateThread
| 0x1004076A |    1437 | 59C  | TermsrvAppInstallMode
| 0xBE1E465D |    1438 | 59D  | TermsrvConvertSysRootToUserDir
| 0xC56BC4A1 |    1439 | 59E  | TermsrvCreateRegEntry
| 0xCCCAAB03 |    1440 | 59F  | TermsrvDeleteKey
| 0x2E536E18 |    1441 | 5A0  | TermsrvDeleteValue
| 0xEDA2C1DF |    1442 | 5A1  | TermsrvGetPreSetValue
| 0x8EDB4FC4 |    1443 | 5A2  | TermsrvGetWindowsDirectoryA
| 0x8EDB4FDA |    1444 | 5A3  | TermsrvGetWindowsDirectoryW
| 0xBE3D769F |    1445 | 5A4  | TermsrvOpenRegEntry
| 0xF3F7FDBC |    1446 | 5A5  | TermsrvOpenUserClasses
| 0xBBBA12C  |    1447 | 5A6  | TermsrvRestoreKey
| 0x699C492A |    1448 | 5A7  | TermsrvSetKeySecurity
| 0x7D895413 |    1449 | 5A8  | TermsrvSetValueKey
| 0x82FD76CB |    1450 | 5A9  | TermsrvSyncUserIniFileExt
| 0xB83BB6EA |    1451 | 5AA  | Thread32First
| 0x86FED608 |    1452 | 5AB  | Thread32Next
| 0x5D2C361D |    1453 | 5AC  | TlsAlloc
| 0x907F4D1B |    1454 | 5AD  | TlsFree
| 0x3A44E495 |    1455 | 5AE  | TlsGetValue
| 0x3A44E615 |    1456 | 5AF  | TlsSetValue
| 0xAA25EE23 |    1457 | 5B0  | Toolhelp32ReadProcessMemory
| 0xAB55924F |    1458 | 5B1  | TransactNamedPipe
| 0x70360A0F |    1459 | 5B2  | TransmitCommChar
| 0xFAEAB50F |    1460 | 5B3  | TryAcquireSRWLockExclusive (forwarded to NTDLL.RtlTryAcquireSRWLockExclusive)
| 0xED0B93AA |    1461 | 5B4  | TryAcquireSRWLockShared (forwarded to NTDLL.RtlTryAcquireSRWLockShared)
| 0x90919EC8 |    1462 | 5B5  | TryEnterCriticalSection (forwarded to NTDLL.RtlTryEnterCriticalSection)
| 0xEE17432A |    1463 | 5B6  | TrySubmitThreadpoolCallback
| 0x70D38544 |    1464 | 5B7  | TzSpecificLocalTimeToSystemTime
| 0x8CA1B86A |    1465 | 5B8  | TzSpecificLocalTimeToSystemTimeEx (forwarded to api-ms-win-core-timezone-l1-1-0.TzSpecificLocalTimeToSystemTimeEx)
| 0xBEC55FE6 |    1466 | 5B9  | UTRegister
| 0xD96F5FFB |    1467 | 5BA  | UTUnRegister
| 0x7452FD5C |    1468 | 5BB  | UmsThreadYield
| 0x36EF56ED |    1469 | 5BC  | UnhandledExceptionFilter
| 0x7F258057 |    1470 | 5BD  | UnlockFile
| 0xCB881657 |    1471 | 5BE  | UnlockFileEx
| 0xB2089259 |    1472 | 5BF  | UnmapViewOfFile
| 0xB7242284 |    1473 | 5C0  | UnmapViewOfFileEx (forwarded to api-ms-win-core-memory-l1-1-1.UnmapViewOfFileEx)
| 0x5E0FF149 |    1474 | 5C1  | UnregisterApplicationRecoveryCallback
| 0xB4C8864  |    1475 | 5C2  | UnregisterApplicationRestart
| 0x5B1CCC29 |    1476 | 5C3  | UnregisterBadMemoryNotification
| 0x736E5177 |    1477 | 5C4  | UnregisterConsoleIME
| 0x7868641  |    1478 | 5C5  | UnregisterWait
| 0xE3C990B9 |    1479 | 5C6  | UnregisterWaitEx
| 0xD934A0D5 |    1480 | 5C7  | UnregisterWaitUntilOOBECompleted
| 0x67DB937A |    1481 | 5C8  | UpdateCalendarDayOfWeek
| 0xBE5A0F4E |    1482 | 5C9  | UpdateProcThreadAttribute (forwarded to api-ms-win-core-processthreads-l1-1-0.UpdateProcThreadAttribute)
| 0xF3C1F836 |    1483 | 5CA  | UpdateResourceA
| 0xF3C1F84C |    1484 | 5CB  | UpdateResourceW
| 0xE9C2265B |    1485 | 5CC  | VDMConsoleOperation
| 0x808E4CC6 |    1486 | 5CD  | VDMOperationStarted
| 0x358FD8BB |    1487 | 5CE  | VerLanguageNameA
| 0x358FD8D1 |    1488 | 5CF  | VerLanguageNameW
| 0x170DC8DE |    1489 | 5D0  | VerSetConditionMask (forwarded to NTDLL.VerSetConditionMask)
| 0xDB737302 |    1490 | 5D1  | VerifyConsoleIoHandle
| 0x3DC09942 |    1491 | 5D2  | VerifyScripts
| 0x84EF581  |    1492 | 5D3  | VerifyVersionInfoA
| 0x84EF597  |    1493 | 5D4  | VerifyVersionInfoW
| 0x91AFCA54 |    1494 | 5D5  | VirtualAlloc
| 0x6E1A959C |    1495 | 5D6  | VirtualAllocEx
| 0x48C1E483 |    1496 | 5D7  | VirtualAllocExNuma
| 0x30633AC  |    1497 | 5D8  | VirtualFree
| 0xC3B4EB78 |    1498 | 5D9  | VirtualFreeEx
| 0xEF632F2  |    1499 | 5DA  | VirtualLock
| 0x7946C61B |    1500 | 5DB  | VirtualProtect
| 0x53D98756 |    1501 | 5DC  | VirtualProtectEx
| 0xA3C8C8AA |    1502 | 5DD  | VirtualQuery
| 0xF45A2B20 |    1503 | 5DE  | VirtualQueryEx
| 0x52A4ADF3 |    1504 | 5DF  | VirtualUnlock
| 0x3C795949 |    1505 | 5E0  | WTSGetActiveConsoleSessionId
| 0xF4EE1D55 |    1506 | 5E1  | WaitCommEvent
| 0xB1813EB1 |    1507 | 5E2  | WaitForDebugEvent
| 0x672313DD |    1508 | 5E3  | WaitForDebugEventEx (forwarded to api-ms-win-core-debug-l1-1-2.WaitForDebugEventEx)
| 0x23EAD524 |    1509 | 5E4  | WaitForMultipleObjects
| 0xFCDD4980 |    1510 | 5E5  | WaitForMultipleObjectsEx
| 0xCE05D9AD |    1511 | 5E6  | WaitForSingleObject
| 0x839E6BEB |    1512 | 5E7  | WaitForSingleObjectEx
| 0x719D8318 |    1513 | 5E8  | WaitForThreadpoolIoCallbacks (forwarded to NTDLL.TpWaitForIoCompletion)
| 0xB6A51DE3 |    1514 | 5E9  | WaitForThreadpoolTimerCallbacks (forwarded to NTDLL.TpWaitForTimer)
| 0x876EF160 |    1515 | 5EA  | WaitForThreadpoolWaitCallbacks (forwarded to NTDLL.TpWaitForWait)
| 0x4780F23E |    1516 | 5EB  | WaitForThreadpoolWorkCallbacks (forwarded to NTDLL.TpWaitForWork)
| 0x6415A041 |    1517 | 5EC  | WaitNamedPipeA
| 0x6415A057 |    1518 | 5ED  | WaitNamedPipeW
| 0x8C0FF1A7 |    1519 | 5EE  | WakeAllConditionVariable (forwarded to NTDLL.RtlWakeAllConditionVariable)
| 0x7E2896FD |    1520 | 5EF  | WakeConditionVariable (forwarded to NTDLL.RtlWakeConditionVariable)
| 0xED3A9E4  |    1521 | 5F0  | WerGetFlags
| 0xEBF46AD  |    1522 | 5F1  | WerGetFlagsWorker
| 0x87A61EBA |    1523 | 5F2  | WerRegisterAdditionalProcess
| 0x25DE6BA7 |    1524 | 5F3  | WerRegisterAppLocalDump
| 0x7423A45C |    1525 | 5F4  | WerRegisterCustomMetadata
| 0x5A1449B3 |    1526 | 5F5  | WerRegisterExcludedMemoryBlock
| 0xED5FE471 |    1527 | 5F6  | WerRegisterFile
| 0xF8F6C0DD |    1528 | 5F7  | WerRegisterFileWorker
| 0xC9E0ABE7 |    1529 | 5F8  | WerRegisterMemoryBlock
| 0x16CE32E1 |    1530 | 5F9  | WerRegisterMemoryBlockWorker
| 0x739C3547 |    1531 | 5FA  | WerRegisterRuntimeExceptionModule
| 0x3C4CD9CF |    1532 | 5FB  | WerRegisterRuntimeExceptionModuleWorker
| 0xED3AB64  |    1533 | 5FC  | WerSetFlags
| 0x14BF46AD |    1534 | 5FD  | WerSetFlagsWorker
| 0x6DF26A70 |    1535 | 5FE  | WerUnregisterAdditionalProcess
| 0xF2770312 |    1536 | 5FF  | WerUnregisterAppLocalDump
| 0x9A497F4F |    1537 | 600  | WerUnregisterCustomMetadata
| 0xED27372C |    1538 | 601  | WerUnregisterExcludedMemoryBlock
| 0x85F7503E |    1539 | 602  | WerUnregisterFile
| 0xA829233B |    1540 | 603  | WerUnregisterFileWorker
| 0xDCCE257A |    1541 | 604  | WerUnregisterMemoryBlock
| 0xFD1A7E96 |    1542 | 605  | WerUnregisterMemoryBlockWorker
| 0x66C25B22 |    1543 | 606  | WerUnregisterRuntimeExceptionModule
| 0xD3B8A667 |    1544 | 607  | WerUnregisterRuntimeExceptionModuleWorker
| 0x3A27FE16 |    1545 | 608  | WerpGetDebugger
| 0x3D10AB8  |    1546 | 609  | WerpInitiateRemoteRecovery
| 0xCACEA304 |    1547 | 60A  | WerpLaunchAeDebug
| 0xE599AEDC |    1548 | 60B  | WerpNotifyLoadStringResourceWorker
| 0x167BCC5D |    1549 | 60C  | WerpNotifyUseStringResourceWorker
| 0xC1634AF9 |    1550 | 60D  | WideCharToMultiByte
| 0xE8AFE98  |    1551 | 60E  | WinExec
| 0x3A2EA97F |    1552 | 60F  | Wow64DisableWow64FsRedirection
| 0x443EADDB |    1553 | 610  | Wow64EnableWow64FsRedirection
| 0xF69CA787 |    1554 | 611  | Wow64GetThreadContext
| 0xFB8BD0A4 |    1555 | 612  | Wow64GetThreadSelectorEntry
| 0x79A939B7 |    1556 | 613  | Wow64RevertWow64FsRedirection
| 0x769CA789 |    1557 | 614  | Wow64SetThreadContext
| 0x8FC07A3  |    1558 | 615  | Wow64SuspendThread
| 0x88D2F963 |    1559 | 616  | WriteConsoleA
| 0xA8107A37 |    1560 | 617  | WriteConsoleInputA
| 0x9BB83235 |    1561 | 618  | WriteConsoleInputVDMA
| 0x9BB8324B |    1562 | 619  | WriteConsoleInputVDMW
| 0xA8107A4D |    1563 | 61A  | WriteConsoleInputW
| 0x496D8108 |    1564 | 61B  | WriteConsoleOutputA
| 0xD1C029DF |    1565 | 61C  | WriteConsoleOutputAttribute
| 0x4166A81E |    1566 | 61D  | WriteConsoleOutputCharacterA
| 0x4166A834 |    1567 | 61E  | WriteConsoleOutputCharacterW
| 0x496D811E |    1568 | 61F  | WriteConsoleOutputW
| 0x88D2F979 |    1569 | 620  | WriteConsoleW
| 0xE80A791F |    1570 | 621  | WriteFile
| 0x4C64872  |    1571 | 622  | WriteFileEx
| 0x4FADCAC0 |    1572 | 623  | WriteFileGather
| 0xB28F0D51 |    1573 | 624  | WritePrivateProfileSectionA
| 0xB28F0D67 |    1574 | 625  | WritePrivateProfileSectionW
| 0x4B63076C |    1575 | 626  | WritePrivateProfileStringA
| 0x4B630782 |    1576 | 627  | WritePrivateProfileStringW
| 0x63CB04AC |    1577 | 628  | WritePrivateProfileStructA
| 0x63CB04C2 |    1578 | 629  | WritePrivateProfileStructW
| 0xD83D6AA1 |    1579 | 62A  | WriteProcessMemory
| 0xF2D0BEF2 |    1580 | 62B  | WriteProfileSectionA
| 0xF2D0BF08 |    1581 | 62C  | WriteProfileSectionW
| 0x81972F74 |    1582 | 62D  | WriteProfileStringA
| 0x81972F8A |    1583 | 62E  | WriteProfileStringW
| 0x850218EE |    1584 | 62F  | WriteTapemark
| 0x176B63D5 |    1585 | 630  | ZombifyActCtx
| 0xF683690B |    1586 | 631  | ZombifyActCtxWorker
| 0xAF9EDA4E |    1587 | 632  | __C_specific_handler (forwarded to NTDLL.__C_specific_handler)
| 0x49EAD935 |    1588 | 633  | __chkstk (forwarded to NTDLL.__chkstk)
| 0xE21ECD14 |    1589 | 634  | __misaligned_access (forwarded to NTDLL.__misaligned_access)
| 0x670E99D4 |    1590 | 635  | _hread
| 0xE9238AD9 |    1591 | 636  | _hwrite
| 0xDD1A4C5B |    1592 | 637  | _lclose
| 0xE88A49EA |    1593 | 638  | _lcreat
| 0xEAAAD9E1 |    1594 | 639  | _llseek
| 0x335CA691 |    1595 | 63A  | _local_unwind (forwarded to NTDLL._local_unwind)
| 0x612EDC9E |    1596 | 63B  | _lopen
| 0x670ED9D4 |    1597 | 63C  | _lread
| 0xE9238ADB |    1598 | 63D  | _lwrite
| 0x68BF596E |    1599 | 63E  | lstrcat
| 0xCB73463B |    1600 | 63F  | lstrcatA
| 0xCB734651 |    1601 | 640  | lstrcatW
| 0x691F596A |    1602 | 641  | lstrcmp
| 0xCB53493B |    1603 | 642  | lstrcmpA
| 0xCB534951 |    1604 | 643  | lstrcmpW
| 0xCB534963 |    1605 | 644  | lstrcmpi
| 0x4B1E5ADB |    1606 | 645  | lstrcmpiA
| 0x4B1E5AF1 |    1607 | 646  | lstrcmpiW
| 0x69375973 |    1608 | 647  | lstrcpy
| 0xCB9B49FB |    1609 | 648  | lstrcpyA
| 0xCB9B4A11 |    1610 | 649  | lstrcpyW
| 0xCB9B4A28 |    1611 | 64A  | lstrcpyn
| 0x51465D1B |    1612 | 64B  | lstrcpynA
| 0x51465D31 |    1613 | 64C  | lstrcpynW
| 0x68DF5BA8 |    1614 | 64D  | lstrlen
| 0xDD43473B |    1615 | 64E  | lstrlenA
| 0xDD434751 |    1616 | 64F  | lstrlenW
| 0x58576CE  |    1617 | 650  | timeBeginPeriod
| 0x6EE3A7E8 |    1618 | 651  | timeEndPeriod
| 0xEA73C60F |    1619 | 652  | timeGetDevCaps
| 0xFA0149D2 |    1620 | 653  | timeGetSystemTime
| 0x998EAF95 |    1621 | 654  | timeGetTime
| 0x6B41016A |    1622 | 655  | uaw_lstrcmpW
| 0xBE35A5F  |    1623 | 656  | uaw_lstrcmpiW
| 0x7D30FF6A |    1624 | 657  | uaw_lstrlenW
| 0xCBC6004E |    1625 | 658  | uaw_wcschr
| 0xCC060055 |    1626 | 659  | uaw_wcscpy
| 0xE4E5D60  |    1627 | 65A  | uaw_wcsicmp
| 0xCBAE028A |    1628 | 65B  | uaw_wcslen
| 0x20265D62 |    1629 | 65C  | uaw_wcsrchr
