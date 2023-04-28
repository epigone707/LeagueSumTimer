# 707FlashTimer
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

707FlashTimer is an in-game overlay Flash cooldown timer for popular game League of Legends. The app is approved by Riot and safe to use.

[中文介绍](#应用介绍)

## Screenshot
![DEMO!](assets/demo.png "DEMO")

![DEMO!](assets/demo_chat.png "DEMOchat")

## In-game Demo

[Demo](https://youtu.be/L2pIBS5HBS0)

## Features 

- It doesn't use riot API. It doesn't automatically detect anything. It requires user to click on the button to start the flash cooldown timers. 

- There're 3 buttons that can start the flash timer for each enemy. Click the "flash icon" means this enemy just used flash. Button "-10s" and"-30s" means this enemy used flash 10/30 seconds ago. 

- Flash Expert: There're 2 checkboxes for each enemy that refers to the rune "Cosmic Insight" and the item "Ionion Boots of Lucidity". If user checks one or two of those checkboxes, the corresponding enemy's timer will be adjusted to correct cooldown value.

- Easy Print: Open the chatbox and click "F2" to print the flash cooldown info to team chatbox. e.g.，"flash: top 298s; bot 269s; "

- Hide/Show: click "F1" to hide/show the window. 


**You need to set the display mode of League of Legend Client to be `borderless` instead of `full screen`, otherwise everytime you click "F1", you will be forced back to the desktop.**

## Changelog 
- 2022/8/22 
Completed version1.0. Submitted the app to riot. Waiting for response.
- 2022/9/2
The app is approved by Riot. The next step is to do the in-game testing.
- 2022/9/6
Version 1.0.1 released. Submitted the app to [Microsoft Malware Analysis](https://www.microsoft.com/en-us/wdsi/filesubmission).

# 应用介绍

707FlashTimer是为英雄联盟设计的闪现技能计时器。它将在游戏内覆盖显示，可以用快捷键快速隐藏或显示窗口。

## 功能

- 本应用不使用拳头API。它不会自动识别任何游戏物件。它需要用户点击按钮生效。

- 每一个敌人都有一个闪现计时器。

- 对于每个敌人，有三个按钮可以让闪现计时器开始计时。按钮1 (闪现图标) 表示这名敌人刚刚使用了闪现。按钮2 "-10s" 表示这名敌人10秒前使用了闪现。按钮3 "-30s" 表示这名敌人30秒前使用了闪现。

- 对于每个敌人，有两个勾选框，分别代表 符文 “星界洞悉” 和 装备 “明朗之靴（CD鞋）”。 用户勾选对应的勾选框后，本应用将缩短对应敌人的闪现总CD时间，来保证不会出现错误的计时。

- 打开聊天框按下"F1"，可将计时信息发送给队友。例如，"flash: top 298s; bot 269s; "

- 按下“F1”快捷键，可快速隐藏/显示应用。

**注意：请将英雄联盟客户端显示模式设置成“无边框”。如果使用“全屏”显示模式，当你按下“F1”快捷键时会被强制返回桌面**

## 更新日志
- 2022/8/22 
完成1.0版本。已将应用提交给拳头官方审核。等待回复。
- 2022/9/2
已通过拳头官方审核。下一步是游戏内测试。
- 2022/9/6
发布1.0.1版本。由于windows默认阻止很烦，已提交给微软审核。
