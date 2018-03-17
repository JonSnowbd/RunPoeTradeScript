## What is this

A very simple gui that will launch TradeMacro when PathOfExile is on. And kill every AHK instance when it sees
Path of Exile is no longer open.

# How to use

Download it from [here](https://raw.githubusercontent.com/JonSnowbd/RunPoeTradeScript/master/dist/StartPoETrade.exe) or build it yourself.

After you have downloaded it just [place it in your TradeMacro folder](https://i.imgur.com/wjH1knL.png), next to `Run_TradeMacro.ahk`.

And you're done! Just make sure you run the provided .exe instead of double clicking `Run_TradeMacro.ahk` 

## Security

https://www.virustotal.com/#/file/6a20a87cab1774b3104d5a3055b7495e53ef2338d7cf3fec7095f4dd148bacdc/detection

Feel free to run the virustotal yourself as well to confirm

No sensitive information is relevant in any of the code. Detection of POE is a simple poll that does not
hook into the Process. In theory this is completely fine. I am not responsible for any harm done while this
script is running.

The code is very simple and about 40 LOC, all of it [found here](https://github.com/JonSnowbd/RunPoeTradeScript/blob/master/Finder.cs)

## Gotchas

When POE is closed, this will close every instance of AutoHotkey it can find.