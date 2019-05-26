The following is table of pre-computed ROR-13 hashes for all comctl32.dll Win32 APIs. The Win32 APIs list was generated using the below command.

```
dumpbin.exe /exports c:\windows\system32\comctl32.dll
```

| hashes     | ordinal | hint | name
|------------|:-------:|:----:|---------------------------------- 
| 0x2955B2DB |     401 |    0 | AddMRUStringW
| 0x1E3A8E1B |     400 |    1 | CreateMRUListW
| 0x77AFC4FF |       8 |    2 | CreateMappedBitmap
| 0x5E46B68E |      12 |    3 | CreatePropertySheetPage
| 0xB472F276 |      18 |    4 | CreatePropertySheetPageA
| 0xB472F28C |      19 |    5 | CreatePropertySheetPageW
| 0xB0674CD5 |      20 |    6 | CreateStatusWindow
| 0x66AD837B |       6 |    7 | CreateStatusWindowA
| 0x66AD8391 |      21 |    8 | CreateStatusWindowW
| 0x11462214 |       7 |    9 | CreateToolbar
| 0x53B0857C |      22 |    A | CreateToolbarEx
| 0x48155BE2 |      16 |    B | CreateUpDownControl
| 0xA0785655 |     331 |    C | DPA_Clone
| 0x9F2560E7 |     328 |    D | DPA_Create
| 0xCB803A5F |     340 |    E | DPA_CreateEx
| 0x492D1AAF |     337 |    F | DPA_DeleteAllPtrs
| 0xD3FA5D95 |     336 |   10 | DPA_DeletePtr
| 0xAD91D91D |     329 |   11 | DPA_Destroy
| 0xE650731A |     386 |   12 | DPA_DestroyCallback
| 0x56B1CF56 |     385 |   13 | DPA_EnumCallback
| 0xBD248CB6 |     332 |   14 | DPA_GetPtr
| 0x3DBEEFD4 |     333 |   15 | DPA_GetPtrIndex
| 0x12BE1598 |     330 |   16 | DPA_Grow
| 0xF7163EB5 |     334 |   17 | DPA_InsertPtr
| 0xBA23CB0F |       9 |   18 | DPA_LoadStream
| 0x9240F715 |      11 |   19 | DPA_Merge
| 0xAC2805AF |      10 |   1A | DPA_SaveStream
| 0x969C9532 |     339 |   1B | DPA_Search
| 0xBD248CBC |     335 |   1C | DPA_SetPtr
| 0x2AD614D5 |     338 |   1D | DPA_Sort
| 0xA22560E7 |     320 |   1E | DSA_Create
| 0xD54CD69B |     327 |   1F | DSA_DeleteAllItems
| 0xDE46A06F |     326 |   20 | DSA_DeleteItem
| 0xAD91F11D |     321 |   21 | DSA_Destroy
| 0xE6507332 |     388 |   22 | DSA_DestroyCallback
| 0x56B1DB56 |     387 |   23 | DSA_EnumCallback
| 0x574E0191 |     322 |   24 | DSA_GetItem
| 0x264EB075 |     323 |   25 | DSA_GetItemPtr
| 0xE747B94E |     324 |   26 | DSA_InsertItem
| 0x577E0191 |     325 |   27 | DSA_SetItem
| 0xFB2D811A |     413 |   28 | DefSubclassProc
| 0x558759B7 |      23 |   29 | DestroyPropertySheetPage
| 0xD0B185BC |      24 |   2A | DllGetVersion
| 0xDD7525F9 |      15 |   2B | DrawInsert
| 0x845BF54D |      25 |   2C | DrawStatusText
| 0xAA6C2320 |       5 |   2D | DrawStatusTextA
| 0xAA6C2336 |      26 |   2E | DrawStatusTextW
| 0x447A8EFE |     403 |   2F | EnumMRUListW
| 0xA504E460 |      27 |   30 | FlatSB_EnableScrollBar
| 0xA5B51E05 |      28 |   31 | FlatSB_GetScrollInfo
| 0xA3BAD683 |      29 |   32 | FlatSB_GetScrollPos
| 0xB3FD1F06 |      30 |   33 | FlatSB_GetScrollProp
| 0x11080EB0 |      31 |   34 | FlatSB_GetScrollPropPtr
| 0xD5EDC00D |      32 |   35 | FlatSB_GetScrollRange
| 0xA5B51EC5 |      33 |   36 | FlatSB_SetScrollInfo
| 0xA3D2D683 |      34 |   37 | FlatSB_SetScrollPos
| 0xB3FD1FC6 |      35 |   38 | FlatSB_SetScrollProp
| 0xDBEDC00D |      36 |   39 | FlatSB_SetScrollRange
| 0x1BA031E9 |      37 |   3A | FlatSB_ShowScrollBar
| 0x81D5078F |     152 |   3B | FreeMRUList
| 0x916D7CF8 |       4 |   3C | GetEffectiveClientRect
| 0x9C2D40C0 |      38 |   3D | GetMUILanguage
| 0xE8A89706 |      39 |   3E | ImageList_Add
| 0x1EE887B9 |      40 |   3F | ImageList_AddIcon
| 0xC549CDED |      41 |   40 | ImageList_AddMasked
| 0x68369FDE |      42 |   41 | ImageList_BeginDrag
| 0xBC97487D |      43 |   42 | ImageList_Copy
| 0x137249D4 |      44 |   43 | ImageList_Create
| 0xF4F57B84 |      45 |   44 | ImageList_Destroy
| 0xBE3C1208 |      46 |   45 | ImageList_DragEnter
| 0xACC47D3B |      47 |   46 | ImageList_DragLeave
| 0x9242D807 |      48 |   47 | ImageList_DragMove
| 0x3485847E |      49 |   48 | ImageList_DragShowNolock
| 0xBE1F493B |      50 |   49 | ImageList_Draw
| 0x89FA4F67 |      51 |   4A | ImageList_DrawEx
| 0x2494D250 |      52 |   4B | ImageList_DrawIndirect
| 0x28F24D9E |      53 |   4C | ImageList_Duplicate
| 0x14888B77 |      54 |   4D | ImageList_EndDrag
| 0x78975E85 |      55 |   4E | ImageList_GetBkColor
| 0x27856E5F |      56 |   4F | ImageList_GetDragImage
| 0x4F94C4FF |      57 |   50 | ImageList_GetFlags
| 0x9F0187B9 |      58 |   51 | ImageList_GetIcon
| 0xC24BB495 |      59 |   52 | ImageList_GetIconSize
| 0x8A3EC82D |      60 |   53 | ImageList_GetImageCount
| 0xE47F3108 |      61 |   54 | ImageList_GetImageInfo
| 0xF6672ECD |      62 |   55 | ImageList_GetImageRect
| 0x444C4CDA |      63 |   56 | ImageList_LoadImage
| 0x66D222A3 |      64 |   57 | ImageList_LoadImageA
| 0x66D222B9 |      65 |   58 | ImageList_LoadImageW
| 0x2F5E859F |      66 |   59 | ImageList_Merge
| 0xDA1F45E8 |      67 |   5A | ImageList_Read
| 0xA3817D5B |      68 |   5B | ImageList_Remove
| 0xE4CD4730 |      69 |   5C | ImageList_Replace
| 0x69EB277B |      70 |   5D | ImageList_ReplaceIcon
| 0x7897BE85 |      75 |   5E | ImageList_SetBkColor
| 0x27E188D3 |      76 |   5F | ImageList_SetDragCursorImage
| 0x498A5058 |      77 |   60 | ImageList_SetFilter
| 0x4F94C67F |      78 |   61 | ImageList_SetFlags
| 0xC24BB498 |      79 |   62 | ImageList_SetIconSize
| 0x8A3EC8ED |      80 |   63 | ImageList_SetImageCount
| 0xDC6B97EE |      81 |   64 | ImageList_SetOverlayImage
| 0x49C7235F |      82 |   65 | ImageList_Write
| 0xD9F0B62B |      17 |   66 | InitCommonControls
| 0x7E558B6E |      83 |   67 | InitCommonControlsEx
| 0xAFAE6500 |      84 |   68 | InitMUILanguage
| 0xC48A0C07 |      85 |   69 | InitializeFlatSB
| 0xD6D59088 |      14 |   6A | LBItemFromPt
| 0xC303EB7D |      13 |   6B | MakeDragList
| 0x94FB7387 |       2 |   6C | MenuHelp
| 0x7AE4DD4D |      86 |   6D | PropertySheet
| 0xEA6BD767 |      87 |   6E | PropertySheetA
| 0xEA6BD77D |      88 |   6F | PropertySheetW
| 0x4DABCDEB |      89 |   70 | RegisterClassNameW
| 0x5A830D65 |     412 |   71 | RemoveWindowSubclass
| 0x2126A1FB |     410 |   72 | SetWindowSubclass
| 0x7CD9902  |       3 |   73 | ShowHideMenuCtl
| 0x56E7097F |     236 |   74 | Str_SetPtrW
| 0xC4F80EB3 |      90 |   75 | UninitializeFlatSB
| 0xBA0A36BE |      91 |   76 | _TrackMouseEvent