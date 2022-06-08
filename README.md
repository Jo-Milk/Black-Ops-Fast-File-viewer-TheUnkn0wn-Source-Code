# Black-Ops-Fast-File-viewer-TheUnkn0wn-Source-Code
Bo1 FF viewer Source code From [TheUnkn0wn] by Jo-Milk for PS3 Xbox 

Disclaimer: This Source Code is for educational purposes only. It hasn't been fully explored and it had a packed .dll runing anything from that source is at your own risk.

Please give credits to Unknown if you use his code. I was doing a FF viewer but I had an issue re-encrypting the zones. 
I wanted to use his code to import\export zones to save time. If modding on ps3\Xbox was alive I would have ask for his source. 
Unfortunately I don't know TheUnkn0wn and it took me 2 seconds to reverse his pack .dll and I intend to use. Once this thought went through I decided to use his designer too.
My goal is to implement more xAssets to the FF viewer and allow better extraction of individual file. My project will be released seperately without a source code because
my code is spaghetti. I been coding in C++ for a while and C# makes it worst haha.

Anyway his orginal FastFile executable was easily decompressed by winrar.
After I used dnspy to get the C# code hand basically all his source files since it's a .NET
Then had the most plesant message from FF32.dll that said: "EPIC FAIL! YOU MUST BE ONE DUMB FUCKER TO BE TRYING THAT... SO DUMB YOU HAVE TO RIP MY WORK? LOL!"

So unpacking was simple step through the code until the dll is unpacked dump if from memory find the entry and add two 'nop' to avoid that annoying message

Tool I used 
IDA OLLydbg peid PE Explorer ImportREC OllyDumpEx dnspy
Visual Studio 2010

Anyways give the guy credits 

Thread : https://www.modding-revived.com/threads/black-ops-fast-file-viewer-theunkn0wn-source-code.349/


Extra knowledge 

Salsa20 Black ops keys :

PS3 :  byte[] Key = { 0x46, 0xD3, 0xF9, 0x97, 0xF2, 0x9C, 0x9A, 0xCE, 0x17, 0x5B, 0x0D, 0xAE, 0x3A, 0xB8, 0xC0, 0xC1, 0xB8, 0xE4, 0x23, 0xE2, 0xE3, 0xBF, 0x7E, 0x3C, 0x31, 0x1E, 0xA3, 0x52, 0x45, 0xBF, 0x19, 0x3A };
Xbox 360 : byte[] Key = { 0x1a, 0xc1, 0xd1, 0x2d, 0x52, 0x7c, 0x59, 0xb4, 0x0e, 0xca, 0x61, 0x91, 0x20, 0xff, 0x82, 0x17, 0xcc, 0xff, 0x09, 0xcd, 0x16, 0x89, 0x6f, 0x81, 0xb8, 0x29, 0xc7, 0xf5, 0x27, 0x93, 0x40, 0x5d };

