---
title: "回顧一下 .NET Conf Taiwan 2023 提到的 Generative AI 的衝擊和應對準備"  
Published: 2024-02-03 19:00  
Modified: 2024-02-03 19:00  
Tags: [generative-ai, semantic-kernel]  
---
不知不覺距離上次的 .NET Conf Taiwan 2023 已經經歷了將近 2 個月了

這 2 個月以來 Generative AI 這個領域發展的速度一如既往的快速，並且 ChatGPT 剛好也進入 1 週年

想要藉著這個機會整理一下 .NET Conf Taiwan 2023 談的內容，以及如果想要準備好面對這個 Generative AI 的浪潮可以做什麼準備

<!--more-->

## Generative AI 含義是什麼？

Generative AI（生成式 AI）想必大家都不陌生 （畢竟被轟炸了 1 年）

一言蔽之，就是我們透過自然語言的方式讓 Large Language Model (LLM) 幫我們產生/生成出內容。不管是要生成文字、圖片還是程式碼都難不到它

所以，只要任何的應用程式透過 LLM 產生出內容都可以稱之為 Generative AI Application

目前成功的 Generative AI Application 有：

1. ChatGPT - 背後透過使用 OpenAI 的 GPT 模型，透過用 Chat 的方式來和使用者互動，達到解決一般性問題
2. GitHub Copilot - 背後透過使用 OpenAI 的 GPT 模型，透過整合到 Editor/IDE 的方式，來解決工程師在寫 Code 的過程遇到的問題

效益不用說，在去年上半年經過 ChatGPT 的應用轟炸，相信大家對於他的幫助深有體會，從會議記錄整理，到學習東西的溝通，全部都難不倒他，只有要注意他的方向對不對，以及有沒有胡說八道而已 XD

到了 GitHub Copilot 更不用說太多的調查顯示不止加速開發、品質更好並且可以讓大家技能提升

​![永豐銀行的案例分享](/posts/2024/02/2024-02-03-review-net-conf-taiwan-2023-github-copilot-generative-ai-semantic-kernel/image-20240207082916-wen0ycs.png "永豐銀行的案例分享"){.img-responsive}

Generative AI 相較於以往任何的技術、功法、軟體等都不一樣，大家使用起來的提升是非常顯著，就算沒有真的深入了解，只要把它當成一個==不懂得思考但是很會做事==的同事，只要把要做什麼明確告訴他，他就可以幫你完成最少 70~80%，同等於節省掉了非常大量時間

這個和以往任何都不一樣，以往都是要從概念發酵到實作導入，往往都是以==年==為單位來計算。隨便舉例，Cloud Skill，或者 DevOps 花了多少時間才到目前我們現在這種算人人都認可的做法。從認可到實際應用又要過了多久。而 ChatGPT 以及 GitHub Copilot 花了不到 1 年的時間基本上霸榜了所有東西

​![相信大家都看過這個梗圖 ChatGPT 或者 GitHub Copilot 就是那麼神，是服務什麼時候可以買的問題，而不是為什麼要花多少錢的問題](/posts/2024/02/2024-02-03-review-net-conf-taiwan-2023-github-copilot-generative-ai-semantic-kernel/image-20240207083411-nakv7n6.png "相信大家都看過這個梗圖 ChatGPT 或者 GitHub Copilot 就是那麼神，是服務什麼時候可以買的問題，而不是為什麼要花多少錢的問題"){.img-responsive}

以我和企業做交流的結論來說，也是在於怎麼可以用好，而不是該不該花錢買的這件事。

在去年下半年跑了不同產業並且培訓近 800 人次的不同的反饋來說，我認為最具代表性就是，下面那句話：

​![公司可以買github copilot給開發者使用嗎](/posts/2024/02/2024-02-03-review-net-conf-taiwan-2023-github-copilot-generative-ai-semantic-kernel/image-20240207083933-5yxxe3c.png "公司可以買github copilot給開發者使用嗎"){.img-responsive}

所以 Generative AI 已經讓整個世界進入了另外一個領域，並且目前這個領域屬於一個大家都不能夠肯定什麼叫對的時候

那我們作為生化在這個當下的人，應該可以先做什麼來準備好自己搭上這個浪潮？

就像小米創辦人雷軍說的「站在風口上，豬都會飛」，不藉著這個機會把自己準備好要等到什麼時候？

在目前這個當下，有兩個層面的問題是作為工程師可以加強：

1. 怎麼會用 Generative AI Application?
2. 怎麼會用 LLM 來開發出 Generative AI Application？

## 怎麼會用 Generative AI Application?

10 年前，我們會說要懂雲（Cloud Computing）的概念，因為雲的出現，很多的工作模式會變換

10 年後，已經很少人會說雲不重要，因為它是一切的基礎。變成有點像水和電，你不會感覺他的重要性，直到台電或台水說要停電或停水，這時候我們才會發現有多不方便

那今天我們要會的是什麼？

答案很簡單怎麼用好 Generative AI。更準確一點說怎麼用好 Generative AI 的 Application 來完成你的日常

當以前會議記錄要 1 小時可以整理好，現在會議開完不到 5 分鐘就可以條例清楚並格式都符合公司規範，這個效益提升是非常巨大

到工程師的世界，我認為會進入一個一人成軍的年代

​![1 位工程師透過 Generative AI Application 在不到 1 天就把 Angry Bird 翻版變成 Angry Pumpkin](/posts/2024/02/2024-02-03-review-net-conf-taiwan-2023-github-copilot-generative-ai-semantic-kernel/image-20240207084916-zqtar97.png "1 位工程師透過 Generative AI Application 在不到 1 天就把 Angry Bird 翻版變成 Angry Pumpkin"){.img-responsive}

Junior 工程師的門檻會變低，因為要懂怎麼寫 Code 不在困難

Senior 工程師的工作形態會有變化，因為他會變成只需要會==指導== Generative AI Application 去做事就對了

因此，Senior 的經驗和判斷能力變的更重要，因為他要能夠正確的==指導== Generative AI Application 怎麼做叫做對，以及當 Generative AI Application 胡說八道的時候，==要能夠識別的出來==

而指導的方式就是我們常常戲稱的下咒語，Prompt Engineering

​![Prompt Engineering - Example 的技巧](/posts/2024/02/2024-02-03-review-net-conf-taiwan-2023-github-copilot-generative-ai-semantic-kernel/image-20240207085519-bjrnweb.png "Prompt Engineering - Example 的技巧"){.img-responsive}

一個好的 Generative AI Application 應該==不需要使用者==需要懂 Prompt Engineering 的技巧就可以完成想做的事情

Prompt Engineering 應該是要整合在 Application 裡面

這個部分 GitHub Copilot 做的就很好，在不了解太多 Prompt Engineering 的情況下他的幫助就非常大

但是，如果你懂更多技巧，那麼讓他運作更好的機會更大

Generative AI 的 Application 某種程度上和你要交辦工作請人處理是一樣的道理

今天你給的描述夠精準，請人完成的幾率就越高

因此你的溝通技巧越好（Prompt Engineering），那麼你請的人（Generative AI Application 或者說 LLM 模型）完成==符合你預期==的機會就越大

所以，從用的角度來說，請把 Generative AI Application 當成是一個==技術能力很好，但是不會思考的工程師==

同樣一個模糊的描述，在某天它心情好，就會幫你多想給的答案可能更圓滿，但是它心情不好就可能不會想那麼多

那業界目前面對不怎麼思考的工程師或者比較資淺的工程師是怎麼解決這種問題呢？

敏捷開發重要的會議之一就是 Planning，其中就有一個概念就是 Definition of Done (DoD)，如果今天 DoD 模糊，資深的工程師會知道要問清楚，資淺的工程師可能埋頭就下去做後面才發生問題

會發現和使用 Generative AI Application 一模一樣。寫的清楚，它歪掉的幾率就會下降，但是還有可能歪掉，那就是適時的提醒它忘記了什麼和漏掉了什麼

總結來說：

1. 把它當成很會做事，但是不會思考的人。如果請他做事會怎麼描述避免他不思考而漏掉
2. 使用越標準的東西越好。因為越標準代表用的人越多，它就越容易理解你在說什麼

## 怎麼會用 LLM 來開發出 Generative AI Application？

會用 Generative AI Application 是為了加速開發，那作為工程師要怎麼開發 Generative AI Application 呢？

1. 結構和框架 - Copilot 和 Semantic Kernel
2. 標準化是關鍵 - API 好不好變得更加重要
3. 與傳統軟體開發的不同

### 結構和框架 - Copilot 和 Semantic Kernel

Generative AI Application 的核心能力來自於 LLM 的 Model，而 Model 訓練起來費用成本非常高

那假設今天想產生出來的內容要依據公司規範，或者某些資料那怎麼辦，因此就有所謂的 4 種模式：

​![使用 LLM 模型的 4 種模式](/posts/2024/02/2024-02-03-review-net-conf-taiwan-2023-github-copilot-generative-ai-semantic-kernel/image-20240207091653-e9w0d8f.png "使用 LLM 模型的 4 種模式"){.img-responsive}

對我們工程師來說，Prompt Engineering 和 Retrieval Augemented Generation (RAG) 是可以下手的地方

Fine Tune 和 Train Model 更偏資料科學一點

那如果我們想做到可以怎麼做？

​![GitHub 提出的 LLM 架構](/posts/2024/02/2024-02-03-review-net-conf-taiwan-2023-github-copilot-generative-ai-semantic-kernel/image-20240207091834-zox2g4z.png "GitHub 提出的 LLM 架構"){.img-responsive}

微軟更進一步的佈局並且把這種 Generative AI Application 統稱為 Copilot

​![What is Copilot](/posts/2024/02/2024-02-03-review-net-conf-taiwan-2023-github-copilot-generative-ai-semantic-kernel/image-20240207091937-9qr33s2.png "What is Copilot"){.img-responsive}

重點就兩個：

1. 使用 LLM 模型
2. 整合到應用 => 因此更多看到會是用 Chat 的形式

Chat 形式我就不多談，在 2018 年就談過 Conventional AI (Chat) 是所謂的下一代的操作體驗，讓我們從==需要知道如何操==作來完成我們的需求，到==只需要描述需求==和不用在意過程如何執行的一個體感上的差異（有興趣可以參考：[[chatbot + AI = 下一代操作模式][01]開篇 - CaaP是什麽，爲什麽應該學](/posts/2018/07/bot-framework-with-ai-cognitive-service-1-introduction-what-is-caap-why-learn-bot-framework-and-cognitives-service)）

‍

怎麼更好的使用 LLM 模型並且容易重複使用 Prompt Engineering 以及 RAG 作出好的 Generative AI Application？

​![image](/posts/2024/02/2024-02-03-review-net-conf-taiwan-2023-github-copilot-generative-ai-semantic-kernel/image-20240207095623-29x03mk.png "微軟提出的是會需要一個 AI Orchestrator"){.img-responsive}

這個 AI Orchestrator 在微軟的 Solution 就是 [Semantic Kernel](https://learn.microsoft.com/semantic-kernel/overview/?WT.mc_id=AZ-MVP-5003856)。簡單理解就微軟體系對標到 [LangChain](https://www.langchain.com/) 的同一個 Level 的框架

AI Orchestrator 簡單來說就是串聯 LLM Model 和 Application 之間的橋樑。當使用者問了一個問題，很有可能是好幾個 Plugin （簡單可以理解為能夠重複使用的 Prompt Engineering 和 RAG 的模組）組合在一起做回答

​![image](/posts/2024/02/2024-02-03-review-net-conf-taiwan-2023-github-copilot-generative-ai-semantic-kernel/image-20240207101522-k4x9bhz.png "使用想做到的事情是透過 ShortPoem 和 StoryGen 兩個 Plugin 組合的結果"){.img-responsive}

AI Orchestrator 充當了組裝的角色

Semantic Kernel 也迎來了 1.0 的版本，換句話說，開始從概念變成一個更加有機會使用的東西 （但是還是要提醒，目前還是非常前期的階段，因此很多東西因為有重新命名等原因不一定已經那調整好了）

現在入場學習我認為是一個好的時機，因為 AI Orchestrator 的概念我認為是 Generative AI Application 會需要，至於用什麼就是看技術的選型問題而已

在加上目前文件相對來說有比較完整一點點

但是，還是要提醒，目前還很前期，請預期容易撞墻、文章資訊太舊以及新舊名稱摻雜在一起的狀況

‍

### 標準化是關鍵 - API 好不好變得更加重要

API 重要性不必說，但是當 Generative AI Application 進來之後，這件事會被放大的更加重要

現在大部分的應用都需要串接一些其他服務才能把碎片內容變成一個使用者好用的資訊

當 Generative AI Application 進來之後，由於它可以幫你呼叫 API，這時候 API 開的好不好就很重要

開的不好的 API，有可能會因此導致你的資料狀態錯誤以及它呼叫的時候錯誤 
（這個的詳細可以看參考資料裡面 Andrew 那篇有更完整闡述，以及後面會有另外一篇重新 review 一下 .NET Conf 2023 Taiwan 的 API 場次）

另外一個和標準化有關是開發的習慣

LLM 模型是透過既有 Open Source 內容訓練出來，因此當你的風格和業界標準越一樣，LLM 可以提供的幫助和內容就越大

### 與傳統軟體開發的不同

‍

最後是 Generative AI 的 Application 模式會和既有軟體開發的模式有很大的不同

以現階段來說（要強調是現階段），整個 LLM 的運作就像是一個黑箱

因此，我稱之為：

​![image](/posts/2024/02/2024-02-03-review-net-conf-taiwan-2023-github-copilot-generative-ai-semantic-kernel/image-20240207085612-03ru83p.png "Prompt Engineering 是一門玄學"){.img-responsive}

這個和我們傳統在開發軟體完全不同在於，傳統軟體是可被預測。你輸入 A 得到 1。不管執行幾次，結果都會一樣，如果不一樣就是 bug

但是，Generative AI Application 是不可預測，也就是說看 LLM 的心情，同一個 Prompt 對同一個 LLM 的 Model，在同一個時間（精準一點說很難做到完全同一個時間）可能會得到不同的結果

整件事就像是一個黑箱，是透過 Trial 和 Error 在開發。因此怎麼精準（或者相對精準控制）就變得很重要啦

如果要類比，我認為和請人做事是一樣的道理

同樣的指令（Prompt）給不同的人（LLM Model）被解讀出來會不一樣

因此，怎麼樣有效率以及有品質的下答指令，讓別人把事情做的如你預期，就是個人技巧問題

（大家有沒有開始發現，從技術問題變成溝通題 XD）

## 工商服務

最後，讓我工商服務一下

針對我們提到的兩個所需要的技能：

1. 怎麼可以用的好 GitHub Copilot 來達到程式碼開發的加速以及品質提升
2. 怎麼可以準備往開發自己的 Copilot 之路

這兩個主題目前有和 Tibame 合作有個直播課程：[GitHub Copilot AI賦能開發實戰訓練班](https://to.alantsai.net/c-github-copilot)

剛好這個時間點第一期已經結束，很感謝有參與的人有給了一些反饋

整體來說，這門是一個入門的課程。假設沒接觸過 Generative AI，沒用過 GitHub Copilot 效果會是最好，重點在於幫大家把路鋪好，要在往下鑽研至少不會被基礎概念卡住

​![很高興大部分的人都有因為課程而得到成長](/posts/2024/02/2024-02-03-review-net-conf-taiwan-2023-github-copilot-generative-ai-semantic-kernel/image-20240207144248-gg5u23w.png "很高興大部分的人都有因為課程而得到成長"){.img-responsive}

## 結語

零零總總說了一大堆，其實結論很簡單

要把 Generative AI 的 Application 用的好，把它當成一個不會思考但是能力很強的人。你做思考，他幫你做執行面

當到了這個程度，執行就是語法（Syntax）而已，重點是想要做什麼的那個意義（Semantic）

​![Schilace Laws](/posts/2024/02/2024-02-03-review-net-conf-taiwan-2023-github-copilot-generative-ai-semantic-kernel/image-20240207145146-3wbsfl3.png "Schilace Laws"){.img-responsive}

## 參考資料

1. [[架構師觀點] 開發人員該如何看待 AI 帶來的改變?](https://columns.chicken-house.net/2024/01/15/archview-llm/) | 安德魯的部落格

    1. Andrew 把 Generative AI 剖析的很清楚，其實看那篇就好了，我這篇根本不用看 XD
2. Semantic Kernel

    1. [What is Semantic Kernel?](https://learn.microsoft.com/en-us/semantic-kernel/overview/?WT.mc_id=AZ-MVP-5003856)  => 官方的參考資料
    2. [GitHub Repo](https://github.com/microsoft/semantic-kernel?WT.mc_id=AZ-MVP-5003856) => 有滿多 sample 和原始碼可以參考
3. [從 GitHub Copilot 到 Enterprise Copilot：打造符合企業需求的智能開發助手之路](https://www.slideshare.net/alantsai2007/github-copilot-enterprise-copilot-net-conf-2023-taiwan?fbclid=IwAR0lEpAr8TnTnk8j62DnyH_lINdQI2MATmdTalmFP86Lsvcxnd2NbSCQUOk) => .NET Conf Taiwan 2023 的簡報
4. [微軟的 Generative AI for Beginners](https://microsoft.github.io/generative-ai-for-beginners/?WT.mc_id=AZ-MVP-5003856&fbclid=IwAR0WN3pFWReLC1xgLZaWpLzj3gHjRNiO6s8PWdxmxr89dc-D7M2iFiZrClU#/)
5. [Google 的 Google Cloud 培訓計劃第四季：GenAI 特別篇](https://rsvp.withgoogle.com/events/csj-tw-s4?fbclid=IwAR1XPFXhKSUjZTncluw6dlzpXIyWOhuSRpvw2tPUZ1Vh_62dCP1hdcwT9jk)
6. [AWS 的 AI就緒計畫](https://aws.amazon.com/tw/events/taiwan/news/ai-ready/?fbclid=IwAR2zyohEHHY6D-OE1LuSf2JsW-k9scs7WrppVrRX5uSAt6VbZbjm3_SMeOE)

‍
