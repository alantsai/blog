---

Title: "如何保留 GitHub Copilot Chat 的對話記錄 | GitHub Copilot 的小貼士"  
Published: 2024-07-22 19:00  
Modified: 2024-07-22 19:00  
Image: "/posts/2024/07/2024-07-22-github-copilot-tips-how-to-export-chat-session/240722-github-copilot-20240722190128-b9epxbv.png"  
Tags: [generative-ai, github-copilot, GitHub Copilot 的小貼士]  
Series: [GitHub Copilot 的小貼士]  
PostDescription: "在這篇文章中，我們將介紹如何備份和保留 GitHub Copilot Chat 的對話記錄。了解如何將對話匯出為 JSON 格式，並在 Visual Studio Code 中重現對話過程，或者將對話儲存為純文字以便分享和參考。這些實用的小貼士將幫助你更好地管理和分享你的開發過程，提升工作效率。"

---

​![240722-github-copilot](/posts/2024/07/2024-07-22-github-copilot-tips-how-to-export-chat-session/240722-github-copilot-20240722190128-b9epxbv.png "Cover Photo"){.img-responsive}​

在 GitHub Copilot 裡面需要透過對談的方式得到答案的時候，就會使用到 GitHub Copilot Chat

這時候我們就會發現，有些問法相對來說比較容易得到你想要的答案

如果想要把這個分享給其他人可以做？

這篇，簡單介紹一下備份 GitHub Copilot Chat 的做法

<!--more-->

## 問題描述

GitHub Copilot Chat 提供了一個 Chat 的界面讓我們可以針對我們的 Code 問它任何問題

相較於 ChatGPT 好處之一當然是可以用一些關鍵字（`#`​, `@`​ 等）讓我們可以快速參照到相關內容作為產生的一環，而==不需要複製/貼上==內容到問題的一部分

如果今天想要整理一系列的使用案例給別人參考，那這時候對話的過程就變得很重要

如何能夠把整個對話過程提供給大家呢？

舉個例子來說，下面我有一段用 GitHub Copilot Chat 來協助 Review SQL 的效能，假設今天要把整個對話過程給大家作為參考，可以如何做到？

​![透過 GitHub Copilot Chat 來 Review SQL 效能](/posts/2024/07/2024-07-22-github-copilot-tips-how-to-export-chat-session/image-20240722150422-71e546i.jpg "透過 GitHub Copilot Chat 來 Review SQL 效能"){.img-responsive}  
^^^ 透過 GitHub Copilot Chat 來 Review SQL 效能

## 做法

總共有兩個做法：

1. 匯出成為 JSON：把整個過程匯出，並且可以在 Visual Studio Code 中重現整個對話過程，甚至往下問問題
2. 儲存成為純文字：方便透過文字檔案就可以打開

|格式|優點|缺點|
| --------| ----------------------------------------------| ---------------------------------------------------|
|JSON|可以匯入 VS Code 並繼續對話|需要 VS Code 才能方便閱讀<br />可能會曝露一些內部訊息|
|純文字|可以用任何編輯器打開<br />沒有曝露其他資訊的風險|沒有 VS Code 的使用體驗|

### 匯出成為 JSON

1. 先把 Chat 切換到想要匯出的 Session
2. 透過 `ctrl+shift+p`​ 呼叫出 command palette，然後輸入：`export`​就會看到 `Chat:Export Session`​

    ​![VS Code 的 command palette 找到 Chat:Export Session](/posts/2024/07/2024-07-22-github-copilot-tips-how-to-export-chat-session/image-20240722150931-h2y5jm9.jpg "VS Code 的 command palette 找到 Chat:Export Session"){.img-responsive}  
    ^^^ VS Code 的 command palette 找到 Chat:Export Session
3. 點下去之後，就會問要儲存在那邊，預設檔名是 `chat.json`​

    ​![選擇儲存的位置](/posts/2024/07/2024-07-22-github-copilot-tips-how-to-export-chat-session/image-20240722151021-4b001b2.jpg "選擇儲存的位置"){.img-responsive}  
    ^^^ 選擇儲存的位置
4. 匯出之後，我們可以用一般編輯器打開，我們可以看到完整的 JSON 內容

    ​![chat.json 的內容](/posts/2024/07/2024-07-22-github-copilot-tips-how-to-export-chat-session/image-20240722151410-c1i9198.jpg "chat.json 的內容"){.img-responsive}  
    ^^^ chat.json 的內容

JSON 當然從人的角度來說不好閱讀

因此可以透過 Visual Studio Code 作為閱讀的工具，可以還原出原本的內容

1. 透過 `ctrl+shift+p`​ 呼叫出 command palette，然後輸入：`import`​就會看到 `Chat:Import Session`​
    ​![VS Code 的 command palette 找到 Chat: Import Session](/posts/2024/07/2024-07-22-github-copilot-tips-how-to-export-chat-session/image-20240722151550-sdecxt7.jpg "VS Code 的 command palette 找到 Chat: Import Session"){.img-responsive}  
    ^^^ VS Code 的 command palette 找到 Chat: Import Session
2. 選擇對應的 json 檔案
    ​![選擇要匯入的 json 檔案](/posts/2024/07/2024-07-22-github-copilot-tips-how-to-export-chat-session/image-20240722151632-gphpj2k.jpg "選擇要匯入的 json 檔案"){.img-responsive}  
    ^^^ 選擇要匯入的 json 檔案
3. 就可以看到原本的對話內容，甚至可以往下延伸詢問下去
    ​![匯入回來的結果](/posts/2024/07/2024-07-22-github-copilot-tips-how-to-export-chat-session/image-20240722151838-or8pu1l.jpg "匯入回來的結果"){.img-responsive}  
    ^^^ 匯入回來的結果

### 儲存成為純文字

JSON 的好處當然是可以還原成原本的樣子，但是缺點是需要有 VS Code 比較好閱讀

另外一個缺點就是 JSON 有些內部的細節不一定想要分享。這個時候純文字就比較方便

1. 在想要匯出的部分點選右鍵，然後選擇 `Copy All`​
    ​![在 GitHub Copilot Chat 點右鍵選擇 Copy All](/posts/2024/07/2024-07-22-github-copilot-tips-how-to-export-chat-session/image-20240722153003-g4z3k88.jpg "在 GitHub Copilot Chat 點右鍵選擇 Copy All"){.img-responsive}  
    ^^^ 在 GitHub Copilot Chat 點右鍵選擇 Copy All
2. 這時候開啟任意文字編輯器，譬如說 `notepad`​ ，把剛剛複製的東西貼上
    ​![貼到編輯器裡面](/posts/2024/07/2024-07-22-github-copilot-tips-how-to-export-chat-session/image-20240722153155-8hf0prs.jpg "貼到編輯器裡面"){.img-responsive}    
    ^^^ 貼到編輯器裡面
3. 最後就可以看到對話的結果
    ​![最後的成果](/posts/2024/07/2024-07-22-github-copilot-tips-how-to-export-chat-session/image-20240722153223-d3i3gqf.jpg "最後的成果"){.img-responsive}  
    ^^^ 最後的成果

## 結語

希望這篇文章對你有所幫助！你有其他備份 GitHub Copilot Chat 對話記錄的方法嗎？歡迎在下方留言分享你的經驗！

‍
