The following is table of pre-computed ROR-13 hashes for all ole32.dll Win32 APIs. The Win32 APIs list was generated using the below command.

```
dumpbin.exe /exports c:\windows\system32\ole32.dll
```

| hashes     | ordinal | hint | name
|------------|:-------:|:----:|-------------------------------------------------------------------------------------------------------------------------------        
| 0x44664FFB |     840 |    0 | BindMoniker
| 0xE9220752 |     841 |    1 | CLIPFORMAT_UserFree (forwarded to COMBASE.CLIPFORMAT_UserFree)
| 0x4A31D4EE |     842 |    2 | CLIPFORMAT_UserFree64 (forwarded to COMBASE.CLIPFORMAT_UserFree64)
| 0xA99255C2 |     805 |    3 | CLIPFORMAT_UserFreeExt
| 0x44F72E72 |     843 |    4 | CLIPFORMAT_UserMarshal (forwarded to COMBASE.CLIPFORMAT_UserMarshal)
| 0x3F7B9CC5 |     844 |    5 | CLIPFORMAT_UserMarshal64 (forwarded to COMBASE.CLIPFORMAT_UserMarshal64)
| 0xE84A0010 |     806 |    6 | CLIPFORMAT_UserMarshalExt
| 0x3CA0513  |     845 |    7 | CLIPFORMAT_UserSize (forwarded to COMBASE.CLIPFORMAT_UserSize)
| 0xF43144F4 |     846 |    8 | CLIPFORMAT_UserSize64 (forwarded to COMBASE.CLIPFORMAT_UserSize64)
| 0x29C7A5BE |     807 |    9 | CLIPFORMAT_UserSizeExt
| 0x6CC03D94 |     847 |    A | CLIPFORMAT_UserUnmarshal (forwarded to COMBASE.CLIPFORMAT_UserUnmarshal)
| 0x31BF654F |     848 |    B | CLIPFORMAT_UserUnmarshal64 (forwarded to COMBASE.CLIPFORMAT_UserUnmarshal64)
| 0x2C99922F |     808 |    C | CLIPFORMAT_UserUnmarshalExt
| 0xEF64E8EA |     849 |    D | CLSIDFromOle1Class (forwarded to api-ms-win-core-com-private-l1-1-1.CLSIDFromOle1Class)
| 0x7A98894E |     850 |    E | CLSIDFromProgID (forwarded to api-ms-win-core-com-l1-1-0.CLSIDFromProgID)
| 0xA84A5416 |     851 |    F | CLSIDFromProgIDEx (forwarded to api-ms-win-core-com-l1-1-2.CLSIDFromProgIDEx)
| 0x1C0A9F3  |     852 |   10 | CLSIDFromString (forwarded to api-ms-win-core-com-l1-1-0.CLSIDFromString)
| 0xEB23144E |     853 |   11 | CStdAsyncStubBuffer2_Connect (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.CStdAsyncStubBuffer2_Connect)
| 0x8EC31881 |     854 |   12 | CStdAsyncStubBuffer2_Disconnect (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.CStdAsyncStubBuffer2_Disconnect)
| 0xD9DEF33A |     855 |   13 | CStdAsyncStubBuffer2_Release (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.CStdAsyncStubBuffer2_Release)
| 0x560E3541 |     856 |   14 | CStdAsyncStubBuffer_AddRef (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.CStdAsyncStubBuffer_AddRef)
| 0x61FB50EB |     857 |   15 | CStdAsyncStubBuffer_Connect (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.CStdAsyncStubBuffer_Connect)
| 0xC7B0C8FA |     858 |   16 | CStdAsyncStubBuffer_Disconnect (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.CStdAsyncStubBuffer_Disconnect)
| 0x7A3EDC84 |     859 |   17 | CStdAsyncStubBuffer_Invoke (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.CStdAsyncStubBuffer_Invoke)
| 0x7D47F5E5 |     860 |   18 | CStdAsyncStubBuffer_QueryInterface (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.CStdAsyncStubBuffer_QueryInterface)
| 0x50B72FD7 |     861 |   19 | CStdAsyncStubBuffer_Release (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.CStdAsyncStubBuffer_Release)
| 0xA2DAF105 |     862 |   1A | CStdStubBuffer2_Connect (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.CStdStubBuffer2_Connect)
| 0x98092E1B |     863 |   1B | CStdStubBuffer2_CountRefs (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.CStdStubBuffer2_CountRefs)
| 0xFC32883A |     864 |   1C | CStdStubBuffer2_Disconnect (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.CStdStubBuffer2_Disconnect)
| 0x993BF92D |     865 |   1D | CStdStubBuffer2_QueryInterface (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.CStdStubBuffer2_QueryInterface)
| 0x4FD3D717 |     866 |   1E | CheckInitDde
| 0xE36DCE7F |     867 |   1F | CleanROTForApartment
| 0x6ED0D92F |     809 |   20 | ClipboardProcessUninitialize
| 0x645342A8 |     868 |   21 | CoAddRefServerProcess (forwarded to api-ms-win-core-com-l1-1-0.CoAddRefServerProcess)
| 0xA8A51BBB |     869 |   22 | CoAicGetTokenForCOM
| 0x756D53BA |     870 |   23 | CoAllowSetForegroundWindow
| 0xBFF8AD7D |     871 |   24 | CoAllowUnmarshalerCLSID (forwarded to api-ms-win-core-com-l1-1-0.CoAllowUnmarshalerCLSID)
| 0x38DE966F |     872 |   25 | CoBuildVersion
| 0x2C7AFEBB |     873 |   26 | CoCancelCall (forwarded to api-ms-win-core-com-l1-1-0.CoCancelCall)
| 0x546C8D0A |     874 |   27 | CoCheckElevationEnabled
| 0x6C88A267 |     875 |   28 | CoCopyProxy (forwarded to api-ms-win-core-com-l1-1-0.CoCopyProxy)
| 0x216C24E1 |     876 |   29 | CoCreateFreeThreadedMarshaler (forwarded to api-ms-win-core-com-l1-1-0.CoCreateFreeThreadedMarshaler)
| 0xC55A929A |     877 |   2A | CoCreateGuid (forwarded to api-ms-win-core-com-l1-1-0.CoCreateGuid)
| 0x6E26C880 |     878 |   2B | CoCreateInstance (forwarded to api-ms-win-core-com-l1-1-0.CoCreateInstance)
| 0x8BDA2093 |     879 |   2C | CoCreateInstanceEx (forwarded to api-ms-win-core-com-l1-1-0.CoCreateInstanceEx)
| 0xA37810F7 |     880 |   2D | CoCreateInstanceFromApp (forwarded to api-ms-win-core-com-l1-1-0.CoCreateInstanceFromApp)
| 0x918E528A |     881 |   2E | CoCreateObjectInContext (forwarded to api-ms-win-core-com-private-l1-1-1.CoCreateObjectInContext)
| 0xAB8E94C7 |     882 |   2F | CoDeactivateObject (forwarded to api-ms-win-core-com-private-l1-1-1.CoDeactivateObject)
| 0xCD36568D |     883 |   30 | CoDecodeProxy (forwarded to COMBASE.CoDecodeProxy)
| 0x9707855  |     884 |   31 | CoDecrementMTAUsage (forwarded to api-ms-win-core-com-l1-1-0.CoDecrementMTAUsage)
| 0x7DB3BBDD |     885 |   32 | CoDisableCallCancellation (forwarded to api-ms-win-core-com-l1-1-0.CoDisableCallCancellation)
| 0xB33806FD |     886 |   33 | CoDisconnectContext (forwarded to api-ms-win-core-com-l1-1-0.CoDisconnectContext)
| 0xF8C062A8 |     887 |   34 | CoDisconnectObject (forwarded to api-ms-win-core-com-l1-1-0.CoDisconnectObject)
| 0x644A0F84 |     888 |   35 | CoDosDateTimeToFileTime
| 0x28217989 |     889 |   36 | CoEnableCallCancellation (forwarded to api-ms-win-core-com-l1-1-0.CoEnableCallCancellation)
| 0x3BB03D0E |     890 |   37 | CoFileTimeNow (forwarded to api-ms-win-core-com-l1-1-2.CoFileTimeNow)
| 0xEEE1FAF6 |     891 |   38 | CoFileTimeToDosDateTime
| 0x282C6899 |     892 |   39 | CoFreeAllLibraries
| 0x4EA7D9D0 |     893 |   3A | CoFreeLibrary
| 0x8E869517 |     894 |   3B | CoFreeUnusedLibraries (forwarded to api-ms-win-core-com-l1-1-0.CoFreeUnusedLibraries)
| 0xA3CD465B |     895 |   3C | CoFreeUnusedLibrariesEx (forwarded to api-ms-win-core-com-l1-1-0.CoFreeUnusedLibrariesEx)
| 0xAFDCF1A1 |     896 |   3D | CoGetActivationState (forwarded to api-ms-win-core-com-private-l1-1-1.CoGetActivationState)
| 0x858BBE24 |     897 |   3E | CoGetApartmentID (forwarded to api-ms-win-core-com-private-l1-1-1.CoGetApartmentID)
| 0x7C6F96C6 |     898 |   3F | CoGetApartmentType (forwarded to api-ms-win-core-com-l1-1-0.CoGetApartmentType)
| 0x1D3FD1D6 |     899 |   40 | CoGetCallContext (forwarded to api-ms-win-core-com-l1-1-0.CoGetCallContext)
| 0x9266FC05 |     900 |   41 | CoGetCallState (forwarded to api-ms-win-core-com-private-l1-1-1.CoGetCallState)
| 0x8D1018A4 |     901 |   42 | CoGetCallerTID (forwarded to api-ms-win-core-com-l1-1-0.CoGetCallerTID)
| 0xF1BD9E3  |     902 |   43 | CoGetCancelObject (forwarded to api-ms-win-core-com-l1-1-0.CoGetCancelObject)
| 0xFE576AA5 |     903 |   44 | CoGetClassObject (forwarded to api-ms-win-core-com-l1-1-0.CoGetClassObject)
| 0xF12474AA |     904 |   45 | CoGetClassVersion (forwarded to api-ms-win-core-com-private-l1-1-1.CoGetClassVersion)
| 0xEDD891C5 |     905 |   46 | CoGetComCatalog (forwarded to api-ms-win-core-com-private-l1-1-1.GetCatalogHelper)
| 0x2A5AFB73 |     906 |   47 | CoGetContextToken (forwarded to api-ms-win-core-com-l1-1-0.CoGetContextToken)
| 0x9C0622B8 |     907 |   48 | CoGetCurrentLogicalThreadId (forwarded to api-ms-win-core-com-l1-1-0.CoGetCurrentLogicalThreadId)
| 0x8C4F1B5E |     908 |   49 | CoGetCurrentProcess (forwarded to api-ms-win-core-com-l1-1-0.CoGetCurrentProcess)
| 0xECAB8A59 |     909 |   4A | CoGetDefaultContext (forwarded to api-ms-win-core-com-l1-1-0.CoGetDefaultContext)
| 0x92AAAC2E |     910 |   4B | CoGetInstanceFromFile (forwarded to api-ms-win-core-com-private-l1-1-1.CoGetInstanceFromFile)
| 0x91A3A234 |     911 |   4C | CoGetInstanceFromIStorage (forwarded to api-ms-win-core-com-private-l1-1-1.CoGetInstanceFromIStorage)
| 0x9DB3ACAF |     912 |   4D | CoGetInterceptor
| 0x8AF6C618 |     913 |   4E | CoGetInterceptorForOle32
| 0x5FE4B9BE |     914 |   4F | CoGetInterceptorFromTypeInfo
| 0xA14497C  |     915 |   50 | CoGetInterfaceAndReleaseStream (forwarded to api-ms-win-core-com-l1-1-0.CoGetInterfaceAndReleaseStream)
| 0x6451B03B |     916 |   51 | CoGetMalloc (forwarded to api-ms-win-core-com-l1-1-0.CoGetMalloc)
| 0x47CBDB1F |     917 |   52 | CoGetMarshalSizeMax (forwarded to api-ms-win-core-com-l1-1-0.CoGetMarshalSizeMax)
| 0x54A7F3E9 |     918 |   53 | CoGetModuleType (forwarded to api-ms-win-core-com-private-l1-1-1.CoGetModuleType)
| 0x5FF1BE8D |     919 |   54 | CoGetObject
| 0x6B0ACB98 |     920 |   55 | CoGetObjectContext (forwarded to api-ms-win-core-com-l1-1-0.CoGetObjectContext)
| 0x821493EA |     921 |   56 | CoGetPSClsid (forwarded to api-ms-win-core-com-l1-1-0.CoGetPSClsid)
| 0x7102D3AF |     922 |   57 | CoGetProcessIdentifier (forwarded to api-ms-win-core-com-private-l1-1-1.CoGetProcessIdentifier)
| 0xB349298D |     923 |   58 | CoGetStandardMarshal (forwarded to api-ms-win-core-com-l1-1-0.CoGetStandardMarshal)
| 0xA663EB3D |     924 |   59 | CoGetStdMarshalEx (forwarded to api-ms-win-core-com-l1-1-0.CoGetStdMarshalEx)
| 0xBA19E57C |     925 |   5A | CoGetSystemSecurityPermissions (forwarded to api-ms-win-core-com-private-l1-1-1.CoGetSystemSecurityPermissions)
| 0x12935510 |     926 |   5B | CoGetSystemWow64DirectoryW
| 0x510FA2D8 |     927 |   5C | CoGetTreatAsClass (forwarded to api-ms-win-core-com-l1-1-0.CoGetTreatAsClass)
| 0xF715DC72 |     928 |   5D | CoHandlePriorityEventsFromMessagePump (forwarded to COMBASE.#111)
| 0x5C7F2318 |     929 |   5E | CoImpersonateClient (forwarded to api-ms-win-core-com-l1-1-0.CoImpersonateClient)
| 0x29757856 |     930 |   5F | CoIncrementMTAUsage (forwarded to api-ms-win-core-com-l1-1-0.CoIncrementMTAUsage)
| 0x8C2E8016 |     931 |   60 | CoInitialize
| 0xDC8061B  |     932 |   61 | CoInitializeEx (forwarded to api-ms-win-core-com-l1-1-0.CoInitializeEx)
| 0x7FC7A3CB |     933 |   62 | CoInitializeSecurity (forwarded to api-ms-win-core-com-l1-1-0.CoInitializeSecurity)
| 0x2F907317 |     934 |   63 | CoInitializeWOW
| 0x2F8B56C4 |     935 |   64 | CoInstall
| 0x8C7DA19  |     936 |   65 | CoInvalidateRemoteMachineBindings (forwarded to api-ms-win-core-com-private-l1-1-1.CoInvalidateRemoteMachineBindings)
| 0xA1F71E26 |     937 |   66 | CoIsHandlerConnected (forwarded to api-ms-win-core-com-l1-1-0.CoIsHandlerConnected)
| 0xED11F28E |     938 |   67 | CoIsOle1Class
| 0xCAA7C1B1 |     939 |   68 | CoLoadLibrary
| 0x4176C76D |     940 |   69 | CoLockObjectExternal (forwarded to api-ms-win-core-com-l1-1-0.CoLockObjectExternal)
| 0x92EF7DA3 |     941 |   6A | CoMarshalHresult (forwarded to api-ms-win-core-com-l1-1-0.CoMarshalHresult)
| 0x700CDA7F |     942 |   6B | CoMarshalInterThreadInterfaceInStream (forwarded to api-ms-win-core-com-l1-1-0.CoMarshalInterThreadInterfaceInStream)
| 0xB4333402 |     943 |   6C | CoMarshalInterface (forwarded to api-ms-win-core-com-l1-1-0.CoMarshalInterface)
| 0x12188A0  |     944 |   6D | CoPopServiceDomain (forwarded to api-ms-win-core-com-private-l1-1-1.CoPopServiceDomain)
| 0xADC29A04 |     945 |   6E | CoPushServiceDomain (forwarded to api-ms-win-core-com-private-l1-1-1.CoPushServiceDomain)
| 0x5C44B8FB |     946 |   6F | CoQueryAuthenticationServices (forwarded to api-ms-win-core-com-l1-1-0.CoQueryAuthenticationServices)
| 0x87C8B6CA |     947 |   70 | CoQueryClientBlanket (forwarded to api-ms-win-core-com-l1-1-0.CoQueryClientBlanket)
| 0xC2EC51BE |     948 |   71 | CoQueryProxyBlanket (forwarded to api-ms-win-core-com-l1-1-0.CoQueryProxyBlanket)
| 0xB336C60C |     949 |   72 | CoQueryReleaseObject
| 0x6B8E94C9 |     950 |   73 | CoReactivateObject (forwarded to api-ms-win-core-com-private-l1-1-1.CoReactivateObject)
| 0xB0BEC7EB |     951 |   74 | CoRegisterActivationFilter (forwarded to api-ms-win-core-com-l1-1-0.CoRegisterActivationFilter)
| 0xD607DDB8 |     952 |   75 | CoRegisterChannelHook (forwarded to COMBASE.#112)
| 0x19BB5BD7 |     953 |   76 | CoRegisterClassObject (forwarded to api-ms-win-core-com-l1-1-0.CoRegisterClassObject)
| 0xEC8448A0 |     954 |   77 | CoRegisterInitializeSpy (forwarded to api-ms-win-core-com-private-l1-1-1.CoRegisterInitializeSpy)
| 0x3EB6485E |     955 |   78 | CoRegisterMallocSpy (forwarded to api-ms-win-core-com-private-l1-1-1.CoRegisterMallocSpy)
| 0xF1FD39CA |     956 |   79 | CoRegisterMessageFilter
| 0x95264A29 |     957 |   7A | CoRegisterPSClsid (forwarded to api-ms-win-core-com-l1-1-0.CoRegisterPSClsid)
| 0x4CEE4E4D |     958 |   7B | CoRegisterSurrogate (forwarded to api-ms-win-core-com-l1-1-0.CoRegisterSurrogate)
| 0x3DBB93CB |     959 |   7C | CoRegisterSurrogateEx
| 0x8CBB1313 |     960 |   7D | CoReleaseMarshalData (forwarded to api-ms-win-core-com-l1-1-0.CoReleaseMarshalData)
| 0xCF5C0ED  |     961 |   7E | CoReleaseServerProcess (forwarded to api-ms-win-core-com-l1-1-0.CoReleaseServerProcess)
| 0xF51332CE |     962 |   7F | CoResumeClassObjects (forwarded to api-ms-win-core-com-l1-1-0.CoResumeClassObjects)
| 0x33EA2366 |     963 |   80 | CoRetireServer (forwarded to api-ms-win-core-com-private-l1-1-1.CoRetireServer)
| 0x725ECF1A |     964 |   81 | CoRevertToSelf (forwarded to api-ms-win-core-com-l1-1-0.CoRevertToSelf)
| 0x634B8A82 |     965 |   82 | CoRevokeClassObject (forwarded to api-ms-win-core-com-l1-1-0.CoRevokeClassObject)
| 0x508FF373 |     966 |   83 | CoRevokeInitializeSpy (forwarded to api-ms-win-core-com-private-l1-1-1.CoRevokeInitializeSpy)
| 0xEBDC8918 |     967 |   84 | CoRevokeMallocSpy (forwarded to api-ms-win-core-com-private-l1-1-1.CoRevokeMallocSpy)
| 0xF1C09E3  |     968 |   85 | CoSetCancelObject (forwarded to api-ms-win-core-com-l1-1-0.CoSetCancelObject)
| 0xD7F084E0 |     969 |   86 | CoSetMessageDispatcher (forwarded to COMBASE.#110)
| 0xEB9E05F5 |     970 |   87 | CoSetProxyBlanket (forwarded to api-ms-win-core-com-l1-1-0.CoSetProxyBlanket)
| 0x5C3B6B40 |     971 |   88 | CoSetState
| 0xBEA14BDA |     972 |   89 | CoSuspendClassObjects (forwarded to api-ms-win-core-com-l1-1-0.CoSuspendClassObjects)
| 0xC4BABD34 |     973 |   8A | CoSwitchCallContext (forwarded to api-ms-win-core-com-l1-1-0.CoSwitchCallContext)
| 0x2A3BD443 |     974 |   8B | CoTaskMemAlloc (forwarded to api-ms-win-core-com-l1-1-0.CoTaskMemAlloc)
| 0x844406BD |     975 |   8C | CoTaskMemFree (forwarded to api-ms-win-core-com-l1-1-0.CoTaskMemFree)
| 0xCB0636A  |     976 |   8D | CoTaskMemRealloc (forwarded to api-ms-win-core-com-l1-1-0.CoTaskMemRealloc)
| 0x8686D7CA |     977 |   8E | CoTestCancel (forwarded to api-ms-win-core-com-l1-1-0.CoTestCancel)
| 0x5FCB867A |     978 |   8F | CoTreatAsClass
| 0x6DD38706 |     979 |   90 | CoUninitialize (forwarded to api-ms-win-core-com-l1-1-0.CoUninitialize)
| 0x633C6978 |     980 |   91 | CoUnloadingWOW
| 0xE35E7BBD |     981 |   92 | CoUnmarshalHresult (forwarded to api-ms-win-core-com-l1-1-0.CoUnmarshalHresult)
| 0xCFF2BA96 |     982 |   93 | CoUnmarshalInterface (forwarded to api-ms-win-core-com-l1-1-0.CoUnmarshalInterface)
| 0x386B1D5A |     983 |   94 | CoVrfCheckThreadState (forwarded to api-ms-win-core-com-private-l1-1-1.CoVrfCheckThreadState)
| 0xD4AC3763 |     984 |   95 | CoVrfGetThreadState (forwarded to api-ms-win-core-com-private-l1-1-1.CoVrfGetThreadState)
| 0x8A95986C |     985 |   96 | CoVrfReleaseThreadState (forwarded to api-ms-win-core-com-private-l1-1-1.CoVrfReleaseThreadState)
| 0xA9B7191F |     986 |   97 | CoWaitForMultipleHandles (forwarded to api-ms-win-core-com-l1-1-0.CoWaitForMultipleHandles)
| 0x2C4AD6E0 |     987 |   98 | CoWaitForMultipleObjects (forwarded to api-ms-win-core-com-l1-1-0.CoWaitForMultipleObjects)
| 0x79742307 |     988 |   99 | ComPs_NdrDllCanUnloadNow
| 0x4D75EE83 |     989 |   9A | ComPs_NdrDllGetClassObject
| 0x25232E11 |     990 |   9B | ComPs_NdrDllRegisterProxy
| 0x5355472F |     991 |   9C | ComPs_NdrDllUnregisterProxy
| 0x7BF513E9 |     992 |   9D | CreateAntiMoniker
| 0x1960A57  |     993 |   9E | CreateBindCtx
| 0xA45F9E5A |     994 |   9F | CreateClassMoniker
| 0x39119FD0 |     995 |   A0 | CreateDataAdviseHolder
| 0xC4DA8FE3 |     996 |   A1 | CreateDataCache
| 0x95C584D4 |     997 |   A2 | CreateErrorInfo (forwarded to api-ms-win-core-com-private-l1-1-1.CoCreateErrorInfo)
| 0xB3F4EB6A |     998 |   A3 | CreateFileMoniker
| 0xBF0B18D8 |     999 |   A4 | CreateGenericComposite
| 0xD43CC381 |    1000 |   A5 | CreateILockBytesOnHGlobal
| 0x6CF5446B |    1001 |   A6 | CreateItemMoniker
| 0x9FD170D1 |    1002 |   A7 | CreateObjrefMoniker
| 0x65FEF179 |    1003 |   A8 | CreateOleAdviseHolder
| 0x11BCDED  |    1004 |   A9 | CreatePointerMoniker
| 0x5688D35F |    1005 |   AA | CreateStdProgressIndicator
| 0x15B28922 |    1006 |   AB | CreateStreamOnHGlobal (forwarded to api-ms-win-core-com-l1-1-0.CreateStreamOnHGlobal)
| 0xE35868D2 |    1007 |   AC | DcomChannelSetHResult (forwarded to COMBASE.DcomChannelSetHResult)
| 0x2F62CAC7 |    1008 |   AD | DdeBindToObject
| 0x25DB5813 |    1009 |   AE | DeletePatternAndExtensionTables
| 0x31D45B25 |    1010 |   AF | DestroyRunningObjectTable
| 0x4773360F |    1011 |   B0 | DllDebugObjectRPCHook (forwarded to api-ms-win-core-com-private-l1-1-1.DllDebugObjectRPCHook)
| 0x1E9B5EAB |    1012 |   B1 | DllGetClassObject
| 0x58B54CD4 |    1013 |   B2 | DllGetClassObjectWOW
| 0xC70DC934 |    1014 |   B3 | DllRegisterServer
| 0x7C48B5A1 |    1015 |   B4 | DoDragDrop
| 0xC0AA9718 |    1016 |   B5 | DragDropSetFDT
| 0xD92645FE |    1017 |   B6 | EnableHookObject (forwarded to api-ms-win-core-com-private-l1-1-1.EnableHookObject)
| 0x4CDEF1E9 |    1018 |   B7 | FindExt
| 0xC30A5272 |    1019 |   B8 | FmtIdToPropStgName
| 0xE6DB279E |    1020 |   B9 | FreePropVariantArray
| 0xEF2983CB |    1021 |   BA | GetActiveObjectExt
| 0x947CF878 |    1022 |   BB | GetClassFile
| 0xDD4B5FA7 |    1023 |   BC | GetConvertStg
| 0x5588F223 |    1024 |   BD | GetDocumentBitStg
| 0x9C90EA80 |    1025 |   BE | GetErrorInfo (forwarded to api-ms-win-core-com-private-l1-1-1.CoGetErrorInfo)
| 0xEB16DDE1 |    1026 |   BF | GetHGlobalFromILockBytes
| 0xC91DF9C  |    1027 |   C0 | GetHGlobalFromStream (forwarded to api-ms-win-core-com-l1-1-0.GetHGlobalFromStream)
| 0x74D2373D |    1028 |   C1 | GetHookInterface (forwarded to api-ms-win-core-com-private-l1-1-1.GetHookInterface)
| 0xF6AF1A48 |    1029 |   C2 | GetObjectFromRotByPath
| 0x73BA0156 |    1030 |   C3 | GetRunningObjectTable
| 0xD104CBF9 |    1031 |   C4 | HACCEL_UserFree (forwarded to COMBASE.HACCEL_UserFree)
| 0x42E2FEA8 |    1032 |   C5 | HACCEL_UserFree64 (forwarded to COMBASE.HACCEL_UserFree64)
| 0x92C6F3FB |    1033 |   C6 | HACCEL_UserMarshal (forwarded to COMBASE.HACCEL_UserMarshal)
| 0xB36CFF18 |    1034 |   C7 | HACCEL_UserMarshal64 (forwarded to COMBASE.HACCEL_UserMarshal64)
| 0xEBACC9B9 |    1035 |   C8 | HACCEL_UserSize (forwarded to COMBASE.HACCEL_UserSize)
| 0xECE26EAE |    1036 |   C9 | HACCEL_UserSize64 (forwarded to COMBASE.HACCEL_UserSize64)
| 0xE0B19FE7 |    1037 |   CA | HACCEL_UserUnmarshal (forwarded to COMBASE.HACCEL_UserUnmarshal)
| 0x2E17FA2C |    1038 |   CB | HACCEL_UserUnmarshal64 (forwarded to COMBASE.HACCEL_UserUnmarshal64)
| 0xD518D511 |    1039 |   CC | HBITMAP_UserFree (forwarded to COMBASE.HBITMAP_UserFree)
| 0x47E544A9 |    1040 |   CD | HBITMAP_UserFree64 (forwarded to COMBASE.HBITMAP_UserFree64)
| 0xC2CF1C0D |    1041 |   CE | HBITMAP_UserMarshal (forwarded to COMBASE.HBITMAP_UserMarshal)
| 0xB57703A4 |    1042 |   CF | HBITMAP_UserMarshal64 (forwarded to COMBASE.HBITMAP_UserMarshal64)
| 0xEFC0D2D1 |    1043 |   D0 | HBITMAP_UserSize (forwarded to COMBASE.HBITMAP_UserSize)
| 0xF1E4B4AF |    1044 |   D1 | HBITMAP_UserSize64 (forwarded to COMBASE.HBITMAP_UserSize64)
| 0xE2BBA473 |    1045 |   D2 | HBITMAP_UserUnmarshal (forwarded to COMBASE.HBITMAP_UserUnmarshal)
| 0xB0991D2C |    1046 |   D3 | HBITMAP_UserUnmarshal64 (forwarded to COMBASE.HBITMAP_UserUnmarshal64)
| 0x51A8ACED |    1047 |   D4 | HBRUSH_UserFree (forwarded to COMBASE.HBRUSH_UserFree)
| 0x6BDB3B88 |    1048 |   D5 | HBRUSH_UserFree64 (forwarded to COMBASE.HBRUSH_UserFree64)
| 0x79C83BBD |    1049 |   D6 | HBRUSH_UserMarshal (forwarded to COMBASE.HBRUSH_UserMarshal)
| 0x73BEEF92 |    1050 |   D7 | HBRUSH_UserMarshal64 (forwarded to COMBASE.HBRUSH_UserMarshal64)
| 0x6C50AAAD |    1051 |   D8 | HBRUSH_UserSize (forwarded to COMBASE.HBRUSH_UserSize)
| 0x15DAAB8F |    1052 |   D9 | HBRUSH_UserSize64 (forwarded to COMBASE.HBRUSH_UserSize64)
| 0xA1039061 |    1053 |   DA | HBRUSH_UserUnmarshal (forwarded to COMBASE.HBRUSH_UserUnmarshal)
| 0x4294189C |    1054 |   DB | HBRUSH_UserUnmarshal64 (forwarded to COMBASE.HBRUSH_UserUnmarshal64)
| 0x708D5FC9 |    1055 |   DC | HDC_UserFree (forwarded to COMBASE.HDC_UserFree)
| 0x2507F290 |    1056 |   DD | HDC_UserFree64 (forwarded to COMBASE.HDC_UserFree64)
| 0x32060523 |    1057 |   DE | HDC_UserMarshal (forwarded to COMBASE.HDC_UserMarshal)
| 0x83314900 |    1058 |   DF | HDC_UserMarshal64 (forwarded to COMBASE.HDC_UserMarshal64)
| 0x8B355D89 |    1059 |   E0 | HDC_UserSize (forwarded to COMBASE.HDC_UserSize)
| 0xCF076296 |    1060 |   E1 | HDC_UserSize64 (forwarded to COMBASE.HDC_UserSize64)
| 0xB075E9CF |    1061 |   E2 | HDC_UserUnmarshal (forwarded to COMBASE.HDC_UserUnmarshal)
| 0x1F2A7420 |    1062 |   E3 | HDC_UserUnmarshal64 (forwarded to COMBASE.HDC_UserUnmarshal64)
| 0xC4DE5078 |    1063 |   E4 | HENHMETAFILE_UserFree
| 0x39441E65 |    1064 |   E5 | HENHMETAFILE_UserFree64
| 0x90AEA704 |    1065 |   E6 | HENHMETAFILE_UserMarshal
| 0x2D59C158 |    1066 |   E7 | HENHMETAFILE_UserMarshal64
| 0xDF864E38 |    1067 |   E8 | HENHMETAFILE_UserSize
| 0xE3438E6B |    1068 |   E9 | HENHMETAFILE_UserSize64
| 0x5A9E6227 |    1069 |   EA | HENHMETAFILE_UserUnmarshal
| 0xA9488A0A |    1070 |   EB | HENHMETAFILE_UserUnmarshal64
| 0xD682C8C1 |    1071 |   EC | HGLOBAL_UserFree (forwarded to COMBASE.HGLOBAL_UserFree)
| 0xA26230A9 |    1072 |   ED | HGLOBAL_UserFree64 (forwarded to COMBASE.HGLOBAL_UserFree64)
| 0x22D1EFF5 |    1073 |   EE | HGLOBAL_UserMarshal (forwarded to COMBASE.HGLOBAL_UserMarshal)
| 0xB62BFD7C |    1074 |   EF | HGLOBAL_UserMarshal64 (forwarded to COMBASE.HGLOBAL_UserMarshal64)
| 0xF12AC681 |    1075 |   F0 | HGLOBAL_UserSize (forwarded to COMBASE.HGLOBAL_UserSize)
| 0x4C61A0B0 |    1076 |   F1 | HGLOBAL_UserSize64 (forwarded to COMBASE.HGLOBAL_UserSize64)
| 0xE3709E4B |    1077 |   F2 | HGLOBAL_UserUnmarshal (forwarded to COMBASE.HGLOBAL_UserUnmarshal)
| 0xDDD7932C |    1078 |   F3 | HGLOBAL_UserUnmarshal64 (forwarded to COMBASE.HGLOBAL_UserUnmarshal64)
| 0x5483BC5C |    1079 |   F4 | HICON_UserFree (forwarded to COMBASE.HICON_UserFree)
| 0x229F1749 |    1080 |   F5 | HICON_UserFree64 (forwarded to COMBASE.HICON_UserFree64)
| 0x57CDF1DC |    1081 |   F6 | HICON_UserMarshal (forwarded to COMBASE.HICON_UserMarshal)
| 0xF52C7749 |    1082 |   F7 | HICON_UserMarshal64 (forwarded to COMBASE.HICON_UserMarshal64)
| 0x6F2BBA1C |    1083 |   F8 | HICON_UserSize (forwarded to COMBASE.HICON_UserSize)
| 0xCC9E874F |    1084 |   F9 | HICON_UserSize64 (forwarded to COMBASE.HICON_UserSize64)
| 0x22711819 |    1085 |   FA | HICON_UserUnmarshal (forwarded to COMBASE.HICON_UserUnmarshal)
| 0x9DF6067C |    1086 |   FB | HICON_UserUnmarshal64 (forwarded to COMBASE.HICON_UserUnmarshal64)
| 0x1487F49C |    1087 |   FC | HMENU_UserFree (forwarded to COMBASE.HMENU_UserFree)
| 0x23AD2739 |    1088 |   FD | HMENU_UserFree64 (forwarded to COMBASE.HMENU_UserFree64)
| 0xD74DFA4C |    1089 |   FE | HMENU_UserMarshal (forwarded to COMBASE.HMENU_UserMarshal)
| 0xD52E9369 |    1090 |   FF | HMENU_UserMarshal64 (forwarded to COMBASE.HMENU_UserMarshal64)
| 0x2F2FF25C |    1091 |  100 | HMENU_UserSize (forwarded to COMBASE.HMENU_UserSize)
| 0xCDAC973F |    1092 |  101 | HMENU_UserSize64 (forwarded to COMBASE.HMENU_UserSize64)
| 0x2733439  |    1093 |  102 | HMENU_UserUnmarshal (forwarded to COMBASE.HMENU_UserUnmarshal)
| 0x9E7D0E74 |    1094 |  103 | HMENU_UserUnmarshal64 (forwarded to COMBASE.HMENU_UserUnmarshal64)
| 0x587BA8DF |    1095 |  104 | HMETAFILEPICT_UserFree
| 0x209A380A |    1096 |  105 | HMETAFILEPICT_UserFree64
| 0x5DD5E1B5 |    1097 |  106 | HMETAFILEPICT_UserMarshal
| 0x77286D8B |    1098 |  107 | HMETAFILEPICT_UserMarshal64
| 0x7323A69F |    1099 |  108 | HMETAFILEPICT_UserSize
| 0xCA99A810 |    1100 |  109 | HMETAFILEPICT_UserSize64
| 0xA46D0E5A |    1101 |  10A | HMETAFILEPICT_UserUnmarshal
| 0x1CF396DD |    1102 |  10B | HMETAFILEPICT_UserUnmarshal64
| 0x315DC674 |    1103 |  10C | HMETAFILE_UserFree
| 0x59219D40 |    1104 |  10D | HMETAFILE_UserFree64
| 0x8787A5F0 |    1105 |  10E | HMETAFILE_UserMarshal
| 0xE3997C55 |    1106 |  10F | HMETAFILE_UserMarshal64
| 0x4C05C434 |    1107 |  110 | HMETAFILE_UserSize
| 0x3210D47  |    1108 |  111 | HMETAFILE_UserSize64
| 0x10DE1D25 |    1109 |  112 | HMETAFILE_UserUnmarshal
| 0x39374978 |    1110 |  113 | HMETAFILE_UserUnmarshal64
| 0xF7EF1865 |    1111 |  114 | HMONITOR_UserFree (forwarded to COMBASE.HMONITOR_UserFree)
| 0xFD7619B1 |    1112 |  115 | HMONITOR_UserFree64 (forwarded to COMBASE.HMONITOR_UserFree64)
| 0x6B14C894 |    1113 |  116 | HMONITOR_UserMarshal (forwarded to COMBASE.HMONITOR_UserMarshal)
| 0xC6E2254E |    1114 |  117 | HMONITOR_UserMarshal64 (forwarded to COMBASE.HMONITOR_UserMarshal64)
| 0x12971626 |    1115 |  118 | HMONITOR_UserSize (forwarded to COMBASE.HMONITOR_UserSize)
| 0xA77589B8 |    1116 |  119 | HMONITOR_UserSize64 (forwarded to COMBASE.HMONITOR_UserSize64)
| 0xF426C61D |    1117 |  11A | HMONITOR_UserUnmarshal (forwarded to COMBASE.HMONITOR_UserUnmarshal)
| 0xB6187B1  |    1118 |  11B | HMONITOR_UserUnmarshal64 (forwarded to COMBASE.HMONITOR_UserUnmarshal64)
| 0x96EE7827 |    1119 |  11C | HPALETTE_UserFree (forwarded to COMBASE.HPALETTE_UserFree)
| 0xBD4E0A19 |    1120 |  11D | HPALETTE_UserFree64 (forwarded to COMBASE.HPALETTE_UserFree64)
| 0x52EDEEA4 |     810 |  11E | HPALETTE_UserFreeExt
| 0xEE52C753 |    1121 |  11F | HPALETTE_UserMarshal (forwarded to COMBASE.HPALETTE_UserMarshal)
| 0x9661D52F |    1122 |  120 | HPALETTE_UserMarshal64 (forwarded to COMBASE.HPALETTE_UserMarshal64)
| 0xAB9CB742 |     811 |  121 | HPALETTE_UserMarshalExt
| 0xB19675E7 |    1123 |  122 | HPALETTE_UserSize (forwarded to COMBASE.HPALETTE_UserSize)
| 0x674D7A20 |    1124 |  123 | HPALETTE_UserSize64 (forwarded to COMBASE.HPALETTE_UserSize64)
| 0xD3233E9F |     812 |  124 | HPALETTE_UserSizeExt
| 0xC3A675FE |    1125 |  125 | HPALETTE_UserUnmarshal (forwarded to COMBASE.HPALETTE_UserUnmarshal)
| 0xEB4D7FE4 |    1126 |  126 | HPALETTE_UserUnmarshal64 (forwarded to COMBASE.HPALETTE_UserUnmarshal64)
| 0x1475EA0  |     813 |  127 | HPALETTE_UserUnmarshalExt
| 0x30A1BC4A |     814 |  128 | HRGN_UserFree (forwarded to COMBASE.HRGN_UserFree)
| 0x33862DDC |     815 |  129 | HRGN_UserMarshal (forwarded to COMBASE.HRGN_UserMarshal)
| 0x4B49BA0A |     816 |  12A | HRGN_UserSize (forwarded to COMBASE.HRGN_UserSize)
| 0x10801810 |     817 |  12B | HRGN_UserUnmarshal (forwarded to COMBASE.HRGN_UserUnmarshal)
| 0xF0AB6C4B |    1127 |  12C | HWND_UserFree (forwarded to COMBASE.HWND_UserFree)
| 0x2C8B1330 |    1128 |  12D | HWND_UserFree64 (forwarded to COMBASE.HWND_UserFree64)
| 0x641927DA |     818 |  12E | HWND_UserFree64Ext
| 0x9BA1688C |     819 |  12F | HWND_UserFreeExt
| 0x3706413C |    1129 |  130 | HWND_UserMarshal (forwarded to COMBASE.HWND_UserMarshal)
| 0xC3404F41 |    1130 |  131 | HWND_UserMarshal64 (forwarded to COMBASE.HWND_UserMarshal64)
| 0x87469252 |     824 |  132 | HWND_UserMarshal64Ext
| 0x7C2E1E36 |     825 |  133 | HWND_UserMarshalExt
| 0xB536A0C  |    1131 |  134 | HWND_UserSize (forwarded to COMBASE.HWND_UserSize)
| 0xD68A8336 |    1132 |  135 | HWND_UserSize64 (forwarded to COMBASE.HWND_UserSize64)
| 0x716D26BA |     826 |  136 | HWND_UserSize64Ext
| 0x1BD6B888 |     827 |  137 | HWND_UserSizeExt
| 0xF084F010 |    1133 |  138 | HWND_UserUnmarshal (forwarded to COMBASE.HWND_UserUnmarshal)
| 0x22EC0470 |    1134 |  139 | HWND_UserUnmarshal64 (forwarded to COMBASE.HWND_UserUnmarshal64)
| 0xE405E9BC |     828 |  13A | HWND_UserUnmarshal64Ext
| 0x25A11B94 |     829 |  13B | HWND_UserUnmarshalExt
| 0xC9087C4C |    1135 |  13C | HkOleRegisterObject (forwarded to api-ms-win-core-com-private-l1-1-1.HkOleRegisterObject)
| 0xDBBF9D52 |    1136 |  13D | IIDFromString (forwarded to api-ms-win-core-com-l1-1-0.IIDFromString)
| 0xEB1866E5 |    1137 |  13E | IsAccelerator
| 0x97267BE7 |    1138 |  13F | IsEqualGUID
| 0xBA907F89 |    1139 |  140 | IsRoInitializeASTAAllowedInDesktop
| 0x3FD4F59B |    1140 |  141 | IsValidIid
| 0x25CC38CC |    1141 |  142 | IsValidInterface
| 0xD85DABE  |    1142 |  143 | IsValidPtrIn
| 0xD6286E22 |    1143 |  144 | IsValidPtrOut
| 0xCE598C89 |    1144 |  145 | MkParseDisplayName
| 0xB80C40D4 |    1145 |  146 | MonikerCommonPrefixWith
| 0xA67744F8 |     830 |  147 | MonikerLoadTypeLib
| 0x4B03891A |    1146 |  148 | MonikerRelativePathTo
| 0xC0F77A0D |    1147 |  149 | NdrOleInitializeExtension (forwarded to api-ms-win-core-com-private-l1-1-1.NdrOleInitializeExtension)
| 0xB3C79A54 |    1148 |  14A | NdrProxyForwardingFunction10 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.NdrProxyForwardingFunction10)
| 0xB3C79A55 |    1149 |  14B | NdrProxyForwardingFunction11 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.NdrProxyForwardingFunction11)
| 0xB3C79A56 |    1150 |  14C | NdrProxyForwardingFunction12 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.NdrProxyForwardingFunction12)
| 0xB3C79A57 |    1151 |  14D | NdrProxyForwardingFunction13 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.NdrProxyForwardingFunction13)
| 0xB3C79A58 |    1152 |  14E | NdrProxyForwardingFunction14 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.NdrProxyForwardingFunction14)
| 0xB3C79A59 |    1153 |  14F | NdrProxyForwardingFunction15 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.NdrProxyForwardingFunction15)
| 0xB3C79A5A |    1154 |  150 | NdrProxyForwardingFunction16 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.NdrProxyForwardingFunction16)
| 0xB3C79A5B |    1155 |  151 | NdrProxyForwardingFunction17 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.NdrProxyForwardingFunction17)
| 0xB3C79A5C |    1156 |  152 | NdrProxyForwardingFunction18 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.NdrProxyForwardingFunction18)
| 0xB3C79A5D |    1157 |  153 | NdrProxyForwardingFunction19 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.NdrProxyForwardingFunction19)
| 0xB3CF9A54 |    1158 |  154 | NdrProxyForwardingFunction20 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.NdrProxyForwardingFunction20)
| 0xB3CF9A55 |    1159 |  155 | NdrProxyForwardingFunction21 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.NdrProxyForwardingFunction21)
| 0xB3CF9A56 |    1160 |  156 | NdrProxyForwardingFunction22 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.NdrProxyForwardingFunction22)
| 0xB3CF9A57 |    1161 |  157 | NdrProxyForwardingFunction23 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.NdrProxyForwardingFunction23)
| 0xB3CF9A58 |    1162 |  158 | NdrProxyForwardingFunction24 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.NdrProxyForwardingFunction24)
| 0xB3CF9A59 |    1163 |  159 | NdrProxyForwardingFunction25 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.NdrProxyForwardingFunction25)
| 0xB3CF9A5A |    1164 |  15A | NdrProxyForwardingFunction26 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.NdrProxyForwardingFunction26)
| 0xB3CF9A5B |    1165 |  15B | NdrProxyForwardingFunction27 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.NdrProxyForwardingFunction27)
| 0xB3CF9A5C |    1166 |  15C | NdrProxyForwardingFunction28 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.NdrProxyForwardingFunction28)
| 0xB3CF9A5D |    1167 |  15D | NdrProxyForwardingFunction29 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.NdrProxyForwardingFunction29)
| 0xF344967A |    1168 |  15E | NdrProxyForwardingFunction3 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.NdrProxyForwardingFunction3)
| 0xB3D79A54 |    1169 |  15F | NdrProxyForwardingFunction30 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.NdrProxyForwardingFunction30)
| 0xB3D79A55 |    1170 |  160 | NdrProxyForwardingFunction31 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.NdrProxyForwardingFunction31)
| 0xB3D79A56 |    1171 |  161 | NdrProxyForwardingFunction32 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.NdrProxyForwardingFunction32)
| 0xF344967B |    1172 |  162 | NdrProxyForwardingFunction4 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.NdrProxyForwardingFunction4)
| 0xF344967C |    1173 |  163 | NdrProxyForwardingFunction5 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.NdrProxyForwardingFunction5)
| 0xF344967D |    1174 |  164 | NdrProxyForwardingFunction6 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.NdrProxyForwardingFunction6)
| 0xF344967E |    1175 |  165 | NdrProxyForwardingFunction7 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.NdrProxyForwardingFunction7)
| 0xF344967F |    1176 |  166 | NdrProxyForwardingFunction8 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.NdrProxyForwardingFunction8)
| 0xF3449680 |    1177 |  167 | NdrProxyForwardingFunction9 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.NdrProxyForwardingFunction9)
| 0xE7783B27 |    1178 |  168 | ObjectStublessClient10 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.ObjectStublessClient10)
| 0xE7783B28 |    1179 |  169 | ObjectStublessClient11 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.ObjectStublessClient11)
| 0xE7783B29 |    1180 |  16A | ObjectStublessClient12 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.ObjectStublessClient12)
| 0xE7783B2A |    1181 |  16B | ObjectStublessClient13 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.ObjectStublessClient13)
| 0xE7783B2B |    1182 |  16C | ObjectStublessClient14 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.ObjectStublessClient14)
| 0xE7783B2C |    1183 |  16D | ObjectStublessClient15 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.ObjectStublessClient15)
| 0xE7783B2D |    1184 |  16E | ObjectStublessClient16 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.ObjectStublessClient16)
| 0xE7783B2E |    1185 |  16F | ObjectStublessClient17 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.ObjectStublessClient17)
| 0xE7783B2F |    1186 |  170 | ObjectStublessClient18 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.ObjectStublessClient18)
| 0xE7783B30 |    1187 |  171 | ObjectStublessClient19 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.ObjectStublessClient19)
| 0xE7803B27 |    1188 |  172 | ObjectStublessClient20 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.ObjectStublessClient20)
| 0xE7803B28 |    1189 |  173 | ObjectStublessClient21 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.ObjectStublessClient21)
| 0xE7803B29 |    1190 |  174 | ObjectStublessClient22 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.ObjectStublessClient22)
| 0xE7803B2A |    1191 |  175 | ObjectStublessClient23 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.ObjectStublessClient23)
| 0xE7803B2B |    1192 |  176 | ObjectStublessClient24 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.ObjectStublessClient24)
| 0xE7803B2C |    1193 |  177 | ObjectStublessClient25 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.ObjectStublessClient25)
| 0xE7803B2D |    1194 |  178 | ObjectStublessClient26 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.ObjectStublessClient26)
| 0xE7803B2E |    1195 |  179 | ObjectStublessClient27 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.ObjectStublessClient27)
| 0xE7803B2F |    1196 |  17A | ObjectStublessClient28 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.ObjectStublessClient28)
| 0xE7803B30 |    1197 |  17B | ObjectStublessClient29 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.ObjectStublessClient29)
| 0x75EFCF1  |    1198 |  17C | ObjectStublessClient3 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.ObjectStublessClient3)
| 0xE7883B27 |    1199 |  17D | ObjectStublessClient30 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.ObjectStublessClient30)
| 0xE7883B28 |    1200 |  17E | ObjectStublessClient31 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.ObjectStublessClient31)
| 0xE7883B29 |    1201 |  17F | ObjectStublessClient32 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.ObjectStublessClient32)
| 0x75EFCF2  |    1202 |  180 | ObjectStublessClient4 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.ObjectStublessClient4)
| 0x75EFCF3  |    1203 |  181 | ObjectStublessClient5 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.ObjectStublessClient5)
| 0x75EFCF4  |    1204 |  182 | ObjectStublessClient6 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.ObjectStublessClient6)
| 0x75EFCF5  |    1205 |  183 | ObjectStublessClient7 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.ObjectStublessClient7)
| 0x75EFCF6  |    1206 |  184 | ObjectStublessClient8 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.ObjectStublessClient8)
| 0x75EFCF7  |    1207 |  185 | ObjectStublessClient9 (forwarded to api-ms-win-core-com-midlproxystub-l1-1-0.ObjectStublessClient9)
| 0xEB83AA41 |    1208 |  186 | Ole32DllGetClassObject
| 0x4D5FD1CF |    1209 |  187 | OleBuildVersion
| 0xE521BE1B |    1210 |  188 | OleConvertIStorageToOLESTREAM
| 0x4A978771 |    1211 |  189 | OleConvertIStorageToOLESTREAMEx
| 0x80132287 |    1212 |  18A | OleConvertOLESTREAMToIStorage
| 0x6F0A258  |    1213 |  18B | OleConvertOLESTREAMToIStorageEx
| 0x9E3B4647 |    1214 |  18C | OleCreate
| 0x837D705  |    1215 |  18D | OleCreateDefaultHandler
| 0x70E01D59 |    1216 |  18E | OleCreateEmbeddingHelper
| 0x90F9925F |    1217 |  18F | OleCreateEx
| 0x3DC246C3 |    1218 |  190 | OleCreateFontIndirectExt
| 0x550D2CDF |    1219 |  191 | OleCreateFromData
| 0x4573384D |    1220 |  192 | OleCreateFromDataEx
| 0x58CD2EE3 |    1221 |  193 | OleCreateFromFile
| 0x3573B94E |    1222 |  194 | OleCreateFromFileEx
| 0x4FD4948F |    1223 |  195 | OleCreateLink
| 0xF74D244B |    1224 |  196 | OleCreateLinkEx
| 0x9CBEC62D |    1225 |  197 | OleCreateLinkFromData
| 0x31D98BDF |    1226 |  198 | OleCreateLinkFromDataEx
| 0xE1A44A21 |    1227 |  199 | OleCreateLinkToFile
| 0x6B3A88F0 |    1228 |  19A | OleCreateLinkToFileEx
| 0x9E8200F2 |    1229 |  19B | OleCreateMenuDescriptor
| 0x3F2E2798 |    1230 |  19C | OleCreatePictureIndirectExt
| 0x65552500 |    1231 |  19D | OleCreatePropertyFrameIndirectExt
| 0x87CD5F6F |    1232 |  19E | OleCreateStaticFromData
| 0xF8B015DB |    1233 |  19F | OleDestroyMenuDescriptor
| 0x38066427 |    1234 |  1A0 | OleDoAutoConvert
| 0x8C4A6D2D |    1235 |  1A1 | OleDraw
| 0x99989A2  |    1236 |  1A2 | OleDuplicateData
| 0x8A782147 |    1237 |  1A3 | OleFlushClipboard
| 0xC95F4A3A |    1238 |  1A4 | OleGetAutoConvert
| 0x9CCD28C6 |    1239 |  1A5 | OleGetClipboard
| 0x9C57E773 |    1240 |  1A6 | OleGetClipboardWithEnterpriseInfo
| 0x30940917 |    1241 |  1A7 | OleGetIconOfClass
| 0x876C8544 |    1242 |  1A8 | OleGetIconOfFile
| 0xE69BAF22 |     802 |  1A9 | OleGetPackageClipboardOwner
| 0x7F5BB618 |    1243 |  1AA | OleIconToCursorExt
| 0xC808504  |    1244 |  1AB | OleInitialize
| 0xA911721  |    1245 |  1AC | OleInitializeWOW
| 0x49BD9BEE |    1246 |  1AD | OleIsCurrentClipboard
| 0xAA60315D |    1247 |  1AE | OleIsRunning
| 0x9C4A6C5A |    1248 |  1AF | OleLoad
| 0x81D832CE |    1249 |  1B0 | OleLoadFromStream
| 0x5FAC5966 |    1250 |  1B1 | OleLoadPictureExt
| 0x1359F7A8 |    1251 |  1B2 | OleLoadPictureFileExt
| 0x198277A4 |    1252 |  1B3 | OleLoadPicturePathExt
| 0xEC0C8715 |    1253 |  1B4 | OleLockRunning
| 0x4710A492 |    1254 |  1B5 | OleMetafilePictFromIconAndLabel
| 0x6856F5DB |    1255 |  1B6 | OleNoteObjectVisible
| 0xE98BCA8E |    1256 |  1B7 | OleQueryCreateFromData
| 0xAD5D9E7A |    1257 |  1B8 | OleQueryLinkFromData
| 0x7BF43392 |    1258 |  1B9 | OleRegEnumFormatEtc
| 0xA920554  |    1259 |  1BA | OleRegEnumVerbs
| 0x38AE6FF5 |    1260 |  1BB | OleRegGetMiscStatus
| 0xB750BE8  |    1261 |  1BC | OleRegGetUserType
| 0x1A493713 |    1262 |  1BD | OleReleaseEnumVerbCache
| 0x4DAED516 |    1263 |  1BE | OleRun
| 0xAAF268DB |    1264 |  1BF | OleSave
| 0xB34BFBE2 |    1265 |  1C0 | OleSavePictureFileExt
| 0x447656C0 |    1266 |  1C1 | OleSaveToStream
| 0xCF5F4A3A |    1267 |  1C2 | OleSetAutoConvert
| 0x9CE528C6 |    1268 |  1C3 | OleSetClipboard
| 0xC8C07C20 |    1269 |  1C4 | OleSetContainedObject
| 0x6CBE53AE |    1270 |  1C5 | OleSetMenuDescriptor
| 0xE8A2C5EE |    1271 |  1C6 | OleTranslateAccelerator
| 0x21B4D6CA |    1272 |  1C7 | OleTranslateColorExt
| 0x8254C266 |    1273 |  1C8 | OleUninitialize
| 0x121E5219 |    1274 |  1C9 | OpenOrCreateStream
| 0xDBD9BA7D |    1275 |  1CA | ProgIDFromCLSID (forwarded to api-ms-win-core-com-l1-1-0.ProgIDFromCLSID)
| 0x55615C1E |    1276 |  1CB | PropStgNameToFmtId
| 0x1FE092E0 |    1277 |  1CC | PropSysAllocString
| 0x145158CD |    1278 |  1CD | PropSysFreeString
| 0x6B548B8  |    1279 |  1CE | PropVariantChangeType
| 0xBDF5B52F |    1280 |  1CF | PropVariantClear
| 0xB6EFB896 |    1281 |  1D0 | PropVariantCopy
| 0xFFE55D2  |    1282 |  1D1 | ReadClassStg
| 0xFFE55D8  |    1283 |  1D2 | ReadClassStm
| 0x38495526 |    1284 |  1D3 | ReadFmtUserTypeStg
| 0xB439716F |    1285 |  1D4 | ReadOleStg
| 0x11555824 |     831 |  1D5 | ReadStorageProperties
| 0x42D691FF |    1286 |  1D6 | ReadStringStream
| 0x3C1CD882 |    1287 |  1D7 | RegisterActiveObjectExt
| 0xF3B15858 |    1288 |  1D8 | RegisterDragDrop
| 0xD7113BCB |    1289 |  1D9 | ReleaseStgMedium
| 0x4CB04F0F |    1290 |  1DA | RevokeActiveObjectExt
| 0x5C35F40D |    1291 |  1DB | RevokeDragDrop
| 0x76D54AC8 |    1292 |  1DC | RoGetAgileReference (forwarded to api-ms-win-core-com-l1-1-1.RoGetAgileReference)
| 0xF0A357CB |    1293 |  1DD | SNB_UserFree
| 0x2A85F330 |    1294 |  1DE | SNB_UserFree64
| 0x37063113 |    1295 |  1DF | SNB_UserMarshal
| 0xC33C4501 |    1296 |  1E0 | SNB_UserMarshal64
| 0xB4B558C  |    1297 |  1E1 | SNB_UserSize
| 0xD4856336 |    1298 |  1E2 | SNB_UserSize64
| 0xF080E5D0 |    1299 |  1E3 | SNB_UserUnmarshal
| 0x21E97470 |    1300 |  1E4 | SNB_UserUnmarshal64
| 0xB364EAAE |    1301 |  1E5 | STGMEDIUM_UserFree
| 0xDAEAABE0 |    1302 |  1E6 | STGMEDIUM_UserFree64
| 0x6126DB89 |     832 |  1E7 | STGMEDIUM_UserFreeExt
| 0xFC8BB438 |    1303 |  1E8 | STGMEDIUM_UserMarshal
| 0x249D0E73 |    1304 |  1E9 | STGMEDIUM_UserMarshal64
| 0x75B9291C |     833 |  1EA | STGMEDIUM_UserMarshalExt
| 0xCE0CE86E |    1305 |  1EB | STGMEDIUM_UserSize
| 0x84EA1BE7 |    1306 |  1EC | STGMEDIUM_UserSize64
| 0xE15C2B84 |     834 |  1ED | STGMEDIUM_UserSizeExt
| 0x51E1AF42 |    1307 |  1EE | STGMEDIUM_UserUnmarshal
| 0x7A1BD0C8 |    1308 |  1EF | STGMEDIUM_UserUnmarshal64
| 0x8863D512 |     835 |  1F0 | STGMEDIUM_UserUnmarshalExt
| 0xDD4B6067 |    1309 |  1F1 | SetConvertStg
| 0x5594F223 |    1310 |  1F2 | SetDocumentBitStg
| 0x9CA8EA80 |    1311 |  1F3 | SetErrorInfo (forwarded to api-ms-win-core-com-private-l1-1-1.CoSetErrorInfo)
| 0xE15997C7 |     836 |  1F4 | SetOleautModule
| 0xC8E89669 |    1312 |  1F5 | SetWOWThunkGlobalPtr
| 0x93F1C679 |     837 |  1F6 | StdTypesGetClassObject
| 0x3C643103 |     838 |  1F7 | StdTypesRegisterServer
| 0x4935C7A8 |    1313 |  1F8 | StgConvertPropertyToVariant
| 0x39528BD2 |    1314 |  1F9 | StgConvertVariantToProperty
| 0x98DF33D1 |    1315 |  1FA | StgCreateDocfile
| 0xD14BD0BE |    1316 |  1FB | StgCreateDocfileOnILockBytes
| 0xC7F9C503 |    1317 |  1FC | StgCreatePropSetStg
| 0x2D4FEE55 |    1318 |  1FD | StgCreatePropStg
| 0x3F247584 |    1319 |  1FE | StgCreateStorageEx
| 0xB48D9029 |    1320 |  1FF | StgGetIFillLockBytesOnFile
| 0x98CB283F |    1321 |  200 | StgGetIFillLockBytesOnILockBytes
| 0xD455EDC8 |    1322 |  201 | StgIsStorageFile
| 0xF47A761  |    1323 |  202 | StgIsStorageILockBytes
| 0xB1F40EB3 |    1324 |  203 | StgOpenAsyncDocfileOnIFillLockBytes
| 0x34389A75 |    1325 |  204 | StgOpenPropStg
| 0x37DC9DF4 |    1326 |  205 | StgOpenStorage
| 0xF94F7D85 |    1327 |  206 | StgOpenStorageEx
| 0xD5561007 |    1328 |  207 | StgOpenStorageOnHandle
| 0xC12272E8 |    1329 |  208 | StgOpenStorageOnILockBytes
| 0x99F0172B |    1330 |  209 | StgPropertyLengthAsVariant
| 0xFDC50662 |    1331 |  20A | StgSetTimes
| 0x1CDEDEB7 |    1332 |  20B | StringFromCLSID (forwarded to api-ms-win-core-com-l1-1-0.StringFromCLSID)
| 0x2EB71C25 |    1333 |  20C | StringFromGUID2 (forwarded to api-ms-win-core-com-l1-1-0.StringFromGUID2)
| 0xCC525CEA |    1334 |  20D | StringFromIID (forwarded to api-ms-win-core-com-l1-1-0.StringFromIID)
| 0x9ECF6BA3 |    1335 |  20E | UpdateDCOMSettings (forwarded to api-ms-win-core-com-private-l1-1-1.UpdateDCOMSettings)
| 0xC30AA9A8 |    1336 |  20F | UpdateProcessTracing (forwarded to api-ms-win-core-com-private-l1-1-1.UpdateProcessTracing)
| 0xD066CA64 |    1337 |  210 | UtConvertDvtd16toDvtd32
| 0xCC56DA68 |    1338 |  211 | UtConvertDvtd32toDvtd16
| 0xC7910315 |    1339 |  212 | UtGetDvtd16Info
| 0xC790C316 |    1340 |  213 | UtGetDvtd32Info
| 0xB18E3576 |    1341 |  214 | WdtpInterfacePointer_UserFree (forwarded to COMBASE.WdtpInterfacePointer_UserFree)
| 0x653D5DE0 |    1342 |  215 | WdtpInterfacePointer_UserFree64 (forwarded to COMBASE.WdtpInterfacePointer_UserFree64)
| 0x8C8806CE |    1343 |  216 | WdtpInterfacePointer_UserMarshal (forwarded to COMBASE.WdtpInterfacePointer_UserMarshal)
| 0x23B1B3D7 |    1344 |  217 | WdtpInterfacePointer_UserMarshal64 (forwarded to COMBASE.WdtpInterfacePointer_UserMarshal64)
| 0xCC363336 |    1345 |  218 | WdtpInterfacePointer_UserSize (forwarded to COMBASE.WdtpInterfacePointer_UserSize)
| 0xF3CCDE7  |    1346 |  219 | WdtpInterfacePointer_UserSize64 (forwarded to COMBASE.WdtpInterfacePointer_UserSize64)
| 0x50F654A6 |    1347 |  21A | WdtpInterfacePointer_UserUnmarshal (forwarded to COMBASE.WdtpInterfacePointer_UserUnmarshal)
| 0x3F4529C8 |    1348 |  21B | WdtpInterfacePointer_UserUnmarshal64 (forwarded to COMBASE.WdtpInterfacePointer_UserUnmarshal64)
| 0x113EF343 |    1349 |  21C | WriteClassStg
| 0x113EF349 |    1350 |  21D | WriteClassStm
| 0xAE0D5A28 |    1351 |  21E | WriteFmtUserTypeStg
| 0x783E73E5 |    1352 |  21F | WriteOleStg
| 0x1640E02E |     839 |  220 | WriteStorageProperties
| 0x4CADA213 |    1353 |  221 | WriteStringStream
