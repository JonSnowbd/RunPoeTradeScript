## What is this

A very simple gui that will launch TradeMacro when PathOfExile is on. And kill every AHK instance when it sees
Path of Exile is no longer open.

# How to use

Download it from [here](https://raw.githubusercontent.com/JonSnowbd/RunPoeTradeScript/master/dist/RunPoeTradeScript.exe) or build it yourself.

After you have downloaded it just [place it in your TradeMacro folder](https://i.imgur.com/wjH1knL.png), next to `Run_TradeMacro.ahk`.

And you're done! Just make sure you run the provided .exe instead of double clicking `Run_TradeMacro.ahk` 

## Security

https://www.virustotal.com/#/file/c7591a02dcd63304d3fc4171b75e7acac81bf80aa9d6584846c224ddddabaa4b/detection

Feel free to run the virustotal yourself as well to confirm

No sensitive information is relevant in any of the code. Detection of POE is a simple poll that does not
hook into the Process. In theory this is completely fine. I am not responsible for any harm done while this
script is running.

## Gotchas

When POE is closed, this will close every instance of AutoHotkey it can find.
