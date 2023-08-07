Title: "2022 .NET Conf Taiwan 記錄 - 談 Event Driven Architecture 之前，是不是該把 Event 規格搞定？ CloudEvents 是什麼？| 活動"  
Published: 2022-12-17 19:00  
Modified: 2022-12-17 19:00  
Image: "/posts/2022/12/2022-12-17-event-net-conf-2022-taiwan-lets-talk-about-standardize-event-using-cloudevents-before-talk-about-eda/image-20230318125358-vlc6j5v.png"  
Tags: [ azure, 「活動」]  
Series: [「活動」]  
PostDescription: "一年一度台灣社群在 .NET 領域最大的活動又開始了。在 2022 的 .NET Conf Taiwan 小弟我也有分享 + 協助舉辦活動。這篇來看一下分享了什麼以及一些活動花絮"

---

​![image](/posts/2022/12/2022-12-17-event-net-conf-2022-taiwan-lets-talk-about-standardize-event-using-cloudevents-before-talk-about-eda/image-20230318125358-vlc6j5v.png "https://www.youtube.com/watch?v=ejI9Y3YLQeU"){.img-responsive}{.img-responsive}

一年一度台灣社群最大的 .NET 相關活動又來了

和前幾年一樣，也是協力主辦和講師的身份參與到活動

在這篇分兩個部分，一個部分是這次分享的主題，另外一個則是協助的一些小插曲

<!--more-->

## 為什麼要講這個主題

就像一個鄉鎮要富裕起來，第一件事一定是修路。修路這件事隱含的是把==通訊==這個渠道打通，只有通訊順暢了才有更多的機會和可能

同樣道理，當我們要把架構從 Monolithic 改成 Microservice 的時候，遇到的第一個問題也是==通訊==

以前，全部都放在一起當然沒有什麼通訊問題，但是當每個領域切開之後，怎麼有效的互相溝通就變得非常重要

通訊廣義一點來說有可以區分為：

1. Synchronous （同步） - 例如透過 API 溝通
2. Asynchronous （非同步）- 例如透過 Event 或者 Message

我這邊主題是 Event，那 Event 的第一步是什麼？

> 很剛好，我前面的兩場分別有兩位大大在介紹 API 和讓呼叫 API 變得簡單的 SDK 大家可以參考。

很多人會想說，就是開始研究要用什麼 Event 服務，或者要用什麼架構把它們組合在一起

這些都對，也都很重要，不過我認為最重要的是你的==服務要有哪些 Event==？

這件事沒有想象中的簡單，訂太大包會導致 Event 傳輸不利，訂太小包會導致後續的人要用不好用

這個和開 Database 的 Table Schema 是一樣的道理，怎麼開出一個合理，然後符合業界標準的規格很重要

所以，就延伸出，那我的 Event 規格應該長成什麼樣子的問題

### 什麼是業界標準？CloudEvents

業界標準的目的是當不知道應該長什麼樣子的時候，有個基底可以讓我們遵循。這樣至少當需要和外界溝通的時候，會比較容易

就像是 Design Pattern 一樣，不管實作的是什麼，只要說這個是 xxx pattern 大家就很容易理解

不管有沒有遵循某個業界標準，最重要的是一定要一致

​![image](/posts/2022/12/2022-12-17-event-net-conf-2022-taiwan-lets-talk-about-standardize-event-using-cloudevents-before-talk-about-eda/image-20230318171632-1kaq23i.png "如果文字不統一，溝通成本就會非常大"){.img-responsive}{.img-responsive}

當進入到 Microservices 的時候，理論上每個系統想怎麼做是那個團隊要負責，但是真的溝通的時候，每個團隊的 Event 都應該要有==一致的風格==

當思考 Event 的時候需要考慮到：

1. 資料格式要支援什麼？

    1. 什麼欄位是一件事，要用 CSV、XML 還是 JSON？
2. 通訊協議要支援什麼？

    1. 除了常見的 HTTP，是否需要支援 AMQP 還是 MQTT

假設真的沒什麼想法，那麼就可以考慮直接用 CNCF 提出的 [CloudEvents](https://cloudevents.io/ 
)

​![image](/posts/2022/12/2022-12-17-event-net-conf-2022-taiwan-lets-talk-about-standardize-event-using-cloudevents-before-talk-about-eda/image-20230318172142-t791zky.png "CloudEvents 的 logo 和目的"){.img-responsive}  
^^^ CloudEvents 的 logo 和目的

### CloudEvents 的基本概念

有核心格式在搭配不同資料格式以及不同通訊協議的建議

​![image](/posts/2022/12/2022-12-17-event-net-conf-2022-taiwan-lets-talk-about-standardize-event-using-cloudevents-before-talk-about-eda/image-20230318172336-p7r618t.png "所有的格式描述 - https://github.com/cloudevents/spec "){.img-responsive}  
^^^ 所有的格式描述 - https://github.com/cloudevents/spec

並且提供常見程式語言的 SDK：

​![image](/posts/2022/12/2022-12-17-event-net-conf-2022-taiwan-lets-talk-about-standardize-event-using-cloudevents-before-talk-about-eda/image-20230318172535-fpudjt0.png "有支援的 SDK - https://github.com/cloudevents/sdk-csharp/blob/main/docs/guide.md "){.img-responsive}  
^^^ 有支援的 SDK - https://github.com/cloudevents/sdk-csharp/blob/main/docs/guide.md

資料格式區分兩個部分：

1. Context Metadata - 會定義出每個資料格式類型應該有那些欄位
2. Event Metadata - 這個部分就是隨著應用不同而自由發揮

​![image](/posts/2022/12/2022-12-17-event-net-conf-2022-taiwan-lets-talk-about-standardize-event-using-cloudevents-before-talk-about-eda/image-20230318173037-dtn4dgv.png "範例 - JSON Event 的格式"){.img-responsive}  
^^^ 範例 - JSON Event 的格式

### 如果要導入記得先做好 Migration 計劃

簡報最後面是在說明，如何從既有的格式轉換成為 CloudEvents

由於應用可能已經有在使用舊的格式，那麼可以透過 Adapter 的方式同時新舊兼容，最後慢慢把舊的格式淘汰掉

​![image](/posts/2022/12/2022-12-17-event-net-conf-2022-taiwan-lets-talk-about-standardize-event-using-cloudevents-before-talk-about-eda/image-20230318173505-mlk8bto.png "透過 Adapter 轉成 CloudEvents 格式"){.img-responsive}  
^^^ 透過 Adapter 轉成 CloudEvents 格式

### 參考資料

如果想要看到完整內容，歡迎參考：

1. [Youtube 影片](https://www.youtube.com/watch?v=ejI9Y3YLQeU)
2. PPT 簡報

## 活動花絮

這次是三軌的議程，不過兩軌是透過錄播的方式，只有其中一軌是即時直播

所以當天是借用微軟大的會議室來做直播

當天小弟的主要工作是幫講師們刷門禁和電梯，所以吃完早餐就要開工啦

​![image](/posts/2022/12/2022-12-17-event-net-conf-2022-taiwan-lets-talk-about-standardize-event-using-cloudevents-before-talk-about-eda/image-20230318175140-et5ieeu.png "麥當勞早餐，和一日門禁卡"){.img-responsive}  
^^^ 麥當勞早餐，和一日門禁卡

在來就是熟悉場地

一開始進去當然就是先拍照啊：

​![image](/posts/2022/12/2022-12-17-event-net-conf-2022-taiwan-lets-talk-about-standardize-event-using-cloudevents-before-talk-about-eda/image-20230318173915-g25vee1.png "整個直播現場"){.img-responsive}  
^^^ 整個直播現場

​![image](/posts/2022/12/2022-12-17-event-net-conf-2022-taiwan-lets-talk-about-standardize-event-using-cloudevents-before-talk-about-eda/image-20230318174105-rzlw9ba.png "專業的控場工具"){.img-responsive}  
^^^ 專業的控場工具

實際直播者的角度來說看到的是這樣：

​![image](/posts/2022/12/2022-12-17-event-net-conf-2022-taiwan-lets-talk-about-standardize-event-using-cloudevents-before-talk-about-eda/image-20230318174547-hwk34rd.png "準備直播的時候先拍一下"){.img-responsive}  
^^^ 準備直播的時候先拍一下

最後有一場是直播的快問快答，整個會場其實是這樣：

​![image](/posts/2022/12/2022-12-17-event-net-conf-2022-taiwan-lets-talk-about-standardize-event-using-cloudevents-before-talk-about-eda/image-20230318175638-953l2sh.png "快問快答的場面"){.img-responsive}  
^^^ 快問快答的場面

郭董和 David 老師做在對面，剩下 4 位大大做在另外一邊

從現場來看其實隔得滿空，也有點像是在面試，蠻有趣的

‍

以上就是這次活動內容的情況，我們明年在見啦