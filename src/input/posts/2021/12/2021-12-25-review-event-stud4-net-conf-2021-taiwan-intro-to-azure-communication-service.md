Title: "[活動] 2021 .NET Conf Taiwan 記錄 - 初探 Azure Communication Service - 讓 App 也有視訊、通話、即時聊天、簡訊和電話功能"
Published: 2021-12-25 19:00
Modified: 2021-12-25 19:00
Image: "/posts/2021/12/2021-12-25-review-event-stud4-net-conf-2021-taiwan-intro-to-azure-communication-service/image-20220328215546-afi2t05.jpg"
Tags: ["「活動」", "ACS"]
Series: ["「活動」"]
PostDescription: "2021 .NET Conf Taiwan 這次的主題是 Azure Communication Service。
來了解一下這個服務可以做到什麼程度，以及整個活動裡面有趣的花絮。
如果想要了解如何在應用程式裡面加上通訊功能，別錯過 Azure Communication Service"
---
^^^  
​![image.jpg](/posts/2021/12/2021-12-25-review-event-stud4-net-conf-2021-taiwan-intro-to-azure-communication-service/image-20220328215546-afi2t05.jpg){.img-responsive}  
^^^主題內容

這篇的目的是為了記錄準備 2021 .NET Conf Taiwan 活動準備的內容  
以及提供一些後面可以參考的資料

<!--more-->

## 為什麼想要做這個主題

Azure Communication Service (以下簡稱 ACS) 算是是一個比較新的服務，不過真的要說新也不算，因為微軟的 Teams 底層用的就是 ACS，所以有點像是把這個底層服務做成一個 PaaS 服務然後發佈出來讓大家可以使用。

我對於通訊這塊沒有什麼了解，所以感覺要在應用程式裡面做到有視訊、通話或者及時聊天應該沒有這麼容易，不過如果搭配 ACS 可以達到這個效果的話，那感覺會很有趣。

想象一下，當使用者說不清楚他的問題的時候，可以馬上透過 app 聯繫到客服並且可以做桌面分享，對於整個流程應該可以變成非常順暢。

所以，想說研究看看，順便和大家分享研究心得。

實際上，當我自己在研究這個過程，我也發現的確非常的好玩，雖然 demo 沒有做什麼，不過我自己是有點回到以前研究技術的哪種好玩的感覺。

Demo 當然要最後一分鐘做完才有感覺 XD，所以活動前一天還在嘗試 tune 最後的內容，還拍了一張照片做了記錄。

^^^
![image.jpg](/posts/2021/12/2021-12-25-review-event-stud4-net-conf-2021-taiwan-intro-to-azure-communication-service/image-20220328213250-1cnpgwa.jpg){.img-responsive}
^^^活動當天早上還在確認 demo 中

## ACS 到底能夠做到什麼？

簡單來說，可以讓我們把通訊整合到應用，這個就包括了

* Video 以及 Video Calling
* Chat
* Phone （目前只有英國和美國）
  * SMS
  * 接入 PSTN - 實際到自己的電話

ACS 不止提供這些服務，還有提供對應的 UI Library，所整合到 Web 應用、Windows 應用以及手機 App 都有可以用的元件。  
這個可以大幅度的減少開發的成本。

由於底層的服務和 Teams 用的是一樣，所以其實可以一方用 Teams，一方用 UI Library 來進行溝通。可以想到的情景包括客服使用 Teams，然後客戶用我們提供的應用程式來達到效果。

以下這個滿好的呈現這個效果：

^^^

<iframe src="https://www.microsoft.com/en-us/videoplayer/embed/RWGTqQ?postJsllMsg=true" data-src="https://www.microsoft.com/en-us/videoplayer/embed/RWGTqQ?postJsllMsg=true" frameborder="0" allowfullscreen="true" data-linktype="external" title="Video Player" style="width: 566px; height: 322px;"></iframe>

^^[Teams interoperability](https://docs.microsoft.com/en-us/azure/communication-services/concepts/teams-interop?WT.mc_id=AZ-MVP-5003856)


## 參考資料

投影片

<iframe src="https://www.slideshare.net/slideshow/embed_code/key/u4t59fx3wzToYc" data-src="//www.slideshare.net/slideshow/embed_code/key/u4t59fx3wzToYc" width="595" height="485" frameborder="0" marginwidth="0" marginheight="0" scrolling="no" style="border:1px solid #CCC; border-width:1px; margin-bottom:5px; max-width: 100%;" allowfullscreen=""></iframe>

參考連結

* [Overview](https://docs.microsoft.com/en-us/azure/communication-services/?WT.mc_id=AZ-MVP-5003856)
* [Demo Code](https://github.com/alantsai-samples/2021-net-conf-acs-demo)

## 活動當天

這次活動是第一次線上+線下，所以相對而言，線下人員比較沒有那麼多。

某種程度來說，也讓一般的接待工作量沒那麼大，所以滿多都是在聊天 XD。

而且這次很多零時補給品：

^^^  
​![image.jpg](/posts/2021/12/2021-12-25-review-event-stud4-net-conf-2021-taiwan-intro-to-azure-communication-service/image-20220328215430-z8vpgmt.jpg){.img-responsive}  
^^^滿滿補給品

和去年一樣，抽獎程式當場寫：

^^^  
​![image.jpg](/posts/2021/12/2021-12-25-review-event-stud4-net-conf-2021-taiwan-intro-to-azure-communication-service/image-20220328215507-fhdgi26.jpg){.img-responsive}  
^^^這次操盤手是 koko dada

這次主題早上就結束，沒什麼時間可以在 tune 簡報 XD

^^^  
​![image.jpg](/posts/2021/12/2021-12-25-review-event-stud4-net-conf-2021-taiwan-intro-to-azure-communication-service/image-20220328215643-qsn40ce.jpg){.img-responsive}  
^^^和活動看板大合照

^^^  
​![image.jpg](/posts/2021/12/2021-12-25-review-event-stud4-net-conf-2021-taiwan-intro-to-azure-communication-service/image-20220328215915-pq7893l.jpg){.img-responsive}  
^^^忘記拍一張有學員的，只有做綵排準備的照片

^^^  
​![image.jpg](/posts/2021/12/2021-12-25-review-event-stud4-net-conf-2021-taiwan-intro-to-azure-communication-service/image-20220328215716-57mlgh3.jpg){.img-responsive}  
^^^不免俗，慶功宴大合照

## 結語

ACS 準備找回了久遠的玩 Code 的感覺。

雖然準備卡了滿多地方，以及最後做出來感覺好像沒做什麼 （SDK 都包好了）XD，不過弄出來就是成功啦。

也算圓滿落幕啦。

期待下次和大家分享其他內容
