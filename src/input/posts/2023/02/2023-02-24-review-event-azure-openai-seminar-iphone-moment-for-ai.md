Title: "微軟 Azure OpenAI Service Partner Workshop 筆記 - AI 時代的 iPhone 時刻 | 活動"  
Published: 2023-02-24 19:00  
Modified: 2023-02-24 19:00  
Image: "/posts/2023/02/2023-02-24-review-event-azure-openai-seminar-iphone-moment-for-ai/image-20230301183104-g1lw94j.png"  
Tags: [ 「活動」, OpenAI, AI, ChatGPT]  
Series: [「活動」]  
PostDescription: "本文探討了Azure和OpenAI的合作，以及AI技術在現實生活中的應用和未來發展趨勢。這篇文章分析了AI技術的實際效用，並展望了未來更廣泛應用的可能性，將對AI技術感興趣的讀者提供有價值的洞察。"

---

​![快開始的時候的人數。有些卡在樓下的電梯，所以實際上最後是幾乎全部坐滿](/posts/2023/02/2023-02-24-review-event-azure-openai-seminar-iphone-moment-for-ai/image-20230301183104-g1lw94j.png "快開始的時候的人數。有些卡在樓下的電梯，所以實際上最後是幾乎全部坐滿"){.img-responsive}
^^^ 快開始的時候的人數。有些卡在樓下的電梯，所以實際上最後是幾乎全部坐滿

微軟最近有場面對所有 Partner 的研討會，是關於目前最夯的在 Azure 上面的 OpenAI 服務（目前最火紅就是 ChatGPT 啦）。聽說一開放報名不到半天整個就爆滿，由此也可以看出這個議題有多熱

這次是有對 Microsoft MVP 保留名額，我就藉著這個機會報名並且參加了久違的線下研討會

這篇主要是把當天內容記錄一下，由於主辦單位目前還沒有釋放出投影片，所以怕踩到著作權問題就沒有把拍到的投影片放出來，我盡量用文字描述每一個我認為重要的點  
（這裡面有些內容不是研討會有談，有些是我自己的想法）

廢話不多說，來一起看看 NVIDIA 執行長黃仁勳說的：「AI的iPhone時刻來臨」指的是什麼

<!--more-->

## 活動資訊

這次活動的時間不長，大約是 14:00 ~ 16:30，主題大概可以區分為兩塊：

1. 微軟介紹
2. Partner 分享

​![活動議程 1](/posts/2023/02/2023-02-24-review-event-azure-openai-seminar-iphone-moment-for-ai/image-20230302064932-f8as2j6.png "活動議程 1"){.img-responsive}
^^^ 活動議程 1
![活動議程 2](/posts/2023/02/2023-02-24-review-event-azure-openai-seminar-iphone-moment-for-ai/image-20230302065008-9lm0pdy.png "活動議程 2"){.img-responsive}​
^^^ 活動議程 2

下面，我就針對我認為重要的地方和大家介紹一下，到底聽到了什麼。

## AI的iPhone時刻來臨

我們都知道（如果你夠老的話 XD），在 2007 年 iPhone 問世之前就已經有所謂的==智慧型裝置==。那時候還叫做 PDA (personal digital assistance)。我還記得那個時候微軟還有出所謂的 Compact Framework 目的就是讓開發 PDA 的應用程式很容易。

在當時，雖然大家都知道 PDA 是一個未來的趨勢，不過不知道為什麼一直火熱不起來。是，有一小撮的人有在使用，甚至當初我也想要買一個來玩看看開發（還好沒有 XD），但是直到了 iPhone 在 2007 年的問世，直接打破了 PDA 並且迅速的成為了主流。

回到我們的現況，在近幾年因為雲和大數據的普及，AI 也開始變成了一門顯學。從一開始需要懂的比較多，到後面很多可以自動化的角度去建立模型，使用 AI 的成本越來越低了，雖然一直會聽到可以用 AI 來增加生產率，但是一直==沒有一個爆點==，直到了現在。

台灣微軟總經理 Sean 也用真實案例反映了這件事。

依照之前的經驗，當微軟有個什麼 Solution 想要推出的時候，都是需要去和 Partner 或者客戶==主動聯繫==看是不是需要做 PoC 或者幫評估帶來的效益是什麼。

但是，Azure 的 OpenAI 服務完全是顛倒過來，是 Partner 或者客戶==主動來詢問==想用這個東西，可以怎麼用。

Azure OpenAI 的服務在 2月 GA，不過是需要申請才可以使用：

1. 全球已經有 10K 以上的客戶有申請要使用
2. 台灣有 50 家以上的客戶有申請要使用

這個量是微軟以前其他 Azure 服務看不到的申請量體

這次研討會的邀請，不到半天就爆滿也無形中的側面了反映這件事

這個告訴我們：

> AI的iPhone時刻來臨
>
> --NVIDIA 執行長黃仁勳

‍

## OpenAI、Azure OpenAI 服務、GPT、ChatGPT、傻傻分不清楚

先簡單說明一下幾個可能容易搞混的資訊：

OpenAI  
:    OpenAI 是一家專門研究 AI 的組織。微軟有提供很多底層服務給這家組織使用。GPT 是其中一個訓練出來的 AI 模型。除了 GPT 之外還有很多其他模型

Azure OpenAI  
:    由微軟提供跑在在 Azure 上面由 OpenAI 訓練出來的模型變成一個==企業等級==的服務。也是目前市面上唯一提供企業等級的 OpenAI 服務

GPT  
:    由 OpenAI 訓練出來的 NLG (Natural Language Generation) 的 AI 模型。目前最新版本是 GPT 3.5

ChatGPT  
:    透過 Conversational AI（或者俗稱的 chat、聊天機器人）的界面整合 GPT 3.5 模型來回答人們的問題。所以他是一個用 GPT 3.5 的 solution

微軟提供的 OpenAI 服務和 OpenAI 這家公司提供的服務雖然底層都是用一樣的模型，但是差別在於微軟是==企業等級的服務==，而 OpenAI 也有提供服務，不過他們是以偏==學術研究==性質的服務。

意思是，微軟的 Azure OpenAI：

1. 高資安規格 - OpenAI 不太可能和 Cognitive Service 一樣提供 Container 可以在地端跑的版本。但是可以透過整合 Virtual Network Private Endpoint 來達到走私有通道  
2. 高可用 - 由微軟的 Azure 作為底層，提供 99.9% SLA 等級的服務
3. 微軟保證不會使用客戶的資料
    1. 資料隱私權規範和整個 Azure 對客戶資料的使用保證是一樣
    2. 如果有微調模型 - 例如 Fine Tune 的資料不會被拿去
    3. 微軟很在乎所謂的 Responsible AI，因此有人工審核流程確保模型不會被訓練壞掉
        1. 如果不想要有人工審核，可以單獨申請關閉

其他幾個和 GPT 有關的資訊

* GPT 是由 1700 億個參數 (parameters) 訓練出來的模型
* 目前訓練的內容涵蓋 2021/06
* 大約是 9 歲小孩的智商

OpenAI 訓練了什麼類型的模型：

1. GPT - 文字 NLG 類型的模型
2. Codex - 程式碼產生類型的模型
3. DALL·E - 圖像產生類型的模型

## GPT 為什麼是 AI 界的 iPhone 時刻 - 可以和什麼整合

微軟本來就有所謂的 Cognitive Service（[之前有個系列在介紹這些服務](/tags/cognitive-service)），和 GPT 最大的不同在於，之前這些服務都是偏識別或者理解（Understanding）裡面的內容

理解內容之後，程式可以在==依照設定好==的內容來決定==應該發生什麼事==

這代表，需要時常更新才有辦法回應最新的內容

GPT 的差別是重點在產生（Generate），所以搭配起來就可以有很多應用

1. Speech to text 服務把語音轉成文字之後，透過 GPT 把會議總結、後續 Action 整理出來
2. Form Recognizer OCR 發票，透過 GPT 把發票性質整理出來

現在有很多這種真實應用的例子：

1. 虛擬主播 - 透過 GPT 把重點總結，然後文字轉語音讓虛擬主播報出來  
2. 遊戲世界 - 可以因為玩家的行為，==動態==由 GPT 生成對應內容，讓 NPC 文字不再是一成不變  
3. 把 Low code 變成 no code - 用文字方式描述要達到的效果，由模型自動產生出 Excel 的函數  

‍

## GPT 的主要概念

#### 幾個術語

Prompt 提示  
:    可以理解成為 input 到 model 的內容。主要為模型 (引擎) 提供上下文。如果提供的不夠明確，會容易導致無法給出有用的回應

Completion 完成回應  
:    可以理解成為 model 的 output 內容

Tokens 組成文字的最小積木  
:    會把文字先轉換成為 Token 之後作為運算內容  
1. 1 token ~= 4 英文字符。1 token ~= 3/4 單詞  
2. 100 token ~= 75 單詞  
3. 1 ~ 2 句子  ~= 30 token  
4. 1 文段 ~= 100 token

Fine-tuning  
:    把模型在訓練的意思。讓模型更適合某個情境或者領域 (domain)。reinforcement learning 的概念

Prompt Design  
:    在 Fine tuning 的過程中依照情境或者領域來設計 prompt 讓模型更貼近應用

Prompt Engineering  
:    怎麼下對的 prompt 讓 GPT 可以回覆出有幫助的內容

#### 模型類型以及挑選方式

GPT 總共有 4 個模型版本：

1. Ada
2. Babbage
3. Curie
4. Davinci

以上從上到下代表的是從最小、最便宜到最大、最貴的順序

==模型並不是越新或者越大就越好==

怎麼挑選模型：

1. 如果有大量優質的數據，建議低複雜度的模型（因為可以 fine tuning）
2. 如果是分類/歸納這類相對簡單認為，建議 A 類型

Fine Tuning 的部分：

1. 可以先從 Davinci 開始作為一個 baseline
2. 透過 fine tuning 其他 3 個模型版本，然後用 baseline 作為驗證讓費用越來越便宜

## Azure OpenAI 相關注意事項

1. 費用計算方式：  
    `(月活躍用戶數 MAU * 用戶平均耗字數 * Token 倍率) + 每月 Fine-Tune 時長 + 模型 hosting 時長`  
    （和 OpenAI 的計算方式不同。Token 倍率英文可以抓 1.33 不過中文就要去試看看）
2. 和 OpenAI 的 Model 版本是否會同步  
    會跟大版號。  
    目前有兩周的落差，不過未來期望不會有落差。
3. Fine Tuning 很吃情境和 case，所以沒有什麼特別的 Best practise
4. 服務產生出來的版權是屬於誰的？  
    和 Word Excel 一樣，Azure OpenAI 只是工具，產生出來的版權屬於製造者  

​

## 怎麼開始

1. 微軟的 Azure OpenAI 目前雖然 GA，但是要申請通過之後才能夠使用，所以可能有需要等的時間，因此建議可以先從 [OpenAI ](https://openai.com/blog/openai-api)開始
2. Azure OpenAI 提供的 API 規格和 OpenAI 會是一樣的，因此可以先從 OpenAI 作為學習的入門點，然後熟悉之後，要做 solution 的時候，在[申請 Azure OpenAI](https://customervoice.microsoft.com/Pages/ResponsePage.aspx?id=v4j5cvGGr0GRqy180BHbR7en2Ais5pxKtso_Pz4b1_xUOFA5Qk1UWDRBMjg0WFhPMkIzTzhKQ1dWNyQlQCN0PWcu)

## 微軟相關應用分享

1. [Teams premium](https://www.microsoft.com/en-us/microsoft-teams/premium) 預計是 4 月才有更詳細消息 - 能夠把會議整合出來重點 summary、action、跳到重點片段  
2. 整合 Power Apps 讓 Low code 變成 no code - 自然語言產生出需要用什麼函數  
3. 整合 Power Automate 把行為自動化或者 RPA 達到生產力提供  

## Partner 的部分

### Deep Insight - 個人化行銷的應用

傳統來說是透過人工的角度去把消費者分群，並且想辦法發出針對性的廣告行銷來促成消費者來購買。能夠分 3~4 群就很了不起，但是如果真的要做到個人化，這個其實還有很多可以加強的部分。所以傳統來說可以增加人力來達成。

但是，如果今天想要不增加行銷或者相關人員就可以快速產生出相關行銷內容怎麼辦？

更甚至，如果我可以針對每一個客戶都發出對應的個人化行銷那麼是否更容易提供轉換率？

Deep Insight 就是透過 GPT 整合演算法來達到個人化行銷


### 碩網

主要在整合應用：

1. 代替訓練的資料換句話說 - 譬如說換語氣，或者換表達方式  
2. 沒有答案的時候，給一個 general 但是又不是那麼 general 的答案  
3. 提供答案的建議 - 類似於 QnA Maker 的概念
4. 改善答案的口語程度
5. 多語係的應用，翻譯文字 - 類似於 Speech Translate
6. 用問句產生報表 - 用自然語言就可以產生出要的效果

### Aiello - 透過語音的方式來提供更好的服務

兩個產品：

1. AVA - 大部分使用在 Hotel。當 call 客房服務的時候，可以因為內容以及環境的情境分析，提供更好的服務給客人。  
2. Vocol - 還沒上市，主要是把語音的內容整合在一起在一個平台能夠了解整個電話的過程達到變成一個集中以及整合的平台。所以會錄音、整理內容變成會議記錄、變成 todo，可以 keyword 查詢，可以從文字對應到那個語音的片段

‍
