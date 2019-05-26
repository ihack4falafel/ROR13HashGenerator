# ROR-13 Hash Generator
Basic program written in C# that produce ROR-13 numeric hash value for given function API name. This will aid shellcoders that want to build smaller payloads and reverse engineers that don't have access to paid RE tools (i.e. IDA pro) and want to make sense of ROR-13 hashes on the fly. Lastly, if you're lazy like me and want to just lookup those hashes/function APIs as opposed to using the program, I made few tables for commonly used DLLs such as kernel32, see the tables list below.

<p align="center">
  <img src="https://github.com/ihack4falafel/ROR13HashGenerator/blob/master/Capture.PNG">
</p>

## Win32 API tables
- [ advapi32 ](https://github.com/ihack4falafel/ROR13HashGenerator/blob/master/pre_computed_hashes/advapi32.md)
- [ comctl32 ](https://github.com/ihack4falafel/ROR13HashGenerator/blob/master/pre_computed_hashes/comctl32.md)
- [ comdlg32 ](https://github.com/ihack4falafel/ROR13HashGenerator/blob/master/pre_computed_hashes/comdlg32.md)
- [ gdi32 ](https://github.com/ihack4falafel/ROR13HashGenerator/blob/master/pre_computed_hashes/gdi32.md)
- [ kernel32 ](https://github.com/ihack4falafel/ROR13HashGenerator/blob/master/pre_computed_hashes/kernel32.md)
- [ netapi32 ](https://github.com/ihack4falafel/ROR13HashGenerator/blob/master/pre_computed_hashes/netapi32.md)
- [ ole32 ](https://github.com/ihack4falafel/ROR13HashGenerator/blob/master/pre_computed_hashes/ole32.md)
- [ user32 ](https://github.com/ihack4falafel/ROR13HashGenerator/blob/master/pre_computed_hashes/user32.md)
- [ ws2_32 ](https://github.com/ihack4falafel/ROR13HashGenerator/blob/master/pre_computed_hashes/ws2_32.md)
